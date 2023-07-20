using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmEnrolledCourseChange : Form
{
    private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

    private readonly ICourseRosterRepository _courseRosterRepository = new CourseRosterRepository();
    public ICourseRosterRepository CourseRosterRepository
    {
        get => _courseRosterRepository;
        init => _courseRosterRepository = value;
    }

    private CourseDisplayModel _oldCourse = new();
    public Course OldCourse
    {
        get => _oldCourse;
        set => _oldCourse = new()
        {
            Id = value.Id,
            ProgramId = value.ProgramId,
            //CourseNumber = value.CourseNumber,
            InstructorId = value.InstructorId,
            StartDate = value.StartDate,
            EndDate = value.EndDate,
            Schedule = value.Schedule,
            RegistrationOpenDate = value.RegistrationOpenDate,
            RegistrationCloseDate = value.RegistrationCloseDate,
            HasNewRequest = value.HasNewRequest,
            Inactive = value.Inactive,

            Instructor = value.Instructor,
            Program = value.Program,
            CourseAssignmentRequests = value.CourseAssignmentRequests,
            CourseRosters = value.CourseRosters,
            Lessons = value.Lessons,

            ProgramCode = value.Program?.Code ?? string.Empty,
            CourseNumber = value.CourseNumber,
        };
    }

    private long _learnerId;
    public long LearnerId
    {
        get => _learnerId;
        set => _learnerId = value;
    }

    private IEnumerable<CourseRoster> _enrolledCourses = new List<CourseRoster>();
    public IEnumerable<CourseRoster> EnrolledCourses
    {
        get => _enrolledCourses;
        set => _enrolledCourses = value;
    }


    private readonly BindingSource bindingSource = new();

    private int _oldCourseId;

    public frmEnrolledCourseChange()
    {
        InitializeComponent();
    }

    private void frmEnrolledCourseChange_Load(object sender, EventArgs e)
    {
        _oldCourseId = _oldCourse.Id;

        InitComboBoxes();
        BindPrimaryModel();
    }

    private void InitComboBoxes()
    {

    }

    private void cboCourse_SelectedValueChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    ComboBox cbo = (ComboBox)sender;
        //    var course = _courseRosterRepository
        //        .GetCourses()
        //        .FirstOrDefault(c => c.Id == Convert.ToInt32(cbo.SelectedValue));
        //    if (course != null)
        //    {
        //        _pom.Course = course;
        //    }
        //}
        //catch (InvalidCastException ex)
        //{
        //    MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        //}
    }

    private void BindPrimaryModel()
    {
        var oldCourseIds = _enrolledCourses.Select(cr => cr.CourseId).ToHashSet();

        var courses = _courseRosterRepository
            .GetCoursesByProgram(_oldCourse.ProgramId)
            //.Where(c => c.Id != _oldCourseId)
            .Where(c => !oldCourseIds.Contains(c.Id))
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
                CourseRosters = c.CourseRosters,
                Lessons = c.Lessons,

                ProgramCode = c.Program?.Code ?? string.Empty,
                CourseNumber = c.CourseNumber,
            })
            .ToList();
        bindingSource.DataSource = courses;

        cboCourse.ValueMember = nameof(CourseDisplayModel.Id);
        cboCourse.DisplayMember = nameof(CourseDisplayModel.CourseCode);
        cboCourse.DataSource = bindingSource;

        //cboCourse.DataBindings.Add(nameof(ComboBox.SelectedValue), bindingSource, nameof(CourseRosterDisplayModel.CourseId),
        //    true, DataSourceUpdateMode.OnPropertyChanged)
        //    .ControlUpdateMode = ControlUpdateMode.Never;
        dtpStartDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseDisplayModel.StartDate),
            true, DataSourceUpdateMode.Never);
        dtpEndDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(CourseDisplayModel.EndDate),
            true, DataSourceUpdateMode.Never);
        rtbSchedule.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(CourseDisplayModel.Schedule),
            true, DataSourceUpdateMode.Never);

        txtInstructorName.DataBindings.Add(nameof(TextBox.Text), bindingSource,
            $"{nameof(CourseDisplayModel.Instructor)}.{nameof(User.Fullname)}",
            true, DataSourceUpdateMode.Never);
        rtbInstructorSpecializations.DataBindings.Add(nameof(RichTextBox.Text), bindingSource,
            $"{nameof(CourseDisplayModel.Instructor)}.{nameof(User.Specializations)}",
            true, DataSourceUpdateMode.Never);
        rtbInstructorExperience.DataBindings.Add(nameof(RichTextBox.Text), bindingSource,
         $"{nameof(CourseDisplayModel.Instructor)}.{nameof(User.Experience)}",
            true, DataSourceUpdateMode.Never);

        var imageBinding = new Binding(nameof(PictureBox.ImageLocation), bindingSource,
            $"{nameof(CourseDisplayModel.Instructor)}.{nameof(User.Img)}",
            true, DataSourceUpdateMode.Never);
        imageBinding.Format += EmptyImageLocationToDefaultImage;
        pictureBox.DataBindings.Add(imageBinding);

        if (cboCourse.Items.Count > 0)
        {
            cboCourse.SelectedIndex = 0;
        }
    }

    private void EmptyImageLocationToDefaultImage(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        cevent.Value ??= DEFAULT_IMG_LOCATION;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        try
        {
            var newCourse = (Course)cboCourse.SelectedItem;
            if (newCourse == null)
            {
                MessageBox.Show("You must select a course to change to.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newCourseId = newCourse.Id;
            if (newCourseId == _oldCourseId)
            {
                MessageBox.Show("You must select a different course to change to.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you wish to change to Course {newCourse.GetCourseCode()}?",
                "Confirm Unenrollment", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _courseRosterRepository.Delete(_oldCourseId, _learnerId);
                _courseRosterRepository.Add(newCourseId, _learnerId, _oldCourse.Program?.Fee ?? 0);

                MessageBox.Show($"You have successfully switch to Course {newCourse.GetCourseCode()}.",
                    "Ennrollment Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.ResetBindings(false);
                Close();
                DialogResult = DialogResult.OK;
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
