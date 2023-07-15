namespace YogaCenterWinApp_Group9
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mainStatus = new StatusStrip();
            formTitleLabel = new ToolStripStatusLabel();
            mainMenu = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            navigationToolStripMenuItem = new ToolStripMenuItem();
            programsToolStripMenuItem = new ToolStripMenuItem();
            myCoursesToolStripMenuItem = new ToolStripMenuItem();
            timetableToolStripMenuItem = new ToolStripMenuItem();
            switchFormControlToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            programManagementToolStripMenuItem = new ToolStripMenuItem();
            courseManagementToolStripMenuItem = new ToolStripMenuItem();
            dailyScheduleManagementToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            mainTool = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            mainStatus.SuspendLayout();
            mainMenu.SuspendLayout();
            mainTool.SuspendLayout();
            SuspendLayout();
            // 
            // mainStatus
            // 
            mainStatus.Items.AddRange(new ToolStripItem[] { formTitleLabel });
            mainStatus.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            mainStatus.Location = new Point(0, 839);
            mainStatus.Name = "mainStatus";
            mainStatus.Padding = new Padding(1, 0, 18, 0);
            mainStatus.Size = new Size(1334, 22);
            mainStatus.TabIndex = 2;
            // 
            // formTitleLabel
            // 
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(173, 17);
            formTitleLabel.Text = "Hello, I am the Placeholder Text";
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, navigationToolStripMenuItem, switchFormControlToolStripMenuItem, managementToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.MdiWindowListItem = switchFormControlToolStripMenuItem;
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(8, 3, 0, 3);
            mainMenu.Size = new Size(1334, 25);
            mainMenu.TabIndex = 0;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, profileToolStripMenuItem, logoutToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.U;
            userToolStripMenuItem.Size = new Size(42, 19);
            userToolStripMenuItem.Text = "&User";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.I;
            loginToolStripMenuItem.Size = new Size(151, 22);
            loginToolStripMenuItem.Text = "Log&in";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            profileToolStripMenuItem.Size = new Size(151, 22);
            profileToolStripMenuItem.Text = "Pro&file";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.O;
            logoutToolStripMenuItem.Size = new Size(151, 22);
            logoutToolStripMenuItem.Text = "Log&out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(151, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // navigationToolStripMenuItem
            // 
            navigationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programsToolStripMenuItem, myCoursesToolStripMenuItem, timetableToolStripMenuItem });
            navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            navigationToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.N;
            navigationToolStripMenuItem.Size = new Size(77, 19);
            navigationToolStripMenuItem.Text = "&Navigation";
            // 
            // programsToolStripMenuItem
            // 
            programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            programsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            programsToolStripMenuItem.Size = new Size(174, 22);
            programsToolStripMenuItem.Text = "&Programs";
            programsToolStripMenuItem.Click += programsToolStripMenuItem_Click;
            // 
            // myCoursesToolStripMenuItem
            // 
            myCoursesToolStripMenuItem.Name = "myCoursesToolStripMenuItem";
            myCoursesToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            myCoursesToolStripMenuItem.Size = new Size(174, 22);
            myCoursesToolStripMenuItem.Text = "My &Courses";
            myCoursesToolStripMenuItem.Click += myCoursesToolStripMenuItem_Click;
            // 
            // timetableToolStripMenuItem
            // 
            timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            timetableToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.T;
            timetableToolStripMenuItem.Size = new Size(174, 22);
            timetableToolStripMenuItem.Text = "&Timetable";
            timetableToolStripMenuItem.Click += timetableToolStripMenuItem_Click;
            // 
            // switchFormControlToolStripMenuItem
            // 
            switchFormControlToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            switchFormControlToolStripMenuItem.Name = "switchFormControlToolStripMenuItem";
            switchFormControlToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            switchFormControlToolStripMenuItem.Size = new Size(68, 19);
            switchFormControlToolStripMenuItem.Text = "&Windows";
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programManagementToolStripMenuItem, courseManagementToolStripMenuItem, dailyScheduleManagementToolStripMenuItem, toolStripSeparator2, userManagementToolStripMenuItem });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.M;
            managementToolStripMenuItem.Size = new Size(90, 19);
            managementToolStripMenuItem.Text = "&Management";
            // 
            // programManagementToolStripMenuItem
            // 
            programManagementToolStripMenuItem.Name = "programManagementToolStripMenuItem";
            programManagementToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.P;
            programManagementToolStripMenuItem.Size = new Size(214, 22);
            programManagementToolStripMenuItem.Text = "&Program";
            programManagementToolStripMenuItem.Click += programManagementToolStripMenuItem_Click;
            // 
            // courseManagementToolStripMenuItem
            // 
            courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            courseManagementToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.C;
            courseManagementToolStripMenuItem.Size = new Size(214, 22);
            courseManagementToolStripMenuItem.Text = "&Course";
            courseManagementToolStripMenuItem.Click += courseManagementToolStripMenuItem_Click;
            // 
            // dailyScheduleManagementToolStripMenuItem
            // 
            dailyScheduleManagementToolStripMenuItem.Name = "dailyScheduleManagementToolStripMenuItem";
            dailyScheduleManagementToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            dailyScheduleManagementToolStripMenuItem.Size = new Size(214, 22);
            dailyScheduleManagementToolStripMenuItem.Text = "Daily &Schedule";
            dailyScheduleManagementToolStripMenuItem.Click += dailyScheduleManagementToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(211, 6);
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.U;
            userManagementToolStripMenuItem.Size = new Size(214, 22);
            userManagementToolStripMenuItem.Text = "&User";
            userManagementToolStripMenuItem.Click += userManagementToolStripMenuItem_Click;
            // 
            // mainTool
            // 
            mainTool.GripStyle = ToolStripGripStyle.Hidden;
            mainTool.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            mainTool.Location = new Point(0, 25);
            mainTool.Name = "mainTool";
            mainTool.Padding = new Padding(12, 2, 1, 2);
            mainTool.RenderMode = ToolStripRenderMode.System;
            mainTool.Size = new Size(1334, 27);
            mainTool.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 20);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 861);
            Controls.Add(mainTool);
            Controls.Add(mainStatus);
            Controls.Add(mainMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = mainMenu;
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yoga Center";
            Load += frmMain_Load;
            mainStatus.ResumeLayout(false);
            mainStatus.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            mainTool.ResumeLayout(false);
            mainTool.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip mainStatus;
        private ToolStripStatusLabel formTitleLabel;
        private MenuStrip mainMenu;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem navigationToolStripMenuItem;
        private ToolStrip mainTool;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem switchFormControlToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem programsToolStripMenuItem;
        private ToolStripMenuItem myCoursesToolStripMenuItem;
        private ToolStripMenuItem timetableToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem programManagementToolStripMenuItem;
        private ToolStripMenuItem courseManagementToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem dailyScheduleManagementToolStripMenuItem;
    }
}