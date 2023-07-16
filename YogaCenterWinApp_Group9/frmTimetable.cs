using Microsoft.VisualBasic;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmTimetable : Form
{

    private readonly ICourseRepository repository = new CourseRepository();
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
        //// Khởi tạo và cấu hình cột cho DataGridView
        //dataGridView1.Columns.Add("TimeSlot", "Time Slot");
        //dataGridView1.Columns.Add("Monday", "Monday");
        //dataGridView1.Columns.Add("Tuesday", "Tuesday");
        //dataGridView1.Columns.Add("Wednesday", "Wednesday");
        //dataGridView1.Columns.Add("Thursday", "Thursday");
        //dataGridView1.Columns.Add("Friday", "Friday");

        //// Đặt kích thước cột TimeSlot
        //dataGridView1.Columns["TimeSlot"].Width = 100;

        //// Đặt chiều rộng cột còn lại tự động điều chỉnh
        //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //// Thêm dữ liệu mẫu vào DataGridView
        //dataGridView1.Rows.Add("8:00 - 9:00", "Class A", "Class B", "", "", "");
        //dataGridView1.Rows.Add("9:00 - 10:00", "", "", "", "", "Class C");
        //dataGridView1.Rows.Add("10:15 - 11:15", "", "", "", "", "Class C");
        //dataGridView1.Rows.Add("11:30 - 12:15", "Class D", "", "", "", "Class C");
        //dataGridView1.Rows.Add("2:00 - 3:00", "", "", "ClassE", "", "Class C");
        //dataGridView1.Rows.Add("3:15 - 4:15", "", "Class F", "", "", "Class C");
        //dataGridView1.Rows.Add("4:30 - 5:15", "ClassA", "", "", "", "Class C");
        //dataGridView1.Rows.Add("5:30 - 6:30", "", "", "", "ClassK " +
        //    "ClassB", "Class C");


        //// Thêm các dòng dữ liệu khác tương tự ở đây

        //// Cho phép chỉnh sửa cột TimeSlot
        //dataGridView1.Columns["TimeSlot"].ReadOnly = true;
        var daysOfWeek = Enum.GetValues(typeof(DayOfWeek));

        // Add columns for each day of the week
        foreach (var day in daysOfWeek)
        {
            dataGridView1.Columns.Add(day.ToString(), day.ToString());
        }

        var courses = repository.GetCourses();

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
