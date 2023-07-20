namespace YogaCenterWinApp_Group9
{
    partial class frmProgramManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramManagement));
            splitContainer = new SplitContainer();
            groupBox2 = new GroupBox();
            txtMaxRating = new TextBox();
            txtMinRating = new TextBox();
            txtSearchCode = new TextBox();
            lbSearchCode = new Label();
            txtMaxFee = new TextBox();
            button5 = new Button();
            label8 = new Label();
            txtMinFee = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnsearch = new Button();
            txtSearchName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btndelete = new Button();
            btnnew = new Button();
            dgvPrograms = new DataGridView();
            txtCode = new TextBox();
            lbCode = new Label();
            starRatingControl = new Controls.StarRatingControl();
            txtName = new TextBox();
            label9 = new Label();
            lbDescription = new Label();
            pictureBox = new PictureBox();
            txtboxdescription = new RichTextBox();
            txtFee = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.None;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBox2);
            splitContainer.Panel1.Controls.Add(groupBox1);
            splitContainer.Panel1.Controls.Add(dgvPrograms);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(txtCode);
            splitContainer.Panel2.Controls.Add(lbCode);
            splitContainer.Panel2.Controls.Add(starRatingControl);
            splitContainer.Panel2.Controls.Add(txtName);
            splitContainer.Panel2.Controls.Add(label9);
            splitContainer.Panel2.Controls.Add(lbDescription);
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Panel2.Controls.Add(txtboxdescription);
            splitContainer.Panel2.Controls.Add(txtFee);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.Controls.Add(label2);
            splitContainer.Size = new Size(1029, 630);
            splitContainer.SplitterDistance = 588;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaxRating);
            groupBox2.Controls.Add(txtMinRating);
            groupBox2.Controls.Add(txtSearchCode);
            groupBox2.Controls.Add(lbSearchCode);
            groupBox2.Controls.Add(txtMaxFee);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMinFee);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnsearch);
            groupBox2.Controls.Add(txtSearchName);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 235);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // txtMaxRating
            // 
            txtMaxRating.Location = new Point(280, 197);
            txtMaxRating.Name = "txtMaxRating";
            txtMaxRating.Size = new Size(66, 29);
            txtMaxRating.TabIndex = 21;
            // 
            // txtMinRating
            // 
            txtMinRating.Location = new Point(178, 197);
            txtMinRating.Name = "txtMinRating";
            txtMinRating.Size = new Size(66, 29);
            txtMinRating.TabIndex = 20;
            // 
            // txtSearchCode
            // 
            txtSearchCode.Location = new Point(180, 77);
            txtSearchCode.Name = "txtSearchCode";
            txtSearchCode.Size = new Size(122, 29);
            txtSearchCode.TabIndex = 19;
            // 
            // lbSearchCode
            // 
            lbSearchCode.AutoSize = true;
            lbSearchCode.Location = new Point(100, 80);
            lbSearchCode.Name = "lbSearchCode";
            lbSearchCode.Size = new Size(49, 21);
            lbSearchCode.TabIndex = 18;
            lbSearchCode.Text = "Code:";
            // 
            // txtMaxFee
            // 
            txtMaxFee.Location = new Point(340, 144);
            txtMaxFee.Name = "txtMaxFee";
            txtMaxFee.Size = new Size(100, 29);
            txtMaxFee.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(15, 143);
            button5.Name = "button5";
            button5.Size = new Size(64, 29);
            button5.TabIndex = 14;
            button5.Text = "Clear All";
            button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 147);
            label8.Name = "label8";
            label8.Size = new Size(24, 21);
            label8.TabIndex = 11;
            label8.Text = "to";
            // 
            // txtMinFee
            // 
            txtMinFee.Location = new Point(180, 144);
            txtMinFee.Name = "txtMinFee";
            txtMinFee.Size = new Size(100, 29);
            txtMinFee.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 147);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 9;
            label7.Text = "Fee:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 197);
            label6.Name = "label6";
            label6.Size = new Size(24, 21);
            label6.TabIndex = 7;
            label6.Text = "to";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 197);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 5;
            label5.Text = "Rating:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 115);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "FILTERS:";
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(438, 51);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(100, 40);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(180, 27);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 29);
            txtSearchName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 30);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(btnnew);
            groupBox1.Location = new Point(12, 518);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(306, 41);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(100, 40);
            btndelete.TabIndex = 2;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnnew
            // 
            btnnew.Location = new Point(130, 41);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(100, 40);
            btnnew.TabIndex = 0;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // dgvPrograms
            // 
            dgvPrograms.AllowUserToAddRows = false;
            dgvPrograms.AllowUserToDeleteRows = false;
            dgvPrograms.AllowUserToResizeRows = false;
            dgvPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrograms.Location = new Point(12, 247);
            dgvPrograms.Name = "dgvPrograms";
            dgvPrograms.ReadOnly = true;
            dgvPrograms.RowHeadersWidth = 51;
            dgvPrograms.RowTemplate.Height = 25;
            dgvPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrograms.Size = new Size(563, 274);
            dgvPrograms.TabIndex = 0;
            dgvPrograms.CellDoubleClick += dgvprogram_CellDoubleClick;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(310, 247);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(114, 29);
            txtCode.TabIndex = 20;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(250, 250);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(46, 21);
            lbCode.TabIndex = 12;
            lbCode.Text = "Code";
            // 
            // starRatingControl
            // 
            starRatingControl.BottomMargin = 2;
            starRatingControl.HoverColor = Color.Gold;
            starRatingControl.LeftMargin = 2;
            starRatingControl.Location = new Point(80, 300);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.OutlineColor = Color.DarkGray;
            starRatingControl.OutlineThickness = 1;
            starRatingControl.ReadOnly = false;
            starRatingControl.RightMargin = 2;
            starRatingControl.SelectedColor = Color.Gold;
            starRatingControl.SelectedStar = 4;
            starRatingControl.Size = new Size(132, 21);
            starRatingControl.StarCount = 5;
            starRatingControl.StarSpacing = 8;
            starRatingControl.TabIndex = 11;
            starRatingControl.TopMargin = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 247);
            txtName.Name = "txtName";
            txtName.Size = new Size(115, 29);
            txtName.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 250);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 9;
            label9.Text = "Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(12, 350);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(412, 216);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // txtboxdescription
            // 
            txtboxdescription.Location = new Point(12, 374);
            txtboxdescription.Name = "txtboxdescription";
            txtboxdescription.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtboxdescription.Size = new Size(412, 244);
            txtboxdescription.TabIndex = 1;
            txtboxdescription.Text = "";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(310, 297);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(86, 29);
            txtFee.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 300);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 3;
            label1.Text = "Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 300);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 6;
            label2.Text = "Fee";
            // 
            // frmProgramManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmProgramManagement";
            Text = "Program Management";
            Load += frmProgramManagement_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label lbDescription;
        private RichTextBox txtboxdescription;
        private PictureBox pictureBox;
        private TextBox txtFee;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvPrograms;
        private Button btndelete;
        private Button btnnew;
        private GroupBox groupBox2;
        private Button btnsearch;
        private TextBox txtSearchName;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMaxFee;
        private Button button5;
        private Label label8;
        private TextBox txtMinFee;
        private Label label7;
        private TextBox txtName;
        private Label label9;
        private TextBox txtSearchCode;
        private Label lbSearchCode;
        private Controls.StarRatingControl starRatingControl;
        private Label lbCode;
        private TextBox txtCode;
        private TextBox txtMaxRating;
        private TextBox txtMinRating;
    }
}
