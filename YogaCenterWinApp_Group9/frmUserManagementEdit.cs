using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9
{
    public partial class frmUserManagementEdit : Form
    {
        private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

        public frmUserManagementEdit()
        {
            InitializeComponent();
        }

        public IUserRepository UserRepository { get; set; } = new UserRepository();
        public bool InsertOrUpdate { get; set; }
        public User UserDetail { get; set; } = new();

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                    string.IsNullOrWhiteSpace(txtpassword.Text) ||
                    string.IsNullOrWhiteSpace(cboroleid.Text) ||
                    string.IsNullOrWhiteSpace(txtfullname.Text) ||
                    string.IsNullOrWhiteSpace(cbogender.Text) ||
                    string.IsNullOrWhiteSpace(txtphonenumber.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information");
                    return; // Stop further processing
                }

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
                UserDetail.Email = txtemail.Text;

                // Check if dayofbirth is greater than datejoin
                if (UserDetail.Dob > UserDetail.JoinDate)
                {
                    MessageBox.Show("Day of Birth cannot be greater than Join Date.", "Invalid Dates");
                    return; // Stop further processing
                }

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
                txtcode.Text = UserDetail?.Code?.ToString();
                txtfullname.Text = UserDetail?.Fullname.ToString();
                dob.Text = UserDetail?.Dob.ToString();
                cbogender.Text = UserDetail?.Gender.ToString();
                txtphonenumber.Text = UserDetail?.Phone?.ToString();
                txtemail.Text = UserDetail?.Email?.ToString();

                pictureBox.ImageLocation = UserDetail?.Img ?? DEFAULT_IMG_LOCATION;
            }
        }

        private void btnexit_Click(object sender, EventArgs e) => Close();
    }
}
