using System.Data;
using YogaCenter.Repository.ModelExtensions;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseManagement : Form
{
    private const int COURSE_HAS_STARTED_STATUS_CODE = 50;
    private const int COURSE_HAS_FINISHED_STATUS_CODE = 70;

    private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

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
            pictureBox.DataBindings.Clear();

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

            var imageBinding = new Binding(nameof(PictureBox.ImageLocation), source, $"{nameof(Course.Instructor)}.{nameof(User.Img)}",
                true, DataSourceUpdateMode.Never);
            imageBinding.Format += EmptyImageLocationToDefaultImage;
            pictureBox.DataBindings.Add(imageBinding);

            dgvcourse.DataSource = null;
            dgvcourse.DataSource = source;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message,
                "ERROR -- Load Course List");
        }

    }

    private void EmptyImageLocationToDefaultImage(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        cevent.Value ??= DEFAULT_IMG_LOCATION;
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
        if (e.ColumnIndex == dgvcourse.Columns["StartDate"].Index || e.ColumnIndex == dgvcourse.Columns["EndDate"].Index || e.ColumnIndex == dgvcourse.Columns["RegistrationOpenDate"].Index || e.ColumnIndex == dgvcourse.Columns["RegistrationCloseDate"].Index)
        {
            if (e.Value != null && e.Value is DateTime)
            {
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }
    }

    //DELETE(BUG NOT FIX --SQL BUG) ----------------------------------------------------------------------------------
    private void btndelete_Click(object sender, EventArgs e)
    {
        if (dgvcourse.SelectedRows.Count > 0)
        {
            var selectedCourse = GetCourse();
            var statusCode = selectedCourse.GetStatusCode();
            if (statusCode == COURSE_HAS_STARTED_STATUS_CODE || statusCode == COURSE_HAS_FINISHED_STATUS_CODE)
            {
                MessageBox.Show("A Course that is in progress or has finished may not be deleted.",
                    "Invalid Course State", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirmation dialog before deleting the course
            var confirmationResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Mark the course as inactive and update it
                    courseRepository.Delete(selectedCourse);
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
            courseRepository = courseRepository,
            UpdateMode = false,
            Course = new()
            {
                CourseNumber = 1,
                //Program = _pom,
            },
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
            courseRepository = courseRepository,
            UpdateMode = true,
            Course = GetCourse(),
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
        string instructorName = txtInstructorSearch.Text.Trim();

        DateTime? startDate = null;
        DateTime? endDate = null;
        DateTime? registrationOpenDate = null;
        DateTime? registrationCloseDate = null;

        if (dateTimePickerStartDate.Checked)
        {
            startDate = dateTimePickerStartDate.Value.Date;
        }

        if (dateTimePickerEndDate.Checked)
        {
            endDate = dateTimePickerEndDate.Value.Date;
        }

        if (dateTimePickerRegistrationOpenDate.Checked)
        {
            registrationOpenDate = dateTimePickerRegistrationOpenDate.Value.Date;
        }

        if (dateTimePickerRegistrationCloseDate.Checked)
        {
            registrationCloseDate = dateTimePickerRegistrationCloseDate.Value.Date;
        }

        var searchResult = courseRepository.SearchCourses(courseCode, schedule, instructorName, startDate, endDate, registrationOpenDate, registrationCloseDate);

        BindingSource source = new BindingSource();
        source.DataSource = searchResult;
        dgvcourse.DataSource = source;
    }

    private void btnRequests_Click(object sender, EventArgs e)
    {

        frmResolveAssignmentRequests frmResolveAssignmentRequests = new()
        {
            Course = GetCourse(),
        };
        if (frmResolveAssignmentRequests.ShowDialog() == DialogResult.OK)
        {
            LoadCourseList();
        }
    }
}

