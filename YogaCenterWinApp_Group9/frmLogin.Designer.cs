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
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbLogin = new Label();
            btLogin = new Button();
            btRegister = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.Anchor = AnchorStyles.None;
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(206, 137);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(81, 21);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.None;
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(206, 182);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(76, 21);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(314, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 29);
            txtUsername.TabIndex = 2;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(314, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lbLogin
            // 
            lbLogin.Anchor = AnchorStyles.None;
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(307, 32);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(178, 41);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login Form";
            // 
            // btLogin
            // 
            btLogin.Anchor = AnchorStyles.None;
            btLogin.Location = new Point(314, 230);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 39);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btnLogin_Click;
            // 
            // btRegister
            // 
            btRegister.Anchor = AnchorStyles.None;
            btRegister.Location = new Point(442, 230);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(100, 39);
            btRegister.TabIndex = 6;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 343);
            Controls.Add(btRegister);
            Controls.Add(btLogin);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private Label lbLogin;
        private Button btLogin;
        private Button btRegister;
    }
}