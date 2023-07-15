namespace YogaCenterWinApp_Group9
{
    partial class frmLearningRecord
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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("In Progress", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Completed", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("Not Completed", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("Vinyasa Yoga", "Vinyasa-Yoga.jpg");
            ListViewItem listViewItem2 = new ListViewItem("Hatha Yoga", "Hatha-Yoga.jpg");
            ListViewItem listViewItem3 = new ListViewItem("Ashtanga Yoga", "Ashtanga-Yoga.jpg");
            ListViewItem listViewItem4 = new ListViewItem("Kundalini Yoga", "Kundalini-Yoga.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLearningRecord));
            mainSplitContainer = new SplitContainer();
            lsvCourses = new ListView();
            imageListGroups = new ImageList(components);
            imageListLarge = new ImageList(components);
            button3 = new Button();
            label19 = new Label();
            richTextBox3 = new RichTextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            richTextBox4 = new RichTextBox();
            lbDescription = new Label();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            starRatingControl = new Controls.StarRatingControl();
            progressBar1 = new ProgressBar();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Margin = new Padding(4);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(lsvCourses);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(button3);
            mainSplitContainer.Panel2.Controls.Add(label19);
            mainSplitContainer.Panel2.Controls.Add(richTextBox3);
            mainSplitContainer.Panel2.Controls.Add(label6);
            mainSplitContainer.Panel2.Controls.Add(pictureBox1);
            mainSplitContainer.Panel2.Controls.Add(label5);
            mainSplitContainer.Panel2.Controls.Add(comboBox1);
            mainSplitContainer.Panel2.Controls.Add(richTextBox4);
            mainSplitContainer.Panel2.Controls.Add(lbDescription);
            mainSplitContainer.Panel2.Controls.Add(richTextBox2);
            mainSplitContainer.Panel2.Controls.Add(textBox1);
            mainSplitContainer.Panel2.Controls.Add(label9);
            mainSplitContainer.Panel2.Controls.Add(starRatingControl);
            mainSplitContainer.Panel2.Controls.Add(progressBar1);
            mainSplitContainer.Panel2.Controls.Add(label8);
            mainSplitContainer.Panel2.Controls.Add(richTextBox1);
            mainSplitContainer.Panel2.Controls.Add(label7);
            mainSplitContainer.Panel2.Controls.Add(dateTimePicker2);
            mainSplitContainer.Panel2.Controls.Add(label4);
            mainSplitContainer.Panel2.Controls.Add(dateTimePicker1);
            mainSplitContainer.Panel2.Controls.Add(label3);
            mainSplitContainer.Panel2.Controls.Add(textBox2);
            mainSplitContainer.Panel2.Controls.Add(label2);
            mainSplitContainer.Panel2.Controls.Add(label1);
            mainSplitContainer.Size = new Size(1029, 630);
            mainSplitContainer.SplitterDistance = 625;
            mainSplitContainer.SplitterWidth = 5;
            mainSplitContainer.TabIndex = 0;
            // 
            // lsvCourses
            // 
            lsvCourses.Dock = DockStyle.Fill;
            lsvCourses.GroupImageList = imageListGroups;
            listViewGroup1.Header = "In Progress";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Completed";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "Not Completed";
            listViewGroup3.Name = "listViewGroup3";
            lsvCourses.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup3;
            lsvCourses.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            lsvCourses.LargeImageList = imageListLarge;
            lsvCourses.Location = new Point(0, 0);
            lsvCourses.Name = "lsvCourses";
            lsvCourses.Size = new Size(625, 630);
            lsvCourses.TabIndex = 0;
            lsvCourses.UseCompatibleStateImageBehavior = false;
            // 
            // imageListGroups
            // 
            imageListGroups.ColorDepth = ColorDepth.Depth32Bit;
            imageListGroups.ImageStream = (ImageListStreamer)resources.GetObject("imageListGroups.ImageStream");
            imageListGroups.TransparentColor = Color.Transparent;
            imageListGroups.Images.SetKeyName(0, "Course_InProgress.png");
            imageListGroups.Images.SetKeyName(1, "Couse_Completed.png");
            imageListGroups.Images.SetKeyName(2, "Course_NotCompleted.png");
            // 
            // imageListLarge
            // 
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListLarge.ImageStream");
            imageListLarge.TransparentColor = Color.Transparent;
            imageListLarge.Images.SetKeyName(0, "Ashtanga-Yoga.jpg");
            imageListLarge.Images.SetKeyName(1, "Hatha-Yoga.jpg");
            imageListLarge.Images.SetKeyName(2, "Kundalini-Yoga.jpg");
            imageListLarge.Images.SetKeyName(3, "Vinyasa-Yoga.jpg");
            // 
            // button3
            // 
            button3.Location = new Point(143, 573);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 51;
            button3.Text = "Leave a review";
            button3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 502);
            label19.Name = "label19";
            label19.Size = new Size(84, 21);
            label19.TabIndex = 49;
            label19.Text = "Experience";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(25, 526);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(343, 29);
            richTextBox3.TabIndex = 50;
            richTextBox3.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 433);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 47;
            label6.Text = "Specializations";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(250, 355);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 100);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 370);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 44;
            label5.Text = "Instructor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 394);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 29);
            comboBox1.TabIndex = 46;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(24, 461);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(344, 29);
            richTextBox4.TabIndex = 48;
            richTextBox4.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(24, 110);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 43;
            lbDescription.Text = "Description";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(24, 134);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox2.Size = new Size(344, 77);
            richTextBox2.TabIndex = 42;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 29);
            textBox1.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 80);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 39;
            label9.Text = "Rating";
            // 
            // starRatingControl
            // 
            starRatingControl.BottomMargin = 2;
            starRatingControl.HoverColor = Color.Gold;
            starRatingControl.LeftMargin = 2;
            starRatingControl.Location = new Point(105, 81);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.OutlineColor = Color.DimGray;
            starRatingControl.OutlineThickness = 1;
            starRatingControl.ReadOnly = true;
            starRatingControl.RightMargin = 2;
            starRatingControl.SelectedColor = Color.Gold;
            starRatingControl.SelectedStar = 4;
            starRatingControl.Size = new Size(120, 18);
            starRatingControl.StarCount = 5;
            starRatingControl.StarSpacing = 8;
            starRatingControl.TabIndex = 40;
            starRatingControl.Text = "starRatingControl1";
            starRatingControl.TopMargin = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 590);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(344, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 38;
            progressBar1.Value = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 563);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 37;
            label8.Text = "Progress";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 319);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(344, 29);
            richTextBox1.TabIndex = 35;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 295);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 34;
            label7.Text = "Schedule";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(208, 249);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(160, 29);
            dateTimePicker2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 225);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 27;
            label4.Text = "Ends on";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 29);
            dateTimePicker1.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 225);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 25;
            label3.Text = "Starts on";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 29);
            textBox2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 15);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 23;
            label2.Text = "Course code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 22;
            label1.Text = "Program";
            // 
            // frmLearningRecord
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(mainSplitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmLearningRecord";
            Text = "frmLearningRecord";
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private ListView lsvCourses;
        private ImageList imageListGroups;
        private ImageList imageListLarge;
        private ProgressBar progressBar1;
        private Label label8;
        private RichTextBox richTextBox1;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Label label9;
        private Controls.StarRatingControl starRatingControl;
        private TextBox textBox1;
        private Label lbDescription;
        private RichTextBox richTextBox2;
        private Label label19;
        private RichTextBox richTextBox3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox comboBox1;
        private RichTextBox richTextBox4;
        private Button button3;
    }
}