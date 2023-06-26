using System.Configuration;
using System.Configuration.Internal;
using Microsoft.Extensions.Configuration;

namespace SalesManagementWinApp_BUIVUDUY
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbPassword = new Label();
            lbEmail = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(408, 255);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(210, 255);
            btnLogin.Margin = new Padding(5, 6, 5, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(210, 161);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(359, 29);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(210, 81);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(359, 29);
            txtEmail.TabIndex = 1;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.None;
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(98, 165);
            lbPassword.Margin = new Padding(5, 0, 5, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(76, 21);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.None;
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(98, 92);
            lbEmail.Margin = new Padding(5, 0, 5, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(48, 21);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 378);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "Login";
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
    }
}