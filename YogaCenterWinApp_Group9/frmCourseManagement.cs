using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseManagement : Form
{
    public frmCourseManagement()
    {
        InitializeComponent();
    }
    //ICourseRepository courseRepository = new CourseRepository();
    //public void LoadCourseList()
    //{
    //    var courseList = courseRepository.GetCourses();
    //    BindingSource source = new BindingSource();
    //    source.DataSource = courseList;

    //    dgvcourse.DataSource = null;
    //    dgvcourse.DataSource = courseList;
    //}

    private void frmCourseManagement_Load(object sender, EventArgs e)
    {
        
    }
}
