using static YogaCenterWinApp_Group9.Utils.Regexes;

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

    //public static void ConfigureMdi(this frmLogin form, Form mdiParent,
    //    ICollection<LoginEventHandler> loginSuccessHandlers, ICollection<LoginEventHandler> loginFailureHandlers, ICollection<ExitEventHandler> exitHandlers)
    //{
    //    form.MdiParent = mdiParent;
    //    form.Dock = DockStyle.Fill;
    //    form.FormBorderStyle = FormBorderStyle.None;
    //    form.StartPosition = FormStartPosition.CenterParent;

    //    foreach (LoginEventHandler loginSuccessHandler in loginSuccessHandlers)
    //        form.AuthenticationPassed += loginSuccessHandler;
    //    foreach (LoginEventHandler loginFailureHandler in loginFailureHandlers)
    //        form.AuthenticationFailed += loginFailureHandler;
    //    foreach (ExitEventHandler exitHandler in exitHandlers)
    //        form.Exiting += exitHandler;
    //}

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

    public static string ReplaceWhitespace(this string inputStr, string replacementStr)
        => Regex_AllWhitespace.Replace(inputStr, replacementStr);

    public static bool IsValidEmailAddress(this string email)
    {
        var trimmedEmail = email.Trim();
        if (trimmedEmail.EndsWith('.'))
        {
            return false;
        }

        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == trimmedEmail;
        }
        catch { return false; }
    }

    public static void Replace(this System.Collections.IList list, int index, object? value)
    {
        if (index > list.Count) throw new ArgumentOutOfRangeException(string.Format("{0} is out of range.", nameof(index)));
        if (list.IsReadOnly || list.IsFixedSize) throw new NotSupportedException("Method is not supported for this list.");
        if (value == null) throw new ArgumentNullException(string.Format("{0} cannot be null.", nameof(value)));
        if (index == list.Count) { list.Add(value); }
        else { list.RemoveAt(index); list.Insert(index, value); }
    }
}
