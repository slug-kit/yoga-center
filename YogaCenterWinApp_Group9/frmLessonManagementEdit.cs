using System.ComponentModel;
using YogaCenter.Repository.Repos;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.ModelExtensions;
using Utils;
using CourseModel = YogaCenter.Repository.Models.Course;
using LessonModel = YogaCenter.Repository.Models.Lesson;

namespace YogaCenterWinApp_Group9;

public partial class frmLessonManagementEdit : Form
{
    private const string DEFAULT_ID = "[AUTO]";

    private ILessonRepository _lessonRepository = new LessonRepository();
    public ILessonRepository LessonRepository
    {
        get => _lessonRepository;
        init => _lessonRepository = value;
    }

    private LessonDisplayModel _pom = new();
    public LessonModel Lesson
    {
        get => _pom;
        init => _pom = new()
        {
            Id = value.Id,
            ProgramId = value.ProgramId,
            CourseNumber = value.CourseNumber,
            //LessonNumber = value.LessonNumber,
            Description = value.Description,
            Date = value.Date,
            Location = value.Location,
            Timeslot = value.Timeslot,

            Course = value.Course,
            TimeslotNavigation = value.TimeslotNavigation,
            Attendances = value.Attendances,

            ProgramCode = value.Course?.Program?.Code ?? string.Empty,
            LessonNumber = value.LessonNumber,
        };
    }

    public CourseModel Course { get; init; } = new();

    private readonly BindingSource bindingSource = new();

    // false -> Add; true -> Update
    private bool _update;
    public bool UpdateMode
    {
        get => _update;
        init => _update = value;
    }

    private byte oldLessonNumber;

    private bool courseHasStartedOrFinished;
    public bool CourseHasStartedOrFinished
    {
        get => courseHasStartedOrFinished;
        init => courseHasStartedOrFinished = value;
    }

    public frmLessonManagementEdit()
    {
        InitializeComponent();
    }

    #region Startup

    private void frmLessonManagementEdit_Load(object sender, EventArgs e)
    {
        // 1. If updating, store original lesson number
        oldLessonNumber = _pom.LessonNumber;

        // 2. Change dialog title according to UpdateMode
        Text = _update ? "Lesson Details" : "New Lesson";

        // 3. Init combo boxes and bind input controls
        InitComboBoxes();
        BindPrimaryModel();

        // 4.If course has started or finished, disable update unless
        // Lesson is in the future
        var now = DateTime.Now.Date;
        if (courseHasStartedOrFinished && _pom.Date?.Date <= now)
        {
            MessageBox.Show("Lessons that has completed or take place today are read-only.",
                "Read Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLessonNumber.ReadOnly = true;
            txtLocation.ReadOnly = true;
            txtTimeslot.ReadOnly = true;
            rtbDescription.ReadOnly = true;

            dtpDate.Enabled = false;

            cboTimeslot.Enabled = false;
            cboTimeslot.Visible = false;
            txtTimeslot.Enabled = true;
            txtTimeslot.Visible = true;
        }

        // 4. If adding, init DateTimePickers and set min value to Now
        if (!_update)
        {
            dtpDate.MinDate = now;
            dtpDate.Value = now;
        }
    }

    private void InitComboBoxes()
    {
        cboTimeslot.Items.Clear();
        var timeslots = LessonRepository.GetTimeslots().ToList();
        cboTimeslot.ValueMember = nameof(Timeslot.Id);
        cboTimeslot.DisplayMember = nameof(Timeslot.Name);
        cboTimeslot.DataSource = timeslots;
    }

    private void cboTimeslot_SelectedValueChanged(object sender, EventArgs e)
    {
        try
        {
            ComboBox cbo = (ComboBox)sender;
            var timeslot = _lessonRepository.GetTimeslots().FirstOrDefault(slot => slot.Id == Convert.ToInt16(cbo.SelectedValue));
            _pom.TimeslotNavigation = timeslot!;
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    private void BindPrimaryModel()
    {
        // 1. Clear bindings
        foreach (Control c in Controls)
            c.DataBindings.Clear();
        bindingSource.DataSource = null;

        // 2. Bind properties to input boxes
        bindingSource.DataSource = _pom;

        var idBinding = new Binding(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.Id),
            true, DataSourceUpdateMode.Never);
        idBinding.Format += DefaultIdToDefaultString;
        txtId.DataBindings.Add(idBinding);

        txtProgramCode.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.ProgramCode),
            true, DataSourceUpdateMode.Never);

        var courseNumberBinding = new Binding(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.CourseNumber),
            true, DataSourceUpdateMode.Never);
        courseNumberBinding.Format += DefaultIdToEmptyString;
        txtCourseNumber.DataBindings.Add(courseNumberBinding);

