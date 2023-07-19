using System.ComponentModel;
using Utils;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;
using YogaCenter.Repository.ModelExtensions;
using CourseModel = YogaCenter.Repository.Models.Course;
using ProgramModel = YogaCenter.Repository.Models.Program;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseManagementEdit : Form
{
    private const string DEFAULT_COURSE_NUMBER = "[AUTO]";

    private readonly TimeSpan MIN_COURSE_DATE_RANGE = TimeSpan.FromDays(7);
    private readonly TimeSpan MAX_COURSE_DATE_RANGE = TimeSpan.FromDays(90);
    private const int MIN_LESSON_COUNT = 2;

    public ICourseRepository courseRepository = new CourseRepository();
    public ILessonRepository lessonRepository = new LessonRepository();
    private readonly BindingSource courseBindingSource = new();
    private readonly BindingSource lessonListBindingSource = new();

    private CourseDisplayModel _pom = new();
    public CourseModel Course
    {
        get => _pom;
        init => _pom = new(true)
        {
            Id = value.Id,
            ProgramId = value.ProgramId,
            //CourseNumber = value.CourseNumber,
            InstructorId = value.InstructorId,
            StartDate = value.StartDate,
            EndDate = value.EndDate,
            Schedule = value.Schedule,
            RegistrationOpenDate = value.RegistrationOpenDate,
            RegistrationCloseDate = value.RegistrationCloseDate,
            HasNewRequest = value.HasNewRequest,
            Inactive = value.Inactive,

            Instructor = value.Instructor,
            Program = value.Program,
            CourseAssignmentRequests = value.CourseAssignmentRequests,
            CourseRegisters = value.CourseRegisters,
            Lessons = value.Lessons,

            ProgramCode = value.Program?.Code ?? string.Empty,
            CourseNumber = value.CourseNumber,
        };
    }

    private ProgramModel Program { get; init; } = new();

    // false -> Add; true -> Update
    private bool _update;
    public bool UpdateMode
    {
        get => _update;
        init => _update = value;
    }

    private short oldCourseNumber;

    public frmCourseManagementEdit()
    {
        InitializeComponent();
    }

    #region Startup

    private void frmCourseManagementDetail_Load(object sender, EventArgs e)
    {
        // 1. If updating, store original Course Number
        oldCourseNumber = _pom.CourseNumber;

        // 2. Change dialog title according to UpdateMode
        Text = _update ? "Course Details" : "New Course";

        // 3. Init combo boxes and bind controls
        InitComboBoxes();
        BindPrimaryModel();
        BindSecondaryModel();
    }

    private void InitComboBoxes()
    {
        // Program Names & Codes
        cboProgramName.Items.Clear();
        var programs = courseRepository.GetPrograms().ToList();
        cboProgramName.ValueMember = nameof(ProgramModel.Id);
        cboProgramName.DisplayMember = nameof(ProgramModel.Name);
        cboProgramName.DataSource = programs;

        cboProgramCode.ValueMember = nameof(ProgramModel.Id);
        cboProgramCode.DisplayMember = nameof(ProgramModel.Code);
        cboProgramCode.DataSource = programs;

        // Left panel -- Instructors
        cboInstructor.Items.Clear();
        var instructors = courseRepository.GetInstructors().ToList();
        cboInstructor.ValueMember = nameof(User.Id);
        cboInstructor.DisplayMember = nameof(User.Fullname);
        cboInstructor.DataSource = instructors;

        // Instructors...Load profile image
        cboInstructor.SelectedIndexChanged += (o, e) =>
        {
            picbInstructorImg.ImageLocation = $"{(cboInstructor.SelectedItem as User)?.Img}";
        };
    }

    private void cboProgramName_SelectedValueChanged(object sender, EventArgs e)
    {
        try
        {
            ComboBox cbo = (ComboBox)sender;
            var program = courseRepository.GetPrograms().FirstOrDefault(p => p.Id == Convert.ToInt32(cbo.SelectedValue));
            _pom.Program = program!;
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    private void BindPrimaryModel()
    {
        try
        {
            // 1. Clear bindings
            foreach (Control c in grbDetails.Controls)
                c.DataBindings.Clear();
            courseBindingSource.DataSource = null;

            // 2. Bind properties to input boxes
            courseBindingSource.DataSource = _pom;

            var courseCodeBinding = new Binding(nameof(TextBox.Text), courseBindingSource, nameof(CourseDisplayModel.CourseCode),
                true, DataSourceUpdateMode.Never);
            courseCodeBinding.Format += DefaultCourseNumberToDefaultCourseCode;
            txtCourseCode.DataBindings.Add(courseCodeBinding);

            txtStatus.DataBindings.Add(nameof(TextBox.Text), courseBindingSource, nameof(CourseDisplayModel.Status),
                true, DataSourceUpdateMode.Never);
            cboProgramName.DataBindings.Add(nameof(ComboBox.SelectedValue), courseBindingSource, nameof(Course.ProgramId),
                true, DataSourceUpdateMode.OnPropertyChanged);
            cboProgramCode.DataBindings.Add(nameof(ComboBox.SelectedValue), courseBindingSource, nameof(Course.ProgramId),
                true, DataSourceUpdateMode.OnPropertyChanged);
            txtProgramName.DataBindings.Add(nameof(TextBox.Text), courseBindingSource,
                $"{nameof(CourseDisplayModel.Program)}.{nameof(ProgramModel.Name)}",
                true, DataSourceUpdateMode.Never);
            txtProgramCode.DataBindings.Add(nameof(TextBox.Text), courseBindingSource,
                $"{nameof(CourseDisplayModel.Program)}.{nameof(ProgramModel.Code)}",
                true, DataSourceUpdateMode.Never);
            txtCourseNumber.DataBindings.Add(nameof(TextBox.Text), courseBindingSource, nameof(CourseDisplayModel.CourseNumber),
                true, DataSourceUpdateMode.OnPropertyChanged);
            cboInstructor.DataBindings.Add(nameof(ComboBox.SelectedValue), courseBindingSource, nameof(CourseDisplayModel.InstructorId),
                true, DataSourceUpdateMode.OnPropertyChanged);
            dtpStartDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseDisplayModel.StartDate),
                true, DataSourceUpdateMode.OnPropertyChanged);
            dtpEndDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseDisplayModel.EndDate),
                true, DataSourceUpdateMode.OnPropertyChanged);
            rtbSchedule.DataBindings.Add(nameof(RichTextBox.Text), courseBindingSource, nameof(CourseDisplayModel.Schedule),
                true, DataSourceUpdateMode.OnValidation);
            dtpRegistrationOpenDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource,
                nameof(CourseDisplayModel.RegistrationOpenDate),
                true, DataSourceUpdateMode.OnPropertyChanged);
            dtpRegistrationCloseDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource,
                nameof(CourseDisplayModel.RegistrationCloseDate),
                true, DataSourceUpdateMode.OnPropertyChanged);

            // 3. Force trigger a status update
            if (_pom.StartDate == null)
            {
                _pom.StartDate = DateTime.Now;
                _pom.StartDate = null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR -- Load Course data");
        }
    }

    private void BindSecondaryModel()
    {
        // 1. Clear bindings
        foreach (Control c in grbLessonDetails.Controls)
            c.DataBindings.Clear();
        dgvLessons.Columns.Clear();
        dgvLessons.DataSource = null;
        lessonListBindingSource.DataSource = null;

        // 2. Bind Lesson collection to DGV + Customize columns
        _pom.Lessons = _pom.Lessons.OrderBy(l => l.LessonNumber).ToList();
        lessonListBindingSource.DataSource = _pom.Lessons;
        dgvLessons.DataSource = lessonListBindingSource;

        var programCodeColumnName = "ProgramCode";
        dgvLessons.Columns.Add(new DataGridViewColumn()
        {
            Name = programCodeColumnName,
            HeaderText = "Program Code",
            DataPropertyName = $"{nameof(Lesson.Course)}.{nameof(CourseModel.Program)}.{nameof(ProgramModel.Code)}",
            CellTemplate = new DataGridViewTextBoxCell(),
        });
        var timeslotNameColumnName = "TimeslotName";
        dgvLessons.Columns.Add(new DataGridViewColumn()
        {
            Name = timeslotNameColumnName,
            HeaderText = "Timeslot",
            DataPropertyName = $"{nameof(Lesson.TimeslotNavigation)}.{nameof(Timeslot.Name)}",
            CellTemplate = new DataGridViewTextBoxCell(),
        });

        dgvLessons.Columns[nameof(Lesson.Id)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.Timeslot)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.Course)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.TimeslotNavigation)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.Attendances)].Visible = false;

        dgvLessons.Columns[programCodeColumnName].DisplayIndex = 1;
        dgvLessons.Columns[nameof(Lesson.CourseNumber)].DisplayIndex = 2;
        dgvLessons.Columns[nameof(Lesson.LessonNumber)].DisplayIndex = 3;
        dgvLessons.Columns[nameof(Lesson.Description)].DisplayIndex = 4;
        dgvLessons.Columns[nameof(Lesson.Date)].DisplayIndex = 5;
        dgvLessons.Columns[timeslotNameColumnName].DisplayIndex = 6;
        dgvLessons.Columns[nameof(Lesson.Location)].DisplayIndex = 7;

        dgvLessons.Columns[nameof(Lesson.Date)].DefaultCellStyle.Format = "dd/MM/yyyy";

        // 3. Bind properties to output boxes
        txtLessonId.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.Id),
            true, DataSourceUpdateMode.Never);
        txtLessonNumber.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.LessonNumber),
            true, DataSourceUpdateMode.Never);
        txtLessonLocation.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.Location),
            true, DataSourceUpdateMode.Never);
        dtpLessonDate.DataBindings.Add(nameof(DateTimePicker.Value), lessonListBindingSource, nameof(Lesson.Date),
            true, DataSourceUpdateMode.Never);
        txtLessonTimeslot.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, $"{nameof(Lesson.TimeslotNavigation)}.{nameof(Timeslot.Name)}",
            true, DataSourceUpdateMode.Never);

        // 4. Update Lesson Actions buttons
        UpdateInputControls();
    }

    private void UpdateInputControls()
    {
        var enable = dgvLessons.RowCount > 0;
        txtProgramName.Enabled = enable;
        txtProgramName.Visible = enable;
        txtProgramCode.Enabled = enable;
        txtProgramCode.Visible = enable;

        cboProgramName.Enabled = !enable;
        cboProgramName.Visible = !enable;
        cboProgramCode.Enabled = !enable;
        cboProgramCode.Visible = !enable;

        btnDeleteLesson.Enabled = enable;
    }

    #endregion

    #region Left Panel

    #region Format and Parse

    private void dgvLessons_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = dgvLessons.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains('.'))
        {
            object data = dgvLessons.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
                data = data.GetType().GetProperty(properties[i])?.GetValue(data)!;
            dgvLessons.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }

    private void DefaultCourseNumberToDefaultCourseCode(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != (typeof(string))) return;
        if (cevent.Value == null) return;

        if (cevent.Value is not string sourceValue) return;

        int numberOfDigitsAtEnd = 0;
        for (var i = sourceValue.Length - 1; i >= 0; --i)
        {
            if (!char.IsNumber(sourceValue[i]))
            {
                break;
            }
            numberOfDigitsAtEnd++;
        }
        var courseNumberString = sourceValue[^numberOfDigitsAtEnd..];
        if (courseNumberString == "0")
        {
            cevent.Value = sourceValue[..(sourceValue.Length - numberOfDigitsAtEnd)] + DEFAULT_COURSE_NUMBER;
        }
    }

    #endregion

    #region Validation

    private void txtCourseNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void txtCourseNumber_Validating(object sender, CancelEventArgs e)
    {
        try
        {
            TextBoxBase? txtb = sender as TextBoxBase;
            if (string.IsNullOrEmpty(txtb?.Text)) { return; }

            string trimmedText = txtb.Text.Trim();
            if (!int.TryParse(trimmedText, out int courseNumber))
            {
                string errorMsg = "Invalid Course Number format. Course Number must be a positive whole number.";
                string errorCaption = "Invalid Value";
                MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (courseNumber < 1 || courseNumber > short.MaxValue)
            {
                string errorMsg = $"Invalid Course Number. Lesson Course must be positive and no greater than {short.MaxValue}.";
                string errorCaption = "Invalid Value";
                MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    private bool ValidateData()
    {
        if (!ValidateChildren()) return false;

        if (_pom.ProgramId == default || _pom.Program == null)
        {
            MessageBox.Show("Course must belong to a Program.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cboProgramName.Focus();
            return false;
        }

        var siblingCourses = _pom.Program.Courses.ToHashSet();
        var courseComparer = new LambdaComparer<CourseModel>((c1, c2) =>
            c1.ProgramId == c2.ProgramId
            && c1.CourseNumber == c2.CourseNumber
        );
        if (siblingCourses.Contains(_pom, courseComparer))
        {
            if (!_update || _pom.CourseNumber != oldCourseNumber)
            {
                MessageBox.Show("Program already contains a Course with the same Course Number.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseNumber.Focus();
                return false;
            }
        }

        var startDate = _pom.StartDate?.Date;
        var endDate = _pom.EndDate?.Date;
        var regOpenDate = _pom.RegistrationOpenDate?.Date;
        var regCloseDate = _pom.RegistrationCloseDate?.Date;
        if (startDate == null || endDate == null)
        {
            MessageBox.Show("Course Start and End Dates are required.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpRegistrationCloseDate.Focus();
            return false;
        }
        if ((regOpenDate == null) != (regCloseDate == null))
        {
            MessageBox.Show("Registration Open and Close Dates must either be both set, or both not set.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpRegistrationCloseDate.Focus();
            return false;
        }
        if (regOpenDate > regCloseDate)
        {
            MessageBox.Show("Registration Close Date must not be earlier than Registration Open Date.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpRegistrationCloseDate.Focus();
            return false;
        }
        if (regCloseDate >= startDate)
        {
            MessageBox.Show("Course registration must be closed before the Course starts.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpRegistrationCloseDate.Focus();
            return false;
        }
        if (startDate > endDate)
        {
            MessageBox.Show("Course End Date must not be earler than Start Date.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpEndDate.Focus();
            return false;
        }
        if (endDate - startDate < MIN_COURSE_DATE_RANGE)
        {
            MessageBox.Show($"Course must last a minimum of {MIN_COURSE_DATE_RANGE.Days} days.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpEndDate.Focus();
            return false;
        }
        if (endDate - startDate > MAX_COURSE_DATE_RANGE)
        {
            MessageBox.Show($"Course may only last a maximum of {MAX_COURSE_DATE_RANGE.Days} days.",
                "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtpEndDate.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(_pom.Schedule))
        {
            MessageBox.Show("Schedule is required.", "Invalid Course Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            rtbSchedule.Focus();
            return false;
        }

        if (_pom.Lessons.Count < MIN_LESSON_COUNT)
        {
            MessageBox.Show($"Course must contain at least {MIN_LESSON_COUNT} lessons.", "Invalid Lesson List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dgvLessons.Focus();
            return false;
        }

        var outOfRangeLessons = _pom.Lessons.Where(l =>
            l.Date?.Date < Course.StartDate?.Date
            || l.Date?.Date > Course.EndDate?.Date);
        if (outOfRangeLessons.Any())
        {
            string errorMsg = "Lesson(s) {";
            for (int i = 0; i < outOfRangeLessons.Count(); ++i)
            {
                errorMsg += $" #{outOfRangeLessons.ElementAt(i).LessonNumber}";
                if (i < outOfRangeLessons.Count() - 1) { errorMsg += ","; }
            }
            errorMsg += " } are set outside the Course's duration.";
            MessageBox.Show(errorMsg, "Invalid Lesson List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dgvLessons.Focus();
            return false;
        }

        var lessons = _pom.Lessons
            .OrderBy(l => l.LessonNumber)
                .ThenBy(l => l.Timeslot)
            .ToList();
        for (int i = 0; i < lessons.Count - 1; ++i)
        {
            if (lessons[i + 1].LessonNumber != lessons[i].LessonNumber + 1)
            {
                MessageBox.Show($"Course must have Lessons with consecutive Lesson Numbers.",
                    "Invalid Lesson List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvLessons.Focus();
                return false;
            }
            if (lessons[i + 1].Date?.Date < lessons[i].Date?.Date
                || (lessons[i + 1].Date?.Date == lessons[i].Date?.Date && lessons[i + 1].Timeslot <= lessons[i].Timeslot)
            )
            {
                MessageBox.Show($"Lesson #{lessons[i + 1].LessonNumber} must take place later than Lesson #{lessons[i].LessonNumber}.",
                    "Invalid Lesson List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvLessons.Focus();
                return false;
            }
        }

        return true;
    }

    #endregion

    #region Form Actions

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateData()) return;

        try
        {
            if (_update)
                courseRepository.Update(Course);
            else
                courseRepository.Add(Course);
            Close();
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.InnerException is null ? ex.Message : ex.InnerException.Message,
                _update ? "ERROR -- Commit Update Course" : "ERROR -- Commit Add Course");
        }
    }

    private void btnExit_Click(object sender, EventArgs e) { Close(); Dispose(); }

    #endregion

    #endregion

    #region Right Panel

    #region CRUD

    private Lesson GetLessonObject()
    {
        var pom = lessonListBindingSource.List[lessonListBindingSource.Position] as Lesson;
        return pom ?? throw new Exception("Could not create Lesson object.");
    }

    private void btnAddLesson_Click(object sender, EventArgs e)
    {
        if (_pom.Program == null)
        {
            MessageBox.Show("To add new Lessons, you must first select a Program.", "Invalid Course State", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (_pom.StartDate == null || _pom.EndDate == null)
        {
            MessageBox.Show("To add new Lessons, you must have set the Course's Start and End Dates.", "Invalid Course State", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            frmLessonManagementEdit frmLessonManagementEdit = new()
            {
                LessonRepository = lessonRepository,
                UpdateMode = false,
                Lesson = new()
                {
                    ProgramId = _pom.ProgramId,
                    CourseNumber = _pom.CourseNumber,
                    LessonNumber = (byte)(_pom.Lessons.Count + 1),
                    Course = _pom,
                },
                Course = _pom,
            };
            if (frmLessonManagementEdit.ShowDialog() == DialogResult.OK)
            {
                lessonListBindingSource.ResetBindings(false);
                UpdateInputControls();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR -- Add Lesson");
        }
    }

    private void dgvLessons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            frmLessonManagementEdit frmLessonManagementEdit = new()
            {
                LessonRepository = lessonRepository,
                UpdateMode = true,
                Lesson = GetLessonObject(),
                Course = _pom,
            };
            if (frmLessonManagementEdit.ShowDialog() == DialogResult.OK)
            {
                lessonListBindingSource.ResetBindings(false);
                UpdateInputControls();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR -- Update Lesson");
        }
    }

    private void btnDeleteLesson_Click(object sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("Are you sure you wish to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                var lessonToDelete = GetLessonObject();
                _pom.Lessons.Remove(lessonToDelete);

                lessonListBindingSource.ResetBindings(false);
                UpdateInputControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR -- Delete Lesson");
            }
        }
    }

    #endregion

    #endregion
}
