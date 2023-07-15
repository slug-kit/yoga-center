using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9
{
    public partial class frmCourseManagementDetail : Form
    {
        public frmCourseManagementDetail()
        {
            InitializeComponent();
        }
        public ICourseRepository courseRepository
        {
            get
                ; set;
        }
        public bool InsertOrUpdate { get; set; }
        public Course CourseDetail { get; set; }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var course = new Course
                {
                    Id = CourseDetail.Id, // Gán Id của CourseDetail để xác định dữ liệu cần cập nhật
                    ProgramId = int.Parse(cboprogramid.Text),
                    CourseNumber = short.Parse(txtcoursenumber.Text),
                    EndDate = DateTime.Now,
                    StartDate = DateTime.Now,
                    InstructorId = long.Parse(cbointructorid.Text),
                    RegistrationCloseDate = DateTime.Now,
                    RegistrationOpenDate = DateTime.Now,
                    Schedule = txtschedule.Text,
                };

                if (InsertOrUpdate == false)
                {
                    courseRepository.Add(course);
                }
                else
                {
                    courseRepository.Update(course);
                }

                MessageBox.Show("Course saved successfully.", InsertOrUpdate == true ? "Update a course" : "Add a new course");
                Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CourseManagementDetail_Load(object sender, EventArgs e)
        {
            cboprogramid.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {

                cbointructorid.Text = CourseDetail.InstructorId.ToString();
                txtcoursenumber.Text = CourseDetail.CourseNumber.ToString();
                enddate.Text = CourseDetail.EndDate.ToString();
                startdate.Text = CourseDetail.StartDate.ToString();
                cboprogramid.Text = CourseDetail.ProgramId.ToString();
                open.Text = CourseDetail.RegistrationOpenDate.ToString();
                close.Text = CourseDetail.RegistrationCloseDate.ToString();
                txtschedule.Text = CourseDetail.Schedule.ToString();

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
