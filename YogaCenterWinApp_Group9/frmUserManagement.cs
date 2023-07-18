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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace YogaCenterWinApp_Group9;

public partial class frmUserManagement : Form
{
    IUserRepository userRepository = new UserRepository();
    BindingSource source = new BindingSource();

    public frmUserManagement()
    {
        InitializeComponent();
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

            dgvuser.DataSource = null;
            dgvuser.DataSource = source;

        }
        catch (Exception)
        {

            throw;
        }
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
                if (user.Role.Id != null)
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
        string username = txtusernameSearch.Text;
        string phone = txtphonenumberSearch.Text;
        string code = txtmembercodeSearch.Text;
        string email = txtemailSearch.Text;
        string fullName = txtfullnameSearch.Text;

        // Gọi phương thức tìm kiếm từ UserRepository với từng giá trị tương ứng
        IEnumerable<User> searchResults = userRepository.GetUsersByCriteria(user =>
            (string.IsNullOrEmpty(username) || user.Username.Contains(username)) &&
            (string.IsNullOrEmpty(phone) || user.Phone.Contains(phone)) &&
            (string.IsNullOrEmpty(code) || user.Code.Contains(code)) &&
            (string.IsNullOrEmpty(email) || user.Email.Contains(email)) &&
            (string.IsNullOrEmpty(fullName) || user.Fullname.Contains(fullName))
        );
        source.DataSource = searchResults;
        dgvuser.DataSource = null;
        dgvuser.DataSource = source;
        if (!searchResults.Any())
        {
            MessageBox.Show("No matching users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUserList();
        }
    }
}
