using static YogaCenterWinApp_Group9.Utils.Extensions;
using YogaCenterWinApp_Group9;

namespace YogaCenterWinApp_Group9;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        frmHome frmHome = new frmHome();
        frmHome.ConfigureMdi(this);
        frmHome.Show();
    }
}
