using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaCenterWinApp_Group9.Utils;

namespace YogaCenterWinApp_Group9
{
    public partial class frmNav : Form
    {
        public frmNav()
        {
            InitializeComponent();
        }

        private void frmNav_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = -1;
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Form frm = new Form();
            if (tabControl1.SelectedIndex == 0)
            {
                frm = new frmHome
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    Parent = tabPage1
                };
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                frm = new frmProgramManagement
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    Parent = tabPage2
                };
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                frm = new frmCourseManagement
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    Parent = tabPage3
                };
                frm.Show();
            }
        }
    }
}
