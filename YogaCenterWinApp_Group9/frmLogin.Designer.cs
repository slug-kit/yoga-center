using System.Configuration;
using System.Configuration.Internal;
using Microsoft.Extensions.Configuration;

namespace YogaCenterWinApp_Group9
{
    partial class frmLogin
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
            lbEmail = new Label();
            lbPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lbLogin = new Label();
            btLogin = new Button();
            btRegister = new Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(160, 98);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(160, 130);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 97);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(244, 128);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(239, 23);
            lbLogin.Margin = new Padding(2, 0, 2, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(178, 41);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login Form";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(244, 164);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(78, 28);
            btLogin.TabIndex = 5;
            btLogin.Text = "&Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btnLogin_Click;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(344, 164);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(78, 28);
            btRegister.TabIndex = 6;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 304);
            Controls.Add(btRegister);
            Controls.Add(btLogin);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Margin = new Padding(2);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbLogin;
        private Button btLogin;
        private Button btRegister;
    }
}