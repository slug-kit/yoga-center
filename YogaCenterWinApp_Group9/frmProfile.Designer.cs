namespace YogaCenterWinApp_Group9
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
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            lbFemale = new RadioButton();
            lbMale = new RadioButton();
            mtxtDateBirth = new MaskedTextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            lbPhone = new Label();
            lbMail = new Label();
            lbDateBirth = new Label();
            lbGender = new Label();
            lbFullname = new Label();
            lbUsername = new Label();
            radioButton1 = new RadioButton();
            lbProfile = new Label();
            btBackHome = new Button();
            lbCourse = new Label();
            dgvCourse = new DataGridView();
            chkInstructor = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 29);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(114, 212);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 38;
            txtEmail.Text = "yoga@gmail.com";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(114, 239);
            maskedTextBox3.Margin = new Padding(2);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(206, 23);
            maskedTextBox3.TabIndex = 37;
            // 
            // lbFemale
            // 
            lbFemale.AutoSize = true;
            lbFemale.Location = new Point(219, 213);
            lbFemale.Margin = new Padding(2);
            lbFemale.Name = "lbFemale";
            lbFemale.Size = new Size(63, 19);
            lbFemale.TabIndex = 36;
            lbFemale.TabStop = true;
            lbFemale.Text = "Female";
            lbFemale.UseVisualStyleBackColor = true;
            // 
            // lbMale
            // 
            lbMale.AutoSize = true;
            lbMale.Location = new Point(148, 191);
            lbMale.Margin = new Padding(2);
            lbMale.Name = "lbMale";
            lbMale.Size = new Size(51, 19);
            lbMale.TabIndex = 35;
            lbMale.TabStop = true;
            lbMale.Text = "Male";
            lbMale.UseVisualStyleBackColor = true;
            // 
            // mtxtDateBirth
            // 
            mtxtDateBirth.Location = new Point(114, 161);
            mtxtDateBirth.Margin = new Padding(2);
            mtxtDateBirth.Name = "mtxtDateBirth";
            mtxtDateBirth.Size = new Size(206, 23);
            mtxtDateBirth.TabIndex = 34;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(114, 134);
            txtFullname.Margin = new Padding(2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(206, 23);
            txtFullname.TabIndex = 31;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(114, 107);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(206, 23);
            txtUsername.TabIndex = 30;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(17, 241);
            lbPhone.Margin = new Padding(2, 0, 2, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(88, 15);
            lbPhone.TabIndex = 29;
            lbPhone.Text = "Phone Number";
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(17, 214);
            lbMail.Margin = new Padding(2, 0, 2, 0);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(36, 15);
            lbMail.TabIndex = 28;
            lbMail.Text = "Email";
            // 
            // lbDateBirth
            // 
            lbDateBirth.AutoSize = true;
            lbDateBirth.Location = new Point(17, 164);
            lbDateBirth.Margin = new Padding(2, 0, 2, 0);
            lbDateBirth.Name = "lbDateBirth";
            lbDateBirth.Size = new Size(73, 15);
            lbDateBirth.TabIndex = 27;
            lbDateBirth.Text = "Date of Birth";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(17, 192);
            lbGender.Margin = new Padding(2, 0, 2, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 26;
            lbGender.Text = "Gender";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(17, 135);
            lbFullname.Margin = new Padding(2, 0, 2, 0);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(61, 15);
            lbFullname.TabIndex = 25;
            lbFullname.Text = "Full Name";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(17, 109);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 22;
            lbUsername.Text = "Username";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(205, 191);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 39;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbProfile.Location = new Point(148, 43);
            lbProfile.Margin = new Padding(2, 0, 2, 0);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(150, 32);
            lbProfile.TabIndex = 40;
            lbProfile.Text = "Your Profile";
            // 
            // btBackHome
            // 
            btBackHome.Location = new Point(0, 0);
            btBackHome.Margin = new Padding(2);
            btBackHome.Name = "btBackHome";
            btBackHome.Size = new Size(78, 25);
            btBackHome.TabIndex = 41;
            btBackHome.Text = "Back";
            btBackHome.UseVisualStyleBackColor = true;
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourse.Location = new Point(420, 80);
            lbCourse.Margin = new Padding(2, 0, 2, 0);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(113, 25);
            lbCourse.TabIndex = 42;
            lbCourse.Text = "In Progress";
            // 
            // dgvCourse
            // 
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(344, 107);
            dgvCourse.Margin = new Padding(2);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 62;
            dgvCourse.RowTemplate.Height = 33;
            dgvCourse.Size = new Size(273, 155);
            dgvCourse.TabIndex = 43;
            // 
            // chkInstructor
            // 
            chkInstructor.AutoSize = true;
            chkInstructor.Location = new Point(114, 266);
            chkInstructor.Margin = new Padding(2);
            chkInstructor.Name = "chkInstructor";
            chkInstructor.Size = new Size(113, 19);
            chkInstructor.TabIndex = 44;
            chkInstructor.TabStop = false;
            chkInstructor.Text = "I'm an instructor";
            chkInstructor.UseVisualStyleBackColor = true;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 332);
            Controls.Add(chkInstructor);
            Controls.Add(dgvCourse);
            Controls.Add(lbCourse);
            Controls.Add(btBackHome);
            Controls.Add(lbProfile);
            Controls.Add(radioButton1);
            Controls.Add(txtEmail);
            Controls.Add(maskedTextBox3);
            Controls.Add(lbFemale);
            Controls.Add(lbMale);
            Controls.Add(mtxtDateBirth);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(lbPhone);
            Controls.Add(lbMail);
            Controls.Add(lbDateBirth);
            Controls.Add(lbGender);
            Controls.Add(lbFullname);
            Controls.Add(lbUsername);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "frmProfile";
            Text = "frmProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private MaskedTextBox maskedTextBox3;
        private RadioButton lbFemale;
        private RadioButton lbMale;
        private MaskedTextBox mtxtDateBirth;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private Label lbPhone;
        private Label lbMail;
        private Label lbDateBirth;
        private Label lbGender;
        private Label lbFullname;
        private Label lbUsername;
        private RadioButton radioButton1;
        private Label lbProfile;
        private Button btBackHome;
        private Label lbCourse;
        private DataGridView dgvCourse;
        private CheckBox chkInstructor;
    }
}