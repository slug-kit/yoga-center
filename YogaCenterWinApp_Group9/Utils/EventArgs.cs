using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9.Utils.CustomEventArgs;

public class LoginEventArgs : EventArgs
{
    public long Id { get; init; }
    public string? Username { get; set; }
    public bool FullPrivilege { get; set; }
}

public class SignupEventArgs : EventArgs
{
    public string Username { get; init; } = null!;
    public User? User { get; set; }
    public bool AutoLogin { get; set; }
}
