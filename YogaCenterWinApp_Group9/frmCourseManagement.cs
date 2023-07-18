using System.Data;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseManagement : Form
{
    ICourseRepository courseRepository = new CourseRepository();
    IProgramRepository programRepository = new ProgramRepository();
    IUserRepository userRepository = new UserRepository();
    BindingSource source = new BindingSource();

    public frmCourseManagement()
    {
        InitializeComponent();
    }

    //LOAD COURSE LIST ----------------------------------------------------------------------------
    public void LoadCourseList()
    {
        try
        {
            var courseList = courseRepository.GetAllCourses();
            source.DataSource = courseList;

            cboprogram.DataBindings.Clear();
            txtcoursecode.DataBindings.Clear();
            datestart.DataBindings.Clear();
            dateend.DataBindings.Clear();
            cboinstructor.DataBindings.Clear();
            rtbspecialization.DataBindings.Clear();
            rtbexperience.DataBindings.Clear();
            rtbSchedule.DataBindings.Clear();
            registationopendate.DataBindings.Clear();
            registationclosedate.DataBindings.Clear();

            registationclosedate.DataBindings.Add("Text", source, "RegistrationCloseDate");
            registationopendate.DataBindings.Add("Text", source, "RegistrationOpenDate");
            rtbSchedule.DataBindings.Add("Text", source, "Schedule");
            rtbexperience.DataBindings.Add("Text", source, "Instructor.Experience");
            rtbspecialization.DataBindings.Add("Text", source, "Instructor.Specializations");
            cboinstructor.DataBindings.Add("Text", source, "Instructor.Fullname");
            dateend.DataBindings.Add("Text", source, "StartDate");
            datestart.DataBindings.Add("Text", source, "EndDate");
            txtcoursecode.DataBindings.Add("Text", source, "CourseNumber");
            cboprogram.DataBindings.Add("Text", source, "Program.Id");

            dgvcourse.DataSource = null;
            dgvcourse.DataSource = source;
        }
        catch (Exception)
        {

            throw;
        }

    }

    private void frmCourseManagement_Load(object sender, EventArgs e)
    {
        LoadCourseList();
    }

    //CELL FORMATING FOR ROW PROGRAM AND INSTRUCTOR--------------------------------------------------------------------------------
    private void dgvcourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex == dgvcourse.Columns["Program"].Index && e.RowIndex >= 0)
        {
            var course = (Course)dgvcourse.Rows[e.RowIndex].DataBoundItem;
            e.Value = course?.Program?.Id;
        }
        if (e.ColumnIndex == dgvcourse.Columns["Instructor"].Index && e.RowIndex >= 0)
        {
            var course = (Course)dgvcourse.Rows[e.RowIndex].DataBoundItem;
            e.Value = course?.Instructor?.Fullname;
        }
    }

    //DELETE(BUG NOT FIX --SQL BUG) ----------------------------------------------------------------------------------
    private void btndelete_Click(object sender, EventArgs e)
    {
        if (dgvcourse.SelectedRows.Count > 0)
        {
            var selectedCourse = GetCourse();

            // Confirmation dialog before deleting the course
            var confirmationResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Mark the course as inactive and update it
                    selectedCourse.Inactive = true;
                    courseRepository.Update(selectedCourse);
                    LoadCourseList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a course to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //NEW COURSE----------------------------------------------------------------------------------------
    private void btnadd_Click(object sender, EventArgs e)
    {
        frmCourseManagementEdit frmCourseManagementDetail = new frmCourseManagementEdit()
        {
            Text = "New Course",
            UpdateMode = false,
            Course = new Course(),
            courseRepository = courseRepository,
        };

        if (frmCourseManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadCourseList();
        }

    }

    //UPDATE COURSE -----------------------------------------------------------------------------------
    private void dgvcourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmCourseManagementEdit frmCourseManagementDetail = new frmCourseManagementEdit()
        {
            Text = "Update Course",
            UpdateMode = true,
            Course = GetCourse(),
            courseRepository = courseRepository,
        };
        if (frmCourseManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadCourseList();
        }
    }

    //GET COURSE FOR UPDATE---------------------------------------------------------------------------------------
    private Course GetCourse()
    {
        return source.List[dgvcourse.SelectedRows[0].Index] as Course
            ?? throw new Exception("Could not get object model.");
    }

    //SEARCH ---------------------------------------------------------------------------------------
    private void btnsearch_Click(object sender, EventArgs e)
    {
        string courseCode = txtcoursecodesearch.Text.Trim();
        string schedule = txtschedulesearch.Text.Trim();

        // Gọi phương thức tìm kiếm từ repository 
        var searchResult = courseRepository.SearchCourses(courseCode, schedule);

        // Hiển thị kết quả tìm kiếm trong DataGridView
        BindingSource source = new BindingSource();
        source.DataSource = searchResult;
        dgvcourse.DataSource = source;
    }

}

