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
            lbMale = new RadioButton();
            lbFemale = new RadioButton();
            chkInstructor = new CheckBox();
            chkAccept = new CheckBox();
            btRegister = new Button();
            txtEmail = new TextBox();
            dtpDob = new DateTimePicker();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.Anchor = AnchorStyles.None;
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(37, 94);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(81, 21);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.None;
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(37, 130);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(76, 21);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbRegister
            // 
            lbRegister.Anchor = AnchorStyles.None;
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegister.Location = new Point(260, 22);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(113, 40);
            lbRegister.TabIndex = 0;
            lbRegister.Text = "Signup";
            // 
            // lbConfirm
            // 
            lbConfirm.Anchor = AnchorStyles.None;
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new Point(37, 169);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(137, 21);
            lbConfirm.TabIndex = 5;
            lbConfirm.Text = "Confirm Password";
            // 
            // lbFullname
            // 
            lbFullname.Anchor = AnchorStyles.None;
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(37, 207);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(81, 21);
            lbFullname.TabIndex = 7;
            lbFullname.Text = "Full Name";
            // 
            // lbGender
            // 
            lbGender.Anchor = AnchorStyles.None;
            lbGender.AutoSize = true;
            lbGender.Location = new Point(37, 278);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(61, 21);
            lbGender.TabIndex = 11;
            lbGender.Text = "Gender";
            // 
            // lbDateBirth
            // 
            lbDateBirth.Anchor = AnchorStyles.None;
            lbDateBirth.AutoSize = true;
            lbDateBirth.Location = new Point(37, 245);
            lbDateBirth.Name = "lbDateBirth";
            lbDateBirth.Size = new Size(97, 21);
            lbDateBirth.TabIndex = 9;
            lbDateBirth.Text = "Date of Birth";
            // 
            // lbMail
            // 
            lbMail.Anchor = AnchorStyles.None;
            lbMail.AutoSize = true;
            lbMail.Location = new Point(37, 312);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(48, 21);
            lbMail.TabIndex = 14;
            lbMail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.None;
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(37, 349);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(116, 21);
            lbPhone.TabIndex = 16;
            lbPhone.Text = "Phone Number";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(184, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(264, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtFullname
            // 
            txtFullname.Anchor = AnchorStyles.None;
            txtFullname.Location = new Point(184, 204);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(264, 29);
            txtFullname.TabIndex = 8;
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.None;
            txtConfirm.Location = new Point(184, 167);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(264, 29);
            txtConfirm.TabIndex = 6;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(184, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbMale
            // 
            lbMale.Anchor = AnchorStyles.None;
            lbMale.AutoSize = true;
            lbMale.Location = new Point(228, 278);
            lbMale.Name = "lbMale";
            lbMale.Size = new Size(62, 25);
            lbMale.TabIndex = 12;
            lbMale.TabStop = true;
            lbMale.Text = "Male";
            lbMale.UseVisualStyleBackColor = true;
            // 
            // lbFemale
            // 
            lbFemale.Anchor = AnchorStyles.None;
            lbFemale.AutoSize = true;
            lbFemale.Location = new Point(319, 278);
            lbFemale.Name = "lbFemale";
            lbFemale.Size = new Size(78, 25);
            lbFemale.TabIndex = 13;
            lbFemale.TabStop = true;
            lbFemale.Text = "Female";
            lbFemale.UseVisualStyleBackColor = true;
            // 
            // chkInstructor
            // 
            chkInstructor.Anchor = AnchorStyles.None;
            chkInstructor.AutoSize = true;
            chkInstructor.Location = new Point(184, 391);
            chkInstructor.Name = "chkInstructor";
            chkInstructor.Size = new Size(143, 25);
            chkInstructor.TabIndex = 18;
            chkInstructor.Text = "I'm an instructor";
            chkInstructor.UseVisualStyleBackColor = true;
            // 
            // chkAccept
            // 
            chkAccept.Anchor = AnchorStyles.None;
            chkAccept.AutoSize = true;
            chkAccept.Location = new Point(184, 420);
            chkAccept.Name = "chkAccept";
            chkAccept.Size = new Size(306, 25);
            chkAccept.TabIndex = 19;
            chkAccept.TabStop = false;
            chkAccept.Text = "I agree to YogaCenter's Terms of Service";
            chkAccept.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            btRegister.Anchor = AnchorStyles.None;
            btRegister.Location = new Point(184, 472);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(264, 38);
            btRegister.TabIndex = 20;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.ForeColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(184, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 29);
            txtEmail.TabIndex = 15;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // dtpDob
            // 
            dtpDob.Anchor = AnchorStyles.None;
            dtpDob.Location = new Point(184, 241);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(264, 29);
            dtpDob.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.ForeColor = SystemColors.InactiveCaption;
            txtPhone.Location = new Point(184, 346);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 29);
            txtPhone.TabIndex = 17;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 556);
            Controls.Add(txtPhone);
            Controls.Add(dtpDob);
            Controls.Add(txtEmail);
            Controls.Add(btRegister);
            Controls.Add(chkAccept);
            Controls.Add(chkInstructor);
            Controls.Add(lbFemale);
            Controls.Add(lbMale);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
        private RadioButton lbMale;
        private RadioButton lbFemale;
        private CheckBox chkInstructor;
        private CheckBox chkAccept;
        private Button btRegister;
        private TextBox txtEmail;
        private DateTimePicker dtpDob;
        private TextBox txtPhone;
    }
}