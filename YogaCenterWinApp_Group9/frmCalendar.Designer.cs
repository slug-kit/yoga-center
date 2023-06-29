namespace YogaCenterWinApp_Group9
{
    partial class frmCalendar
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
            daycontanier = new FlowLayoutPanel();
            btnprevious = new Button();
            btnnext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // daycontanier
            // 
            daycontanier.Location = new Point(12, 116);
            daycontanier.Name = "daycontanier";
            daycontanier.Size = new Size(1081, 574);
            daycontanier.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Location = new Point(847, 712);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(94, 29);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "Previous";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(986, 712);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 2;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 72);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 3;
            label1.Text = "Monday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(194, 72);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 4;
            label2.Text = "Tuesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(330, 72);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 5;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(496, 72);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 6;
            label4.Text = "Thursday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(663, 72);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 7;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(807, 72);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 8;
            label6.Text = "Saturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(969, 72);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 9;
            label7.Text = "Sunday";
            // 
            // frmCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 764);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnnext);
            Controls.Add(btnprevious);
            Controls.Add(daycontanier);
            Name = "frmCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalendar";
            Load += frmCalendar_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontanier;
        private Button btnprevious;
        private Button btnnext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}