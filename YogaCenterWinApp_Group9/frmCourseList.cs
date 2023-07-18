﻿using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using YogaCenterWinApp_Group9.DisplayModels;

namespace YogaCenterWinApp_Group9
{
    public partial class frmCourseList : Form
    {
        private readonly int _programId;

        public frmCourseList(int programId)
        {
            InitializeComponent();
            _programId = programId;
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = CourseDAO.Instance.GetByProgram(_programId);
            dataGridView1.DataSource = courses.ToList();

            dataGridView1.Columns.Remove("HasNewRequest");
            dataGridView1.Columns.Remove("Inactive");
            dataGridView1.Columns.Remove("Program");
            dataGridView1.Columns.Remove("CourseAssignmentRequests");
            dataGridView1.Columns.Remove("CourseRegisters");
            dataGridView1.Columns.Remove("Lessons");
            dataGridView1.Columns.Remove("Instructor");
            dataGridView1.Columns.Remove("InstructorId");


            dataGridView1.Columns.Add(new DataGridViewColumn()
            {
                Name = "InstructorName",
                HeaderText = "InstructorName",
                DataPropertyName = "Instructor.Fullname",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    var course = (Course)selectedRow.DataBoundItem;

                    // Hiển thị dữ liệu lên các ô textbox
                    txtProgramId.Text = course.GetCourseCode();
                    txtCoursenumber.Text = course.CourseNumber.ToString();
                    txtInstructor.Text = course.Instructor?.Fullname;
                    rtbschedule.Text = course.Schedule;
                    dateTimePickerCourseStart.Text = course.StartDate.ToString();
                    dateTimePickerCourseEnd.Text = course.EndDate.ToString();
                    dateTimePickerAvailableTo.Text = course.RegistrationCloseDate.ToString();
                    dateTimePickerAvailableFrom.Text = course.RegistrationOpenDate.ToString();
                    txtCourseStatus.Text = course.GetStatusName();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            var courses = CourseDAO.Instance.GetByProgram(_programId)
                .Where(c => c.StartDate >= startDate && c.EndDate <= endDate)
                .ToList();

            dataGridView1.DataSource = courses;

            // Làm sạch các ô textbox
            txtProgramId.Text = string.Empty;
            txtCoursenumber.Text = string.Empty;
            txtInstructor.Text = string.Empty;
            rtbschedule.Text = string.Empty;
            dateTimePickerCourseStart.Text = string.Empty;
            dateTimePickerCourseEnd.Text = string.Empty;
            dateTimePickerAvailableTo.Text = string.Empty;
            dateTimePickerAvailableFrom.Text = string.Empty;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "StartDate" || dataGridView1.Columns[e.ColumnIndex].Name == "EndDate" || dataGridView1.Columns[e.ColumnIndex].Name == "RegistrationOpenDate" || dataGridView1.Columns[e.ColumnIndex].Name == "RegistrationCloseDate")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains('.'))
            {
                object data = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i])?.GetValue(data)!;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }

    }
}
