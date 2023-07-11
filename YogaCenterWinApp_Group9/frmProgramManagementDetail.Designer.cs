namespace YogaCenterWinApp_Group9
{
    partial class frmProgramManagementDetail
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
            txtdescription = new Label();
            txttFee = new Label();
            txtfee = new TextBox();
            button2 = new Button();
            btnsave = new Button();
            txtid = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // txtdescription
            // 
            txtdescription.AutoSize = true;
            txtdescription.Location = new Point(12, 81);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(67, 15);
            txtdescription.TabIndex = 0;
            txtdescription.Text = "Description";
            // 
            // txttFee
            // 
            txttFee.AutoSize = true;
            txttFee.Location = new Point(12, 47);
            txttFee.Name = "txttFee";
            txttFee.Size = new Size(25, 15);
            txttFee.TabIndex = 1;
            txttFee.Text = "Fee";
            // 
            // txtfee
            // 
            txtfee.Location = new Point(104, 44);
            txtfee.Margin = new Padding(3, 2, 3, 2);
            txtfee.Name = "txtfee";
            txtfee.Size = new Size(198, 23);
            txtfee.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(220, 181);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(104, 181);
            btnsave.Margin = new Padding(3, 2, 3, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(82, 22);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(104, 11);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(198, 23);
            txtid.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(104, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(198, 98);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // frmProgramManagementDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 211);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(btnsave);
            Controls.Add(button2);
            Controls.Add(txtfee);
            Controls.Add(txttFee);
            Controls.Add(txtdescription);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProgramManagementDetail";
            Text = "frmProgramManagementDetail";
            Load += frmProgramManagementDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdescription;
        private Label txttFee;
        private TextBox txtfee;
        private Button button2;
        private Button btnsave;
        private TextBox txtid;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}