using YogaCenterWinApp_Group9.Controls;

namespace YogaCenterWinApp_Group9
{
    partial class frmCourseRegister
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Jane Doe", "16/20" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "John Hack", "20/20" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Joe Dot", "20/20" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Linda Rut", "19/20" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Bob Thing", "19/20" }, -1);
            lsvLearners = new BindableListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnSave = new Button();
            splitContainer = new SplitContainer();
            grbListActions = new GroupBox();
            btnKick = new Button();
            btnAdd = new Button();
            txtGender = new TextBox();
            txtRole = new TextBox();
            lbRole = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            lbGender = new Label();
            txtPhone = new TextBox();
            lbPhone = new Label();
            dtpDob = new DateTimePicker();
            lbDob = new Label();
            txtFullname = new TextBox();
            lbFullname = new Label();
            txtCode = new TextBox();
            lbCode = new Label();
            txtUsername = new TextBox();
            lbUsername = new Label();
            picImg = new PictureBox();
            lbStudyGoals = new Label();
            rtbStudyGoals = new RichTextBox();
            grbFormActions = new GroupBox();
            btnCancel = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            grbListActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            grbFormActions.SuspendLayout();
            SuspendLayout();
            // 
            // lsvLearners
            // 
            lsvLearners.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsvLearners.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lsvLearners.Location = new Point(0, 0);
            lsvLearners.Margin = new Padding(4);
            lsvLearners.Name = "lsvLearners";
            lsvLearners.Size = new Size(258, 495);
            lsvLearners.TabIndex = 10;
            lsvLearners.UseCompatibleStateImageBehavior = false;
            lsvLearners.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Learner";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Attendance";
            columnHeader2.Width = 90;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(76, 22);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(12, 12);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(grbListActions);
            splitContainer.Panel1.Controls.Add(lsvLearners);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(txtGender);
            splitContainer.Panel2.Controls.Add(txtRole);
            splitContainer.Panel2.Controls.Add(lbRole);
            splitContainer.Panel2.Controls.Add(txtEmail);
            splitContainer.Panel2.Controls.Add(lbEmail);
            splitContainer.Panel2.Controls.Add(lbGender);
            splitContainer.Panel2.Controls.Add(txtPhone);
            splitContainer.Panel2.Controls.Add(lbPhone);
            splitContainer.Panel2.Controls.Add(dtpDob);
            splitContainer.Panel2.Controls.Add(lbDob);
            splitContainer.Panel2.Controls.Add(txtFullname);
            splitContainer.Panel2.Controls.Add(lbFullname);
            splitContainer.Panel2.Controls.Add(txtCode);
            splitContainer.Panel2.Controls.Add(lbCode);
            splitContainer.Panel2.Controls.Add(txtUsername);
            splitContainer.Panel2.Controls.Add(lbUsername);
            splitContainer.Panel2.Controls.Add(picImg);
            splitContainer.Panel2.Controls.Add(lbStudyGoals);
            splitContainer.Panel2.Controls.Add(rtbStudyGoals);
            splitContainer.Size = new Size(707, 570);
            splitContainer.SplitterDistance = 258;
            splitContainer.TabIndex = 12;
            // 
            // grbListActions
            // 
            grbListActions.Controls.Add(btnKick);
            grbListActions.Controls.Add(btnAdd);
            grbListActions.Location = new Point(3, 498);
            grbListActions.Name = "grbListActions";
            grbListActions.Size = new Size(252, 69);
            grbListActions.TabIndex = 52;
            grbListActions.TabStop = false;
            // 
            // btnKick
            // 
            btnKick.Location = new Point(131, 22);
            btnKick.Margin = new Padding(4);
            btnKick.Name = "btnKick";
            btnKick.Size = new Size(120, 40);
            btnKick.TabIndex = 9;
            btnKick.Text = "Kick";
            btnKick.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 22);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(239, 185);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(81, 29);
            txtGender.TabIndex = 52;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(325, 108);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(100, 29);
            txtRole.TabIndex = 51;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(325, 84);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(41, 21);
            lbRole.TabIndex = 43;
            lbRole.Text = "Role";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 29);
            txtEmail.TabIndex = 42;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(239, 301);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(48, 21);
            lbEmail.TabIndex = 41;
            lbEmail.Text = "Email";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(239, 161);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(61, 21);
            lbGender.TabIndex = 39;
            lbGender.Text = "Gender";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(24, 325);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 29);
            txtPhone.TabIndex = 38;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(24, 301);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(113, 21);
            lbPhone.TabIndex = 37;
            lbPhone.Text = "Phone number";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(24, 255);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(186, 29);
            dtpDob.TabIndex = 36;
            // 
            // lbDob
            // 
            lbDob.AutoSize = true;
            lbDob.Location = new Point(24, 231);
            lbDob.Name = "lbDob";
            lbDob.Size = new Size(97, 21);
            lbDob.TabIndex = 35;
            lbDob.Text = "Date of Birth";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(24, 185);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(186, 29);
            txtFullname.TabIndex = 34;
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(24, 161);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(74, 21);
            lbFullname.TabIndex = 33;
            lbFullname.Text = "Fullname";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(162, 108);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(145, 29);
            txtCode.TabIndex = 32;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(162, 84);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(109, 21);
            lbCode.TabIndex = 31;
            lbCode.Text = "Member Code";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 29);
            txtUsername.TabIndex = 30;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(162, 14);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(81, 21);
            lbUsername.TabIndex = 29;
            lbUsername.Text = "Username";
            // 
            // picImg
            // 
            picImg.Location = new Point(31, 14);
            picImg.Name = "picImg";
            picImg.Size = new Size(90, 120);
            picImg.TabIndex = 28;
            picImg.TabStop = false;
            // 
            // lbStudyGoals
            // 
            lbStudyGoals.AutoSize = true;
            lbStudyGoals.Location = new Point(24, 371);
            lbStudyGoals.Name = "lbStudyGoals";
            lbStudyGoals.Size = new Size(169, 21);
            lbStudyGoals.TabIndex = 45;
            lbStudyGoals.Text = "Goals in Learning Yoga";
            // 
            // rtbStudyGoals
            // 
            rtbStudyGoals.Location = new Point(24, 395);
            rtbStudyGoals.Name = "rtbStudyGoals";
            rtbStudyGoals.Size = new Size(401, 165);
            rtbStudyGoals.TabIndex = 44;
            rtbStudyGoals.Text = "";
            // 
            // grbFormActions
            // 
            grbFormActions.Controls.Add(btnCancel);
            grbFormActions.Controls.Add(btnReset);
            grbFormActions.Controls.Add(btnSave);
            grbFormActions.Location = new Point(12, 595);
            grbFormActions.Name = "grbFormActions";
            grbFormActions.Size = new Size(707, 69);
            grbFormActions.TabIndex = 51;
            grbFormActions.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(293, 22);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(525, 22);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // frmCourseRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 676);
            Controls.Add(grbFormActions);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCourseRegister";
            Text = "Course Register";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            grbListActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            grbFormActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BindableListView lsvLearners;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnSave;
        private SplitContainer splitContainer;
        private Label lbRole;
        private TextBox txtEmail;
        private Label lbEmail;
        private ComboBox comboBox1;
        private Label lbGender;
        private TextBox txtPhone;
        private Label lbPhone;
        private DateTimePicker dtpDob;
        private Label lbDob;
        private TextBox textBox3;
        private Label lbFullname;
        private TextBox txtCode;
        private Label lbCode;
        private TextBox txtUsername;
        private Label lbUsername;
        private PictureBox picImg;
        private Label lbStudyGoals;
        private RichTextBox rtbStudyGoals;
        private GroupBox grbListActions;
        private Button btnKick;
        private Button btnAdd;
        private GroupBox grbFormActions;
        private Button btnReset;
        private Button btnCancel;
        private TextBox txtRole;
        private TextBox txtFullname;
        private TextBox txtGender;
    }
}