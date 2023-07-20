using YogaCenter.Repository.DAL;
using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9
{
    public partial class frmCourseList : Form
    {
        private readonly int _programId;

        // Think of a way to inject these things later
        private const byte LEARNER_ROLE = 2;
        private const byte INSTRUCTOR_ROLE = 3;

        private readonly ICourseRosterRepository courseRosterRepository = new CourseRosterRepository();
        private readonly ICourseAssignmentRequestRepository courseAssignmentRequestRepository = new CourseAssignmentRequestRepository();

        private User _user = new()
        {
            Id = Program.CurrentUser!.Id,
            Username = Program.CurrentUser.Username,
            RoleId = Program.CurrentUser.RoleId,
        };

        public frmCourseList(int programId)
        {
            InitializeComponent();
            _programId = programId;
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourses();

            btnEnrol.Enabled = _user.RoleId == LEARNER_ROLE;
            btnEnrol.Visible = _user.RoleId == LEARNER_ROLE;
            btnRequestAssignment.Enabled = _user.RoleId == INSTRUCTOR_ROLE;
            btnRequestAssignment.Visible = _user.RoleId == INSTRUCTOR_ROLE;
        }

        private void LoadCourses()
        {
            var courses = CourseDAO.Instance.GetByProgram(_programId);
            dataGridView1.DataSource = courses.ToList();

            dataGridView1.Columns.Remove("HasNewRequest");
            dataGridView1.Columns.Remove("Inactive");
            dataGridView1.Columns.Remove("Program");
            dataGridView1.Columns.Remove("CourseAssignmentRequests");
            dataGridView1.Columns.Remove("CourseRosters");
            dataGridView1.Columns.Remove("Lessons");
            dataGridView1.Columns.Remove("Instructor");
            dataGridView1.Columns.Remove("InstructorId");


            dataGridView1.Columns.Add(new DataGridViewColumn()
            {
                Name = "InstructorName",
                HeaderText = "InstructorName",
                DataPropertyName = "Instructor.Fullname",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    var course = (Course)selectedRow.DataBoundItem;

                    // Hiển thị dữ liệu lên các ô textbox
                    txtProgramId.Text = course.GetCourseCode();
                    txtCoursenumber.Text = course.CourseNumber.ToString();
                    txtInstructor.Text = course.Instructor?.Fullname;
                    rtbschedule.Text = course.Schedule;
                    dateTimePickerCourseStart.Text = course.StartDate.ToString();
                    dateTimePickerCourseEnd.Text = course.EndDate.ToString();
                    dateTimePickerAvailableTo.Text = course.RegistrationCloseDate.ToString();
                    dateTimePickerAvailableFrom.Text = course.RegistrationOpenDate.ToString();
                    txtCourseStatus.Text = course.GetStatusName();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(Text, "Error");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            var courses = CourseDAO.Instance.GetByProgram(_programId)
                .Where(c => c.StartDate >= startDate && c.EndDate <= endDate)
                .ToList();

            dataGridView1.DataSource = courses;

            // Làm sạch các ô textbox
            txtProgramId.Text = string.Empty;
            txtCoursenumber.Text = string.Empty;
            txtInstructor.Text = string.Empty;
            rtbschedule.Text = string.Empty;
            dateTimePickerCourseStart.Text = string.Empty;
            dateTimePickerCourseEnd.Text = string.Empty;
            dateTimePickerAvailableTo.Text = string.Empty;
            dateTimePickerAvailableFrom.Text = string.Empty;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "StartDate" || dataGridView1.Columns[e.ColumnIndex].Name == "EndDate" || dataGridView1.Columns[e.ColumnIndex].Name == "RegistrationOpenDate" || dataGridView1.Columns[e.ColumnIndex].Name == "RegistrationCloseDate")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains('.'))
            {
                object data = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i])?.GetValue(data)!;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }

        #region Form Actions

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you wish to enrol in this course?", "Confirm Enrollment", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var course = GetCourseObject();
                    var fee = course.Program.Fee.HasValue ? course.Program.Fee.Value : 0;
                    courseRosterRepository.Add(course.Id, _user.Id, fee);

                    MessageBox.Show($"You have successfully enrolled in Course {course.GetCourseCode()}.",
                        "Enrollment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message,
                    "ERROR -- Enrol");
            }
        }

        private void btnRequestAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you wish to request to be assigned to this course?", "Confirm Request Submission", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var course = GetCourseObject();
                    courseAssignmentRequestRepository.Add(new()
                    {
                        InstructorId = _user.Id,
                        CourseId = course.Id,
                    });
                    MessageBox.Show($"You have successfully submitted an assignment request for Course {course.GetCourseCode()}.",
                        "Request Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message,
                    "ERROR -- Request Assignment");
            }
        }

        private Course GetCourseObject()
        {
            var course = dataGridView1.SelectedRows[0].DataBoundItem as Course;
            return course ?? throw new Exception("Could not retrieve object model.");
        }

        #endregion
    }
}
