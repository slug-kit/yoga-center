using Microsoft.VisualBasic;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmTimetable : Form
{

    private ICourseRepository repository = new CourseRepository();
    private readonly bool _adminMode;
    public bool AdminMode
    {
        get => _adminMode;
        init => _adminMode = value;
    }

    public frmTimetable()
    {
        InitializeComponent();
    }

    private void frmTimetable_Load(object sender, EventArgs e)
    {
    }
    private void SetupTimetableDataGridView()
    {
        dataGridView1.Columns.Add("TimeSlot", "Time Slot");
        dataGridView1.Columns["TimeSlot"].ReadOnly = true;

        var daysOfWeek = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
        foreach (var day in daysOfWeek)
        {
            dataGridView1.Columns.Add(day.ToString(), day.ToString());
        }
    }

    private void PopulateTimetable()
    {
        var courses = repository.GetCourses();

        var timeSlots = new List<string> { "Morning 9:00 - 11:00", "Afternoon 14:00 - 16:00" };

        foreach (var timeSlot in timeSlots)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = timeSlot;
        //// Thêm các dòng dữ liệu khác tương tự ở đây
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>())
            {
                var course = courses.FirstOrDefault(c => c.TimeSlot == timeSlot && c.DayOfWeek == day.ToString());
                if (course != null)
                {
                    row.Cells[day.ToString()].Value = $"Course: {course.CourseID}, Instructor: {course.InstructorName}";
                }
            }
        foreach (var day in daysOfWeek)
            dataGridView1.Rows.Add(row);
        }
    }
        }
}

        // Loop through the courses and populate the timetable
        foreach (var course in courses)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            foreach (var day in daysOfWeek)
            {
                var column = dataGridView1.Columns[day.ToString()];
                var cell = row.Cells[column.Index];
                cell.Value = course.Schedule?.Contains(day.ToString()) ?? false ? course.Lessons : string.Empty;
            }

            dataGridView1.Rows.Add(row);
        }

    }
}
