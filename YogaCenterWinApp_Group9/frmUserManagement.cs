using System.Data;
using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9;

public partial class frmUserManagement : Form
{
    private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

    IUserRepository userRepository = new UserRepository();
    BindingSource source = new BindingSource();

    public frmUserManagement()
    {
        InitializeComponent();
        source.CurrentChanged += source_CurrentChanged;
    }

    //LOAD--------------------------------------------------------------------
    public void LoadUserList()
    {
        try
        {
            var userList = userRepository.GetAllUsers();
            source.DataSource = userList;

            txtusername.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtmembercode.DataBindings.Clear();
            txtfullname.DataBindings.Clear();
            txtphonenumber.DataBindings.Clear();
            cborole.DataBindings.Clear();
            cbogender.DataBindings.Clear();
            datejoin.DataBindings.Clear();
            lastlogin.DataBindings.Clear();
            dob.DataBindings.Clear();
            rtbSpecialization.DataBindings.Clear();

            txtusername.DataBindings.Add("Text", source, "Username");
            txtemail.DataBindings.Add("Text", source, "Email");
            txtmembercode.DataBindings.Add("Text", source, "Code");
            txtfullname.DataBindings.Add("Text", source, "Fullname");
            txtphonenumber.DataBindings.Add("Text", source, "Phone");
            cborole.DataBindings.Add("Text", source, "RoleId");
            cbogender.DataBindings.Add("Text", source, "Gender");
            datejoin.DataBindings.Add("Text", source, "JoinDate");
            lastlogin.DataBindings.Add("Text", source, "LastLogin");
            dob.DataBindings.Add("Text", source, "Dob");
            rtbSpecialization.DataBindings.Add("Text", source, "Specializations");

            var imageBinding = new Binding(nameof(PictureBox.ImageLocation), source, nameof(User.Img),
                true, DataSourceUpdateMode.Never);
            imageBinding.Format += EmptyImageLocationToDefaultImage;
            pictureBox.DataBindings.Add(imageBinding);

            dgvuser.DataSource = null;
            dgvuser.DataSource = source;

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void EmptyImageLocationToDefaultImage(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        cevent.Value ??= DEFAULT_IMG_LOCATION;
    }

    private void source_CurrentChanged(object? sender, EventArgs e)
    {
        // Update the visibility of the labels whenever the selected user changes
        User? selectedUser = source.Current as User;
        if (selectedUser != null)
        {
            // Assuming Role "2" corresponds to "role 2" and Role "3" corresponds to "role 3"
            if (selectedUser.RoleId == 2)
            {
                lbgoal.Visible = true;
                lbexperience.Visible = false;
                ShowGoalOrExperience(selectedUser.StudyGoals);
            }
            else if (selectedUser.RoleId == 3)
            {
                lbgoal.Visible = false;
                lbexperience.Visible = true;
                ShowGoalOrExperience(selectedUser.Specializations);
            }
            else
            {
                lbgoal.Visible = false;
                lbexperience.Visible = false;
                rtbGoalOrExperience.Text = ""; // If neither role 2 nor role 3, clear the text box
            }
        }
        else
        {
            lbgoal.Visible = false;
            lbexperience.Visible = false;
            rtbGoalOrExperience.Text = ""; // If no user selected, clear the text box
        }
    }
    private void ShowGoalOrExperience(string? textToShow)
    {
        rtbGoalOrExperience.Text = textToShow ?? ""; // Show the provided text or an empty string if null
    }

    private void frmUserManagement_Load(object sender, EventArgs e)
    {
        LoadUserList();
    }


    //GET ROLE VALUE ----------------------------------------------------------------------
    private void dgvuser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex == dgvuser.Columns["Role"].Index && e.RowIndex >= 0)
        {
            var user = dgvuser.Rows[e.RowIndex].DataBoundItem as User;
            if (user?.Role != null)
            {
                if (user?.Role.Id != null)
                {
                    e.Value = user.Role.Id.ToString(); // Chuyển đổi Id thành chuỗi
                }
                else
                {
                    e.Value = string.Empty; // Gán giá trị rỗng nếu không có giá trị Id
                }
            }
            else
            {
                e.Value = string.Empty; // Gán giá trị rỗng nếu không có giá trị Role
            }
        }
        if (e.ColumnIndex == dgvuser.Columns["JoinDate"].Index || e.ColumnIndex == dgvuser.Columns["LastLogin"].Index || e.ColumnIndex == dgvuser.Columns["Dob"].Index)
        {
            if (e.Value is DateTime)
            {
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }
    }

    //ADD USER --------------------------------------------------------------------------------------------------------
    private void btnadd_Click(object sender, EventArgs e)
    {
        frmUserManagementEdit frmUserManagementDetail = new frmUserManagementEdit()
        {
            Text = "New User",
            InsertOrUpdate = false,
            UserRepository = userRepository,
        };

        if (frmUserManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadUserList();
        }
    }

    //UPDATE USER --------------------------------------------------------------------------------------------------
    private void dgvuser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmUserManagementEdit frmUserManagementDetail = new frmUserManagementEdit()
        {
            Text = "Update User",
            InsertOrUpdate = true,
            UserDetail = GetUser(),
            UserRepository = userRepository,
        };

        if (frmUserManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadUserList();
        }
    }

