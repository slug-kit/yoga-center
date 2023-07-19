using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9
{
    public partial class frmUserManagementEdit : Form
    {
        public frmUserManagementEdit()
        {
            InitializeComponent();
        }

        public IUserRepository UserRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public User UserDetail { get; set; }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng đối tượng User đã được truyền vào thay vì tạo mới
                UserDetail.Username = txtusername.Text;
                UserDetail.Password = txtpassword.Text;
                UserDetail.JoinDate = DateTime.Now;
                UserDetail.RoleId = byte.Parse(cboroleid.Text);
                UserDetail.Code = txtcode.Text;
                UserDetail.Fullname = txtfullname.Text;
                UserDetail.Dob = DateTime.Now;
                UserDetail.Gender = byte.Parse(cbogender.Text);
                UserDetail.Phone = txtphonenumber.Text;
                UserDetail.StudyGoals = txtstudygoal.Text;
                UserDetail.Email = txtemail.Text;

                if (InsertOrUpdate == false)
                {
                    UserRepository.AddUser(UserDetail);
                }
                else
                {
                    UserRepository.UpdateUser(UserDetail);
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
            if (InsertOrUpdate == true && UserDetail != null)
            {
                txtusername.Text = UserDetail.Username.ToString();
                txtpassword.Text = UserDetail.Password.ToString();
                datejoin.Text = UserDetail.JoinDate.ToString();
                cboroleid.Text = UserDetail.RoleId.ToString();
                txtcode.Text = UserDetail.Code.ToString();
                txtfullname.Text = UserDetail.Fullname.ToString();
                dob.Text = UserDetail.Dob.ToString();
                cbogender.Text = UserDetail.Gender.ToString();
                txtphonenumber.Text = UserDetail.Phone.ToString();
                txtemail.Text = UserDetail.Email.ToString();
                txtstudygoal.Text = UserDetail.StudyGoals.ToString();
            }
        }

        private void btnexit_Click(object sender, EventArgs e) => Close();
    }
}
