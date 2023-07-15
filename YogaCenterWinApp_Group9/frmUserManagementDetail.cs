using Microsoft.VisualBasic.Devices;
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
    public partial class frmUserManagementDetail : Form
    {
        public frmUserManagementDetail()
        {
            InitializeComponent();
        }

        public IUserRepository userRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public User userDetail { get; set; }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng đối tượng User đã được truyền vào thay vì tạo mới
                userDetail.Username = txtusername.Text;
                userDetail.Password = txtpassword.Text;
                userDetail.JoinDate = DateTime.Now;
                userDetail.RoleId = byte.Parse(cboroleid.Text);
                userDetail.Code = txtcode.Text;
                userDetail.Fullname = txtfullname.Text;
                userDetail.Dob = DateTime.Now;
                userDetail.Gender = byte.Parse(cbogender.Text);
                userDetail.Phone = txtphonenumber.Text;
                userDetail.StudyGoals = txtstudygoal.Text;
                userDetail.Email = txtemail.Text;

                if (InsertOrUpdate == false)
                {
                    userRepository.AddUser(userDetail);
                }
                else
                {
                    userRepository.UpdateUser(userDetail);
                }

                MessageBox.Show("User saved successfully.", InsertOrUpdate == true ? "Update a user" : "Add a new user");
                Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmUserManagementDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true && userDetail != null)
            {
                txtusername.Text = userDetail.Username.ToString();
                txtpassword.Text = userDetail.Password.ToString();
                datejoin.Text = userDetail.JoinDate.ToString();
                cboroleid.Text = userDetail.RoleId.ToString();
                txtcode.Text = userDetail.Code.ToString();
                txtfullname.Text = userDetail.Fullname.ToString();
                dob.Text = userDetail.Dob.ToString();
                cbogender.Text = userDetail.Gender.ToString();
                txtphonenumber.Text = userDetail.Phone.ToString();
                txtemail.Text = userDetail.Email.ToString();
                txtstudygoal.Text = userDetail.StudyGoals.ToString();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