    //GET USER FOR UPDATE-------------------------------------------------------------------------------------------
    private User GetUser()
    {
        return source.List[dgvuser.SelectedRows[0].Index] as User
            ?? throw new Exception("Could not get object model.");
    }

    //SUSPEND USER(REMOVE)-------------------------------------------------------------------------------------------------------------------------
    private void btnsuspend_Click(object sender, EventArgs e)
    {
        if (dgvuser.SelectedRows.Count > 0)
        {
            var selectedCourse = GetUser();

            // Confirmation dialog before deleting the course
            var confirmationResult = MessageBox.Show("Are you sure you want to suspend this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Mark the course as inactive and update it

                    selectedCourse.Inactive = true;
                    userRepository.DeleteUser(selectedCourse);
                    LoadUserList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while suspending a user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a course to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //SEARCH -----------------------------------------------------------------------------------------------------------------------------
    private void btnsearch_Click(object sender, EventArgs e)
    {
        string usernameSearch = txtusernameSearch.Text.Trim();
        string phoneNumberSearch = txtphonenumberSearch.Text.Trim();
        string memberCodeSearch = txtmembercodeSearch.Text.Trim();
        string emailSearch = txtemailSearch.Text.Trim();
        string fullnameSearch = txtfullnameSearch.Text.Trim();
        string roleIdSearch = txtRoleSearch.Text.Trim();
        string genderSearch = txtGenderSearch.Text.Trim();
        DateTime joinDateFrom = dtpJoinDateFrom.Value;
        DateTime joinDateTo = dtpJoinDateTo.Value;

        // Kiểm tra xem người dùng đã nhập thông tin tìm kiếm hay chưa
        bool isSearchEmpty = string.IsNullOrEmpty(usernameSearch) &&
                             string.IsNullOrEmpty(phoneNumberSearch) &&
                             string.IsNullOrEmpty(memberCodeSearch) &&
                             string.IsNullOrEmpty(emailSearch) &&
                             string.IsNullOrEmpty(fullnameSearch) &&
                             string.IsNullOrEmpty(roleIdSearch) &&
                             string.IsNullOrEmpty(genderSearch) &&
                             joinDateFrom == dtpJoinDateFrom.MinDate &&
                             joinDateTo == dtpJoinDateTo.MinDate;

        if (isSearchEmpty)
        {
            MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var userList = userRepository.GetAllUsers();
        var filteredUsers = userList
            .Where(user =>
                (string.IsNullOrEmpty(usernameSearch) || user.Username.Contains(usernameSearch)) &&
                (string.IsNullOrEmpty(phoneNumberSearch) || user.Phone != null && user.Phone.Contains(phoneNumberSearch)) &&
                (string.IsNullOrEmpty(memberCodeSearch) || user.Code != null && user.Code.Contains(memberCodeSearch)) &&
                (string.IsNullOrEmpty(emailSearch) || user.Email != null && user.Email.Contains(emailSearch)) &&
                (string.IsNullOrEmpty(fullnameSearch) || user.Fullname.Contains(fullnameSearch)) &&
                (string.IsNullOrEmpty(roleIdSearch) || (user.RoleId == byte.Parse(roleIdSearch))) && // Tìm kiếm theo RoleId
                (string.IsNullOrEmpty(genderSearch) || (user.Gender == byte.Parse(genderSearch))) &&
                (user.JoinDate >= joinDateFrom && user.JoinDate <= joinDateTo) // Tìm kiếm theo Gender
            )
            .ToList();

        source.DataSource = filteredUsers;
        dgvuser.DataSource = null;
        dgvuser.DataSource = source;
    }


}
