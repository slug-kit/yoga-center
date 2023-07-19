using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9
{
    public partial class frmResolveAssignmentRequests : Form
    {
        private readonly ICourseAssignmentRequestRepository courseAssignmentRequestRepository = new CourseAssignmentRequestRepository();

        private BindingSource bindingSource = new();

        private Course _course = new();
        public Course Course
        {
            get => _course;
            init => _course = value;
        }

        public frmResolveAssignmentRequests()
        {
            InitializeComponent();
        }

        private void frmResolveAssignmentRequests_Load(object sender, EventArgs e)
        {
            var oldInstructor = _course.Instructor;
            txtNameOld.Text = oldInstructor?.Fullname;
            txtCodeOld.Text = oldInstructor?.Code;
            pictureBoxOld.ImageLocation = oldInstructor?.Img;

            var assignmentRequests = courseAssignmentRequestRepository
                .GetAssignmentRequestsByCourse(Course.Id);
            bindingSource.DataSource = assignmentRequests;
            dgvRequests.DataSource = bindingSource;

            txtNameNew.DataBindings.Add(nameof(TextBox.Text), bindingSource,
                $"{nameof(CourseAssignmentRequest.Instructor)}.{nameof(User.Fullname)}",
                true, DataSourceUpdateMode.Never);
            txtCodeNew.DataBindings.Add(nameof(TextBox.Text), bindingSource,
                $"{nameof(CourseAssignmentRequest.Instructor)}.{nameof(User.Code)}",
                true, DataSourceUpdateMode.Never);
            pictureBoxNew.DataBindings.Add(nameof(PictureBox.ImageLocation), bindingSource,
                $"{nameof(CourseAssignmentRequest.Instructor)}.{nameof(User.Img)}",
                true, DataSourceUpdateMode.Never);
        }

        private CourseAssignmentRequest GetCourseAssignmentRequests()
        {
            return bindingSource.List[bindingSource.Position] as CourseAssignmentRequest
                ?? throw new Exception("Could not get object model.");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Accept this request?",
                "Confirm Request Approval", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                courseAssignmentRequestRepository.AcceptRequest(GetCourseAssignmentRequests());
                Close();
                DialogResult = DialogResult.OK;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
