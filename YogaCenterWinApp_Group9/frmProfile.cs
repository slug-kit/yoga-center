using YogaCenter.Repository.Models;
using YogaCenterWinApp_Group9.Utils;

namespace YogaCenterWinApp_Group9;

public partial class frmProfile : Form
{
    public event UserChangedEventHandler? ProfileUpdated;

    private readonly User _pom = new()
    {
        
    };

    public User User => _pom;

    public frmProfile()
    {
        InitializeComponent();
    }

    protected virtual void OnProfileUpdate(UserChangedEventArgs e) => ProfileUpdated?.Invoke(this, e);
}
