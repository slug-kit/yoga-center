﻿namespace YogaCenterWinApp_Group9
{
    partial class frmProfile
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
            pictureBox = new PictureBox();
            txtEmail = new TextBox();
            mtbphonenumber = new MaskedTextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            lbPhone = new Label();
            lbMail = new Label();
            lbDateBirth = new Label();
            lbGender = new Label();
            lbFullname = new Label();
            lbUsername = new Label();
            lbProfile = new Label();
            lbCourse = new Label();
            dgvCourse = new DataGridView();
            dob = new DateTimePicker();
            txtgender = new TextBox();
            btnUpdate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtpassword = new TextBox();
            label1 = new Label();
            txtGoalOrExper = new TextBox();
            txtSpecialization = new TextBox();
            lbStudyGoal = new Label();
            lbSpecialization = new Label();
            lbExperience = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point(10, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(105, 140);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.ForeColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(147, 334);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(264, 29);
            txtEmail.TabIndex = 38;
            txtEmail.Text = "yoga@gmail.com";
            // 
            // mtbphonenumber
            // 
            mtbphonenumber.Anchor = AnchorStyles.None;
            mtbphonenumber.Location = new Point(147, 374);
            mtbphonenumber.Name = "mtbphonenumber";
            mtbphonenumber.ReadOnly = true;
            mtbphonenumber.Size = new Size(264, 29);
            mtbphonenumber.TabIndex = 37;
            // 
            // txtFullname
            // 
            txtFullname.Anchor = AnchorStyles.None;
            txtFullname.Location = new Point(147, 188);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(264, 29);
            txtFullname.TabIndex = 31;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(147, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(264, 29);
            txtUsername.TabIndex = 30;
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.None;
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(22, 382);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(116, 21);
            lbPhone.TabIndex = 29;
            lbPhone.Text = "Phone Number";
            // 
            // lbMail
            // 
            lbMail.Anchor = AnchorStyles.None;
            lbMail.AutoSize = true;
            lbMail.Location = new Point(22, 337);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(48, 21);
            lbMail.TabIndex = 28;
            lbMail.Text = "Email";
            // 
            // lbDateBirth
            // 
            lbDateBirth.Anchor = AnchorStyles.None;
            lbDateBirth.AutoSize = true;
            lbDateBirth.Location = new Point(22, 255);
            lbDateBirth.Name = "lbDateBirth";
            lbDateBirth.Size = new Size(97, 21);
            lbDateBirth.TabIndex = 27;
            lbDateBirth.Text = "Date of Birth";
            // 
            // lbGender
            // 
            lbGender.Anchor = AnchorStyles.None;
            lbGender.AutoSize = true;
            lbGender.Location = new Point(22, 293);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(61, 21);
            lbGender.TabIndex = 26;
            lbGender.Text = "Gender";
            // 
            // lbFullname
            // 
            lbFullname.Anchor = AnchorStyles.None;
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(22, 189);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(81, 21);
            lbFullname.TabIndex = 25;
            lbFullname.Text = "Full Name";
            // 
            // lbUsername
            // 
            lbUsername.Anchor = AnchorStyles.None;
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(22, 153);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(81, 21);
            lbUsername.TabIndex = 22;
            lbUsername.Text = "Username";
            // 
            // lbProfile
            // 
            lbProfile.Anchor = AnchorStyles.None;
            lbProfile.AutoSize = true;
            lbProfile.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbProfile.Location = new Point(190, 60);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(150, 32);
            lbProfile.TabIndex = 40;
            lbProfile.Text = "Your Profile";
            // 
            // lbCourse
            // 
            lbCourse.Anchor = AnchorStyles.None;
            lbCourse.AutoSize = true;
            lbCourse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourse.Location = new Point(564, 110);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(109, 25);
            lbCourse.TabIndex = 42;
            lbCourse.Text = "Completed";
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AllowUserToResizeRows = false;
            dgvCourse.Anchor = AnchorStyles.None;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(442, 150);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersWidth = 62;
            dgvCourse.RowTemplate.Height = 33;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(351, 217);
            dgvCourse.TabIndex = 43;
            // 
            // dob
            // 
            dob.Anchor = AnchorStyles.None;
            dob.Enabled = false;
            dob.Location = new Point(147, 256);
            dob.Margin = new Padding(4);
            dob.Name = "dob";
            dob.Size = new Size(264, 29);
            dob.TabIndex = 45;
            // 
            // txtgender
            // 
            txtgender.Anchor = AnchorStyles.None;
            txtgender.Location = new Point(147, 293);
            txtgender.Margin = new Padding(4);
            txtgender.Name = "txtgender";
            txtgender.ReadOnly = true;
            txtgender.Size = new Size(127, 29);
            txtgender.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Location = new Point(147, 482);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 32);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Enabled = false;
            btnSave.Location = new Point(147, 482);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 32);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(312, 482);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 32);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.Location = new Point(147, 223);
            txtpassword.Name = "txtpassword";
            txtpassword.ReadOnly = true;
            txtpassword.Size = new Size(261, 29);
            txtpassword.TabIndex = 50;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(31, 226);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 51;
            label1.Text = "Password";
            // 
            // txtGoalOrExper
            // 
            txtGoalOrExper.Anchor = AnchorStyles.None;
            txtGoalOrExper.Location = new Point(147, 409);
            txtGoalOrExper.Name = "txtGoalOrExper";
            txtGoalOrExper.ReadOnly = true;
            txtGoalOrExper.Size = new Size(261, 29);
            txtGoalOrExper.TabIndex = 52;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Anchor = AnchorStyles.None;
            txtSpecialization.Location = new Point(147, 444);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.ReadOnly = true;
            txtSpecialization.Size = new Size(261, 29);
            txtSpecialization.TabIndex = 53;
            // 
            // lbStudyGoal
            // 
            lbStudyGoal.Anchor = AnchorStyles.None;
            lbStudyGoal.AutoSize = true;
            lbStudyGoal.Location = new Point(22, 417);
            lbStudyGoal.Name = "lbStudyGoal";
            lbStudyGoal.Size = new Size(85, 21);
            lbStudyGoal.TabIndex = 54;
            lbStudyGoal.Text = "Study Goal";
            // 
            // lbSpecialization
            // 
            lbSpecialization.Anchor = AnchorStyles.None;
            lbSpecialization.AutoSize = true;
            lbSpecialization.Location = new Point(20, 452);
            lbSpecialization.Name = "lbSpecialization";
            lbSpecialization.Size = new Size(105, 21);
            lbSpecialization.TabIndex = 55;
            lbSpecialization.Text = "Specialization";
            // 
            // lbExperience
            // 
            lbExperience.Anchor = AnchorStyles.None;
            lbExperience.AutoSize = true;
            lbExperience.Location = new Point(22, 417);
            lbExperience.Name = "lbExperience";
            lbExperience.Size = new Size(84, 21);
            lbExperience.TabIndex = 56;
            lbExperience.Text = "Experience";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 538);
            Controls.Add(lbExperience);
            Controls.Add(lbSpecialization);
            Controls.Add(lbStudyGoal);
            Controls.Add(txtSpecialization);
            Controls.Add(txtGoalOrExper);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(btnUpdate);
            Controls.Add(txtgender);
            Controls.Add(dob);
            Controls.Add(dgvCourse);
            Controls.Add(lbCourse);
            Controls.Add(lbProfile);
            Controls.Add(txtEmail);
            Controls.Add(mtbphonenumber);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(lbPhone);
            Controls.Add(lbMail);
            Controls.Add(lbDateBirth);
            Controls.Add(lbGender);
            Controls.Add(lbFullname);
            Controls.Add(lbUsername);
            Controls.Add(pictureBox);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TextBox txtEmail;
        private MaskedTextBox mtbphonenumber;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private Label lbPhone;
        private Label lbMail;
        private Label lbDateBirth;
        private Label lbGender;
        private Label lbFullname;
        private Label lbUsername;
        private Label lbProfile;
        private Label lbCourse;
        private DataGridView dgvCourse;
        private DateTimePicker dob;
        private TextBox txtgender;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtpassword;
        private Label label1;
        private TextBox txtGoalOrExper;
        private TextBox txtSpecialization;
        private Label lbStudyGoal;
        private Label lbSpecialization;
        private Label lbExperience;
    }
}