namespace YogaCenterWinApp_Group9
{
    partial class frmReviewProgram
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
            lbDescription = new Label();
            richTextBox2 = new RichTextBox();
            label9 = new Label();
            starRatingControl1 = new Controls.StarRatingControl();
            SuspendLayout();
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescription.Location = new Point(25, 90);
            lbDescription.Margin = new Padding(4, 0, 4, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(74, 25);
            lbDescription.TabIndex = 47;
            lbDescription.Text = "Review";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(13, 126);
            richTextBox2.Margin = new Padding(4, 4, 4, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox2.Size = new Size(358, 189);
            richTextBox2.TabIndex = 46;
            richTextBox2.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 30);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 44;
            label9.Text = "Rating";
            // 
            // starRatingControl1
            // 
            starRatingControl1.BottomMargin = 2;
            starRatingControl1.HoverColor = Color.Yellow;
            starRatingControl1.LeftMargin = 2;
            starRatingControl1.Location = new Point(168, 30);
            starRatingControl1.Margin = new Padding(4, 4, 4, 4);
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
            starRatingControl1.TabIndex = 45;
            starRatingControl1.Text = "starRatingControl1";
            starRatingControl1.TopMargin = 2;
            // 
            // frmReviewProgram
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 341);
            Controls.Add(lbDescription);
            Controls.Add(richTextBox2);
            Controls.Add(label9);
            Controls.Add(starRatingControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmReviewProgram";
            Text = "frmReviewProgram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDescription;
        private RichTextBox richTextBox2;
        private Label label9;
        private Controls.StarRatingControl starRatingControl1;
    }
}