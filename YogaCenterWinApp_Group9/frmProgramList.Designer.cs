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
            dgvPrograms = new DataGridView();
            lbProgram = new Label();
            lbFilterName = new Label();
            txtFilterName = new TextBox();
            lbFilter = new Label();
            lbFilterFee = new Label();
            btnApply = new Button();
            pictureBox = new PictureBox();
            txtName = new TextBox();
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
            pnlFilters = new Panel();
            pnlDetails = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            pnlFilters.SuspendLayout();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrograms
            // 
            dgvPrograms.AllowUserToAddRows = false;
            dgvPrograms.AllowUserToDeleteRows = false;
            dgvPrograms.AllowUserToResizeRows = false;
            dgvPrograms.Anchor = AnchorStyles.None;
            dgvPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrograms.Location = new Point(10, 202);
            dgvPrograms.Margin = new Padding(4);
            dgvPrograms.Name = "dgvPrograms";
            dgvPrograms.RowTemplate.Height = 25;
            dgvPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrograms.Size = new Size(636, 326);
            dgvPrograms.TabIndex = 0;
            dgvPrograms.CellFormatting += dgvPrograms_CellFormatting;
            // 
            // lbProgram
            // 
            lbProgram.Anchor = AnchorStyles.None;
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
            lbFilterName.Location = new Point(4, 10);
            lbFilterName.Margin = new Padding(4, 0, 4, 0);
            lbFilterName.Name = "lbFilterName";
            lbFilterName.Size = new Size(52, 21);
            lbFilterName.TabIndex = 2;
            lbFilterName.Text = "Name";
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(90, 7);
            txtFilterName.Margin = new Padding(4);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(200, 29);
            txtFilterName.TabIndex = 3;
            // 
            // lbFilter
            // 
            lbFilter.Anchor = AnchorStyles.None;
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
            lbFilterFee.Location = new Point(4, 50);
            lbFilterFee.Margin = new Padding(4, 0, 4, 0);
            lbFilterFee.Name = "lbFilterFee";
            lbFilterFee.Size = new Size(34, 21);
            lbFilterFee.TabIndex = 5;
            lbFilterFee.Text = "Fee";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(25, 123);
            btnApply.Margin = new Padding(4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(96, 32);
            btnApply.TabIndex = 7;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // pictureBox
            // 
            pictureBox.ImageLocation = ".\\Images\\Ashtanga-Yoga.jpg";
            pictureBox.Location = new Point(9, 5);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(320, 160);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 182);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(225, 29);
            txtName.TabIndex = 10;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(9, 185);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(52, 21);
            lbName.TabIndex = 9;
            lbName.Text = "Name";
            // 
            // lbRating
            // 
            lbRating.AutoSize = true;
            lbRating.Location = new Point(9, 230);
            lbRating.Margin = new Padding(4, 0, 4, 0);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(55, 21);
            lbRating.TabIndex = 11;
            lbRating.Text = "Rating";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(102, 272);
            txtFee.Margin = new Padding(4);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(96, 29);
            txtFee.TabIndex = 14;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(9, 275);
            lbFee.Margin = new Padding(4, 0, 4, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(34, 21);
            lbFee.TabIndex = 13;
            lbFee.Text = "Fee";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(9, 320);
            lbDescription.Margin = new Padding(4, 0, 4, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 15;
            lbDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(9, 345);
            rtbDescription.Margin = new Padding(4);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.Size = new Size(318, 128);
            rtbDescription.TabIndex = 16;
            rtbDescription.Text = "";
            // 
            // btnCourses
            // 
            btnCourses.Anchor = AnchorStyles.None;
            btnCourses.Location = new Point(669, 496);
            btnCourses.Margin = new Padding(4);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(320, 32);
            btnCourses.TabIndex = 17;
            btnCourses.Text = "See available courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // lbFilterInstructor
            // 
            lbFilterInstructor.AutoSize = true;
            lbFilterInstructor.Location = new Point(4, 90);
            lbFilterInstructor.Margin = new Padding(4, 0, 4, 0);
            lbFilterInstructor.Name = "lbFilterInstructor";
            lbFilterInstructor.Size = new Size(77, 21);
            lbFilterInstructor.TabIndex = 18;
            lbFilterInstructor.Text = "Instructor";
            // 
            // txtFilterInstructor
            // 
            txtFilterInstructor.Location = new Point(90, 87);
            txtFilterInstructor.Margin = new Padding(4);
            txtFilterInstructor.Name = "txtFilterInstructor";
            txtFilterInstructor.Size = new Size(200, 29);
            txtFilterInstructor.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(170, 123);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 32);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtFilterFeeLow
            // 
            txtFilterFeeLow.Location = new Point(90, 47);
            txtFilterFeeLow.Margin = new Padding(4);
            txtFilterFeeLow.Name = "txtFilterFeeLow";
            txtFilterFeeLow.Size = new Size(70, 29);
            txtFilterFeeLow.TabIndex = 6;
            txtFilterFeeLow.KeyPress += FilterFee_KeyPress;
            txtFilterFeeLow.Validating += FilterFee_Validating;
            txtFilterFeeLow.Validated += FilterFee_Validated;
            // 
            // lbFilterFeeTo
            // 
            lbFilterFeeTo.AutoSize = true;
            lbFilterFeeTo.Location = new Point(181, 50);
            lbFilterFeeTo.Margin = new Padding(4, 0, 4, 0);
            lbFilterFeeTo.Name = "lbFilterFeeTo";
            lbFilterFeeTo.Size = new Size(24, 21);
            lbFilterFeeTo.TabIndex = 21;
            lbFilterFeeTo.Text = "to";
            // 
            // txtFilterFeeHigh
            // 
            txtFilterFeeHigh.Location = new Point(220, 47);
            txtFilterFeeHigh.Margin = new Padding(4);
            txtFilterFeeHigh.Name = "txtFilterFeeHigh";
            txtFilterFeeHigh.Size = new Size(70, 29);
            txtFilterFeeHigh.TabIndex = 22;
            txtFilterFeeHigh.KeyPress += FilterFee_KeyPress;
            txtFilterFeeHigh.Validating += FilterFee_Validating;
            txtFilterFeeHigh.Validated += FilterFee_Validated;
            // 
            // starRatingControl
            // 
            starRatingControl.BottomMargin = 2;
            starRatingControl.HoverColor = Color.Yellow;
            starRatingControl.LeftMargin = 2;
            starRatingControl.Location = new Point(102, 230);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.OutlineColor = Color.DarkGray;
            starRatingControl.OutlineThickness = 1;
            starRatingControl.ReadOnly = true;
            starRatingControl.RightMargin = 2;
            starRatingControl.SelectedColor = Color.Gold;
            starRatingControl.SelectedStar = 0;
            starRatingControl.Size = new Size(116, 21);
            starRatingControl.StarCount = 5;
            starRatingControl.StarSpacing = 8;
            starRatingControl.TabIndex = 23;
            starRatingControl.TopMargin = 2;
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.None;
            pnlFilters.Controls.Add(lbFilterName);
            pnlFilters.Controls.Add(btnClear);
            pnlFilters.Controls.Add(lbFilterFeeTo);
            pnlFilters.Controls.Add(txtFilterInstructor);
            pnlFilters.Controls.Add(txtFilterFeeHigh);
            pnlFilters.Controls.Add(lbFilterFee);
            pnlFilters.Controls.Add(txtFilterName);
            pnlFilters.Controls.Add(lbFilterInstructor);
            pnlFilters.Controls.Add(txtFilterFeeLow);
            pnlFilters.Controls.Add(btnApply);
            pnlFilters.Location = new Point(318, 35);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(298, 160);
            pnlFilters.TabIndex = 24;
            // 
            // pnlDetails
            // 
            pnlDetails.Anchor = AnchorStyles.None;
            pnlDetails.Controls.Add(starRatingControl);
            pnlDetails.Controls.Add(rtbDescription);
            pnlDetails.Controls.Add(pictureBox);
            pnlDetails.Controls.Add(txtFee);
            pnlDetails.Controls.Add(lbName);
            pnlDetails.Controls.Add(lbRating);
            pnlDetails.Controls.Add(lbDescription);
            pnlDetails.Controls.Add(txtName);
            pnlDetails.Controls.Add(lbFee);
            pnlDetails.Location = new Point(660, 8);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(338, 481);
            pnlDetails.TabIndex = 25;
            // 
            // frmProgramList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 541);
            Controls.Add(btnCourses);
            Controls.Add(lbFilter);
            Controls.Add(lbProgram);
            Controls.Add(dgvPrograms);
            Controls.Add(pnlFilters);
            Controls.Add(pnlDetails);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmProgramList";
            Text = "Program List";
            Load += frmProgramList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrograms;
        private Label lbProgram;
        private Label lbFilterName;
        private TextBox txtFilterName;
        private Label lbFilter;
        private Label lbFilterFee;
        private Button btnApply;
        private PictureBox pictureBox;
        private TextBox txtName;
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
        private Panel pnlFilters;
        private Panel pnlDetails;
    }
}