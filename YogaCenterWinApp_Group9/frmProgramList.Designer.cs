namespace YogaCenterWinApp_Group9
{
    partial class frmProgramList
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
            dgvListProgram = new DataGridView();
            lbProgram = new Label();
            lbFilterName = new Label();
            txtFilterName = new TextBox();
            lbFilter = new Label();
            lbFilterFee = new Label();
            btnApply = new Button();
            pictureBox = new PictureBox();
            textBox1 = new TextBox();
            lbName = new Label();
            lbRating = new Label();
            txtFee = new TextBox();
            lbFee = new Label();
            lbDescription = new Label();
            rtbDescription = new RichTextBox();
            btnCourses = new Button();
            lbFilterInstructor = new Label();
            txtFilterInstructor = new TextBox();
            btnClear = new Button();
            txtFilterFeeLow = new TextBox();
            lbFilterFeeTo = new Label();
            txtFilterFeeHigh = new TextBox();
            starRatingControl = new Controls.StarRatingControl();
            pnlFilter = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListProgram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dgvListProgram
            // 
            dgvListProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProgram.Location = new Point(10, 202);
            dgvListProgram.Margin = new Padding(4);
            dgvListProgram.Name = "dgvListProgram";
            dgvListProgram.RowTemplate.Height = 25;
            dgvListProgram.Size = new Size(636, 279);
            dgvListProgram.TabIndex = 0;
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbProgram.Location = new Point(10, 63);
            lbProgram.Margin = new Padding(4, 0, 4, 0);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(193, 40);
            lbProgram.TabIndex = 1;
            lbProgram.Text = "Program List";
            // 
            // lbFilterName
            // 
            lbFilterName.AutoSize = true;
            lbFilterName.Location = new Point(325, 45);
            lbFilterName.Margin = new Padding(4, 0, 4, 0);
            lbFilterName.Name = "lbFilterName";
            lbFilterName.Size = new Size(52, 21);
            lbFilterName.TabIndex = 2;
            lbFilterName.Text = "Name";
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(408, 42);
            txtFilterName.Margin = new Padding(4);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(200, 29);
            txtFilterName.TabIndex = 3;
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFilter.Location = new Point(430, 2);
            lbFilter.Margin = new Padding(4, 0, 4, 0);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(93, 30);
            lbFilter.TabIndex = 4;
            lbFilter.Text = "Filter By";
            // 
            // lbFilterFee
            // 
            lbFilterFee.AutoSize = true;
            lbFilterFee.Location = new Point(325, 85);
            lbFilterFee.Margin = new Padding(4, 0, 4, 0);
            lbFilterFee.Name = "lbFilterFee";
            lbFilterFee.Size = new Size(34, 21);
            lbFilterFee.TabIndex = 5;
            lbFilterFee.Text = "Fee";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(345, 158);
            btnApply.Margin = new Padding(4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(96, 32);
            btnApply.TabIndex = 7;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(669, 17);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(320, 160);
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(762, 197);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 29);
            textBox1.TabIndex = 10;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(669, 202);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(52, 21);
            lbName.TabIndex = 9;
            lbName.Text = "Name";
            // 
            // lbRating
            // 
            lbRating.AutoSize = true;
            lbRating.Location = new Point(669, 242);
            lbRating.Margin = new Padding(4, 0, 4, 0);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(55, 21);
            lbRating.TabIndex = 11;
            lbRating.Text = "Rating";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(762, 279);
            txtFee.Margin = new Padding(4);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(96, 29);
            txtFee.TabIndex = 14;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(669, 283);
            lbFee.Margin = new Padding(4, 0, 4, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(34, 21);
            lbFee.TabIndex = 13;
            lbFee.Text = "Fee";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(669, 323);
            lbDescription.Margin = new Padding(4, 0, 4, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 15;
            lbDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(762, 323);
            rtbDescription.Margin = new Padding(4);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(225, 116);
            rtbDescription.TabIndex = 16;
            rtbDescription.Text = "";
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(669, 449);
            btnCourses.Margin = new Padding(4);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(320, 32);
            btnCourses.TabIndex = 17;
            btnCourses.Text = "See available courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // lbFilterInstructor
            // 
            lbFilterInstructor.AutoSize = true;
            lbFilterInstructor.Location = new Point(325, 125);
            lbFilterInstructor.Margin = new Padding(4, 0, 4, 0);
            lbFilterInstructor.Name = "lbFilterInstructor";
            lbFilterInstructor.Size = new Size(77, 21);
            lbFilterInstructor.TabIndex = 18;
            lbFilterInstructor.Text = "Instructor";
            // 
            // txtFilterInstructor
            // 
            txtFilterInstructor.Location = new Point(408, 122);
            txtFilterInstructor.Margin = new Padding(4);
            txtFilterInstructor.Name = "txtFilterInstructor";
            txtFilterInstructor.Size = new Size(200, 29);
            txtFilterInstructor.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(492, 158);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 32);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtFilterFeeLow
            // 
            txtFilterFeeLow.Location = new Point(408, 82);
            txtFilterFeeLow.Margin = new Padding(4);
            txtFilterFeeLow.Name = "txtFilterFeeLow";
            txtFilterFeeLow.Size = new Size(70, 29);
            txtFilterFeeLow.TabIndex = 6;
            // 
            // lbFilterFeeTo
            // 
            lbFilterFeeTo.AutoSize = true;
            lbFilterFeeTo.Location = new Point(500, 85);
            lbFilterFeeTo.Margin = new Padding(4, 0, 4, 0);
            lbFilterFeeTo.Name = "lbFilterFeeTo";
            lbFilterFeeTo.Size = new Size(24, 21);
            lbFilterFeeTo.TabIndex = 21;
            lbFilterFeeTo.Text = "to";
            // 
            // txtFilterFeeHigh
            // 
            txtFilterFeeHigh.Location = new Point(538, 82);
            txtFilterFeeHigh.Margin = new Padding(4);
            txtFilterFeeHigh.Name = "txtFilterFeeHigh";
            txtFilterFeeHigh.Size = new Size(70, 29);
            txtFilterFeeHigh.TabIndex = 22;
            // 
            // starRatingControl
            // 
            starRatingControl.BottomMargin = 2;
            starRatingControl.HoverColor = Color.Yellow;
            starRatingControl.LeftMargin = 2;
            starRatingControl.Location = new Point(762, 242);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.OutlineColor = Color.DarkGray;
            starRatingControl.OutlineThickness = 1;
            starRatingControl.ReadOnly = false;
            starRatingControl.RightMargin = 2;
            starRatingControl.SelectedColor = Color.RoyalBlue;
            starRatingControl.SelectedStar = 0;
            starRatingControl.Size = new Size(116, 21);
            starRatingControl.StarCount = 5;
            starRatingControl.StarSpacing = 8;
            starRatingControl.TabIndex = 23;
            starRatingControl.TopMargin = 2;
            // 
            // pnlFilter
            // 
            pnlFilter.Location = new Point(318, 35);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(298, 160);
            pnlFilter.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Location = new Point(660, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 437);
            panel1.TabIndex = 25;
            // 
            // frmProgramList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 490);
            Controls.Add(starRatingControl);
            Controls.Add(txtFilterFeeHigh);
            Controls.Add(lbFilterFeeTo);
            Controls.Add(btnClear);
            Controls.Add(txtFilterInstructor);
            Controls.Add(lbFilterInstructor);
            Controls.Add(btnCourses);
            Controls.Add(rtbDescription);
            Controls.Add(lbDescription);
            Controls.Add(txtFee);
            Controls.Add(lbFee);
            Controls.Add(lbRating);
            Controls.Add(textBox1);
            Controls.Add(lbName);
            Controls.Add(pictureBox);
            Controls.Add(btnApply);
            Controls.Add(txtFilterFeeLow);
            Controls.Add(lbFilterFee);
            Controls.Add(lbFilter);
            Controls.Add(txtFilterName);
            Controls.Add(lbFilterName);
            Controls.Add(lbProgram);
            Controls.Add(dgvListProgram);
            Controls.Add(pnlFilter);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmProgramList";
            Text = "ListProgram";
            Load += frmProgramList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListProgram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListProgram;
        private Label lbProgram;
        private Label lbFilterName;
        private TextBox txtFilterName;
        private Label lbFilter;
        private Label lbFilterFee;
        private Button btnApply;
        private PictureBox pictureBox;
        private TextBox textBox1;
        private Label lbName;
        private Label lbRating;
        private TextBox txtFee;
        private Label lbFee;
        private Label lbDescription;
        private RichTextBox rtbDescription;
        private Button btnCourses;
        private Label lbFilterInstructor;
        private TextBox txtFilterInstructor;
        private Button btnClear;
        private TextBox txtFilterFeeLow;
        private Label lbFilterFeeTo;
        private TextBox txtFilterFeeHigh;
        private Controls.StarRatingControl starRatingControl;
        private Panel pnlFilter;
        private Panel panel1;
    }
}