namespace YogaCenterWinApp_Group9
{
    partial class frmRateInstructor
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
            label9 = new Label();
            starRatingControl1 = new Controls.StarRatingControl();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 30);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 46;
            label9.Text = "Rating";
            // 
            // starRatingControl1
            // 
            starRatingControl1.BottomMargin = 2;
            starRatingControl1.HoverColor = Color.Yellow;
            starRatingControl1.LeftMargin = 2;
            starRatingControl1.Location = new Point(185, 30);
            starRatingControl1.Margin = new Padding(4);
            starRatingControl1.Name = "starRatingControl1";
            starRatingControl1.OutlineColor = Color.DimGray;
            starRatingControl1.OutlineThickness = 2;
            starRatingControl1.ReadOnly = false;
            starRatingControl1.RightMargin = 2;
            starRatingControl1.SelectedColor = Color.Gold;
            starRatingControl1.SelectedStar = 0;
            starRatingControl1.Size = new Size(154, 25);
            starRatingControl1.StarCount = 5;
            starRatingControl1.StarSpacing = 8;
            starRatingControl1.TabIndex = 47;
            starRatingControl1.Text = "starRatingControl1";
            starRatingControl1.TopMargin = 2;
            // 
            // frmRateInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 86);
            Controls.Add(label9);
            Controls.Add(starRatingControl1);
            Name = "frmRateInstructor";
            Text = "frmRateInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Controls.StarRatingControl starRatingControl1;
    }
}