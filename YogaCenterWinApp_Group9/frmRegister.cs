using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using YogaCenter.Repository.Models;
using YogaCenterWinApp_Group9.Utils.CustomEventArgs;
using YogaCenterWinApp_Group9.Utils.CustomEventHandlers;

namespace YogaCenterWinApp_Group9;

public partial class frmRegister : Form
{
    private const string PLACEHOLDER_EMAIL = "yoga@gmail.com";

    private const int MINIMUM_AGE = 13;
    private readonly TimeSpan MINIMUM_YEARS = TimeSpan.FromDays(MINIMUM_AGE * 365.2425);

    private readonly IUserRepository repository = new UserRepository();

    public event SignupEventHandler? NewUserRegistered;

    public frmRegister()
    {
        InitializeComponent();
        txtEmail.Enter += txtEmail_Enter!;
        txtEmail.Leave += txtEmail_Leave!;
    }

    private void frmRegister_Load(object sender, EventArgs e)
    {
        txtEmail.Text = PLACEHOLDER_EMAIL;
    }

    private void txtEmail_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            txtEmail.Text = PLACEHOLDER_EMAIL;
            txtEmail.ForeColor = SystemColors.GrayText; // Optional: Change the text color to gray
        }
    }

    private void txtEmail_Enter(object sender, EventArgs e)
    {
        if (txtEmail.Text == PLACEHOLDER_EMAIL)
        {
            txtEmail.Text = string.Empty;
            txtEmail.ForeColor = SystemColors.WindowText; // Optional: Restore the default text color
        }
    }
    private void btRegister_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text) ||
            string.IsNullOrWhiteSpace(txtConfirm.Text) ||
            string.IsNullOrWhiteSpace(txtFullname.Text) ||
            string.IsNullOrWhiteSpace(txtPhone.Text) ||
            (!lbFemale.Checked && !lbMale.Checked))
        {
            MessageBox.Show("Please fill in all the required fields.");
            return;
        }

        string username = txtUsername.Text;

        string password = txtPassword.Text;

        string confirmPassword = txtConfirm.Text;
        if (password != confirmPassword)
        {
            MessageBox.Show("Password and Confirm Password do not match.");
            return;
        }

        string fullname = txtFullname.Text;

        string email = txtEmail.Text;

        DateTime joinDate = DateTime.Now;
        DateTime birthDate = dtpDob.Value;
        if (joinDate - birthDate < MINIMUM_YEARS)
        {
            MessageBox.Show($"You must be at least {MINIMUM_AGE} years old to register.");
            return;
        }

        byte gender = (byte)(lbFemale.Checked ? 1 : 2);

        string phone = txtPhone.Text;

        byte roleNum = (byte)(chkInstructor.Checked ? 2 : 3);

        if (!chkAccept.Checked)
        {
            MessageBox.Show("You must accept to our Terms of Service to proceed.");
            return;
        }

        var user = new User
        {
            Username = username,
            Password = password,
            JoinDate = joinDate,
            RoleId = roleNum,
            Fullname = fullname,
            Dob = birthDate,
            Gender = gender,
            Email = email,
            Phone = phone
        };

        try
        {
            repository.AddUser(user);
            OnSignupSuccess(new SignupEventArgs() { Username = username, AutoLogin = true });
            Close();
            Dispose();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message, "ERROR -- Login");
        }
    }

    protected virtual void OnSignupSuccess(SignupEventArgs e) => NewUserRegistered?.Invoke(this, e);
}
