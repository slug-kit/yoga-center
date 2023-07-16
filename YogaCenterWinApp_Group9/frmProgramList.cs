using System.Globalization;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmProgramList : Form
{
    private const NumberStyles CURRENCY_STYLE = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
    private readonly CultureInfo CULTURE = CultureInfo.CurrentCulture;

    private readonly IProgramRepository programRepository = new ProgramRepository();

    private readonly bool _adminMode;
    public bool AdminMode
    {
        get => _adminMode;
        init => _adminMode = value;
    }

    public frmProgramList()
    {
        InitializeComponent();
    }

    private void frmProgramList_Load(object sender, EventArgs e)
    {
        // 1. If user does not have admin privileges, start in limited mode
        // 2. Load data to grid view
        if (!_adminMode)
        {
            StartInLimitedMode();
        }
        BindPrimaryModel();
    }

    private void BindPrimaryModel()
    {
        try
        {
            // 1. Clear bindings
            foreach (Control control in pnlFilter.Controls)
            {
                control.DataBindings.Clear();
            }
        }
        catch (Exception)
        {

        }
    }

    private void StartInLimitedMode()
    {
        // Admin mode not implemented, so do nothing
    }
}
