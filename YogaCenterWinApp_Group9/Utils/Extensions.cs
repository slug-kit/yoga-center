using System.Runtime.CompilerServices;

namespace YogaCenterWinApp_Group9.Utils;

public delegate void LoginEventHandler(object sender, LoginEventArgs e);
public delegate void ExitEventHandler(object sender, EventArgs e);
public delegate void UserChangedEventHandler(object sender, UserChangedEventArgs e);

public static class Extensions
{
    public static IEnumerable<T> Descendants<T>(this Control control) where T : class?
    {
        foreach (Control child in control.Controls)
        {
            if (child is T childOfT)
            {
                yield return childOfT;
            }

            if (child is ToolStrip toolStrip)
            {
                foreach (ToolStripItem toolStripItem in toolStrip.Items)
                {
                    if (toolStripItem is T toolStripItemOfT)
                    {
                        yield return toolStripItemOfT;
                    }
                }
            }

            if (child.HasChildren)
            {
                foreach (T descendant in Descendants<T>(child))
                {
                    yield return descendant;
                }
            }
        }
    }

    private const string STATUS_BAR_FORM_TITLE_CONTROL_NAME = "formTitleLabel";
    public static void ConfigureMdi(this Form form, Form mdiParent)
    {
        form.MdiParent = mdiParent;
        form.Dock = DockStyle.Fill;
        form.FormBorderStyle = FormBorderStyle.None;
        form.StartPosition = FormStartPosition.CenterParent;
        if (mdiParent is frmMain frmMain)
        {
            foreach (ToolStripItem toolStripItem in frmMain.Descendants<ToolStripItem>())
            {
                if (toolStripItem.Name == STATUS_BAR_FORM_TITLE_CONTROL_NAME)
                {
                    toolStripItem.Text = form.Text;
                    break;
                }
            }
        }
    }

    public static void ConfigureMdi(this frmLogin form, Form mdiParent,
        ICollection<LoginEventHandler> loginSuccessHandlers, ICollection<LoginEventHandler> loginFailureHandlers, ICollection<ExitEventHandler> exitHandlers)
    {
        ConfigureMdi(form, mdiParent);

        foreach (LoginEventHandler loginSuccessHandler in loginSuccessHandlers)
            form.AuthenticationPassed += loginSuccessHandler;
        foreach (LoginEventHandler loginFailureHandler in loginFailureHandlers)
            form.AuthenticationFailed += loginFailureHandler;
        foreach (ExitEventHandler exitHandler in exitHandlers)
            form.Exiting += exitHandler;
    }

    public static string GetDataDisplayPropertyName(this Control control) => control switch
    {
        DateTimePicker or ListControl or MonthCalendar or UpDownBase => "Value",
        TextBoxBase => "Text",
        _ => string.Empty
    };
}
