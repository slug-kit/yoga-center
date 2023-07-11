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
            txtdes = new TextBox();
            txtfee = new TextBox();
            button2 = new Button();
            btnsave = new Button();
            txtid = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtdescription
            // 
            txtdescription.AutoSize = true;
            txtdescription.Location = new Point(28, 55);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(85, 20);
            txtdescription.TabIndex = 0;
            txtdescription.Text = "Description";
            // 
            // txttFee
            // 
            txttFee.AutoSize = true;
            txttFee.Location = new Point(65, 99);
            txttFee.Name = "txttFee";
            txttFee.Size = new Size(32, 20);
            txttFee.TabIndex = 1;
            txttFee.Text = "Fee";
            // 
            // txtdes
            // 
            txtdes.Location = new Point(119, 48);
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(226, 27);
            txtdes.TabIndex = 6;
            // 
            // txtfee
            // 
            txtfee.Location = new Point(119, 99);
            txtfee.Name = "txtfee";
            txtfee.Size = new Size(109, 27);
            txtfee.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(210, 162);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(65, 162);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(119, 15);
            txtid.Name = "txtid";
            txtid.Size = new Size(61, 27);
            txtid.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 18);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // frmProgramManagementDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 217);
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(btnsave);
            Controls.Add(button2);
            Controls.Add(txtfee);
            Controls.Add(txtdes);
            Controls.Add(txttFee);
            Controls.Add(txtdescription);
            Name = "frmProgramManagementDetail";
            Text = "frmProgramManagementDetail";
            Load += frmProgramManagementDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtdescription;
        private Label txttFee;
        private TextBox txtdes;
        private TextBox txtfee;
        private Button button2;
        private Button btnsave;
        private TextBox txtid;
        private Label label1;
    }
}