using YogaCenter.Repository.Models;
using YogaCenterWinApp_Group9.Utils;
using static YogaCenterWinApp_Group9.Utils.Extensions;

namespace YogaCenterWinApp_Group9;

public partial class frmMain : Form
{
    private bool authenticated;
    private bool adminMode;

    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        UpdateMenu();
        ShowLoginForm();
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
        navigationToolStripMenuItem.Visible = authenticated;
        programsToolStripMenuItem.Enabled = authenticated && !adminMode;
        programsToolStripMenuItem.Visible = authenticated && !adminMode;
        myCoursesToolStripMenuItem.Enabled = authenticated && !adminMode;
        myCoursesToolStripMenuItem.Visible = authenticated && !adminMode;
        timetableToolStripMenuItem.Enabled = authenticated && !adminMode;
        timetableToolStripMenuItem.Visible = authenticated && !adminMode;

        managementToolStripMenuItem.Enabled = authenticated && adminMode;
        managementToolStripMenuItem.Visible = authenticated && adminMode;
        programManagementToolStripMenuItem.Enabled = authenticated && adminMode;
        programManagementToolStripMenuItem.Visible = authenticated && adminMode;
        courseManagementToolStripMenuItem.Enabled = authenticated && adminMode;
        courseManagementToolStripMenuItem.Visible = authenticated && adminMode;
        userManagementToolStripMenuItem.Enabled = authenticated && adminMode;
        userManagementToolStripMenuItem.Visible = authenticated && adminMode;
    }

    #region User Session Management

    private void GrantAccess(object sender, LoginEventArgs e)
    {
        if (!authenticated)
        {
            authenticated = true;
            adminMode = e.FullPrivilege;
            if (!adminMode) Program.CurrentUser = new UserRepository().GetUserById(e.Id)
                    ?? throw new ArgumentException("A error has occurred during the login process.");

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
        {
            MessageBox.Show("Incorrect email and password combination.");
        }
    }

    private void UpdateProfileObject(object sender, UserChangedEventArgs e)
    {
        if (sender is frmProfile frmProfile)
        {
            Program.CurrentUser = frmProfile.User;
            if (e.ReAuthenticate)
                PerformLogout();
        }
    }

    private void Exit(object sender, EventArgs e) => Close();

    #endregion

    #region User Menu

    private void ShowLoginForm()
    {
        if (!authenticated)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == typeof(frmLogin))
                {
                    f.Activate();
                    return;
                }
            }

            frmLogin frmLogin = new();
            frmLogin.ConfigureMdi(this,
                new List<LoginEventHandler> { GrantAccess },
                new List<LoginEventHandler> { DenyAccess },
                new List<ExitEventHandler> { Exit });
            frmLogin.Show();
        }
    }

    private void PerformLogout()
    {
        adminMode = false;
        authenticated = false;
        Program.CurrentUser = null;
        foreach (Form f in MdiChildren)
        {
            f.Close();
            f.Dispose();
        }
        UpdateMenu();
        ShowLoginForm();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e) => ShowLoginForm();

    private void profileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Program.CurrentUser == null) throw new InvalidOperationException("User is unauthenticated or does not have a profile.");
        frmProfile frmProfile = new();
        frmProfile.ConfigureMdi(this);
        frmProfile.ProfileUpdated += UpdateProfileObject;
        frmProfile.Show();
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e) => PerformLogout();

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Exit(sender, e);

    #endregion

    #region Navigation Menu

    private void programsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            //frmProgramList frmProgramList = new() { AdminMode = adminMode };
            //frmProgramList.ConfigureMdi(this);
            //frmProgramList.Show();
        }
    }

    private void myCoursesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmEnrolledCourses frmEnrolledCourses = new();
            frmEnrolledCourses.ConfigureMdi(this);
            frmEnrolledCourses.Show();
        }
    }

    private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmTimetable frmTimetable = new();
            frmTimetable.ConfigureMdi(this);
            frmTimetable.Show();
        }
    }

    #endregion

    #region Management Menu

    private void programManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmProgramManagement frmProgramManagement = new();
            frmProgramManagement.ConfigureMdi(this);
            frmProgramManagement.Show();
        }
    }

    private void courseManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmCourseManagement frmCourseManagement = new();
            frmCourseManagement.ConfigureMdi(this);
            frmCourseManagement.Show();
        }
    }

    private void dailyScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmCalendarDetail frmDailyScheduleManagement = new();
            frmDailyScheduleManagement.ConfigureMdi(this);
            frmDailyScheduleManagement.Show();
        }
    }

    private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (authenticated)
        {
            frmUserManagement frmUserManagement = new();
            frmUserManagement.ConfigureMdi(this);
            frmUserManagement.Show();
        }
    }

    #endregion
}
