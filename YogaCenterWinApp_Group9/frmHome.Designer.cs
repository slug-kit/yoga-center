﻿namespace YogaCenterWinApp_Group9
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
            pictureBox1 = new PictureBox();
            lbWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbWelcome
            // 
            lbWelcome.Anchor = AnchorStyles.None;
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Blackadder ITC", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbWelcome.Location = new Point(139, 9);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(642, 82);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "Welcome to the Yoga Center";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(lbWelcome);
            Controls.Add(pictureBox1);
            Name = "frmHome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbWelcome;
    }
}