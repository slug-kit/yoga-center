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
            textBox5 = new TextBox();
            lbCode = new Label();
            textBox4 = new TextBox();
            button5 = new Button();
            numericUpDown2 = new NumericUpDown();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            btnsearch = new Button();
            txtSearchName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btndelete = new Button();
            btnnew = new Button();
            dgvprogram = new DataGridView();
            starRatingControl = new Controls.StarRatingControl();
            textBox1 = new TextBox();
            label9 = new Label();
            lbDescription = new Label();
            pictureBox1 = new PictureBox();
            txtboxdescription = new RichTextBox();
            txtfee = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvprogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer.Panel1.Controls.Add(dgvprogram);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(starRatingControl);
            splitContainer.Panel2.Controls.Add(textBox1);
            splitContainer.Panel2.Controls.Add(label9);
            splitContainer.Panel2.Controls.Add(lbDescription);
            splitContainer.Panel2.Controls.Add(pictureBox1);
            splitContainer.Panel2.Controls.Add(txtboxdescription);
            splitContainer.Panel2.Controls.Add(txtfee);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.Controls.Add(label2);
            splitContainer.Size = new Size(1029, 630);
            splitContainer.SplitterDistance = 588;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(lbCode);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDown1);
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
            // textBox5
            // 
            textBox5.Location = new Point(180, 77);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 29);
            textBox5.TabIndex = 19;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(100, 80);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(49, 21);
            lbCode.TabIndex = 18;
            lbCode.Text = "Code:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 144);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 15;
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
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(290, 195);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(50, 29);
            numericUpDown2.TabIndex = 13;
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
            // textBox3
            // 
            textBox3.Location = new Point(180, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 10;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(180, 195);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 29);
            numericUpDown1.TabIndex = 6;
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
            // dgvprogram
            // 
            dgvprogram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprogram.Location = new Point(12, 247);
            dgvprogram.Name = "dgvprogram";
            dgvprogram.RowHeadersWidth = 51;
            dgvprogram.RowTemplate.Height = 25;
            dgvprogram.Size = new Size(563, 274);
            dgvprogram.TabIndex = 0;
            dgvprogram.CellDoubleClick += dgvprogram_CellDoubleClick;
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
            // textBox1
            // 
            textBox1.Location = new Point(80, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 29);
            textBox1.TabIndex = 10;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            // txtfee
            // 
            txtfee.Location = new Point(310, 247);
            txtfee.Name = "txtfee";
            txtfee.Size = new Size(86, 29);
            txtfee.TabIndex = 7;
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
            label2.Location = new Point(250, 250);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvprogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label lbDescription;
        private RichTextBox txtboxdescription;
        private PictureBox pictureBox1;
        private TextBox txtfee;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvprogram;
        private Button btndelete;
        private Button btnnew;
        private GroupBox groupBox2;
        private Button btnsearch;
        private TextBox txtSearchName;
        private Label label3;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Button button5;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox5;
        private Label lbCode;
        private Controls.StarRatingControl starRatingControl;
    }
}
