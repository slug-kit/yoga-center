namespace YogaCenterWinApp_Group9.Utils;

public class LoginEventArgs : EventArgs
{
    public long Id { get; init; }
    public string? Name { get; set; }
    public bool FullPrivilege { get; set; }
}