        var lessonNumberBinding = new Binding(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.LessonNumber),
            true, DataSourceUpdateMode.OnPropertyChanged);
        lessonNumberBinding.Format += DefaultIdToEmptyString;
        txtLessonNumber.DataBindings.Add(lessonNumberBinding);

        txtLessonCode.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.LessonCode),
            true, DataSourceUpdateMode.Never);
        txtLocation.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(LessonDisplayModel.Location),
            true, DataSourceUpdateMode.OnValidation)
            .Parse += StringToTrimmedString;
        dtpDate.DataBindings.Add(nameof(DateTimePicker.Value), bindingSource, nameof(LessonDisplayModel.Date),
            true, DataSourceUpdateMode.OnValidation)
            .Parse += DateTimeToSqlDateTimeLegalValue;
        cboTimeslot.DataBindings.Add(nameof(ComboBox.SelectedValue), bindingSource, nameof(LessonDisplayModel.Timeslot),
            true, DataSourceUpdateMode.OnValidation);
        rtbDescription.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(LessonDisplayModel.Description),
            true, DataSourceUpdateMode.OnValidation)
            .Parse += StringToTrimmedString;

        if (CourseHasStartedOrFinished && _pom.Date?.Date <= DateTime.Now.Date)
        {
            txtTimeslot.DataBindings.Add(nameof(TextBox.Text), bindingSource, $"{nameof(LessonDisplayModel.TimeslotNavigation)}.{nameof(Timeslot.Name)}",
                true, DataSourceUpdateMode.Never);
        }
    }

    #endregion

    #region Format and Parse

    private void DefaultIdToDefaultString(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != (typeof(string))) return;
        if (cevent.Value == null) return;

        if ((cevent.Value as int?) == default(int))
            cevent.Value = DEFAULT_ID;
    }

    private void DefaultIdToEmptyString(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != (typeof(string))) return;
        if (cevent.Value == null) return;

        if ((cevent.Value as int?) == default(int))
            cevent.Value = string.Empty;
    }

    private void StringToTrimmedString(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) { return; }
        if (cevent.Value == null) { return; }

        cevent.Value = ((string)cevent.Value).Trim();
    }

    private void DateTimeToSqlDateTimeLegalValue(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(DateTime?)) { return; }
        if (cevent.Value == null) { return; }

        cevent.Value = ((DateTime)cevent.Value).ClampSqlDateTime();
    }

    #endregion

    #region Validation

    private void txtLessonNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void txtLessonNumber_Validating(object sender, CancelEventArgs e)
    {
        TextBoxBase? txtb = sender as TextBoxBase;
        if (string.IsNullOrEmpty(txtb?.Text)) { return; }

        string trimmedText = txtb.Text.Trim();
        if (!int.TryParse(trimmedText, out int lessonNumber))
        {
            string errorMsg = "Invalid Lesson Number format. Lesson Number must be a positive whole number.";
            string errorCaption = "Invalid Value";
            MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
        else if (lessonNumber < 1 || lessonNumber > byte.MaxValue)
        {
            string errorMsg = $"Invalid Lesson Number. Lesson Number must be positive and no greater than {byte.MaxValue}.";
            string errorCaption = "Invalid Value";
            MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }

    private void dtpDate_Validating(object sender, CancelEventArgs e)
    {
        DateTimePicker? dtp = sender as DateTimePicker;
        if (dtp?.Value == null) { return; }

        var date = dtp.Value.Date;
        var courseStartDate = Course.StartDate?.Date;
        var courseEndDate = Course.EndDate?.Date;
        if (date < courseStartDate || date > courseEndDate)
        {
            string errorMsg = $"Invalid Date. Lesson Date must be within its Course's date range" +
                $" : [{(courseStartDate == null ? "<UNSET>" : courseStartDate.Value.ToString("dd/MM/yyyy"))}]" +
                $" to [{(courseEndDate == null ? "<UNSET>" : courseEndDate.Value.ToString("dd/MM/yyyy"))}].";
            string errorCaption = "Invalid Value";
            MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }

    private bool ValidateData()
    {
        if (!ValidateChildren()) { return false; }

        var siblingLessons = Course.Lessons.ToHashSet();
        var lessonComparer = new LambdaComparer<LessonModel>((l1, l2) =>
            l1.ProgramId == l2.ProgramId
            && l1.CourseNumber == l2.CourseNumber
            && l1.LessonNumber == l2.LessonNumber
        );
        if (siblingLessons.Contains(_pom, lessonComparer))
        {
            if (!_update || _pom.LessonNumber != oldLessonNumber)
            {
                MessageBox.Show("Course already contains a Lesson with the same Lesson Number.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLessonNumber.Focus();
                return false;
            }
        }

        if (string.IsNullOrWhiteSpace(_pom.Location))
        {
            MessageBox.Show("Location is required.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtLocation.Focus();
            return false;
        }
        // ??? How do we dynamically read this length limit ???
        var locationMaxLength = 20;
        if (_pom.Location.Length > locationMaxLength)
        {
            MessageBox.Show($"Location must have at most {locationMaxLength} characters.",
                "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtLocation.Focus();
            return false;
        }
        if (_pom.Date == null)
        {
            MessageBox.Show("Date is required.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpDate.Focus();
            return false;
        }
        if (!_update && _pom.Date?.Date < DateTime.Now.Date)
        {
            MessageBox.Show("New Lesson's Date must not be in the past.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpDate.Focus();
            return false;
        }
        if (_pom.Timeslot == null)
        {
            MessageBox.Show("Lesson must have a timeslot.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cboTimeslot.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(_pom.Description))
        {
            MessageBox.Show("Description is required.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            rtbDescription.Focus();
            return false;
        }
        // ??? How do we dynamically read this length limit ???
        var descriptionMinLength = 3;
        var descriptionMaxLength = 1000;
        if (_pom.Description.Length < descriptionMinLength || _pom.Description.Length > descriptionMaxLength)
        {
            MessageBox.Show($"Description must contain between {descriptionMinLength} and {descriptionMaxLength} characters, inclusive.",
                "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            rtbDescription.Focus();
            return false;
        }
        return true;
    }

    #endregion

    #region CRUD

    private void DataField_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && Validate())
            PerformSave();
    }

    private void btnSave_Click(object sender, EventArgs e) => PerformSave();

    private void PerformSave()
    {
        if (!ValidateData()) return;

        try
        {
            if (_update)
            {
                var lessonToUpdate = Course.Lessons.FirstOrDefault(l =>
                    l.ProgramId == _pom.ProgramId
                    && l.CourseNumber == _pom.CourseNumber
                    && l.LessonNumber == _pom.LessonNumber
                )
                    ?? throw new Exception("Could not find Lesson-to-update in the in-memory Course.");
                if (Course.Lessons.Remove(lessonToUpdate))
                {
                    AddLessonToCourse();
                }
                else throw new Exception("Failed to update Lesson in the in-memory Course.");
            }
            else
            {
                AddLessonToCourse();
            }

            Close();
            DialogResult = DialogResult.OK;

            void AddLessonToCourse()
            {
                Course.Lessons.Add(_pom);
                var sortedLessons = Course.Lessons.ToList();
                sortedLessons.Sort((l1, l2) => l1.LessonNumber.CompareTo(l2.LessonNumber));
                Course.Lessons.Clear();
                Course.Lessons.AddRange(sortedLessons);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message,
                _update ? "ERROR -- Commit Update Lesson" : "ERROR -- Commit Add Lesson");
        }
    }

    #endregion

    private void btnCancel_Click(object sender, EventArgs e) => Close();
}
