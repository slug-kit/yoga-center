using System.Windows.Forms;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;
using CourseModel = YogaCenter.Repository.Models.Course;
using ProgramModel = YogaCenter.Repository.Models.Program;

namespace YogaCenterWinApp_Group9;

public partial class frmCourseManagementEdit : Form
{
    private const string DEFAULT_ID = "[AUTO]";

    public ICourseRepository courseRepository = new CourseRepository();
    public ILessonRepository lessonRepository = new LessonRepository();
    private readonly BindingSource courseBindingSource = new();
    private readonly BindingSource lessonListBindingSource = new();

    private CourseModel _pom = new();
    public CourseModel Course
    {
        get => _pom;
        init => _pom = new()
        {
            Id = value.Id,
            ProgramId = value.ProgramId,
            CourseNumber = value.CourseNumber,
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
        };
    }

    // false -> Add; true -> Update
    private bool _update;
    public bool UpdateMode
    {
        get => _update;
        init => _update = value;
    }

    public frmCourseManagementEdit()
    {
        InitializeComponent();
    }

    #region Startup

    private void frmCourseManagementDetail_Load(object sender, EventArgs e)
    {
        // 1. Change dialog title according to UpdateMode
        Text = _update ? "Course Details" : "New Course";

        // 2. Init combo boxes and bind controls
        InitComboBoxes();
        BindPrimaryModel();
        BindSecondaryModel();
    }

    private void InitComboBoxes()
    {
        // Left panel -- Instructors
        cboInstructor.Items.Clear();
        var instructors = courseRepository.GetInstructors().ToList();
        cboInstructor.DataSource = instructors;
        cboInstructor.ValueMember = nameof(User.Id);
        cboInstructor.DisplayMember = nameof(User.Fullname);

        // Instructors...Load profile image
        cboInstructor.SelectedIndexChanged += (o, e) =>
        {
            picbInstructorImg.ImageLocation = $"{(cboInstructor.SelectedItem as User)?.Img}";
        };
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

            // Course ID
            var courseIdBinding = new Binding(nameof(TextBox.Text), courseBindingSource, nameof(CourseModel.Id),
                true, DataSourceUpdateMode.OnValidation);
            courseIdBinding.Format += DefaultIdToDefaultString;
            txtCourseId.DataBindings.Add(courseIdBinding);
            // ***
            txtProgramName.DataBindings.Add(nameof(TextBox.Text), courseBindingSource, $"{nameof(CourseModel.Program)}.{nameof(ProgramModel.Name)}",
                true, DataSourceUpdateMode.OnValidation);
            txtProgramCode.DataBindings.Add(nameof(TextBox.Text), courseBindingSource, $"{nameof(CourseModel.Program)}.{nameof(ProgramModel.Code)}",
                true, DataSourceUpdateMode.OnValidation);
            txtCourseNumber.DataBindings.Add(nameof(TextBox.Text), courseBindingSource, nameof(CourseModel.CourseNumber),
                true, DataSourceUpdateMode.OnValidation);
            cboInstructor.DataBindings.Add(nameof(ComboBox.SelectedValue), courseBindingSource, nameof(CourseModel.InstructorId),
                true, DataSourceUpdateMode.OnValidation);
            dtpStartDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseModel.StartDate),
                true, DataSourceUpdateMode.OnValidation);
            dtpEndDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseModel.EndDate),
                true, DataSourceUpdateMode.OnValidation);
            rtbSchedule.DataBindings.Add(nameof(RichTextBox.Text), courseBindingSource, nameof(CourseModel.Schedule),
                true, DataSourceUpdateMode.OnValidation);
            dtpRegistrationOpenDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseModel.RegistrationOpenDate),
                true, DataSourceUpdateMode.OnValidation);
            dtpRegistrationCloseDate.DataBindings.Add(nameof(DateTimePicker.Value), courseBindingSource, nameof(CourseModel.RegistrationCloseDate),
                true, DataSourceUpdateMode.OnValidation);
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

        dgvLessons.Columns[nameof(Lesson.Description)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.Course)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.TimeslotNavigation)].Visible = false;
        dgvLessons.Columns[nameof(Lesson.Attendances)].Visible = false;

        dgvLessons.Columns[nameof(Lesson.Id)].DisplayIndex = 0;
        dgvLessons.Columns[nameof(Lesson.ProgramId)].DisplayIndex = 1;
        dgvLessons.Columns[programCodeColumnName].DisplayIndex = 2;
        dgvLessons.Columns[nameof(Lesson.CourseNumber)].DisplayIndex = 3;
        dgvLessons.Columns[nameof(Lesson.LessonNumber)].DisplayIndex = 4;
        dgvLessons.Columns[nameof(Lesson.Date)].DisplayIndex = 5;
        dgvLessons.Columns[nameof(Lesson.Timeslot)].DisplayIndex = 6;
        dgvLessons.Columns[nameof(Lesson.Location)].DisplayIndex = 7;

        // 3. Bind properties to output boxes
        txtLessonId.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.Id),
            true, DataSourceUpdateMode.Never);
        txtLessonNumber.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.LessonNumber),
            true, DataSourceUpdateMode.Never);
        txtLessonLocation.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, nameof(Lesson.Location),
            true, DataSourceUpdateMode.Never);
        dtpLessonDate.DataBindings.Add(nameof(DateTimePicker.Value), lessonListBindingSource, nameof(Lesson.Date),
            true, DataSourceUpdateMode.Never);
        txtLessonTimeslot.DataBindings.Add(nameof(TextBox.Text), lessonListBindingSource, $"{nameof(Lesson.Timeslot)}.{nameof(Timeslot.Name)}",
            true, DataSourceUpdateMode.Never);

        // 4. Update Lesson Actions buttons
        UpdateLessonListButtons();
    }

    private void UpdateLessonListButtons()
    {
        var enable = dgvLessons.RowCount > 0;
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

    private void DefaultIdToDefaultString(object? sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != (typeof(string))) return;
        if (cevent.Value == null) return;

        if ((cevent.Value as int?) == default(int))
            cevent.Value = DEFAULT_ID;
    }

    #endregion

    #region Form Actions

    private void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            //var course = new Course
            //{
            //    Id = Course.Id, // Gán Id của CourseDetail để xác định dữ liệu cần cập nhật
            //    ProgramId = int.Parse(cboprogramid.Text),
            //    CourseNumber = short.Parse(txtCourseNumber.Text),
            //    EndDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    InstructorId = long.Parse(cboInstructor.Text),
            //    RegistrationCloseDate = DateTime.Now,
            //    RegistrationOpenDate = DateTime.Now,
            //    Schedule = txtschedule.Text,
            //};

            //if (InsertOrUpdate == false)
            //{
            //    courseRepository.Add(course);
            //}
            //else
            //{
            //    courseRepository.Update(course);
            //}

            //MessageBox.Show("Course saved successfully.", InsertOrUpdate == true ? "Update a course" : "Add a new course");
            //Close();
            //DialogResult = DialogResult.OK;
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void btnexit_Click(object sender, EventArgs e) { Close(); Dispose(); }

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
                    // Not necessary, but just a nice thing to do
                    LessonNumber = (byte)(_pom.Lessons.Count + 1),
                    Course = _pom,
                },
                Course = _pom,
            };
            if (frmLessonManagementEdit.ShowDialog() == DialogResult.OK)
            {
                lessonListBindingSource.ResetBindings(false);
                UpdateLessonListButtons();
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
                UpdateLessonListButtons();
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
                UpdateLessonListButtons();
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
