using System.ComponentModel;
using YogaCenterWinApp_Group9.Utils.CustomEventHandlers;
using YogaCenterWinApp_Group9.Utils.CustomEventArgs;
using Utils;

namespace YogaCenterWinApp_Group9;

public partial class frmLogin : Form
{
    private const int ADMIN_ROLE = 1;

    private readonly IUserRepository userRepository = new UserRepository();

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

    private void txtUsername_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && Validate())
            PerformLogin();
    }

    private void PerformLogin()
    {
        try
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.");
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            var curAccount = userRepository.GetUsersByCriteria(u => username == u.Username && password == u.Password).FirstOrDefault();
            if (curAccount != null)
            {
                if (ADMIN_ROLE == curAccount.Role.Id)
                    OnLoginSuccess(new LoginEventArgs() { Id = curAccount.Id, FullPrivilege = true });
                else
                    OnLoginSuccess(new LoginEventArgs() { Id = curAccount.Id, FullPrivilege = false });
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
        LoginEventHandler? loginEventDelegate = (LoginEventHandler?)EventHandlers[authFailedEventKey];
        loginEventDelegate?.Invoke(this, e);
    }

    protected virtual void OnExitCall(EventArgs e) => Exiting?.Invoke(this, e);

    private void btnExit_Click(object sender, EventArgs e) => OnExitCall(EventArgs.Empty);

    private void btRegister_Click(object sender, EventArgs e)
    {
        frmRegister frmRegister = new();
        frmRegister.NewUserRegistered += LoginNewlyRegisteredUser;
        frmRegister.ShowDialog();
    }

    private void LoginNewlyRegisteredUser(object sender, SignupEventArgs e)
    {
        e.User ??= userRepository.GetUsersByCriteria(u => u.Username == e.Username).First();
        if (e.User != null)
        {
            txtUsername.Text = e.User.Username.ToString();
            txtPassword.Text = e.User.Password.ToString();
            PerformLogin();
        }
    }
}
