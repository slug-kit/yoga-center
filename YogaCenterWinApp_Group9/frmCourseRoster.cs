using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseRoster : Form
{
    private readonly ICourseRosterRepository courseRosterRepository = new CourseRosterRepository();
    private readonly BindingSource bindingSource = new();

    private readonly Course _course = new();
    public Course Course
    {
        get => _course;
        init => _course = value;
    }

    private readonly bool _adminMode;
    public bool AdminMode
    {
        get => _adminMode;
        init => _adminMode = value;
    }

    public frmCourseRoster()
    {
        InitializeComponent();
    }

    private void frmCourseRoster_Load(object sender, EventArgs e)
    {
        // 1. If user does not have admin privileges, start in limited mode
        // 2. Load data to grid view
        if (!_adminMode)
        {
            StartInLimitedMode();
        }
        BindPrimaryModel();
    }

    private void StartInLimitedMode()
    {
        grbListActions.Enabled = false;
        grbListActions.Visible = false;
        grbFormActions.Enabled = false;
        grbFormActions.Visible = false;

        lsvLearners.Height = splitContainer.Panel1.Height;
        Height = splitContainer.Height + splitContainer.Margin.Bottom;
    }

    private void BindPrimaryModel()
    {
        // 1. Clear bindings
        foreach (Control control in splitContainer.Panel2.Controls)
        {
            control.DataBindings.Clear();
        }
        lsvLearners.Columns.Clear();
        lsvLearners.DataSource = null;
        bindingSource.DataSource = null;

        // 2. Bind table to ListView + Customize columns
        // Add lesson schedule count via select
        var courseRosterEntries = courseRosterRepository.GetCourseRosterByCourse(_course.Id);
        bindingSource.DataSource = courseRosterEntries;
        lsvLearners.DataSource = bindingSource;

        var learnerIdColumn = lsvLearners.Columns[nameof(CourseRoster.LearnerId)];
        learnerIdColumn.Text = "Learner";
        learnerIdColumn.Width = 160;

        lsvLearners.Columns.RemoveByKey(nameof(CourseRoster.CourseId));
        lsvLearners.Columns.RemoveByKey(nameof(CourseRoster.Course));
        lsvLearners.Columns.RemoveByKey(nameof(CourseRoster.Learner));
    }
}
