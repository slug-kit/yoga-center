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
            lbCourseNum.Location = new Point(4, 230);
            lbCourseNum.Margin = new Padding(4, 0, 4, 0);
            lbCourseNum.Name = "lbCourseNum";
            lbCourseNum.Size = new Size(121, 21);
            lbCourseNum.TabIndex = 0;
            lbCourseNum.Text = "Course Number";
            // 
            // btBack
            // 
            btBack.Location = new Point(-8, -3);
            btBack.Margin = new Padding(4, 4, 4, 4);
            btBack.Name = "btBack";
            btBack.Size = new Size(108, 49);
            btBack.TabIndex = 2;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInstructor.Location = new Point(4, 279);
            lbInstructor.Margin = new Padding(4, 0, 4, 0);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(77, 21);
            lbInstructor.TabIndex = 3;
            lbInstructor.Text = "Instructor";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbProgram.Location = new Point(201, 32);
            lbProgram.Margin = new Padding(4, 0, 4, 0);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(147, 32);
            lbProgram.TabIndex = 5;
            lbProgram.Text = "Program ID";
            // 
            // txtProgramId
            // 
            txtProgramId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramId.Location = new Point(185, 81);
            txtProgramId.Margin = new Padding(4, 4, 4, 4);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.ReadOnly = true;
            txtProgramId.Size = new Size(216, 29);
            txtProgramId.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 225);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 29);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(185, 274);
            comboBox2.Margin = new Padding(4, 4, 4, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 29);
            comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(185, 323);
            comboBox3.Margin = new Padding(4, 4, 4, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(154, 29);
            comboBox3.TabIndex = 10;
            // 
            // lbTimeSlot
            // 
            lbTimeSlot.AutoSize = true;
            lbTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimeSlot.Location = new Point(4, 328);
            lbTimeSlot.Margin = new Padding(4, 0, 4, 0);
            lbTimeSlot.Name = "lbTimeSlot";
            lbTimeSlot.Size = new Size(75, 21);
            lbTimeSlot.TabIndex = 9;
            lbTimeSlot.Text = "Time Slot";
            // 
            // lbCourseStart
            // 
            lbCourseStart.AutoSize = true;
            lbCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseStart.Location = new Point(4, 381);
            lbCourseStart.Margin = new Padding(4, 0, 4, 0);
            lbCourseStart.Name = "lbCourseStart";
            lbCourseStart.Size = new Size(136, 21);
            lbCourseStart.TabIndex = 12;
            lbCourseStart.Text = "Course Start From";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTo.Location = new Point(406, 381);
            lbTo.Margin = new Padding(4, 0, 4, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(25, 21);
            lbTo.TabIndex = 14;
            lbTo.Text = "To";
            // 
            // lbNonAvailable
            // 
            lbNonAvailable.AutoSize = true;
            lbNonAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNonAvailable.Location = new Point(796, 90);
            lbNonAvailable.Margin = new Padding(4, 0, 4, 0);
            lbNonAvailable.Name = "lbNonAvailable";
            lbNonAvailable.Size = new Size(25, 21);
            lbNonAvailable.TabIndex = 18;
            lbNonAvailable.Text = "To";
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAvailable.Location = new Point(427, 85);
            lbAvailable.Margin = new Padding(4, 0, 4, 0);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new Size(114, 21);
            lbAvailable.TabIndex = 16;
            lbAvailable.Text = "Available From";
            // 
            // dateTimePickerAvailableFrom
            // 
            dateTimePickerAvailableFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableFrom.Location = new Point(581, 81);
            dateTimePickerAvailableFrom.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerAvailableFrom.Name = "dateTimePickerAvailableFrom";
            dateTimePickerAvailableFrom.Size = new Size(206, 29);
            dateTimePickerAvailableFrom.TabIndex = 19;
            // 
            // dateTimePickerAvailableTo
            // 
            dateTimePickerAvailableTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAvailableTo.Location = new Point(836, 81);
            dateTimePickerAvailableTo.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerAvailableTo.Name = "dateTimePickerAvailableTo";
            dateTimePickerAvailableTo.Size = new Size(210, 29);
            dateTimePickerAvailableTo.TabIndex = 20;
            // 
            // dateTimePickerCourseEnd
            // 
            dateTimePickerCourseEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseEnd.Location = new Point(446, 372);
            dateTimePickerCourseEnd.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerCourseEnd.Name = "dateTimePickerCourseEnd";
            dateTimePickerCourseEnd.Size = new Size(235, 29);
            dateTimePickerCourseEnd.TabIndex = 21;
            // 
            // dateTimePickerCourseStart
            // 
            dateTimePickerCourseStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCourseStart.Location = new Point(185, 372);
            dateTimePickerCourseStart.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerCourseStart.Name = "dateTimePickerCourseStart";
            dateTimePickerCourseStart.Size = new Size(216, 29);
            dateTimePickerCourseStart.TabIndex = 22;
            // 
            // btEnroll
            // 
            btEnroll.Location = new Point(364, 490);
            btEnroll.Margin = new Padding(4, 4, 4, 4);
            btEnroll.Name = "btEnroll";
            btEnroll.Size = new Size(319, 66);
            btEnroll.TabIndex = 23;
            btEnroll.Text = "Enroll This Course";
            btEnroll.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(364, 225);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 139);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(689, 130);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(357, 139);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(791, 281);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(255, 130);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSchedule.Location = new Point(689, 286);
            lbSchedule.Margin = new Padding(4, 0, 4, 0);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(73, 21);
            lbSchedule.TabIndex = 27;
            lbSchedule.Text = "Schedule";
            // 
            // frmCourseList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 630);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
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