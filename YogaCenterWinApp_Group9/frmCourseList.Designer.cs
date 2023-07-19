namespace YogaCenterWinApp_Group9
{
    partial class frmCourseList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCourseNum = new Label();
            lbInstructor = new Label();
            lbProgram = new Label();
            txtProgramId = new TextBox();
            lbTimeSlot = new Label();
            lbCourseStart = new Label();
            lbTo = new Label();
            lbNonAvailable = new Label();
            lbAvailable = new Label();
            dateTimePickerAvailableFrom = new DateTimePicker();
            dateTimePickerAvailableTo = new DateTimePicker();
            dateTimePickerCourseEnd = new DateTimePicker();
            dateTimePickerCourseStart = new DateTimePicker();
            btnEnrol = new Button();
            pictureBox1 = new PictureBox();
            rtbschedule = new RichTextBox();
            lbSchedule = new Label();
            dataGridView1 = new DataGridView();
            txtCoursenumber = new TextBox();
            txtInstructor = new TextBox();
            txtCourseStatus = new TextBox();
            label1 = new Label();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            btnSearch = new Button();
            txtStatusfilter = new TextBox();
            label2 = new Label();
            btnRequestAssignment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbCourseNum
            // 
            lbCourseNum.AutoSize = true;
            lbCourseNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseNum.Location = new Point(20, 332);
            lbCourseNum.Margin = new Padding(4, 0, 4, 0);
            lbCourseNum.Name = "lbCourseNum";
            lbCourseNum.Size = new Size(121, 21);
            lbCourseNum.TabIndex = 0;
            lbCourseNum.Text = "Course Number";
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInstructor.Location = new Point(20, 381);
            lbInstructor.Margin = new Padding(4, 0, 4, 0);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(77, 21);
            lbInstructor.TabIndex = 3;
            lbInstructor.Text = "Instructor";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbProgram.Location = new Point(201, 32);
            lbProgram.Margin = new Padding(4, 0, 4, 0);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(139, 32);
            lbProgram.TabIndex = 5;
            lbProgram.Text = "Course List";
            // 
            // txtProgramId
            // 
            txtProgramId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramId.Location = new Point(185, 81);
            txtProgramId.Margin = new Padding(4);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.ReadOnly = true;
            txtProgramId.Size = new Size(216, 29);
            txtProgramId.TabIndex = 6;
            // 
            // lbTimeSlot
            // 
            lbTimeSlot.AutoSize = true;
            lbTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimeSlot.Location = new Point(20, 430);
            lbTimeSlot.Margin = new Padding(4, 0, 4, 0);
            lbTimeSlot.Name = "lbTimeSlot";
            lbTimeSlot.Size = new Size(105, 21);
            lbTimeSlot.TabIndex = 9;
            lbTimeSlot.Text = "Course Status";
            // 
            // lbCourseStart
            // 
            lbCourseStart.AutoSize = true;
            lbCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseStart.Location = new Point(20, 483);
            lbCourseStart.Margin = new Padding(4, 0, 4, 0);
            lbCourseStart.Name = "lbCourseStart";
            lbCourseStart.Size = new Size(136, 21);
            lbCourseStart.TabIndex = 12;
            lbCourseStart.Text = "Course Start From";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTo.Location = new Point(472, 481);
            lbTo.Margin = new Padding(4, 0, 4, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(25, 21);
            lbTo.TabIndex = 14;
            lbTo.Text = "To";
            // 
            // lbNonAvailable
            // 
            lbNonAvailable.AutoSize = true;
            lbNonAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNonAvailable.Location = new Point(762, 542);
            lbNonAvailable.Margin = new Padding(4, 0, 4, 0);
            lbNonAvailable.Name = "lbNonAvailable";
            lbNonAvailable.Size = new Size(25, 21);
            lbNonAvailable.TabIndex = 18;
            lbNonAvailable.Text = "To";
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAvailable.Location = new Point(383, 538);
            lbAvailable.Margin = new Padding(4, 0, 4, 0);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new Size(114, 21);
            lbAvailable.TabIndex = 16;
            lbAvailable.Text = "Available From";
            // 
            // dateTimePickerAvailableFrom
            // 
            dateTimePickerAvailableFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableFrom.Location = new Point(505, 536);
            dateTimePickerAvailableFrom.Margin = new Padding(4);
            dateTimePickerAvailableFrom.Name = "dateTimePickerAvailableFrom";
            dateTimePickerAvailableFrom.Size = new Size(249, 29);
            dateTimePickerAvailableFrom.TabIndex = 19;
            // 
            // dateTimePickerAvailableTo
            // 
            dateTimePickerAvailableTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableTo.Location = new Point(795, 536);
            dateTimePickerAvailableTo.Margin = new Padding(4);
            dateTimePickerAvailableTo.Name = "dateTimePickerAvailableTo";
            dateTimePickerAvailableTo.Size = new Size(250, 29);
            dateTimePickerAvailableTo.TabIndex = 20;
            // 
            // dateTimePickerCourseEnd
            // 
            dateTimePickerCourseEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseEnd.Location = new Point(515, 475);
            dateTimePickerCourseEnd.Margin = new Padding(4);
            dateTimePickerCourseEnd.Name = "dateTimePickerCourseEnd";
            dateTimePickerCourseEnd.Size = new Size(250, 29);
            dateTimePickerCourseEnd.TabIndex = 21;
            // 
            // dateTimePickerCourseStart
            // 
            dateTimePickerCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseStart.Location = new Point(201, 474);
            dateTimePickerCourseStart.Margin = new Padding(4);
            dateTimePickerCourseStart.Name = "dateTimePickerCourseStart";
            dateTimePickerCourseStart.Size = new Size(251, 29);
            dateTimePickerCourseStart.TabIndex = 22;
            // 
            // btnEnrol
            // 
            btnEnrol.Location = new Point(677, 332);
            btnEnrol.Margin = new Padding(4);
            btnEnrol.Name = "btnEnrol";
            btnEnrol.Size = new Size(278, 70);
            btnEnrol.TabIndex = 23;
            btnEnrol.Text = "Enrol in this Course";
            btnEnrol.UseVisualStyleBackColor = true;
            btnEnrol.Click += btnEnrol_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(377, 317);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 139);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // rtbschedule
            // 
            rtbschedule.Location = new Point(148, 527);
            rtbschedule.Margin = new Padding(4);
            rtbschedule.Name = "rtbschedule";
            rtbschedule.ReadOnly = true;
            rtbschedule.Size = new Size(227, 75);
            rtbschedule.TabIndex = 26;
            rtbschedule.Text = "";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSchedule.Location = new Point(20, 530);
            lbSchedule.Margin = new Padding(4, 0, 4, 0);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 27;
            lbSchedule.Text = "Schedule";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(120, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(835, 181);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtCoursenumber
            // 
            txtCoursenumber.Location = new Point(148, 332);
            txtCoursenumber.Name = "txtCoursenumber";
            txtCoursenumber.ReadOnly = true;
            txtCoursenumber.Size = new Size(187, 29);
            txtCoursenumber.TabIndex = 29;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(148, 381);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.ReadOnly = true;
            txtInstructor.Size = new Size(187, 29);
            txtInstructor.TabIndex = 30;
            // 
            // txtCourseStatus
            // 
            txtCourseStatus.Location = new Point(148, 427);
            txtCourseStatus.Name = "txtCourseStatus";
            txtCourseStatus.ReadOnly = true;
            txtCourseStatus.Size = new Size(187, 29);
            txtCourseStatus.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(536, 18);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 32;
            label1.Text = "Filter";
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(617, 18);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(269, 29);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(617, 78);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(269, 29);
            dateTimePickerEndDate.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 28);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Apply";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStatusfilter
            // 
            txtStatusfilter.Location = new Point(908, 53);
            txtStatusfilter.Name = "txtStatusfilter";
            txtStatusfilter.ReadOnly = true;
            txtStatusfilter.Size = new Size(100, 29);
            txtStatusfilter.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(931, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 35;
            label2.Text = "Status";
            // 
            // btnRequestAssignment
            // 
            btnRequestAssignment.Location = new Point(677, 332);
            btnRequestAssignment.Margin = new Padding(4);
            btnRequestAssignment.Name = "btnRequestAssignment";
            btnRequestAssignment.Size = new Size(278, 70);
            btnRequestAssignment.TabIndex = 36;
            btnRequestAssignment.Text = "Request to be assigned to this Course";
            btnRequestAssignment.UseVisualStyleBackColor = true;
            btnRequestAssignment.Click += btnRequestAssignment_Click;
            // 
            // frmCourseList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 630);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(txtCourseStatus);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(txtInstructor);
            Controls.Add(txtCoursenumber);
            Controls.Add(dataGridView1);
            Controls.Add(lbSchedule);
            Controls.Add(rtbschedule);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePickerCourseStart);
            Controls.Add(dateTimePickerCourseEnd);
            Controls.Add(dateTimePickerAvailableTo);
            Controls.Add(dateTimePickerAvailableFrom);
            Controls.Add(lbNonAvailable);
            Controls.Add(lbAvailable);
            Controls.Add(lbTo);
            Controls.Add(lbCourseStart);
            Controls.Add(lbTimeSlot);
            Controls.Add(txtProgramId);
            Controls.Add(lbProgram);
            Controls.Add(lbInstructor);
            Controls.Add(lbCourseNum);
            Controls.Add(btnEnrol);
            Controls.Add(btnRequestAssignment);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCourseList";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmCourseList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCourseNum;
        private Button btBack;
        private Label lbInstructor;
        private Label lbProgram;
        private TextBox txtProgramId;
        private Label lbTimeSlot;
        private Label lbCourseStart;
        private Label lbTo;
        private Label lbNonAvailable;
        private Label lbAvailable;
        private DateTimePicker dateTimePickerAvailableFrom;
        private DateTimePicker dateTimePickerAvailableTo;
        private DateTimePicker dateTimePickerCourseEnd;
        private DateTimePicker dateTimePickerCourseStart;
        private Button btnEnrol;
        private PictureBox pictureBox1;
        private RichTextBox rtbschedule;
        private Label lbSchedule;
        private DataGridView dataGridView1;
        private TextBox txtCoursenumber;
        private TextBox txtInstructor;
        private TextBox txtCourseStatus;
        private Label label1;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Button btnSearch;
        private TextBox txtStatusfilter;
        private Label label2;
        private Button btnRequestAssignment;
    }
}