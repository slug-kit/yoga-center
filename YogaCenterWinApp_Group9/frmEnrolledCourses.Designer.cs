using YogaCenterWinApp_Group9.Controls;

namespace YogaCenterWinApp_Group9
{
    partial class frmEnrolledCourses
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Karma Yoga", "36", "14/06/2023" }, 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrolledCourses));
            mainSplitContainer = new SplitContainer();
            dgvEnrolledCourses = new DataGridView();
            lsvEnrolledCourses = new BindableListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageListSmall = new ImageList(components);
            grpFormActions = new GroupBox();
            btnUnenrol = new Button();
            btnChangeCourse = new Button();
            lbInstructorExperience = new Label();
            rtblbInstructorExperience = new RichTextBox();
            lbInstructorSpecializations = new Label();
            pictureBox = new PictureBox();
            lbInstructor = new Label();
            rtbInstructorSpecializations = new RichTextBox();
            lbDescription = new Label();
            rtbDescription = new RichTextBox();
            txtProgramName = new TextBox();
            lbRating = new Label();
            starRatingControl = new StarRatingControl();
            rtbSchedule = new RichTextBox();
            lbSchedule = new Label();
            dtpEndDate = new DateTimePicker();
            lbEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lbStartDate = new Label();
            txtCourseCode = new TextBox();
            lbCourseCode = new Label();
            lbProgramName = new Label();
            txtInstructorName = new TextBox();
            imageListGroups = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrolledCourses).BeginInit();
            grpFormActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.IsSplitterFixed = true;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Margin = new Padding(4);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(dgvEnrolledCourses);
            mainSplitContainer.Panel1.Controls.Add(lsvEnrolledCourses);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(grpFormActions);
            mainSplitContainer.Panel2.Controls.Add(lbInstructorExperience);
            mainSplitContainer.Panel2.Controls.Add(rtblbInstructorExperience);
            mainSplitContainer.Panel2.Controls.Add(lbInstructorSpecializations);
            mainSplitContainer.Panel2.Controls.Add(pictureBox);
            mainSplitContainer.Panel2.Controls.Add(lbInstructor);
            mainSplitContainer.Panel2.Controls.Add(rtbInstructorSpecializations);
            mainSplitContainer.Panel2.Controls.Add(lbDescription);
            mainSplitContainer.Panel2.Controls.Add(rtbDescription);
            mainSplitContainer.Panel2.Controls.Add(txtProgramName);
            mainSplitContainer.Panel2.Controls.Add(lbRating);
            mainSplitContainer.Panel2.Controls.Add(starRatingControl);
            mainSplitContainer.Panel2.Controls.Add(rtbSchedule);
            mainSplitContainer.Panel2.Controls.Add(lbSchedule);
            mainSplitContainer.Panel2.Controls.Add(dtpEndDate);
            mainSplitContainer.Panel2.Controls.Add(lbEndDate);
            mainSplitContainer.Panel2.Controls.Add(dtpStartDate);
            mainSplitContainer.Panel2.Controls.Add(lbStartDate);
            mainSplitContainer.Panel2.Controls.Add(txtCourseCode);
            mainSplitContainer.Panel2.Controls.Add(lbCourseCode);
            mainSplitContainer.Panel2.Controls.Add(lbProgramName);
            mainSplitContainer.Panel2.Controls.Add(txtInstructorName);
            mainSplitContainer.Size = new Size(1029, 630);
            mainSplitContainer.SplitterDistance = 625;
            mainSplitContainer.SplitterWidth = 5;
            mainSplitContainer.TabIndex = 0;
            // 
            // dgvEnrolledCourses
            // 
            dgvEnrolledCourses.AllowUserToAddRows = false;
            dgvEnrolledCourses.AllowUserToDeleteRows = false;
            dgvEnrolledCourses.AllowUserToResizeColumns = false;
            dgvEnrolledCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrolledCourses.Dock = DockStyle.Fill;
            dgvEnrolledCourses.Location = new Point(0, 0);
            dgvEnrolledCourses.Name = "dgvEnrolledCourses";
            dgvEnrolledCourses.ReadOnly = true;
            dgvEnrolledCourses.RowTemplate.Height = 25;
            dgvEnrolledCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrolledCourses.Size = new Size(625, 630);
            dgvEnrolledCourses.TabIndex = 53;
            // 
            // lsvEnrolledCourses
            // 
            lsvEnrolledCourses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvEnrolledCourses.DataMember = null;
            lsvEnrolledCourses.DataSource = null;
            lsvEnrolledCourses.Dock = DockStyle.Fill;
            lsvEnrolledCourses.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lsvEnrolledCourses.Location = new Point(0, 0);
            lsvEnrolledCourses.Name = "lsvEnrolledCourses";
            lsvEnrolledCourses.Size = new Size(625, 630);
            lsvEnrolledCourses.SmallImageList = imageListSmall;
            lsvEnrolledCourses.TabIndex = 0;
            lsvEnrolledCourses.UseCompatibleStateImageBehavior = false;
            lsvEnrolledCourses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Program";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Class";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Registered on";
            columnHeader3.Width = 120;
            // 
            // imageListSmall
            // 
            imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imageListSmall.ImageStream");
            imageListSmall.TransparentColor = Color.Transparent;
            imageListSmall.Images.SetKeyName(0, "Ashtanga-Yoga.jpg");
            imageListSmall.Images.SetKeyName(1, "Hatha-Yoga.jpg");
            imageListSmall.Images.SetKeyName(2, "Kundalini-Yoga.jpg");
            imageListSmall.Images.SetKeyName(3, "Vinyasa-Yoga.jpg");
            imageListSmall.Images.SetKeyName(4, "Karma-Yoga.jpg");
            // 
            // grpFormActions
            // 
            grpFormActions.Controls.Add(btnUnenrol);
            grpFormActions.Controls.Add(btnChangeCourse);
            grpFormActions.Location = new Point(25, 561);
            grpFormActions.Name = "grpFormActions";
            grpFormActions.Size = new Size(343, 57);
            grpFormActions.TabIndex = 51;
            grpFormActions.TabStop = false;
            // 
            // btnUnenrol
            // 
            btnUnenrol.Location = new Point(185, 18);
            btnUnenrol.Name = "btnUnenrol";
            btnUnenrol.Size = new Size(135, 33);
            btnUnenrol.TabIndex = 1;
            btnUnenrol.Text = "Unenrol";
            btnUnenrol.UseVisualStyleBackColor = true;
            btnUnenrol.Click += btnUnenrol_Click;
            // 
            // btnChangeCourse
            // 
            btnChangeCourse.Location = new Point(24, 18);
            btnChangeCourse.Name = "btnChangeCourse";
            btnChangeCourse.Size = new Size(135, 33);
            btnChangeCourse.TabIndex = 0;
            btnChangeCourse.Text = "Change course";
            btnChangeCourse.UseVisualStyleBackColor = true;
            btnChangeCourse.Click += btnChangeCourse_Click;
            // 
            // lbInstructorExperience
            // 
            lbInstructorExperience.AutoSize = true;
            lbInstructorExperience.Location = new Point(25, 502);
            lbInstructorExperience.Name = "lbInstructorExperience";
            lbInstructorExperience.Size = new Size(84, 21);
            lbInstructorExperience.TabIndex = 49;
            lbInstructorExperience.Text = "Experience";
            // 
            // rtblbInstructorExperience
            // 
            rtblbInstructorExperience.Location = new Point(25, 526);
            rtblbInstructorExperience.Name = "rtblbInstructorExperience";
            rtblbInstructorExperience.ReadOnly = true;
            rtblbInstructorExperience.Size = new Size(343, 29);
            rtblbInstructorExperience.TabIndex = 50;
            rtblbInstructorExperience.Text = "";
            // 
            // lbInstructorSpecializations
            // 
            lbInstructorSpecializations.AutoSize = true;
            lbInstructorSpecializations.Location = new Point(24, 433);
            lbInstructorSpecializations.Name = "lbInstructorSpecializations";
            lbInstructorSpecializations.Size = new Size(112, 21);
            lbInstructorSpecializations.TabIndex = 47;
            lbInstructorSpecializations.Text = "Specializations";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(250, 355);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(75, 100);
            pictureBox.TabIndex = 45;
            pictureBox.TabStop = false;
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Location = new Point(24, 365);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(77, 21);
            lbInstructor.TabIndex = 44;
            lbInstructor.Text = "Instructor";
            // 
            // rtbInstructorSpecializations
            // 
            rtbInstructorSpecializations.Location = new Point(24, 461);
            rtbInstructorSpecializations.Name = "rtbInstructorSpecializations";
            rtbInstructorSpecializations.ReadOnly = true;
            rtbInstructorSpecializations.Size = new Size(344, 29);
            rtbInstructorSpecializations.TabIndex = 48;
            rtbInstructorSpecializations.Text = "";
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
            // rtbDescription
            // 
            rtbDescription.Location = new Point(24, 134);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbDescription.Size = new Size(344, 77);
            rtbDescription.TabIndex = 42;
            rtbDescription.Text = "";
            // 
            // txtProgramName
            // 
            txtProgramName.Location = new Point(24, 39);
            txtProgramName.Name = "txtProgramName";
            txtProgramName.ReadOnly = true;
            txtProgramName.Size = new Size(160, 29);
            txtProgramName.TabIndex = 41;
            // 
            // lbRating
            // 
            lbRating.AutoSize = true;
            lbRating.Location = new Point(24, 80);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(55, 21);
            lbRating.TabIndex = 39;
            lbRating.Text = "Rating";
            // 
            // starRatingControl
            // 
            starRatingControl.BottomMargin = 2;
            starRatingControl.HoverColor = Color.Yellow;
            starRatingControl.LeftMargin = 2;
            starRatingControl.Location = new Point(105, 81);
            starRatingControl.Name = "starRatingControl";
            starRatingControl.OutlineColor = Color.DimGray;
            starRatingControl.OutlineThickness = 2;
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
            // rtbSchedule
            // 
            rtbSchedule.Location = new Point(24, 319);
            rtbSchedule.Name = "rtbSchedule";
            rtbSchedule.ReadOnly = true;
            rtbSchedule.Size = new Size(344, 29);
            rtbSchedule.TabIndex = 35;
            rtbSchedule.Text = "";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Location = new Point(24, 295);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 34;
            lbSchedule.Text = "Schedule";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Location = new Point(208, 249);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(160, 29);
            dtpEndDate.TabIndex = 28;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(208, 225);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(65, 21);
            lbEndDate.TabIndex = 27;
            lbEndDate.Text = "Ends on";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Enabled = false;
            dtpStartDate.Location = new Point(24, 249);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(160, 29);
            dtpStartDate.TabIndex = 26;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(30, 225);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(71, 21);
            lbStartDate.TabIndex = 25;
            lbStartDate.Text = "Starts on";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(208, 39);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.ReadOnly = true;
            txtCourseCode.Size = new Size(160, 29);
            txtCourseCode.TabIndex = 24;
            // 
            // lbCourseCode
            // 
            lbCourseCode.AutoSize = true;
            lbCourseCode.Location = new Point(208, 15);
            lbCourseCode.Name = "lbCourseCode";
            lbCourseCode.Size = new Size(96, 21);
            lbCourseCode.TabIndex = 23;
            lbCourseCode.Text = "Course code";
            // 
            // lbProgramName
            // 
            lbProgramName.AutoSize = true;
            lbProgramName.Location = new Point(24, 15);
            lbProgramName.Name = "lbProgramName";
            lbProgramName.Size = new Size(71, 21);
            lbProgramName.TabIndex = 22;
            lbProgramName.Text = "Program";
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(25, 389);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.ReadOnly = true;
            txtInstructorName.Size = new Size(159, 29);
            txtInstructorName.TabIndex = 52;
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
            // frmEnrolledCourses
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(mainSplitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmEnrolledCourses";
            Text = "Enrolled Courses";
            Load += frmEnrolledCourses_Load;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnrolledCourses).EndInit();
            grpFormActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private ImageList imageListGroups;
        private ImageList imageListSmall;
        private RichTextBox rtbSchedule;
        private Label lbSchedule;
        private DateTimePicker dtpEndDate;
        private Label lbEndDate;
        private DateTimePicker dtpStartDate;
        private Label lbStartDate;
        private TextBox txtCourseCode;
        private Label lbCourseCode;
        private Label lbProgramName;
        private Label lbRating;
        private Controls.StarRatingControl starRatingControl;
        private TextBox txtProgramName;
        private Label lbDescription;
        private RichTextBox rtbDescription;
        private Label lbInstructorExperience;
        private RichTextBox rtblbInstructorExperience;
        private Label lbInstructorSpecializations;
        private PictureBox pictureBox;
        private Label lbInstructor;
        private RichTextBox rtbInstructorSpecializations;
        private BindableListView lsvEnrolledCourses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox grpFormActions;
        private Button btnUnenrol;
        private Button btnChangeCourse;
        private TextBox txtInstructorName;
        private DataGridView dgvEnrolledCourses;
    }
}