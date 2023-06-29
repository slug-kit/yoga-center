namespace YogaCenterWinApp_Group9
{
    partial class UserControlCalendarfordays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtdays = new Label();
            SuspendLayout();
            // 
            // txtdays
            // 
            txtdays.AutoSize = true;
            txtdays.Location = new Point(20, 24);
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(50, 20);
            txtdays.TabIndex = 0;
            txtdays.Text = "label1";
            txtdays.Click += label1_Click;
            // 
            // UserControlCalendarfordays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtdays);
            Name = "UserControlCalendarfordays";
            Size = new Size(147, 88);
            Load += UserControlCalendarfordays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdays;
    }
}
