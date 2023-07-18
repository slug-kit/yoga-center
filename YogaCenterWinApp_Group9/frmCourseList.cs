using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace YogaCenterWinApp_Group9
{
    public partial class frmCourseList : Form
    {
        private readonly int _programId;

        public frmCourseList(int programId)
        {
            InitializeComponent();
            _programId = programId;
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = CourseDAO.Instance.SearchCoursesByProgramId(_programId);
            dataGridView1.DataSource = courses.ToList();

            dataGridView1.Columns.Remove("HasNewRequest");
            dataGridView1.Columns.Remove("Inactive");
            dataGridView1.Columns.Remove("Program");
            dataGridView1.Columns.Remove("CourseAssignmentRequests");
            dataGridView1.Columns.Remove("CourseRegisters");
            dataGridView1.Columns.Remove("Lessons");
            dataGridView1.Columns.Remove("Instructor");
            dataGridView1.Columns.Remove("InstructorId");

            dataGridView1.Columns.Add(new DataGridViewColumn()
            {
                Name = "Lessons",
                HeaderText = "Lessons",
                DataPropertyName = "Lesson.LessonNumber",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            dataGridView1.Columns.Add(new DataGridViewColumn()
            {
                Name = "Instructor",
                HeaderText = "Instructor",
                DataPropertyName = "Instructor.Fullname",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var course = (Course)selectedRow.DataBoundItem;

                // Hiển thị dữ liệu lên các ô textbox
                txtProgramId.Text = course.Id.ToString();
                txtCoursenumber.Text = course.CourseNumber.ToString();
                txtInstructor.Text = course.InstructorId.ToString();
                rtbschedule.Text = course.Schedule;
                dateTimePickerCourseStart.Text = course.StartDate.ToString();
                dateTimePickerCourseEnd.Text = course.EndDate.ToString();
                dateTimePickerAvailableTo.Text = course.RegistrationCloseDate.ToString();
                dateTimePickerAvailableFrom.Text = course.RegistrationOpenDate.ToString();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            var courses = CourseDAO.Instance.SearchCoursesByProgramId(_programId)
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

            txtStatusfilter.Text = courses.Any() ? "1" : "0";
        }
    }
}
