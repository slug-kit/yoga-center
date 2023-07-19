namespace YogaCenterWinApp_Group9
{
    partial class frmEnrolledCourseChange
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
            lbExperience = new Label();
            rtbInstructorExperience = new RichTextBox();
            lbSpecializations = new Label();
            pictureBox = new PictureBox();
            lbInstructorName = new Label();
            rtbInstructorSpecializations = new RichTextBox();
            rtbSchedule = new RichTextBox();
            lbSchedule = new Label();
            dtpEndDate = new DateTimePicker();
            lbEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lbStartDate = new Label();
            grbPreview = new GroupBox();
            txtInstructorName = new TextBox();
            grbChangeCourse = new GroupBox();
            lbCourse = new Label();
            cboCourse = new ComboBox();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            grbPreview.SuspendLayout();
            grbChangeCourse.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbExperience
            // 
            lbExperience.AutoSize = true;
            lbExperience.Location = new Point(8, 420);
            lbExperience.Margin = new Padding(4, 0, 4, 0);
            lbExperience.Name = "lbExperience";
            lbExperience.Size = new Size(84, 21);
            lbExperience.TabIndex = 62;
            lbExperience.Text = "Experience";
            // 
            // rtbInstructorExperience
            // 
            rtbInstructorExperience.Location = new Point(8, 453);
            rtbInstructorExperience.Margin = new Padding(4);
            rtbInstructorExperience.Name = "rtbInstructorExperience";
            rtbInstructorExperience.ReadOnly = true;
            rtbInstructorExperience.Size = new Size(440, 39);
            rtbInstructorExperience.TabIndex = 63;
            rtbInstructorExperience.Text = "";
            // 
            // lbSpecializations
            // 
            lbSpecializations.AutoSize = true;
            lbSpecializations.Location = new Point(7, 329);
            lbSpecializations.Margin = new Padding(4, 0, 4, 0);
            lbSpecializations.Name = "lbSpecializations";
            lbSpecializations.Size = new Size(112, 21);
            lbSpecializations.TabIndex = 60;
            lbSpecializations.Text = "Specializations";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(298, 214);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(96, 140);
            pictureBox.TabIndex = 58;
            pictureBox.TabStop = false;
            // 
            // lbInstructorName
            // 
            lbInstructorName.AutoSize = true;
            lbInstructorName.Location = new Point(7, 235);
            lbInstructorName.Margin = new Padding(4, 0, 4, 0);
            lbInstructorName.Name = "lbInstructorName";
            lbInstructorName.Size = new Size(77, 21);
            lbInstructorName.TabIndex = 57;
            lbInstructorName.Text = "Instructor";
            // 
            // rtbInstructorSpecializations
            // 
            rtbInstructorSpecializations.Location = new Point(7, 362);
            rtbInstructorSpecializations.Margin = new Padding(4);
            rtbInstructorSpecializations.Name = "rtbInstructorSpecializations";
            rtbInstructorSpecializations.ReadOnly = true;
            rtbInstructorSpecializations.Size = new Size(441, 39);
            rtbInstructorSpecializations.TabIndex = 61;
            rtbInstructorSpecializations.Text = "";
            // 
            // rtbSchedule
            // 
            rtbSchedule.Location = new Point(7, 164);
            rtbSchedule.Margin = new Padding(4);
            rtbSchedule.Name = "rtbSchedule";
            rtbSchedule.ReadOnly = true;
            rtbSchedule.Size = new Size(441, 39);
            rtbSchedule.TabIndex = 56;
            rtbSchedule.Text = "";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Location = new Point(7, 129);
            lbSchedule.Margin = new Padding(4, 0, 4, 0);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 55;
            lbSchedule.Text = "Schedule";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(244, 66);
            dtpEndDate.Margin = new Padding(4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(205, 29);
            dtpEndDate.TabIndex = 54;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(244, 32);
            lbEndDate.Margin = new Padding(4, 0, 4, 0);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(65, 21);
            lbEndDate.TabIndex = 53;
            lbEndDate.Text = "Ends on";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(7, 66);
            dtpStartDate.Margin = new Padding(4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(205, 29);
            dtpStartDate.TabIndex = 52;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(7, 32);
            lbStartDate.Margin = new Padding(4, 0, 4, 0);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(71, 21);
            lbStartDate.TabIndex = 51;
            lbStartDate.Text = "Starts on";
            // 
            // grbPreview
            // 
            grbPreview.Controls.Add(dtpStartDate);
            grbPreview.Controls.Add(lbExperience);
            grbPreview.Controls.Add(lbStartDate);
            grbPreview.Controls.Add(rtbInstructorExperience);
            grbPreview.Controls.Add(lbEndDate);
            grbPreview.Controls.Add(lbSpecializations);
            grbPreview.Controls.Add(dtpEndDate);
            grbPreview.Controls.Add(pictureBox);
            grbPreview.Controls.Add(lbSchedule);
            grbPreview.Controls.Add(lbInstructorName);
            grbPreview.Controls.Add(rtbSchedule);
            grbPreview.Controls.Add(rtbInstructorSpecializations);
            grbPreview.Controls.Add(txtInstructorName);
            grbPreview.Location = new Point(12, 92);
            grbPreview.Name = "grbPreview";
            grbPreview.Size = new Size(456, 520);
            grbPreview.TabIndex = 64;
            grbPreview.TabStop = false;
            grbPreview.Text = "Preview";
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(6, 269);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.ReadOnly = true;
            txtInstructorName.Size = new Size(206, 29);
            txtInstructorName.TabIndex = 64;
            // 
            // grbChangeCourse
            // 
            grbChangeCourse.Controls.Add(lbCourse);
            grbChangeCourse.Controls.Add(cboCourse);
            grbChangeCourse.Location = new Point(12, 12);
            grbChangeCourse.Name = "grbChangeCourse";
            grbChangeCourse.Size = new Size(456, 74);
            grbChangeCourse.TabIndex = 65;
            grbChangeCourse.TabStop = false;
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourse.Location = new Point(16, 30);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(103, 25);
            lbCourse.TabIndex = 0;
            lbCourse.Text = "Change to";
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(156, 30);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(292, 29);
            cboCourse.TabIndex = 26;
            cboCourse.SelectedValueChanged += cboCourse_SelectedValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnConfirm);
            groupBox1.Location = new Point(12, 618);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 86);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(290, 29);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 45);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(60, 29);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(110, 45);
            btnConfirm.TabIndex = 21;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // frmEnrolledCourseChange
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 716);
            Controls.Add(groupBox1);
            Controls.Add(grbChangeCourse);
            Controls.Add(grbPreview);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmEnrolledCourseChange";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Course";
            Load += frmEnrolledCourseChange_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            grbPreview.ResumeLayout(false);
            grbPreview.PerformLayout();
            grbChangeCourse.ResumeLayout(false);
            grbChangeCourse.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbExperience;
        private RichTextBox rtbInstructorExperience;
        private Label lbSpecializations;
        private PictureBox pictureBox;
        private Label lbInstructorName;
        private RichTextBox rtbInstructorSpecializations;
        private RichTextBox rtbSchedule;
        private Label lbSchedule;
        private DateTimePicker dtpEndDate;
        private Label lbEndDate;
        private DateTimePicker dtpStartDate;
        private Label lbStartDate;
        private GroupBox grbPreview;
        private GroupBox grbChangeCourse;
        private Label lbCourse;
        private ComboBox cboCourse;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox txtInstructorName;
    }
}