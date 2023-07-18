namespace YogaCenterWinApp_Group9
{
    partial class frmLessonManagementEdit
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
            txtId = new TextBox();
            lbId = new Label();
            lbProgramCode = new Label();
            txtProgramCode = new TextBox();
            lbCourseNumber = new Label();
            txtCourseNumber = new TextBox();
            lbLessonNumber = new Label();
            txtLessonNumber = new TextBox();
            lbLessonCode = new Label();
            txtLessonCode = new TextBox();
            lbLocation = new Label();
            txtLocation = new TextBox();
            lbDate = new Label();
            dtpDate = new DateTimePicker();
            lbTimeslot = new Label();
            cboTimeslot = new ComboBox();
            lbDescription = new Label();
            rtbDescription = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(200, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 29);
            txtId.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(40, 40);
            lbId.Name = "lbId";
            lbId.Size = new Size(77, 21);
            lbId.TabIndex = 1;
            lbId.Text = "Lesson ID";
            // 
            // lbProgramCode
            // 
            lbProgramCode.AutoSize = true;
            lbProgramCode.Location = new Point(40, 95);
            lbProgramCode.Name = "lbProgramCode";
            lbProgramCode.Size = new Size(111, 21);
            lbProgramCode.TabIndex = 2;
            lbProgramCode.Text = "Program Code";
            // 
            // txtProgramCode
            // 
            txtProgramCode.Location = new Point(200, 92);
            txtProgramCode.Name = "txtProgramCode";
            txtProgramCode.ReadOnly = true;
            txtProgramCode.Size = new Size(250, 29);
            txtProgramCode.TabIndex = 3;
            // 
            // lbCourseNumber
            // 
            lbCourseNumber.AutoSize = true;
            lbCourseNumber.Location = new Point(40, 150);
            lbCourseNumber.Name = "lbCourseNumber";
            lbCourseNumber.Size = new Size(121, 21);
            lbCourseNumber.TabIndex = 4;
            lbCourseNumber.Text = "Course Number";
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.Location = new Point(200, 147);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.ReadOnly = true;
            txtCourseNumber.Size = new Size(250, 29);
            txtCourseNumber.TabIndex = 5;
            // 
            // lbLessonNumber
            // 
            lbLessonNumber.AutoSize = true;
            lbLessonNumber.Location = new Point(40, 205);
            lbLessonNumber.Name = "lbLessonNumber";
            lbLessonNumber.Size = new Size(120, 21);
            lbLessonNumber.TabIndex = 6;
            lbLessonNumber.Text = "Lesson Number";
            // 
            // txtLessonNumber
            // 
            txtLessonNumber.Location = new Point(200, 202);
            txtLessonNumber.Name = "txtLessonNumber";
            txtLessonNumber.Size = new Size(250, 29);
            txtLessonNumber.TabIndex = 7;
            txtLessonNumber.KeyPress += txtLessonNumber_KeyPress;
            txtLessonNumber.Validating += txtLessonNumber_Validating;
            // 
            // lbLessonCode
            // 
            lbLessonCode.AutoSize = true;
            lbLessonCode.Location = new Point(40, 260);
            lbLessonCode.Name = "lbLessonCode";
            lbLessonCode.Size = new Size(98, 21);
            lbLessonCode.TabIndex = 8;
            lbLessonCode.Text = "Lesson Code";
            // 
            // txtLessonCode
            // 
            txtLessonCode.Location = new Point(200, 257);
            txtLessonCode.Name = "txtLessonCode";
            txtLessonCode.ReadOnly = true;
            txtLessonCode.Size = new Size(250, 29);
            txtLessonCode.TabIndex = 9;
            txtLessonCode.KeyDown += DataField_KeyDown;
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Location = new Point(40, 315);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(69, 21);
            lbLocation.TabIndex = 10;
            lbLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(200, 312);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(250, 29);
            txtLocation.TabIndex = 11;
            txtLocation.KeyDown += DataField_KeyDown;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(40, 370);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(42, 21);
            lbDate.TabIndex = 12;
            lbDate.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(200, 364);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 29);
            dtpDate.TabIndex = 13;
            dtpDate.KeyDown += DataField_KeyDown;
            dtpDate.Validating += dtpDate_Validating;
            // 
            // lbTimeslot
            // 
            lbTimeslot.AutoSize = true;
            lbTimeslot.Location = new Point(40, 425);
            lbTimeslot.Name = "lbTimeslot";
            lbTimeslot.Size = new Size(69, 21);
            lbTimeslot.TabIndex = 14;
            lbTimeslot.Text = "Timeslot";
            // 
            // cboTimeslot
            // 
            cboTimeslot.FormattingEnabled = true;
            cboTimeslot.Location = new Point(200, 422);
            cboTimeslot.Name = "cboTimeslot";
            cboTimeslot.Size = new Size(250, 29);
            cboTimeslot.TabIndex = 15;
            cboTimeslot.KeyDown += DataField_KeyDown;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(40, 480);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 16;
            lbDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(200, 477);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(250, 96);
            rtbDescription.TabIndex = 17;
            rtbDescription.Text = "";
            rtbDescription.KeyDown += DataField_KeyDown;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(72, 600);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 45);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 600);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 45);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLessonManagementEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(499, 671);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbDescription);
            Controls.Add(lbDescription);
            Controls.Add(cboTimeslot);
            Controls.Add(lbTimeslot);
            Controls.Add(dtpDate);
            Controls.Add(lbDate);
            Controls.Add(txtLocation);
            Controls.Add(lbLocation);
            Controls.Add(txtLessonCode);
            Controls.Add(lbLessonCode);
            Controls.Add(txtLessonNumber);
            Controls.Add(lbLessonNumber);
            Controls.Add(txtCourseNumber);
            Controls.Add(lbCourseNumber);
            Controls.Add(txtProgramCode);
            Controls.Add(lbProgramCode);
            Controls.Add(lbId);
            Controls.Add(txtId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmLessonManagementEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lesson Details";
            Load += frmLessonManagementEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lbId;
        private Label lbProgramCode;
        private TextBox txtProgramCode;
        private Label lbCourseNumber;
        private TextBox txtCourseNumber;
        private Label lbLessonNumber;
        private TextBox txtLessonNumber;
        private Label lbLessonCode;
        private TextBox txtLessonCode;
        private Label lbLocation;
        private TextBox txtLocation;
        private Label lbDate;
        private DateTimePicker dtpDate;
        private Label lbTimeslot;
        private ComboBox cboTimeslot;
        private Label lbDescription;
        private RichTextBox rtbDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}