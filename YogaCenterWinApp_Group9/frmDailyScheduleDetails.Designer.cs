namespace YogaCenterWinApp_Group9
{
    partial class frmDailyScheduleDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnsave = new Button();
            btnexit = new Button();
            cboprogram = new ComboBox();
            cbocourse = new ComboBox();
            timeslot = new Label();
            textBox1 = new TextBox();
            txtlesson = new TextBox();
            txtlecture = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 100);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 0;
            label1.Text = "Program";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 148);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 1;
            label2.Text = "Cousre";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(140, 189);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 2;
            label3.Text = "Lesson";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(178, 276);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 6;
            label4.Text = "Lecture";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(230, 328);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 8;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(399, 328);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 9;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // cboprogram
            // 
            cboprogram.FormattingEnabled = true;
            cboprogram.Location = new Point(249, 103);
            cboprogram.Name = "cboprogram";
            cboprogram.Size = new Size(225, 28);
            cboprogram.TabIndex = 10;
            // 
            // cbocourse
            // 
            cbocourse.FormattingEnabled = true;
            cbocourse.Location = new Point(249, 151);
            cbocourse.Name = "cbocourse";
            cbocourse.Size = new Size(151, 28);
            cbocourse.TabIndex = 11;
            // 
            // timeslot
            // 
            timeslot.AutoSize = true;
            timeslot.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeslot.Location = new Point(119, 229);
            timeslot.Name = "timeslot";
            timeslot.Size = new Size(109, 26);
            timeslot.TabIndex = 14;
            timeslot.Text = "Timeslot";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // txtlesson
            // 
            txtlesson.Location = new Point(249, 192);
            txtlesson.Name = "txtlesson";
            txtlesson.Size = new Size(125, 27);
            txtlesson.TabIndex = 16;
            // 
            // txtlecture
            // 
            txtlecture.Location = new Point(297, 279);
            txtlecture.Name = "txtlecture";
            txtlecture.Size = new Size(144, 27);
            txtlecture.TabIndex = 17;
            // 
            // CalendarDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtlecture);
            Controls.Add(txtlesson);
            Controls.Add(textBox1);
            Controls.Add(timeslot);
            Controls.Add(cbocourse);
            Controls.Add(cboprogram);
            Controls.Add(btnexit);
            Controls.Add(btnsave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalendarDetail";
            Text = "CalendarDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnsave;
        private Button btnexit;
        private ComboBox cboprogram;
        private ComboBox cbocourse;
        private Label timeslot;
        private TextBox textBox1;
        private TextBox txtlesson;
        private TextBox txtlecture;
    }
}