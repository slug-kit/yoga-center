namespace YogaCenterWinApp_Group9
{
    partial class frmCourseManagementEdit
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
            lbProgramName = new Label();
            lbCourseNumber = new Label();
            lbInstructor = new Label();
            lbStartDate = new Label();
            lbEndDate = new Label();
            lbRegistrationOpenDate = new Label();
            lbRegistrationCloseDate = new Label();
            lbSchedule = new Label();
            txtCourseNumber = new TextBox();
            cboInstructor = new ComboBox();
            dtpStartDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            lbCourseId = new Label();
            lbProgramCode = new Label();
            txtCourseId = new TextBox();
            txtProgramName = new TextBox();
            txtProgramCode = new TextBox();
            rtbSchedule = new RichTextBox();
            grbDetails = new GroupBox();
            picbInstructorImg = new PictureBox();
            dtpRegistrationCloseDate = new DateTimePicker();
            dtpRegistrationOpenDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            splitContainer = new SplitContainer();
            grbFormActions = new GroupBox();
            grbLessonDetails = new GroupBox();
            lbLessonTimeslot = new Label();
            txtLessonLocation = new TextBox();
            lbLessonLocation = new Label();
            dtpLessonDate = new DateTimePicker();
            lbLessonDate = new Label();
            txtLessonNumber = new TextBox();
            lbLessonNumber = new Label();
            txtLessonId = new TextBox();
            lbLessonId = new Label();
            grbLessonListActions = new GroupBox();
            btnDeleteLesson = new Button();
            btnAddLesson = new Button();
            dgvLessons = new DataGridView();
            txtLessonTimeslot = new TextBox();
            grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbInstructorImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            grbFormActions.SuspendLayout();
            grbLessonDetails.SuspendLayout();
            grbLessonListActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLessons).BeginInit();
            SuspendLayout();
            // 
            // lbProgramName
            // 
            lbProgramName.AutoSize = true;
            lbProgramName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProgramName.Location = new Point(25, 105);
            lbProgramName.Margin = new Padding(4, 0, 4, 0);
            lbProgramName.Name = "lbProgramName";
            lbProgramName.Size = new Size(117, 21);
            lbProgramName.TabIndex = 1;
            lbProgramName.Text = "Program Name";
            // 
            // lbCourseNumber
            // 
            lbCourseNumber.AutoSize = true;
            lbCourseNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseNumber.Location = new Point(25, 165);
            lbCourseNumber.Margin = new Padding(4, 0, 4, 0);
            lbCourseNumber.Name = "lbCourseNumber";
            lbCourseNumber.Size = new Size(121, 21);
            lbCourseNumber.TabIndex = 2;
            lbCourseNumber.Text = "Course Number";
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInstructor.Location = new Point(25, 225);
            lbInstructor.Margin = new Padding(4, 0, 4, 0);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(77, 21);
            lbInstructor.TabIndex = 3;
            lbInstructor.Text = "Instructor";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStartDate.Location = new Point(25, 290);
            lbStartDate.Margin = new Padding(4, 0, 4, 0);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(49, 21);
            lbStartDate.TabIndex = 4;
            lbStartDate.Text = "Starts";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEndDate.Location = new Point(380, 290);
            lbEndDate.Margin = new Padding(4, 0, 4, 0);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(36, 21);
            lbEndDate.TabIndex = 5;
            lbEndDate.Text = "End";
            // 
            // lbRegistrationOpenDate
            // 
            lbRegistrationOpenDate.AutoSize = true;
            lbRegistrationOpenDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRegistrationOpenDate.Location = new Point(25, 445);
            lbRegistrationOpenDate.Margin = new Padding(4, 0, 4, 0);
            lbRegistrationOpenDate.Name = "lbRegistrationOpenDate";
            lbRegistrationOpenDate.Size = new Size(143, 21);
            lbRegistrationOpenDate.TabIndex = 6;
            lbRegistrationOpenDate.Text = "Registration Opens";
            // 
            // lbRegistrationCloseDate
            // 
            lbRegistrationCloseDate.AutoSize = true;
            lbRegistrationCloseDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRegistrationCloseDate.Location = new Point(380, 445);
            lbRegistrationCloseDate.Margin = new Padding(4, 0, 4, 0);
            lbRegistrationCloseDate.Name = "lbRegistrationCloseDate";
            lbRegistrationCloseDate.Size = new Size(55, 21);
            lbRegistrationCloseDate.TabIndex = 7;
            lbRegistrationCloseDate.Text = "Closes";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSchedule.Location = new Point(25, 350);
            lbSchedule.Margin = new Padding(4, 0, 4, 0);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 8;
            lbSchedule.Text = "Schedule";
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCourseNumber.Location = new Point(182, 162);
            txtCourseNumber.Margin = new Padding(4);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Size = new Size(100, 29);
            txtCourseNumber.TabIndex = 11;
            // 
            // cboInstructor
            // 
            cboInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboInstructor.FormattingEnabled = true;
            cboInstructor.Location = new Point(182, 222);
            cboInstructor.Margin = new Padding(4);
            cboInstructor.Name = "cboInstructor";
            cboInstructor.Size = new Size(200, 29);
            cboInstructor.TabIndex = 13;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(182, 287);
            dtpStartDate.Margin = new Padding(4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 29);
            dtpStartDate.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 33);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 45);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnsave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(380, 33);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 45);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnexit_Click;
            // 
            // lbCourseId
            // 
            lbCourseId.AutoSize = true;
            lbCourseId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseId.Location = new Point(25, 45);
            lbCourseId.Margin = new Padding(4, 0, 4, 0);
            lbCourseId.Name = "lbCourseId";
            lbCourseId.Size = new Size(78, 21);
            lbCourseId.TabIndex = 20;
            lbCourseId.Text = "Course ID";
            // 
            // lbProgramCode
            // 
            lbProgramCode.AutoSize = true;
            lbProgramCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProgramCode.Location = new Point(400, 105);
            lbProgramCode.Margin = new Padding(4, 0, 4, 0);
            lbProgramCode.Name = "lbProgramCode";
            lbProgramCode.Size = new Size(46, 21);
            lbProgramCode.TabIndex = 21;
            lbProgramCode.Text = "Code";
            // 
            // txtCourseId
            // 
            txtCourseId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCourseId.Location = new Point(182, 42);
            txtCourseId.Margin = new Padding(4);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(100, 29);
            txtCourseId.TabIndex = 22;
            // 
            // txtProgramName
            // 
            txtProgramName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramName.Location = new Point(182, 102);
            txtProgramName.Margin = new Padding(4);
            txtProgramName.Name = "txtProgramName";
            txtProgramName.Size = new Size(200, 29);
            txtProgramName.TabIndex = 23;
            // 
            // txtProgramCode
            // 
            txtProgramCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramCode.Location = new Point(475, 102);
            txtProgramCode.Margin = new Padding(4);
            txtProgramCode.Name = "txtProgramCode";
            txtProgramCode.Size = new Size(127, 29);
            txtProgramCode.TabIndex = 24;
            // 
            // rtbSchedule
            // 
            rtbSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbSchedule.Location = new Point(182, 347);
            rtbSchedule.Name = "rtbSchedule";
            rtbSchedule.Size = new Size(300, 70);
            rtbSchedule.TabIndex = 25;
            rtbSchedule.Text = "";
            // 
            // grbDetails
            // 
            grbDetails.Controls.Add(picbInstructorImg);
            grbDetails.Controls.Add(dtpRegistrationCloseDate);
            grbDetails.Controls.Add(dtpRegistrationOpenDate);
            grbDetails.Controls.Add(dtpEndDate);
            grbDetails.Controls.Add(lbProgramCode);
            grbDetails.Controls.Add(txtProgramCode);
            grbDetails.Controls.Add(rtbSchedule);
            grbDetails.Controls.Add(txtCourseId);
            grbDetails.Controls.Add(txtProgramName);
            grbDetails.Controls.Add(lbCourseId);
            grbDetails.Controls.Add(lbProgramName);
            grbDetails.Controls.Add(lbCourseNumber);
            grbDetails.Controls.Add(lbInstructor);
            grbDetails.Controls.Add(lbStartDate);
            grbDetails.Controls.Add(txtCourseNumber);
            grbDetails.Controls.Add(cboInstructor);
            grbDetails.Controls.Add(dtpStartDate);
            grbDetails.Controls.Add(lbEndDate);
            grbDetails.Controls.Add(lbSchedule);
            grbDetails.Controls.Add(lbRegistrationOpenDate);
            grbDetails.Controls.Add(lbRegistrationCloseDate);
            grbDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            grbDetails.Location = new Point(15, 3);
            grbDetails.Name = "grbDetails";
            grbDetails.Size = new Size(624, 505);
            grbDetails.TabIndex = 26;
            grbDetails.TabStop = false;
            grbDetails.Text = "Course Info";
            // 
            // picbInstructorImg
            // 
            picbInstructorImg.Location = new Point(475, 150);
            picbInstructorImg.Name = "picbInstructorImg";
            picbInstructorImg.Size = new Size(90, 120);
            picbInstructorImg.TabIndex = 29;
            picbInstructorImg.TabStop = false;
            // 
            // dtpRegistrationCloseDate
            // 
            dtpRegistrationCloseDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpRegistrationCloseDate.Format = DateTimePickerFormat.Short;
            dtpRegistrationCloseDate.Location = new Point(452, 442);
            dtpRegistrationCloseDate.Margin = new Padding(4);
            dtpRegistrationCloseDate.Name = "dtpRegistrationCloseDate";
            dtpRegistrationCloseDate.Size = new Size(150, 29);
            dtpRegistrationCloseDate.TabIndex = 28;
            // 
            // dtpRegistrationOpenDate
            // 
            dtpRegistrationOpenDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpRegistrationOpenDate.Format = DateTimePickerFormat.Short;
            dtpRegistrationOpenDate.Location = new Point(182, 442);
            dtpRegistrationOpenDate.Margin = new Padding(4);
            dtpRegistrationOpenDate.Name = "dtpRegistrationOpenDate";
            dtpRegistrationOpenDate.Size = new Size(150, 29);
            dtpRegistrationOpenDate.TabIndex = 27;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(452, 287);
            dtpEndDate.Margin = new Padding(4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 29);
            dtpEndDate.TabIndex = 26;
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(12, 12);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(grbFormActions);
            splitContainer.Panel1.Controls.Add(grbDetails);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(grbLessonDetails);
            splitContainer.Panel2.Controls.Add(grbLessonListActions);
            splitContainer.Panel2.Controls.Add(dgvLessons);
            splitContainer.Size = new Size(1221, 621);
            splitContainer.SplitterDistance = 653;
            splitContainer.TabIndex = 27;
            // 
            // grbFormActions
            // 
            grbFormActions.Controls.Add(btnCancel);
            grbFormActions.Controls.Add(btnSave);
            grbFormActions.Location = new Point(15, 510);
            grbFormActions.Name = "grbFormActions";
            grbFormActions.Size = new Size(624, 100);
            grbFormActions.TabIndex = 27;
            grbFormActions.TabStop = false;
            // 
            // grbLessonDetails
            // 
            grbLessonDetails.Controls.Add(lbLessonTimeslot);
            grbLessonDetails.Controls.Add(txtLessonLocation);
            grbLessonDetails.Controls.Add(lbLessonLocation);
            grbLessonDetails.Controls.Add(dtpLessonDate);
            grbLessonDetails.Controls.Add(lbLessonDate);
            grbLessonDetails.Controls.Add(txtLessonNumber);
            grbLessonDetails.Controls.Add(lbLessonNumber);
            grbLessonDetails.Controls.Add(txtLessonId);
            grbLessonDetails.Controls.Add(lbLessonId);
            grbLessonDetails.Controls.Add(txtLessonTimeslot);
            grbLessonDetails.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbLessonDetails.Location = new Point(15, 3);
            grbLessonDetails.Name = "grbLessonDetails";
            grbLessonDetails.Size = new Size(535, 210);
            grbLessonDetails.TabIndex = 2;
            grbLessonDetails.TabStop = false;
            grbLessonDetails.Text = "Lessons";
            // 
            // lbLessonTimeslot
            // 
            lbLessonTimeslot.AutoSize = true;
            lbLessonTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLessonTimeslot.Location = new Point(260, 165);
            lbLessonTimeslot.Margin = new Padding(4, 0, 4, 0);
            lbLessonTimeslot.Name = "lbLessonTimeslot";
            lbLessonTimeslot.Size = new Size(69, 21);
            lbLessonTimeslot.TabIndex = 30;
            lbLessonTimeslot.Text = "Timeslot";
            // 
            // txtLessonLocation
            // 
            txtLessonLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLessonLocation.Location = new Point(115, 102);
            txtLessonLocation.Name = "txtLessonLocation";
            txtLessonLocation.ReadOnly = true;
            txtLessonLocation.Size = new Size(250, 29);
            txtLessonLocation.TabIndex = 29;
            // 
            // lbLessonLocation
            // 
            lbLessonLocation.AutoSize = true;
            lbLessonLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLessonLocation.Location = new Point(25, 105);
            lbLessonLocation.Margin = new Padding(4, 0, 4, 0);
            lbLessonLocation.Name = "lbLessonLocation";
            lbLessonLocation.Size = new Size(69, 21);
            lbLessonLocation.TabIndex = 28;
            lbLessonLocation.Text = "Location";
            // 
            // dtpLessonDate
            // 
            dtpLessonDate.Enabled = false;
            dtpLessonDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLessonDate.Format = DateTimePickerFormat.Short;
            dtpLessonDate.Location = new Point(115, 162);
            dtpLessonDate.Margin = new Padding(4);
            dtpLessonDate.Name = "dtpLessonDate";
            dtpLessonDate.Size = new Size(125, 29);
            dtpLessonDate.TabIndex = 27;
            // 
            // lbLessonDate
            // 
            lbLessonDate.AutoSize = true;
            lbLessonDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLessonDate.Location = new Point(25, 165);
            lbLessonDate.Margin = new Padding(4, 0, 4, 0);
            lbLessonDate.Name = "lbLessonDate";
            lbLessonDate.Size = new Size(42, 21);
            lbLessonDate.TabIndex = 26;
            lbLessonDate.Text = "Date";
            // 
            // txtLessonNumber
            // 
            txtLessonNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLessonNumber.Location = new Point(355, 42);
            txtLessonNumber.Margin = new Padding(4);
            txtLessonNumber.Name = "txtLessonNumber";
            txtLessonNumber.ReadOnly = true;
            txtLessonNumber.Size = new Size(100, 29);
            txtLessonNumber.TabIndex = 25;
            // 
            // lbLessonNumber
            // 
            lbLessonNumber.AutoSize = true;
            lbLessonNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLessonNumber.Location = new Point(260, 45);
            lbLessonNumber.Margin = new Padding(4, 0, 4, 0);
            lbLessonNumber.Name = "lbLessonNumber";
            lbLessonNumber.Size = new Size(71, 21);
            lbLessonNumber.TabIndex = 24;
            lbLessonNumber.Text = "Lesson #";
            // 
            // txtLessonId
            // 
            txtLessonId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLessonId.Location = new Point(115, 42);
            txtLessonId.Margin = new Padding(4);
            txtLessonId.Name = "txtLessonId";
            txtLessonId.ReadOnly = true;
            txtLessonId.Size = new Size(100, 29);
            txtLessonId.TabIndex = 23;
            // 
            // lbLessonId
            // 
            lbLessonId.AutoSize = true;
            lbLessonId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLessonId.Location = new Point(25, 45);
            lbLessonId.Margin = new Padding(4, 0, 4, 0);
            lbLessonId.Name = "lbLessonId";
            lbLessonId.Size = new Size(77, 21);
            lbLessonId.TabIndex = 21;
            lbLessonId.Text = "Lesson ID";
            // 
            // grbLessonListActions
            // 
            grbLessonListActions.Controls.Add(btnDeleteLesson);
            grbLessonListActions.Controls.Add(btnAddLesson);
            grbLessonListActions.Location = new Point(15, 494);
            grbLessonListActions.Name = "grbLessonListActions";
            grbLessonListActions.Size = new Size(535, 116);
            grbLessonListActions.TabIndex = 1;
            grbLessonListActions.TabStop = false;
            // 
            // btnDeleteLesson
            // 
            btnDeleteLesson.Location = new Point(330, 49);
            btnDeleteLesson.Margin = new Padding(4);
            btnDeleteLesson.Name = "btnDeleteLesson";
            btnDeleteLesson.Size = new Size(110, 45);
            btnDeleteLesson.TabIndex = 20;
            btnDeleteLesson.Text = "Delete";
            btnDeleteLesson.UseVisualStyleBackColor = true;
            btnDeleteLesson.Click += btnDeleteLesson_Click;
            // 
            // btnAddLesson
            // 
            btnAddLesson.Location = new Point(90, 49);
            btnAddLesson.Margin = new Padding(4);
            btnAddLesson.Name = "btnAddLesson";
            btnAddLesson.Size = new Size(110, 45);
            btnAddLesson.TabIndex = 19;
            btnAddLesson.Text = "Add";
            btnAddLesson.UseVisualStyleBackColor = true;
            btnAddLesson.Click += btnAddLesson_Click;
            // 
            // dgvLessons
            // 
            dgvLessons.AllowUserToAddRows = false;
            dgvLessons.AllowUserToDeleteRows = false;
            dgvLessons.AllowUserToResizeRows = false;
            dgvLessons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLessons.Location = new Point(15, 219);
            dgvLessons.Name = "dgvLessons";
            dgvLessons.ReadOnly = true;
            dgvLessons.RowTemplate.Height = 25;
            dgvLessons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLessons.Size = new Size(535, 279);
            dgvLessons.TabIndex = 0;
            dgvLessons.CellDoubleClick += dgvLessons_CellDoubleClick;
            dgvLessons.CellFormatting += dgvLessons_CellFormatting;
            // 
            // txtLessonTimeslot
            // 
            txtLessonTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLessonTimeslot.Location = new Point(355, 162);
            txtLessonTimeslot.Margin = new Padding(4);
            txtLessonTimeslot.Name = "txtLessonTimeslot";
            txtLessonTimeslot.ReadOnly = true;
            txtLessonTimeslot.Size = new Size(160, 29);
            txtLessonTimeslot.TabIndex = 32;
            // 
            // frmCourseManagementEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1244, 641);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCourseManagementEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Course Details";
            Load += frmCourseManagementDetail_Load;
            grbDetails.ResumeLayout(false);
            grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbInstructorImg).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            grbFormActions.ResumeLayout(false);
            grbLessonDetails.ResumeLayout(false);
            grbLessonDetails.PerformLayout();
            grbLessonListActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLessons).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Label lbProgramName;
        private Label lbCourseNumber;
        private Label lbInstructor;
        private Label lbStartDate;
        private Label lbEndDate;
        private Label lbRegistrationOpenDate;
        private Label lbRegistrationCloseDate;
        private Label lbSchedule;
        private TextBox txtCourseNumber;
        private ComboBox cboInstructor;
        private DateTimePicker dtpStartDate;
        private Button btnSave;
        private Button btnCancel;
        private Label lbCourseId;
        private Label lbProgramCode;
        private TextBox txtCourseId;
        private TextBox txtProgramName;
        private TextBox txtProgramCode;
        private RichTextBox rtbSchedule;
        private GroupBox grbDetails;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpRegistrationOpenDate;
        private DateTimePicker dtpRegistrationCloseDate;
        private SplitContainer splitContainer;
        private GroupBox grbFormActions;
        private DataGridView dgvLessons;
        private GroupBox grbLessonListActions;
        private GroupBox grbLessonDetails;
        private PictureBox picbInstructorImg;
        private TextBox txtLessonId;
        private Label lbLessonId;
        private Label lbLessonNumber;
        private TextBox txtLessonNumber;
        private Label lbLessonDate;
        private DateTimePicker dtpLessonDate;
        private Label lbLessonLocation;
        private TextBox txtLessonLocation;
        private Label lbLessonTimeslot;
        private Button btnAddLesson;
        private Button btnDeleteLesson;
        private TextBox txtLessonTimeslot;
    }
}