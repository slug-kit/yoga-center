using YogaCenterWinApp_Group9.Utils.CustomEventArgs;

namespace YogaCenterWinApp_Group9.Utils.CustomEventHandlers;

public delegate void LoginEventHandler(object sender, LoginEventArgs e);
public delegate void SignupEventHandler(object sender, SignupEventArgs e);
public delegate void ExitEventHandler(object sender, EventArgs e);
public delegate void UserChangedEventHandler(object sender, UserChangedEventArgs e);
