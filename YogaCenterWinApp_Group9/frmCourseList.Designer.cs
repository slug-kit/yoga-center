namespace YogaCenterWinApp_Group9
{
    partial class frmCourseList
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
            lbCourseNum = new Label();
            btBack = new Button();
            lbInstructor = new Label();
            lbProgram = new Label();
            txtProgramId = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            lbTimeSlot = new Label();
            lbCourseStart = new Label();
            lbTo = new Label();
            lbNonAvailable = new Label();
            lbAvailable = new Label();
            dateTimePickerAvailableFrom = new DateTimePicker();
            dateTimePickerAvailableTo = new DateTimePicker();
            dateTimePickerCourseEnd = new DateTimePicker();
            dateTimePickerCourseStart = new DateTimePicker();
            btEnroll = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            lbSchedule = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbCourseNum
            // 
            lbCourseNum.AutoSize = true;
            lbCourseNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseNum.Location = new Point(3, 164);
            lbCourseNum.Name = "lbCourseNum";
            lbCourseNum.Size = new Size(121, 21);
            lbCourseNum.TabIndex = 0;
            lbCourseNum.Text = "Course Number";
            // 
            // btBack
            // 
            btBack.Location = new Point(-6, -2);
            btBack.Name = "btBack";
            btBack.Size = new Size(84, 35);
            btBack.TabIndex = 2;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInstructor.Location = new Point(3, 199);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(77, 21);
            lbInstructor.TabIndex = 3;
            lbInstructor.Text = "Instructor";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbProgram.Location = new Point(156, 23);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(147, 32);
            lbProgram.TabIndex = 5;
            lbProgram.Text = "Program ID";
            // 
            // txtProgramId
            // 
            txtProgramId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramId.Location = new Point(144, 58);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.ReadOnly = true;
            txtProgramId.Size = new Size(169, 29);
            txtProgramId.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(144, 231);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 29);
            comboBox3.TabIndex = 10;
            // 
            // lbTimeSlot
            // 
            lbTimeSlot.AutoSize = true;
            lbTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimeSlot.Location = new Point(3, 234);
            lbTimeSlot.Name = "lbTimeSlot";
            lbTimeSlot.Size = new Size(75, 21);
            lbTimeSlot.TabIndex = 9;
            lbTimeSlot.Text = "Time Slot";
            // 
            // lbCourseStart
            // 
            lbCourseStart.AutoSize = true;
            lbCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseStart.Location = new Point(3, 272);
            lbCourseStart.Name = "lbCourseStart";
            lbCourseStart.Size = new Size(136, 21);
            lbCourseStart.TabIndex = 12;
            lbCourseStart.Text = "Course Start From";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTo.Location = new Point(316, 272);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(25, 21);
            lbTo.TabIndex = 14;
            lbTo.Text = "To";
            // 
            // lbNonAvailable
            // 
            lbNonAvailable.AutoSize = true;
            lbNonAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNonAvailable.Location = new Point(619, 64);
            lbNonAvailable.Name = "lbNonAvailable";
            lbNonAvailable.Size = new Size(25, 21);
            lbNonAvailable.TabIndex = 18;
            lbNonAvailable.Text = "To";
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAvailable.Location = new Point(332, 61);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new Size(114, 21);
            lbAvailable.TabIndex = 16;
            lbAvailable.Text = "Available From";
            // 
            // dateTimePickerAvailableFrom
            // 
            dateTimePickerAvailableFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableFrom.Location = new Point(452, 58);
            dateTimePickerAvailableFrom.Name = "dateTimePickerAvailableFrom";
            dateTimePickerAvailableFrom.Size = new Size(161, 29);
            dateTimePickerAvailableFrom.TabIndex = 19;
            // 
            // dateTimePickerAvailableTo
            // 
            dateTimePickerAvailableTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableTo.Location = new Point(650, 58);
            dateTimePickerAvailableTo.Name = "dateTimePickerAvailableTo";
            dateTimePickerAvailableTo.Size = new Size(164, 29);
            dateTimePickerAvailableTo.TabIndex = 20;
            // 
            // dateTimePickerCourseEnd
            // 
            dateTimePickerCourseEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseEnd.Location = new Point(347, 266);
            dateTimePickerCourseEnd.Name = "dateTimePickerCourseEnd";
            dateTimePickerCourseEnd.Size = new Size(184, 29);
            dateTimePickerCourseEnd.TabIndex = 21;
            // 
            // dateTimePickerCourseStart
            // 
            dateTimePickerCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseStart.Location = new Point(144, 266);
            dateTimePickerCourseStart.Name = "dateTimePickerCourseStart";
            dateTimePickerCourseStart.Size = new Size(169, 29);
            dateTimePickerCourseStart.TabIndex = 22;
            // 
            // btEnroll
            // 
            btEnroll.Location = new Point(283, 350);
            btEnroll.Name = "btEnroll";
            btEnroll.Size = new Size(248, 47);
            btEnroll.TabIndex = 23;
            btEnroll.Text = "Enroll This Course";
            btEnroll.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(283, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 99);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(536, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 99);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(615, 201);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(199, 94);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSchedule.Location = new Point(536, 204);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 27;
            lbSchedule.Text = "Schedule";
            // 
            // frmCourseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(lbSchedule);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btEnroll);
            Controls.Add(dateTimePickerCourseStart);
            Controls.Add(dateTimePickerCourseEnd);
            Controls.Add(dateTimePickerAvailableTo);
            Controls.Add(dateTimePickerAvailableFrom);
            Controls.Add(lbNonAvailable);
            Controls.Add(lbAvailable);
            Controls.Add(lbTo);
            Controls.Add(lbCourseStart);
            Controls.Add(comboBox3);
            Controls.Add(lbTimeSlot);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtProgramId);
            Controls.Add(lbProgram);
            Controls.Add(lbInstructor);
            Controls.Add(btBack);
            Controls.Add(lbCourseNum);
            Name = "frmCourseList";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCourseNum;
        private Button btBack;
        private Label lbInstructor;
        private Label lbProgram;
        private TextBox txtProgramId;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label lbTimeSlot;
        private Label lbCourseStart;
        private Label lbTo;
        private Label lbNonAvailable;
        private Label lbAvailable;
        private DateTimePicker dateTimePickerAvailableFrom;
        private DateTimePicker dateTimePickerAvailableTo;
        private DateTimePicker dateTimePickerCourseEnd;
        private DateTimePicker dateTimePickerCourseStart;
        private Button btEnroll;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Label lbSchedule;
    }
}