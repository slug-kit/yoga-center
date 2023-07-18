using System.Reflection;
using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;
using YogaCenterWinApp_Group9.Utils;
using YogaCenterWinApp_Group9.Utils.CustomEventHandlers;

namespace YogaCenterWinApp_Group9;

public partial class frmProfile : Form
{
    public event UserChangedEventHandler? ProfileUpdated;

    private readonly IUserRepository userRepository = new UserRepository();
    private readonly BindingSource bindingSource = new();
    private bool isModified = false;

    private readonly List<Control> dataInputControls;

    private readonly User _pom = new()
    {
        Id = Program.CurrentUser!.Id,
        Username = Program.CurrentUser.Username,
        Fullname = Program.CurrentUser.Fullname,
        Dob = Program.CurrentUser.Dob,
        Gender = Program.CurrentUser.Gender,
        Email = Program.CurrentUser.Email,
        Phone = Program.CurrentUser.Phone,
    };

    public User User => _pom;

    public frmProfile()
    {
        InitializeComponent();
        dataInputControls = new()
        {
            txtEmail,
            txtFullname,
            txtUsername,
            dob,
            mtbphonenumber,
            txtgender
        };
    }

    protected virtual void OnProfileUpdate(UserChangedEventArgs e) => ProfileUpdated?.Invoke(this, e);

    private void frmProfile_Load(object sender, EventArgs e)
    {
        LoadUserprofile();
        LoadCourseOfUser();
    }

    private void LoadCourseOfUser()
    {
        long userId = _pom.Id;

        // Get the enrolled courses for the user
        IEnumerable<Course> enrolledCourses = userRepository.GetEnrolledCourses(userId);

        // Clear any existing data in the DataGridView
        dgvCourse.DataSource = null;
        dgvCourse.Rows.Clear();

        // Bind the enrolled courses to the DataGridView
        dgvCourse.DataSource = enrolledCourses.ToList();
    }

    private void LoadUserprofile()
    {
        foreach (Control c in Controls)
            c.DataBindings.Clear();
        bindingSource.DataSource = null;

        bindingSource.DataSource = _pom;

        txtEmail.DataBindings.Add("Text", bindingSource, "Email", true)
            .Parse += DataField_DetectChange!;
        txtFullname.DataBindings.Add("Text", bindingSource, "Fullname", true)
            .Parse += DataField_DetectChange!;
        txtUsername.DataBindings.Add("Text", bindingSource, "Username", true)
            .Parse += DataField_DetectChange!;
        txtgender.DataBindings.Add("Text", bindingSource, "Gender", true)
            .Parse += DataField_DetectChange!;
        dob.DataBindings.Add("Text", bindingSource, "Dob", true)
            .Parse += DataField_DetectChange!;
        mtbphonenumber.DataBindings.Add("Text", bindingSource, "Phone", true)
            .Parse += DataField_DetectChange!;
    }

    private void DataField_DetectChange(object sender, ConvertEventArgs e) => isModified = true;

    private void TurnOnUpdateMode()
    {
        foreach (Control c in dataInputControls)
        {
            if (c is TextBoxBase txtb)
                txtb.ReadOnly = false;
            else c.Enabled = true;
        }
        btnUpdate.Enabled = false;
        btnUpdate.Visible = false;

        btnSave.Visible = true;
        btnSave.Enabled = true;
        btnCancel.Visible = true;
        btnCancel.Enabled = true;
    }

    private void TurnOffUpdateMode()
    {
        foreach (Control c in dataInputControls)
        {
            if (c is TextBoxBase txtb)
                txtb.ReadOnly = true;
            else c.Enabled = false;
        }

        btnSave.Enabled = false;
        btnSave.Visible = false;
        btnCancel.Enabled = false;
        btnCancel.Visible = false;

        btnUpdate.Visible = true;
        btnUpdate.Enabled = true;
    }

    private void btnSave_Click(object sender, EventArgs e) => PerformSave();

    private void btnUpdate_Click(object sender, EventArgs e) => TurnOnUpdateMode();

    private void PerformSave()
    {
        try
        {
            userRepository.UpdateUser(_pom);
            OnProfileUpdate(new() { ReAuthenticate = false });

            TurnOffUpdateMode();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message, "ERROR -- Update profile");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (isModified)
        {
            if (MessageBox.Show("Cancelling now will undo all changes. Are you sure?", "Change Detected", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
        }

        ResetProfile();
        TurnOffUpdateMode();
        isModified = false;
    }
    private void ResetProfile()
    {
        foreach (PropertyInfo prop in _pom.GetType().GetProperties())
        {
            prop.SetValue(_pom, prop.GetValue(Program.CurrentUser));
        }
        bindingSource.ResetBindings(false);
    }
}
