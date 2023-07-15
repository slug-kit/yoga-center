namespace YogaCenterWinApp_Group9
{
    partial class ListProgram
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
            dgvListProgram = new DataGridView();
            colProgram = new DataGridViewTextBoxColumn();
            colInstructor = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colRegister = new DataGridViewButtonColumn();
            lbProgram = new Label();
            lbInstructor = new Label();
            txtInstructor = new TextBox();
            lbFilter = new Label();
            txtProgram = new TextBox();
            lbProg = new Label();
            btCheck = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lbRate = new Label();
            textBox3 = new TextBox();
            lbFee = new Label();
            lbDescription = new Label();
            richTextBox1 = new RichTextBox();
            btDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListProgram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvListProgram
            // 
            dgvListProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProgram.Columns.AddRange(new DataGridViewColumn[] { colProgram, colInstructor, colStartDate, colRegister });
            dgvListProgram.Location = new Point(8, 139);
            dgvListProgram.Name = "dgvListProgram";
            dgvListProgram.RowTemplate.Height = 25;
            dgvListProgram.Size = new Size(495, 176);
            dgvListProgram.TabIndex = 0;
            // 
            // colProgram
            // 
            colProgram.HeaderText = "Program";
            colProgram.Name = "colProgram";
            colProgram.Width = 150;
            // 
            // colInstructor
            // 
            colInstructor.HeaderText = "Instructor";
            colInstructor.Name = "colInstructor";
            // 
            // colStartDate
            // 
            colStartDate.HeaderText = "Start Date ";
            colStartDate.Name = "colStartDate";
            // 
            // colRegister
            // 
            colRegister.HeaderText = "Add";
            colRegister.Name = "colRegister";
            colRegister.Text = "Register";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbProgram.Location = new Point(8, 45);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(193, 40);
            lbProgram.TabIndex = 1;
            lbProgram.Text = "Program List";
            // 
            // lbInstructor
            // 
            lbInstructor.AutoSize = true;
            lbInstructor.Location = new Point(253, 36);
            lbInstructor.Name = "lbInstructor";
            lbInstructor.Size = new Size(58, 15);
            lbInstructor.TabIndex = 2;
            lbInstructor.Text = "Instructor";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(317, 33);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(119, 23);
            txtInstructor.TabIndex = 3;
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFilter.Location = new Point(302, 9);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(72, 21);
            lbFilter.TabIndex = 4;
            lbFilter.Text = "Filter By";
            // 
            // txtProgram
            // 
            txtProgram.Location = new Point(317, 62);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(119, 23);
            txtProgram.TabIndex = 6;
            // 
            // lbProg
            // 
            lbProg.AutoSize = true;
            lbProg.Location = new Point(253, 65);
            lbProg.Name = "lbProg";
            lbProg.Size = new Size(53, 15);
            lbProg.TabIndex = 5;
            lbProg.Text = "Program";
            lbProg.Click += label1_Click;
            // 
            // btCheck
            // 
            btCheck.Location = new Point(302, 91);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(75, 23);
            btCheck.TabIndex = 7;
            btCheck.Text = "Check";
            btCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(520, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 102);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(593, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 144);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 9;
            label1.Text = "Instructor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(593, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 12;
            // 
            // lbRate
            // 
            lbRate.AutoSize = true;
            lbRate.Location = new Point(520, 173);
            lbRate.Name = "lbRate";
            lbRate.Size = new Size(41, 15);
            lbRate.TabIndex = 11;
            lbRate.Text = "Rating";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(593, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 14;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(520, 202);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 13;
            lbFee.Text = "Fee";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(520, 231);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 15;
            lbDescription.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(593, 231);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(176, 84);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // btDetails
            // 
            btDetails.Location = new Point(520, 321);
            btDetails.Name = "btDetails";
            btDetails.Size = new Size(249, 23);
            btDetails.TabIndex = 17;
            btDetails.Text = "More Details ";
            btDetails.UseVisualStyleBackColor = true;
            // 
            // ListProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 375);
            Controls.Add(btDetails);
            Controls.Add(richTextBox1);
            Controls.Add(lbDescription);
            Controls.Add(textBox3);
            Controls.Add(lbFee);
            Controls.Add(textBox2);
            Controls.Add(lbRate);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btCheck);
            Controls.Add(txtProgram);
            Controls.Add(lbProg);
            Controls.Add(lbFilter);
            Controls.Add(txtInstructor);
            Controls.Add(lbInstructor);
            Controls.Add(lbProgram);
            Controls.Add(dgvListProgram);
            Name = "ListProgram";
            Text = "ListProgram";
            ((System.ComponentModel.ISupportInitialize)dgvListProgram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListProgram;
        private Label lbProgram;
        private Label lbInstructor;
        private TextBox txtInstructor;
        private Label lbFilter;
        private TextBox txtProgram;
        private Label lbProg;
        private Button btCheck;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colInstructor;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewButtonColumn colRegister;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label lbRate;
        private TextBox textBox3;
        private Label lbFee;
        private Label lbDescription;
        private RichTextBox richTextBox1;
        private Button btDetails;
    }
}