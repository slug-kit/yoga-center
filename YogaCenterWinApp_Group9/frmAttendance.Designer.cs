namespace YogaCenterWinApp_Group9
{
    partial class frmAttendance
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Jane Doe", "Present" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "John Hack", "Present" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Joe Dot", "Present" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Linda Rut", "Absent" }, -1);
            ListViewItem listViewItem5 = new ListViewItem("Bob Thing");
            button1 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(310, 293);
            button1.Name = "button1";
            button1.Size = new Size(265, 40);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(310, 338);
            button3.Name = "button3";
            button3.Size = new Size(265, 40);
            button3.TabIndex = 4;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(310, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 270);
            panel1.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 25);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Present";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(25, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Absent";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView1.Location = new Point(12, 17);
            listView1.Name = "listView1";
            listView1.Size = new Size(292, 361);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmAttendance";
            Text = "frmAttendance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button3;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}