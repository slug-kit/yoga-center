using System.Windows.Forms;
using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;
using YogaCenterWinApp_Group9.Controls;
using YogaCenterWinApp_Group9.DisplayModels;

namespace YogaCenterWinApp_Group9;

public partial class frmEnrolledCourseChange : Form
{
    private readonly ICourseRegisterRepository _courseRegisterRepository = new CourseRegisterRepository();
    public ICourseRegisterRepository CourseRegisterRepository
    {
        get => _courseRegisterRepository;
        init => _courseRegisterRepository = value;
    }

    private CourseRegisterDisplayModel _pom = new();
    public CourseRegister CourseRegister
    {
        get => _pom;
        set => _pom = new()
        {
            CourseId = value.CourseId,
            LearnerId = value.LearnerId,
            EnrolDatetime = value.EnrolDatetime,
            TuitionFee = value.TuitionFee,

            Course = value.Course,
            Learner = value.Learner,
        };
    }

    private readonly BindingSource bindingSource = new();

    private int _oldCourseId;

    public frmEnrolledCourseChange()
    {
        InitializeComponent();
    }

    private void frmEnrolledCourseChange_Load(object sender, EventArgs e)
    {
        _oldCourseId = _pom.CourseId;

        InitComboBoxes();
        BindPrimaryModel();
    }

    private void InitComboBoxes()
    {
        cboCourse.Items.Clear();
        var courses = _courseRegisterRepository
            .GetCoursesByProgram(_pom.Course.ProgramId)
            .Where(c => c.Id != _oldCourseId)
            .Select(c => new CourseDisplayModel
            {
                Id = c.Id,
                ProgramId = c.ProgramId,
                //CourseNumber = c.CourseNumber,
                InstructorId = c.InstructorId,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Schedule = c.Schedule,
                RegistrationOpenDate = c.RegistrationOpenDate,
                RegistrationCloseDate = c.RegistrationCloseDate,
                HasNewRequest = c.HasNewRequest,
                Inactive = c.Inactive,

                Instructor = c.Instructor,
                Program = c.Program,
                CourseAssignmentRequests = c.CourseAssignmentRequests,
                CourseRegisters = c.CourseRegisters,
                Lessons = c.Lessons,

                ProgramCode = c.Program?.Code ?? string.Empty,
                CourseNumber = c.CourseNumber,
            })
            .ToList();
        cboCourse.ValueMember = nameof(CourseDisplayModel.Id);
        cboCourse.DisplayMember = nameof(CourseDisplayModel.CourseCode);
        cboCourse.DataSource = courses;
    }

    private void cboCourse_SelectedValueChanged(object sender, EventArgs e)
    {
        try
        {
            ComboBox cbo = (ComboBox)sender;
            var course = _courseRegisterRepository
                .GetCourses()
                .FirstOrDefault(c => c.Id == Convert.ToInt32(cbo.SelectedValue));
            if (course != null)
            {
                _pom.Course = course;
            }
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    private void BindPrimaryModel()
    {
        bindingSource.DataSource = _pom;

        cboCourse.DataBindings.Add(nameof(ComboBox.SelectedValue), bindingSource, nameof(CourseRegisterDisplayModel.CourseId),
            true, DataSourceUpdateMode.OnValidation)
            .ControlUpdateMode = ControlUpdateMode.Never;
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
        rtbInstructorExperience.DataBindings.Add(nameof(RichTextBox.Text), bindingSource
            , nameof(CourseRegisterDisplayModel.InstructorExperience),
            true, DataSourceUpdateMode.Never);
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        try
        {
            var newCourseId = _pom.CourseId;
            if (newCourseId == _oldCourseId)
            {
                MessageBox.Show("You must select a different course to change to.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you wish to change to Course {_pom.Course.GetCourseCode()}?",
                "Confirm Unenrollment", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _courseRegisterRepository.Delete(_oldCourseId, _pom.LearnerId);
                _courseRegisterRepository.Add(_pom.CourseId, _pom.LearnerId, _pom.Course.Program.Fee ?? 0);

                MessageBox.Show($"You have successfully switch to Course {_pom.Course.GetCourseCode()}.",
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

    private void btnCancel_Click(object sender, EventArgs e) { Close(); Dispose(); }


}
