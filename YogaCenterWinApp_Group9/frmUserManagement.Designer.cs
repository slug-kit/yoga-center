namespace YogaCenterWinApp_Group9
{
    partial class frmUserManagement
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
            splitContainer = new SplitContainer();
            groupBox2 = new GroupBox();
            txtGenderSearch = new TextBox();
            txtRoleSearch = new TextBox();
            dtpJoinDateTo = new DateTimePicker();
            label23 = new Label();
            txtmembercodeSearch = new TextBox();
            label16 = new Label();
            txtemailSearch = new TextBox();
            label22 = new Label();
            txtphonenumberSearch = new TextBox();
            label21 = new Label();
            txtfullnameSearch = new TextBox();
            label20 = new Label();
            button5 = new Button();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            btnsearch = new Button();
            txtusernameSearch = new TextBox();
            label19 = new Label();
            dtpJoinDateFrom = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnsuspend = new Button();
            btnadd = new Button();
            dgvuser = new DataGridView();
            cborole = new ComboBox();
            rtbSpecialization = new RichTextBox();
            label13 = new Label();
            rtbGoalOrExperience = new RichTextBox();
            lbexperience = new Label();
            label10 = new Label();
            txtemail = new TextBox();
            label9 = new Label();
            cbogender = new ComboBox();
            label8 = new Label();
            txtphonenumber = new TextBox();
            label7 = new Label();
            lastlogin = new DateTimePicker();
            label6 = new Label();
            datejoin = new DateTimePicker();
            label5 = new Label();
            dob = new DateTimePicker();
            label4 = new Label();
            txtfullname = new TextBox();
            label3 = new Label();
            txtmembercode = new TextBox();
            label2 = new Label();
            txtusername = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            lbgoal = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBox2);
            splitContainer.Panel1.Controls.Add(groupBox1);
            splitContainer.Panel1.Controls.Add(dgvuser);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(cborole);
            splitContainer.Panel2.Controls.Add(rtbSpecialization);
            splitContainer.Panel2.Controls.Add(label13);
            splitContainer.Panel2.Controls.Add(rtbGoalOrExperience);
            splitContainer.Panel2.Controls.Add(lbexperience);
            splitContainer.Panel2.Controls.Add(label10);
            splitContainer.Panel2.Controls.Add(txtemail);
            splitContainer.Panel2.Controls.Add(label9);
            splitContainer.Panel2.Controls.Add(cbogender);
            splitContainer.Panel2.Controls.Add(label8);
            splitContainer.Panel2.Controls.Add(txtphonenumber);
            splitContainer.Panel2.Controls.Add(label7);
            splitContainer.Panel2.Controls.Add(lastlogin);
            splitContainer.Panel2.Controls.Add(label6);
            splitContainer.Panel2.Controls.Add(datejoin);
            splitContainer.Panel2.Controls.Add(label5);
            splitContainer.Panel2.Controls.Add(dob);
            splitContainer.Panel2.Controls.Add(label4);
            splitContainer.Panel2.Controls.Add(txtfullname);
            splitContainer.Panel2.Controls.Add(label3);
            splitContainer.Panel2.Controls.Add(txtmembercode);
            splitContainer.Panel2.Controls.Add(label2);
            splitContainer.Panel2.Controls.Add(txtusername);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.Controls.Add(pictureBox);
            splitContainer.Panel2.Controls.Add(lbgoal);
            splitContainer.Size = new Size(1029, 630);
            splitContainer.SplitterDistance = 584;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGenderSearch);
            groupBox2.Controls.Add(txtRoleSearch);
            groupBox2.Controls.Add(dtpJoinDateTo);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(txtmembercodeSearch);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtemailSearch);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(txtphonenumberSearch);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(txtfullnameSearch);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(btnsearch);
            groupBox2.Controls.Add(txtusernameSearch);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(dtpJoinDateFrom);
            groupBox2.Location = new Point(11, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 265);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // txtGenderSearch
            // 
            txtGenderSearch.Location = new Point(396, 182);
            txtGenderSearch.Name = "txtGenderSearch";
            txtGenderSearch.Size = new Size(100, 29);
            txtGenderSearch.TabIndex = 33;
            // 
            // txtRoleSearch
            // 
            txtRoleSearch.Location = new Point(180, 177);
            txtRoleSearch.Name = "txtRoleSearch";
            txtRoleSearch.Size = new Size(100, 29);
            txtRoleSearch.TabIndex = 32;
            // 
            // dtpJoinDateTo
            // 
            dtpJoinDateTo.Location = new Point(393, 217);
            dtpJoinDateTo.Name = "dtpJoinDateTo";
            dtpJoinDateTo.Size = new Size(164, 29);
            dtpJoinDateTo.TabIndex = 31;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(326, 185);
            label23.Name = "label23";
            label23.Size = new Size(64, 21);
            label23.TabIndex = 27;
            label23.Text = "Gender:";
            // 
            // txtmembercodeSearch
            // 
            txtmembercodeSearch.Location = new Point(412, 44);
            txtmembercodeSearch.Name = "txtmembercodeSearch";
            txtmembercodeSearch.Size = new Size(145, 29);
            txtmembercodeSearch.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(412, 20);
            label16.Name = "label16";
            label16.Size = new Size(109, 21);
            label16.TabIndex = 24;
            label16.Text = "Member Code";
            // 
            // txtemailSearch
            // 
            txtemailSearch.Location = new Point(210, 114);
            txtemailSearch.Name = "txtemailSearch";
            txtemailSearch.Size = new Size(180, 29);
            txtemailSearch.TabIndex = 23;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(210, 90);
            label22.Name = "label22";
            label22.Size = new Size(48, 21);
            label22.TabIndex = 22;
            label22.Text = "Email";
            // 
            // txtphonenumberSearch
            // 
            txtphonenumberSearch.Location = new Point(6, 114);
            txtphonenumberSearch.Name = "txtphonenumberSearch";
            txtphonenumberSearch.Size = new Size(180, 29);
            txtphonenumberSearch.TabIndex = 21;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 90);
            label21.Name = "label21";
            label21.Size = new Size(113, 21);
            label21.TabIndex = 20;
            label21.Text = "Phone number";
            // 
            // txtfullnameSearch
            // 
            txtfullnameSearch.Location = new Point(210, 44);
            txtfullnameSearch.Name = "txtfullnameSearch";
            txtfullnameSearch.Size = new Size(180, 29);
            txtfullnameSearch.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(210, 20);
            label20.Name = "label20";
            label20.Size = new Size(74, 21);
            label20.TabIndex = 16;
            label20.Text = "Fullname";
            // 
            // button5
            // 
            button5.Location = new Point(15, 184);
            button5.Name = "button5";
            button5.Size = new Size(60, 30);
            button5.TabIndex = 14;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(355, 220);
            label14.Name = "label14";
            label14.Size = new Size(24, 21);
            label14.TabIndex = 11;
            label14.Text = "to";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(100, 220);
            label15.Name = "label15";
            label15.Size = new Size(70, 21);
            label15.TabIndex = 9;
            label15.Text = "JoinDate";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(100, 185);
            label17.Name = "label17";
            label17.Size = new Size(44, 21);
            label17.TabIndex = 5;
            label17.Text = "Role:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(15, 160);
            label18.Name = "label18";
            label18.Size = new Size(71, 21);
            label18.TabIndex = 3;
            label18.Text = "FILTERS:";
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(430, 107);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(100, 40);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtusernameSearch
            // 
            txtusernameSearch.Location = new Point(6, 44);
            txtusernameSearch.Name = "txtusernameSearch";
            txtusernameSearch.Size = new Size(180, 29);
            txtusernameSearch.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 20);
            label19.Name = "label19";
            label19.Size = new Size(81, 21);
            label19.TabIndex = 0;
            label19.Text = "Username";
            // 
            // dtpJoinDateFrom
            // 
            dtpJoinDateFrom.Location = new Point(180, 217);
            dtpJoinDateFrom.Name = "dtpJoinDateFrom";
            dtpJoinDateFrom.Size = new Size(164, 29);
            dtpJoinDateFrom.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsuspend);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Location = new Point(11, 524);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnsuspend
            // 
            btnsuspend.Location = new Point(326, 40);
            btnsuspend.Name = "btnsuspend";
            btnsuspend.Size = new Size(100, 40);
            btnsuspend.TabIndex = 2;
            btnsuspend.Text = "Suspend";
            btnsuspend.UseVisualStyleBackColor = true;
            btnsuspend.Click += btnsuspend_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(128, 40);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(100, 40);
            btnadd.TabIndex = 0;
            btnadd.Text = "New";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dgvuser
            // 
            dgvuser.AllowUserToAddRows = false;
            dgvuser.AllowUserToDeleteRows = false;
            dgvuser.AllowUserToResizeRows = false;
            dgvuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuser.Location = new Point(11, 289);
            dgvuser.Name = "dgvuser";
            dgvuser.ReadOnly = true;
            dgvuser.RowHeadersWidth = 51;
            dgvuser.RowTemplate.Height = 25;
            dgvuser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvuser.Size = new Size(563, 229);
            dgvuser.TabIndex = 3;
            dgvuser.CellDoubleClick += dgvuser_CellDoubleClick;
            dgvuser.CellFormatting += dgvuser_CellFormatting;
            // 
            // cborole
            // 
            cborole.FormattingEnabled = true;
            cborole.Location = new Point(328, 122);
            cborole.Name = "cborole";
            cborole.Size = new Size(100, 29);
            cborole.TabIndex = 27;
            // 
            // rtbSpecialization
            // 
            rtbSpecialization.Location = new Point(27, 496);
            rtbSpecialization.Name = "rtbSpecialization";
            rtbSpecialization.Size = new Size(401, 40);
            rtbSpecialization.TabIndex = 26;
            rtbSpecialization.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 465);
            label13.Name = "label13";
            label13.Size = new Size(112, 21);
            label13.TabIndex = 26;
            label13.Text = "Specializations";
            // 
            // rtbGoalOrExperience
            // 
            rtbGoalOrExperience.Location = new Point(27, 409);
            rtbGoalOrExperience.Name = "rtbGoalOrExperience";
            rtbGoalOrExperience.Size = new Size(401, 47);
            rtbGoalOrExperience.TabIndex = 25;
            rtbGoalOrExperience.Text = "";
            // 
            // lbexperience
            // 
            lbexperience.AutoSize = true;
            lbexperience.Location = new Point(27, 385);
            lbexperience.Name = "lbexperience";
            lbexperience.Size = new Size(84, 21);
            lbexperience.TabIndex = 24;
            lbexperience.Text = "Experience";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(328, 98);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 20;
            label10.Text = "Role";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(242, 339);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(186, 29);
            txtemail.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(242, 315);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 18;
            label9.Text = "Email";
            // 
            // cbogender
            // 
            cbogender.FormattingEnabled = true;
            cbogender.Location = new Point(242, 199);
            cbogender.Name = "cbogender";
            cbogender.Size = new Size(81, 29);
            cbogender.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 175);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 15;
            label8.Text = "Gender";
            // 
            // txtphonenumber
            // 
            txtphonenumber.Location = new Point(27, 339);
            txtphonenumber.Name = "txtphonenumber";
            txtphonenumber.Size = new Size(186, 29);
            txtphonenumber.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 315);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 13;
            label7.Text = "Phone number";
            // 
            // lastlogin
            // 
            lastlogin.Location = new Point(242, 575);
            lastlogin.Name = "lastlogin";
            lastlogin.Size = new Size(186, 29);
            lastlogin.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 551);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 11;
            label6.Text = "Last Login";
            // 
            // datejoin
            // 
            datejoin.Location = new Point(27, 575);
            datejoin.Name = "datejoin";
            datejoin.Size = new Size(186, 29);
            datejoin.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 551);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 9;
            label5.Text = "Joined";
            // 
            // dob
            // 
            dob.Location = new Point(27, 269);
            dob.Name = "dob";
            dob.Size = new Size(186, 29);
            dob.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 245);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 7;
            label4.Text = "Date of Birth";
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(27, 199);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(186, 29);
            txtfullname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 5;
            label3.Text = "Fullname";
            // 
            // txtmembercode
            // 
            txtmembercode.Location = new Point(165, 122);
            txtmembercode.Name = "txtmembercode";
            txtmembercode.Size = new Size(145, 29);
            txtmembercode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 98);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 3;
            label2.Text = "Member Code";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(165, 52);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(263, 29);
            txtusername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(27, 26);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(105, 140);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lbgoal
            // 
            lbgoal.AutoSize = true;
            lbgoal.Location = new Point(27, 385);
            lbgoal.Name = "lbgoal";
            lbgoal.Size = new Size(169, 21);
            lbgoal.TabIndex = 23;
            lbgoal.Text = "Goals in Learning Yoga";
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmUserManagement";
            Text = "frmUserManagement";
            Load += frmUserManagement_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TextBox txtmembercode;
        private Label label2;
        private TextBox txtusername;
        private Label label1;
        private PictureBox pictureBox;
        private Label label8;
        private TextBox txtphonenumber;
        private Label label7;
        private DateTimePicker lastlogin;
        private Label label6;
        private DateTimePicker datejoin;
        private Label label5;
        private DateTimePicker dob;
        private Label label4;
        private TextBox txtfullname;
        private Label label3;
        private Label label10;
        private TextBox txtemail;
        private Label label9;
        private ComboBox cbogender;
        private Label lbgoal;
        private RichTextBox rtbSpecialization;
        private Label label13;
        private RichTextBox rtbGoalOrExperience;
        private Label lbexperience;
        private GroupBox groupBox2;
        private TextBox txtfullnameSearch;
        private Label label20;
        private Button button5;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private Button btnsearch;
        private TextBox txtusernameSearch;
        private Label label19;
        private GroupBox groupBox1;
        private Button btnsuspend;
        private Button btnadd;
        private DataGridView dgvuser;
        private TextBox txtphonenumberSearch;
        private Label label21;
        private TextBox txtemailSearch;
        private Label label22;
        private Label label23;
        private TextBox txtmembercodeSearch;
        private Label label16;
        private ComboBox cborole;
        private DateTimePicker dtpJoinDateFrom;
        private DateTimePicker dtpJoinDateTo;
        private TextBox txtGenderSearch;
        private TextBox txtRoleSearch;
    }
}