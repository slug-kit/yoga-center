using YogaCenter.Repository.Models;
using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Repos;
using YogaCenterWinApp_Group9.Controls;
using YogaCenterWinApp_Group9.DisplayModels;
using System;

namespace YogaCenterWinApp_Group9;

public partial class frmEnrolledCourses : Form
{
    public ICourseRegisterRepository courseRegisterRepository = new CourseRegisterRepository();
    private readonly BindingSource bindingSource = new();

    private User _user = new()
    {
        Id = Program.CurrentUser!.Id,
        Username = Program.CurrentUser.Username,
        RoleId = Program.CurrentUser.RoleId,
    };

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
        foreach (Control c in Controls)
            c.DataBindings.Clear();
        bindingSource.DataSource = null;

        // 2. Bind to DGV + Customize columns
        var enrolledCourses = courseRegisterRepository
            .GetCourseRegisterEntriesByLearner(_user.Id)
            .Select(cr => new CourseRegisterDisplayModel
            {
                CourseId = cr.CourseId,
                LearnerId = cr.LearnerId,
                EnrolDatetime = cr.EnrolDatetime,
                TuitionFee = cr.TuitionFee,

                Course = cr.Course,
                Learner = cr.Learner,
            }).ToList();
        bindingSource.DataSource = enrolledCourses;
        dgvEnrolledCourses.DataSource = bindingSource;

        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.CourseId)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.LearnerId)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.Course)].Visible = false;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.Learner)].Visible = false;

        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.CourseCode)].DisplayIndex = 0;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.ProgramName)].DisplayIndex = 1;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.EnrolDatetime)].DisplayIndex = 2;
        dgvEnrolledCourses.Columns[nameof(CourseRegisterDisplayModel.TuitionFee)].DisplayIndex = 3;

        // 3. Bind to output boxes
        txtProgramName.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRegisterDisplayModel.ProgramName),
            true, DataSourceUpdateMode.Never);
        txtCourseCode.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRegisterDisplayModel.CourseCode),
            true, DataSourceUpdateMode.Never);
        starRatingControl.DataBindings.Add(nameof(StarRatingControl.SelectedStar), bindingSource, nameof(CourseRegisterDisplayModel.ProgramRating),
            true, DataSourceUpdateMode.Never);
        rtbDescription.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(CourseRegisterDisplayModel.ProgramDescription),
            true, DataSourceUpdateMode.Never);
        dtpStartDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseRegisterDisplayModel.StartDate),
            true, DataSourceUpdateMode.Never);
        dtpEndDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseRegisterDisplayModel.EndDate),
            true, DataSourceUpdateMode.Never);
        rtbSchedule.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(CourseRegisterDisplayModel.CourseSchedule),
            true, DataSourceUpdateMode.Never);
        txtInstructorName.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(CourseRegisterDisplayModel.InstructorName),
            true, DataSourceUpdateMode.Never);
        pictureBox.DataBindings.Add(nameof(PictureBox.ImageLocation), bindingSource, nameof(CourseRegisterDisplayModel.InstructorImg),
            true, DataSourceUpdateMode.Never);
        rtbInstructorSpecializations.DataBindings.Add(nameof(RichTextBox.Text), bindingSource,
            nameof(CourseRegisterDisplayModel.InstructorSpecializations),
            true, DataSourceUpdateMode.Never);
        rtblbInstructorExperience.DataBindings.Add(nameof(RichTextBox.Text), bindingSource
            , nameof(CourseRegisterDisplayModel.InstructorExperience),
            true, DataSourceUpdateMode.Never);
    }

    #endregion

    #region Form Actions

    private CourseRegister GetCourseRegisterObject()
    {
        var pom = bindingSource.List[bindingSource.Position] as CourseRegister;
        return pom ?? throw new Exception("Could not create CourseRegister object.");
    }

    private void btnChangeCourse_Click(object sender, EventArgs e)
    {
        try
        {
            var cr = GetCourseRegisterObject();
            frmEnrolledCourseChange frmEnrolledCourseChange = new()
            {
                CourseRegisterRepository = courseRegisterRepository,
                CourseRegister = cr,
            };
            if (frmEnrolledCourseChange.ShowDialog() == DialogResult.OK)
            {
                bindingSource.ResetBindings(false);
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
        try
        {
            var confirmResult = MessageBox.Show("Are you sure you wish to unenrol from this course?", "Confirm Unenrollment", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var courseRegisterEntry = GetCourseRegisterObject();
                courseRegisterRepository.Delete(courseRegisterEntry.CourseId, courseRegisterEntry.LearnerId);

                MessageBox.Show($"You have successfully enrolled in Course {courseRegisterEntry.Course.GetCourseCode()}.",
                    "Ennrollment Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.ResetBindings(false);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message
                , "ERROR -- Unenrol");
        }
    }

    #endregion
}
