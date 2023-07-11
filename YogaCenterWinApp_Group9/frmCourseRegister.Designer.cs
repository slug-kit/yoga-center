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
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Jane Doe", "16/20" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "John Hack", "20/20" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Joe Dot", "20/20" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Linda Rut", "19/20" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "Bob Thing", "19/20" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            splitContainer = new SplitContainer();
            comboBox3 = new ComboBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Dock = DockStyle.Top;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15 });
            listView1.Location = new Point(0, 0);
            listView1.Margin = new Padding(4, 4, 4, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(258, 495);
            listView1.TabIndex = 10;
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
            // button1
            // 
            button1.Location = new Point(76, 22);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(12, 12);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBox2);
            splitContainer.Panel1.Controls.Add(listView1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(comboBox3);
            splitContainer.Panel2.Controls.Add(label10);
            splitContainer.Panel2.Controls.Add(textBox5);
            splitContainer.Panel2.Controls.Add(label9);
            splitContainer.Panel2.Controls.Add(comboBox1);
            splitContainer.Panel2.Controls.Add(label8);
            splitContainer.Panel2.Controls.Add(textBox4);
            splitContainer.Panel2.Controls.Add(label7);
            splitContainer.Panel2.Controls.Add(dateTimePicker1);
            splitContainer.Panel2.Controls.Add(label4);
            splitContainer.Panel2.Controls.Add(textBox3);
            splitContainer.Panel2.Controls.Add(label3);
            splitContainer.Panel2.Controls.Add(textBox2);
            splitContainer.Panel2.Controls.Add(label2);
            splitContainer.Panel2.Controls.Add(textBox1);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.Controls.Add(pictureBox1);
            splitContainer.Panel2.Controls.Add(label11);
            splitContainer.Panel2.Controls.Add(richTextBox1);
            splitContainer.Size = new Size(707, 570);
            splitContainer.SplitterDistance = 258;
            splitContainer.TabIndex = 12;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(325, 108);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 29);
            comboBox3.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(325, 84);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 43;
            label10.Text = "Role";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(239, 325);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 29);
            textBox5.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(239, 301);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 41;
            label9.Text = "Email";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(239, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(81, 29);
            comboBox1.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 161);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 39;
            label8.Text = "Gender";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(24, 325);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 29);
            textBox4.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 301);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 37;
            label7.Text = "Phone number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 29);
            dateTimePicker1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 231);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 35;
            label4.Text = "Date of Birth";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 29);
            textBox3.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 161);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 33;
            label3.Text = "Fullname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 29);
            textBox2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 84);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 31;
            label2.Text = "Member Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 29);
            textBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 29;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 120);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 371);
            label11.Name = "label11";
            label11.Size = new Size(169, 21);
            label11.TabIndex = 45;
            label11.Text = "Goals in Learning Yoga";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 395);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(401, 165);
            richTextBox1.TabIndex = 44;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 595);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 69);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(525, 22);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 8;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(3, 498);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 69);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(3, 22);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(131, 22);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(120, 40);
            button4.TabIndex = 9;
            button4.Text = "Kick";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(293, 22);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 9;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            // 
            // frmCourseRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 676);
            Controls.Add(groupBox1);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmCourseRegister";
            Text = "frmCourseRegister";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private SplitContainer splitContainer;
        private ComboBox comboBox3;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label11;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private GroupBox groupBox1;
        private Button button2;
        private Button button5;
    }
}