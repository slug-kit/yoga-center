namespace YogaCenterWinApp_Group9.Utils;

public delegate void LoginEventHandler(object sender, LoginEventArgs e);
public delegate void ExitEventHandler(object sender, EventArgs e);
public delegate void UserChangedEventHandler(object sender, UserChangedEventArgs e);

public static class Extensions
{
    public static void ConfigureMdi(this Form form, Form mdiParent)
    {
        form.MdiParent = mdiParent;
        form.Dock = DockStyle.Fill;
        form.FormBorderStyle = FormBorderStyle.None;
        form.StartPosition = FormStartPosition.CenterParent;
    }

    public static void ConfigureMdi(this frmLogin form, Form mdiParent,
        ICollection<LoginEventHandler> loginSuccessHandlers, ICollection<LoginEventHandler> loginFailureHandlers, ICollection<ExitEventHandler> exitHandlers)
    {
        form.MdiParent = mdiParent;
        form.Dock = DockStyle.Fill;
        form.FormBorderStyle = FormBorderStyle.None;
        form.StartPosition = FormStartPosition.CenterParent;

        foreach (LoginEventHandler loginSuccessHandler in loginSuccessHandlers)
            form.AuthenticationPassed += loginSuccessHandler;
        foreach (LoginEventHandler loginFailureHandler in loginFailureHandlers)
            form.AuthenticationFailed += loginFailureHandler;
        foreach (ExitEventHandler exitHandler in exitHandlers)
            form.Exiting += exitHandler;
    }

    public static string GetDataDisplayPropertyName(this Control control)
    {
        if ((control is DateTimePicker)
         || (control is ListControl)
         || (control is MonthCalendar)
         || (control is TextBoxBase)
         || (control is UpDownBase)
         || (control is UserControl)) { }

        return control switch
        {
            DateTimePicker or ListControl or MonthCalendar or UpDownBase => "Value",
            TextBoxBase => "Text",
            _ => string.Empty
        };
    }
}
