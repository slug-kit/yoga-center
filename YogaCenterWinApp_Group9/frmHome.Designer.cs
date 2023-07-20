namespace YogaCenterWinApp_Group9
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            pictureBox = new PictureBox();
            lbWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox.Location = new Point(72, 143);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(998, 596);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lbWelcome
            // 
            lbWelcome.Anchor = AnchorStyles.None;
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Blackadder ITC", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbWelcome.Location = new Point(255, 40);
            lbWelcome.Margin = new Padding(4, 0, 4, 0);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(642, 82);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Welcome to the Yoga Center";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 785);
            Controls.Add(lbWelcome);
            Controls.Add(pictureBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmHome";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label lbWelcome;
    }
}