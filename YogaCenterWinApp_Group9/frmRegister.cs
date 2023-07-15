using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9
{
    public partial class frmRegister : Form
    {
        IUserRepository repository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "yoga@gmail.com";
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtEmail.Text = "yoga@gmail.com";
                    txtEmail.ForeColor = SystemColors.GrayText; // Optional: Change the text color to gray
                }
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "yoga@gmail.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.WindowText; // Optional: Restore the default text color
            }
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }
            DateTime joinDate = DateTime.Now;
            string email = txtEmail.Text;
            string fullname = txtFullname.Text;
            DateTime birthdate;
            bool isValidBirthdate = DateTime.TryParseExact(mtxtDateBirth.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate);
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text) ||
                string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(mtxtDateBirth.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                (!lbFemale.Checked && !lbMale.Checked))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            if (!chkAccept.Checked)
            {
                MessageBox.Show("You have to accept the policy");
                return;
            }
            if (!isValidBirthdate)
            {
                // Display an error message or handle the invalid birthdate input
                MessageBox.Show("Invalid birthdate format. Please enter the date in dd/MM/yyyy format.");
                return;
            }
            byte gender = 1;
            if (lbFemale.Checked)
            {
                gender = 2;
            }
            string phone = txtPhone.Text;
            byte roleNum = 1;
            if (chkInstructor.Checked)
            {
                roleNum = 2;
            }
            Boolean accept = chkAccept.Checked;

            using (var repository = new YogaCenterContext())
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    JoinDate = joinDate,
                    RoleId = roleNum,
                    Fullname = fullname,
                    Dob = birthdate,
                    Gender = gender,
                    Email = email,
                    Phone = phone,


                };
                repository.Users.Add(user);
                repository.SaveChanges();
            }

            this.Hide();
            frmHome homeForm = new frmHome();
            homeForm.ShowDialog();
        }


    }
}
