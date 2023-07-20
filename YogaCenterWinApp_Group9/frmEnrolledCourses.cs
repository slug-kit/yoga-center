using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;
using YogaCenterWinApp_Group9.Controls;
using YogaCenterWinApp_Group9.DisplayModels;

namespace YogaCenterWinApp_Group9;

public partial class frmEnrolledCourses : Form
{
    private const int COURSE_HAS_STARTED_STATUS_CODE = 50;

    private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

    public ICourseRosterRepository courseRosterRepository = new CourseRosterRepository();
    private readonly BindingSource bindingSource = new();

    private User _user = new()
    {
        Id = Program.CurrentUser!.Id,
        Username = Program.CurrentUser.Username,
        RoleId = Program.CurrentUser.RoleId,
    };

    private IEnumerable<CourseRosterDisplayModel> _enrolledCourses = new List<CourseRosterDisplayModel>();

    public frmEnrolledCourses()
    {
        InitializeComponent();
    }

    #region Startup

    private void frmEnrolledCourses_Load(object sender, EventArgs e)
    {
        BindPrimaryModel();
    }

    private void BindPrimaryModel()
    {
        // 1. Clear bindings
        foreach (Control c in mainSplitContainer.Panel1.Controls)
            c.DataBindings.Clear();
        foreach (Control c in mainSplitContainer.Panel2.Controls)
            c.DataBindings.Clear();
        dgvEnrolledCourses.Columns.Clear();
        dgvEnrolledCourses.DataSource = null;
        bindingSource.DataSource = null;

        // 2. Bind to DGV + Customize columns
        _enrolledCourses = courseRosterRepository
           .GetCourseRosterEntriesByLearner(_user.Id)
           .Where(cr =>
           {
               var statusCode = cr.Course?.GetStatusCode();
               if (statusCode == null) return false;
               else return statusCode >= 0 && statusCode < COURSE_HAS_STARTED_STATUS_CODE;
           })
           .Select(cr => new CourseRosterDisplayModel
           {
               CourseId = cr.CourseId,
               LearnerId = cr.LearnerId,
               EnrolDatetime = cr.EnrolDatetime,
               TuitionFee = cr.TuitionFee,

               Course = cr.Course,
               Learner = cr.Learner,
           }).ToList();
        bindingSource.DataSource = _enrolledCourses;
        dgvEnrolledCourses.DataSource = bindingSource;

        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.CourseId)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.LearnerId)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.Course)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.Learner)].Visible = false;

        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.CourseCode)].DisplayIndex = 0;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.ProgramName)].DisplayIndex = 1;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.EnrolDatetime)].DisplayIndex = 2;
        dgvEnrolledCourses.Columns[nameof(CourseRosterDisplayModel.TuitionFee)].DisplayIndex = 3;

        // 3. Bind to output boxes
        txtProgramName.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRosterDisplayModel.ProgramName),
            true, DataSourceUpdateMode.Never);
        txtCourseCode.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRosterDisplayModel.CourseCode),
            true, DataSourceUpdateMode.Never);
        starRatingControl.DataBindings.Add(nameof(StarRatingControl.SelectedStar), bindingSource, nameof(CourseRosterDisplayModel.ProgramRating),
            true, DataSourceUpdateMode.Never);
        rtbDescription.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(CourseRosterDisplayModel.ProgramDescription),
            true, DataSourceUpdateMode.Never);
        dtpStartDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseRosterDisplayModel.StartDate),
            true, DataSourceUpdateMode.Never);
        dtpEndDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseRosterDisplayModel.EndDate),
            true, DataSourceUpdateMode.Never);
        rtbSchedule.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(CourseRosterDisplayModel.CourseSchedule),
            true, DataSourceUpdateMode.Never);
        txtInstructorName.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRosterDisplayModel.InstructorName),
            true, DataSourceUpdateMode.Never);

        var imageBinding = new Binding(nameof(PictureBox.ImageLocation), bindingSource, nameof(CourseRosterDisplayModel.InstructorImg),
            true, DataSourceUpdateMode.Never);
        imageBinding.Format += EmptyImageLocationToDefaultImage;
        pictureBox.DataBindings.Add(imageBinding);

        rtbInstructorSpecializations.DataBindings.Add(nameof(RichTextBox.Text), bindingSource,
            nameof(CourseRosterDisplayModel.InstructorSpecializations),
            true, DataSourceUpdateMode.Never);
        rtblbInstructorExperience.DataBindings.Add(nameof(RichTextBox.Text), bindingSource
            , nameof(CourseRosterDisplayModel.InstructorExperience),
            true, DataSourceUpdateMode.Never);

        if (dgvEnrolledCourses.Rows.Count == 0)
        {
            btnChangeCourse.Enabled = false;
            btnUnenrol.Enabled = false;
        }
    }

    private void EmptyImageLocationToDefaultImage(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        cevent.Value ??= DEFAULT_IMG_LOCATION;
    }

    #endregion

    #region Form Actions

    private CourseRoster GetCourseRosterObject()
    {
        var pom = bindingSource.List[bindingSource.Position] as CourseRoster;
        return pom ?? throw new Exception("Could not create CourseRoster object.");
    }

    private void btnChangeCourse_Click(object sender, EventArgs e)
    {
        if (dgvEnrolledCourses.Rows.Count == 0) return;
        try
        {
            var cr = GetCourseRosterObject();
            frmEnrolledCourseChange frmEnrolledCourseChange = new()
            {
                CourseRosterRepository = courseRosterRepository,
                OldCourse = cr.Course,
                LearnerId = cr.LearnerId,
                EnrolledCourses = _enrolledCourses,
            };
            if (frmEnrolledCourseChange.ShowDialog() == DialogResult.OK)
            {
                bindingSource.ResetBindings(false);
                ReloadData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message
                , "ERROR -- Change Course");
        }
    }

    private void btnUnenrol_Click(object sender, EventArgs e)
    {
        if (dgvEnrolledCourses.Rows.Count == 0) return;
        try
        {
            var confirmResult = MessageBox.Show($"Are you sure you wish to unenrol from Course {GetCourseRosterObject().CourseId}?", "Confirm Unenrollment", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var courseRosterEntry = GetCourseRosterObject();
                courseRosterRepository.Delete(courseRosterEntry.CourseId, courseRosterEntry.LearnerId);

                MessageBox.Show($"You have successfully enrolled in Course {courseRosterEntry.Course.GetCourseCode()}.",
                    "Ennrollment Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.ResetBindings(false);
                ReloadData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message
                , "ERROR -- Unenrol");
        }
    }

    private void ReloadData()
    {
        try
        {
            BindPrimaryModel();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Oops!!! " + ex.Message);
        }
    }

    #endregion
}
