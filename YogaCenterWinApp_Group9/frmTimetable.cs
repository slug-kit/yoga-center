﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YogaCenterWinApp_Group9
{
    public partial class frmTimetable : Form
    {
        public frmTimetable()
        {
            InitializeComponent();
        }

        private void frmTimetable_Load(object sender, EventArgs e)
        {
            // Khởi tạo và cấu hình cột cho DataGridView
            dataGridView1.Columns.Add("TimeSlot", "Time Slot");
            dataGridView1.Columns.Add("Monday", "Monday");
            dataGridView1.Columns.Add("Tuesday", "Tuesday");
            dataGridView1.Columns.Add("Wednesday", "Wednesday");
            dataGridView1.Columns.Add("Thursday", "Thursday");
            dataGridView1.Columns.Add("Friday", "Friday");

            // Đặt kích thước cột TimeSlot
            dataGridView1.Columns["TimeSlot"].Width = 100;

            // Đặt chiều rộng cột còn lại tự động điều chỉnh
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm dữ liệu mẫu vào DataGridView
            dataGridView1.Rows.Add("8:00 - 9:00", "Class A", "Class B", "", "", "");
            dataGridView1.Rows.Add("9:00 - 10:00", "", "", "", "", "Class C");
            dataGridView1.Rows.Add("10:15 - 11:15", "", "", "", "", "Class C");
            dataGridView1.Rows.Add("11:30 - 12:15", "Class D", "", "", "", "Class C");
            dataGridView1.Rows.Add("2:00 - 3:00", "", "", "ClassE", "", "Class C");
            dataGridView1.Rows.Add("3:15 - 4:15", "", "Class F", "", "", "Class C");
            dataGridView1.Rows.Add("4:30 - 5:15", "ClassA", "", "", "", "Class C");
            dataGridView1.Rows.Add("5:30 - 6:30", "", "", "", "ClassK " +
                "ClassB", "Class C");


            // Thêm các dòng dữ liệu khác tương tự ở đây

            // Cho phép chỉnh sửa cột TimeSlot
            dataGridView1.Columns["TimeSlot"].ReadOnly = true;
        }
    }
}