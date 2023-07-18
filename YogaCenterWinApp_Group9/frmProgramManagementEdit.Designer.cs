namespace YogaCenterWinApp_Group9
{
    partial class frmProgramManagementEdit
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
            txtdescription.Location = new Point(15, 113);
            txtdescription.Margin = new Padding(4, 0, 4, 0);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(89, 21);
            txtdescription.TabIndex = 0;
            txtdescription.Text = "Description";
            // 
            // txttFee
            // 
            txttFee.AutoSize = true;
            txttFee.Location = new Point(15, 66);
            txttFee.Margin = new Padding(4, 0, 4, 0);
            txttFee.Name = "txttFee";
            txttFee.Size = new Size(34, 21);
            txttFee.TabIndex = 1;
            txttFee.Text = "Fee";
            // 
            // txtfee
            // 
            txtfee.Location = new Point(134, 62);
            txtfee.Margin = new Padding(4, 3, 4, 3);
            txtfee.Name = "txtfee";
            txtfee.Size = new Size(253, 29);
            txtfee.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(283, 253);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(105, 31);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(134, 253);
            btnsave.Margin = new Padding(4, 3, 4, 3);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(105, 31);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(134, 15);
            txtid.Margin = new Padding(4, 3, 4, 3);
            txtid.Name = "txtid";
            txtid.Size = new Size(253, 29);
            txtid.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(134, 109);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 136);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // frmProgramManagementEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 295);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(btnsave);
            Controls.Add(button2);
            Controls.Add(txtfee);
            Controls.Add(txttFee);
            Controls.Add(txtdescription);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmProgramManagementEdit";
            Text = "Program Details";
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