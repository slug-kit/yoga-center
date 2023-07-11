using static YogaCenterWinApp_Group9.Utils.Extensions;
using YogaCenterWinApp_Group9;
using YogaCenter.Repository.Models;
using YogaCenterWinApp_Group9.Utils;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmMain : Form
{
    private bool authenticated;
    private bool adminMode;
    private User? _curUser;

    public User? CurrentUser
    {
        get => _curUser;
        private set
        {
            _curUser = value;
            Program.User = value;
        }
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        UpdateMenu();
        //ShowLoginForm();
    }

    private void UpdateMenu()
    {
        loginToolStripMenuItem.Enabled = !authenticated;
        loginToolStripMenuItem.Visible = !authenticated;
        profileToolStripMenuItem.Enabled = authenticated && !adminMode;
        profileToolStripMenuItem.Visible = authenticated && !adminMode;
        logoutToolStripMenuItem.Enabled = authenticated;
        logoutToolStripMenuItem.Visible = authenticated;

        navigationToolStripMenuItem.Enabled = authenticated;
        programsToolStripMenuItem.Enabled = adminMode;
        coursesToolStripMenuItem.Enabled = adminMode;
        usersToolStripMenuItem.Enabled = adminMode;
    }

    #region User Session Management

    private void GrantAccess(object sender, LoginEventArgs e)
    {
        if (!authenticated)
        {
            authenticated = true;
            adminMode = e.FullPrivilege;
            if (!adminMode) CurrentUser = new UserRepository().GetUserById(e.Id)
                    ?? throw new ArgumentException("Login was successful but user could not be found.");

            Form frmLogin = (Form)sender;
            frmLogin.Close();
            frmLogin.Dispose();
            UpdateMenu();

            frmHome frmWelcome = new();
            frmWelcome.ConfigureMdi(this);
            frmWelcome.Show();

            YogaCenter.Repository.Models.Program program = new();
        }
    }
    private void DenyAccess(object sender, LoginEventArgs e)
    {
        if (!authenticated)
            MessageBox.Show("Incorrect email and password combination.");
    }

    private void UpdateProfileObject(object sender, UserChangedEventArgs e)
    {
        //if (sender is frmProfile frmProfile)
        //{
        //    Program.User = frmProfile.User;
        //    if (e.ReAuthenticate)
        //        PerformLogout();
        //}
    }

    private void Exit(object sender, EventArgs e) => Close();

    #endregion

}
