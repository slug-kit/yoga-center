namespace YogaCenterWinApp_Group9
{
    partial class frmRegister
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
            lbUsername = new Label();
            lbPassword = new Label();
            lbRegister = new Label();
            lbConfirm = new Label();
            lbFullname = new Label();
            lbGender = new Label();
            lbDateBirth = new Label();
            lbMail = new Label();
            lbPhone = new Label();
            txtUsername = new TextBox();
            txtFullname = new TextBox();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            mtxtDateBirth = new MaskedTextBox();
            lbMale = new RadioButton();
            lbFemale = new RadioButton();
            chkInstructor = new CheckBox();
            chkAccept = new CheckBox();
            btRegister = new Button();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(30, 67);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(30, 93);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegister.Location = new Point(198, 9);
            lbRegister.Margin = new Padding(2, 0, 2, 0);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(94, 32);
            lbRegister.TabIndex = 2;
            lbRegister.Text = "Signup";
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new Point(29, 121);
            lbConfirm.Margin = new Padding(2, 0, 2, 0);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(104, 15);
            lbConfirm.TabIndex = 3;
            lbConfirm.Text = "Confirm Password";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(30, 148);
            lbFullname.Margin = new Padding(2, 0, 2, 0);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(61, 15);
            lbFullname.TabIndex = 4;
            lbFullname.Text = "Full Name";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(30, 202);
            lbGender.Margin = new Padding(2, 0, 2, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // lbDateBirth
            // 
            lbDateBirth.AutoSize = true;
            lbDateBirth.Location = new Point(30, 175);
            lbDateBirth.Margin = new Padding(2, 0, 2, 0);
            lbDateBirth.Name = "lbDateBirth";
            lbDateBirth.Size = new Size(73, 15);
            lbDateBirth.TabIndex = 6;
            lbDateBirth.Text = "Date of Birth";
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(30, 223);
            lbMail.Margin = new Padding(2, 0, 2, 0);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(36, 15);
            lbMail.TabIndex = 7;
            lbMail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(29, 249);
            lbPhone.Margin = new Padding(2, 0, 2, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(88, 15);
            lbPhone.TabIndex = 8;
            lbPhone.Text = "Phone Number";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(143, 65);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(206, 23);
            txtUsername.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(143, 146);
            txtFullname.Margin = new Padding(2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(206, 23);
            txtFullname.TabIndex = 10;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(143, 119);
            txtConfirm.Margin = new Padding(2);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(206, 23);
            txtConfirm.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 92);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 23);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // mtxtDateBirth
            // 
            mtxtDateBirth.Location = new Point(143, 173);
            mtxtDateBirth.Margin = new Padding(2);
            mtxtDateBirth.Mask = "00/00/0000";
            mtxtDateBirth.Name = "mtxtDateBirth";
            mtxtDateBirth.Size = new Size(206, 23);
            mtxtDateBirth.TabIndex = 13;
            mtxtDateBirth.ValidatingType = typeof(DateTime);
            // 
            // lbMale
            // 
            lbMale.AutoSize = true;
            lbMale.Location = new Point(177, 200);
            lbMale.Margin = new Padding(2);
            lbMale.Name = "lbMale";
            lbMale.Size = new Size(51, 19);
            lbMale.TabIndex = 14;
            lbMale.TabStop = true;
            lbMale.Text = "Male";
            lbMale.UseVisualStyleBackColor = true;
            // 
            // lbFemale
            // 
            lbFemale.AutoSize = true;
            lbFemale.Location = new Point(248, 200);
            lbFemale.Margin = new Padding(2);
            lbFemale.Name = "lbFemale";
            lbFemale.Size = new Size(63, 19);
            lbFemale.TabIndex = 15;
            lbFemale.TabStop = true;
            lbFemale.Text = "Female";
            lbFemale.UseVisualStyleBackColor = true;
            // 
            // chkInstructor
            // 
            chkInstructor.AutoSize = true;
            chkInstructor.Location = new Point(143, 279);
            chkInstructor.Margin = new Padding(2);
            chkInstructor.Name = "chkInstructor";
            chkInstructor.Size = new Size(113, 19);
            chkInstructor.TabIndex = 18;
            chkInstructor.Text = "I'm an instructor";
            chkInstructor.UseVisualStyleBackColor = true;
            // 
            // chkAccept
            // 
            chkAccept.AutoSize = true;
            chkAccept.Location = new Point(143, 300);
            chkAccept.Margin = new Padding(2);
            chkAccept.Name = "chkAccept";
            chkAccept.Size = new Size(235, 19);
            chkAccept.TabIndex = 19;
            chkAccept.TabStop = false;
            chkAccept.Text = "I agree to YogaCenter's Terms of Service";
            chkAccept.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(143, 337);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(205, 27);
            btRegister.TabIndex = 20;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(209, 248);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(206, 23);
            txtPhone.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(143, 221);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 21;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 397);
            Controls.Add(txtEmail);
            Controls.Add(btRegister);
            Controls.Add(chkAccept);
            Controls.Add(chkInstructor);
            Controls.Add(lbFemale);
            Controls.Add(lbMale);
            Controls.Add(mtxtDateBirth);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirm);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(lbPhone);
            Controls.Add(lbMail);
            Controls.Add(lbDateBirth);
            Controls.Add(lbGender);
            Controls.Add(lbFullname);
            Controls.Add(lbConfirm);
            Controls.Add(lbRegister);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Margin = new Padding(2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private Label lbRegister;
        private Label lbConfirm;
        private Label lbFullname;
        private Label lbGender;
        private Label lbDateBirth;
        private Label lbMail;
        private Label lbPhone;
        private TextBox txtUsername;
        private TextBox txtFullname;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private MaskedTextBox mtxtDateBirth;
        private RadioButton lbMale;
        private RadioButton lbFemale;
        private CheckBox chkInstructor;
        private CheckBox chkAccept;
        private Button btRegister;
        private TextBox txtPhone;
        private TextBox txtEmail;
    }
}