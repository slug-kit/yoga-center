using System.ComponentModel;
using YogaCenter.Repository.Repos;
using YogaCenterWinApp_Group9.Utils;

namespace YogaCenterWinApp_Group9;

public partial class frmLogin : Form
{
    private const int ADMIN_ROLE = 1;

    private readonly IUserRepository _userRepository = new UserRepository();

    protected EventHandlerList EventHandlers = new EventHandlerList();

    private static readonly object authPassedEventKey = new();
    private static readonly object authFailedEventKey = new();

    public event LoginEventHandler? AuthenticationPassed
    {
        add => EventHandlers.AddHandler(authPassedEventKey, value);
        remove => EventHandlers.RemoveHandler(authPassedEventKey, value);
    }
    public event LoginEventHandler? AuthenticationFailed
    {
        add => EventHandlers.AddHandler(authFailedEventKey, value);
        remove => EventHandlers.RemoveHandler(authFailedEventKey, value);
    }

    public event ExitEventHandler? Exiting;

    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e) => PerformLogin();

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && Validate())
            PerformLogin();
    }
    private void txtEmail_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && Validate())
            PerformLogin();
    }

    private void PerformLogin()
    {
        try
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                txtEmail.Focus();
                return;
            }
            if (!email.IsValidEmailAddress())
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            var curAccount = _userRepository.GetUsersByCriteria(u => email == u.Email && password == u.Password).SingleOrDefault();
            if (curAccount != null)
            {
                if (ADMIN_ROLE == curAccount.Role.Id)
                    OnLoginSuccess(new LoginEventArgs() { FullPrivilege = true });
                else
                    OnLoginSuccess(new LoginEventArgs() { Id = curAccount.Id, FullPrivilege = false });
                frmMain frmMain = new frmMain();
                frmMain.Show();
                Hide();
            }
            else
            {
                OnLoginFailure(new LoginEventArgs());
                txtPassword.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message, "ERROR -- Login");
        }
    }

    protected virtual void OnLoginSuccess(LoginEventArgs e)
    {
        LoginEventHandler? loginEventDelegate = (LoginEventHandler?)EventHandlers[authPassedEventKey];
        loginEventDelegate?.Invoke(this, e);
    }

    protected virtual void OnLoginFailure(LoginEventArgs e)
    {
        LoginEventHandler? loginEventDelegate = (LoginEventHandler?)EventHandlers[(authFailedEventKey)];
        loginEventDelegate?.Invoke(this, e);
    }

    protected virtual void OnExitCall(EventArgs e) => Exiting?.Invoke(this, e);

    private void btnExit_Click(object sender, EventArgs e) => OnExitCall(EventArgs.Empty);
}
