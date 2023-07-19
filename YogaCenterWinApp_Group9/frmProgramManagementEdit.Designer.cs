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
            lb = new Label();
            lbfee = new Label();
            txtFee = new TextBox();
            button2 = new Button();
            btnsave = new Button();
            txtid = new TextBox();
            label1 = new Label();
            txtdescription = new RichTextBox();
            lbcode = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            lbimg = new Label();
            txtImgLink = new TextBox();
            SuspendLayout();
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(18, 224);
            lb.Margin = new Padding(4, 0, 4, 0);
            lb.Name = "lb";
            lb.Size = new Size(89, 21);
            lb.TabIndex = 0;
            lb.Text = "Description";
            // 
            // lbfee
            // 
            lbfee.AutoSize = true;
            lbfee.Location = new Point(20, 143);
            lbfee.Margin = new Padding(4, 0, 4, 0);
            lbfee.Name = "lbfee";
            lbfee.Size = new Size(34, 21);
            lbfee.TabIndex = 1;
            lbfee.Text = "Fee";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(139, 143);
            txtFee.Margin = new Padding(4, 3, 4, 3);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(105, 29);
            txtFee.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(288, 330);
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
            btnsave.Location = new Point(139, 330);
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
            txtid.Location = new Point(139, 30);
            txtid.Margin = new Padding(4, 3, 4, 3);
            txtid.Name = "txtid";
            txtid.Size = new Size(76, 29);
            txtid.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(139, 224);
            txtdescription.Margin = new Padding(4);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(253, 98);
            txtdescription.TabIndex = 15;
            txtdescription.Text = "";
            // 
            // lbcode
            // 
            lbcode.AutoSize = true;
            lbcode.Location = new Point(17, 184);
            lbcode.Name = "lbcode";
            lbcode.Size = new Size(46, 21);
            lbcode.TabIndex = 16;
            lbcode.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(139, 184);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(105, 29);
            txtCode.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 29);
            txtName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // lbimg
            // 
            lbimg.AutoSize = true;
            lbimg.Location = new Point(20, 113);
            lbimg.Name = "lbimg";
            lbimg.Size = new Size(70, 21);
            lbimg.TabIndex = 21;
            lbimg.Text = "Img Link";
            // 
            // txtImgLink
            // 
            txtImgLink.Location = new Point(139, 110);
            txtImgLink.Name = "txtImgLink";
            txtImgLink.Size = new Size(191, 29);
            txtImgLink.TabIndex = 23;
            // 
            // frmProgramManagementEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 390);
            Controls.Add(txtImgLink);
            Controls.Add(lbimg);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(lbcode);
            Controls.Add(txtdescription);
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(btnsave);
            Controls.Add(button2);
            Controls.Add(txtFee);
            Controls.Add(lbfee);
            Controls.Add(lb);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmProgramManagementEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Program Details";
            Load += frmProgramManagementDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb;
        private Label lbfee;
        private TextBox txtFee;
        private Button button2;
        private Button btnsave;
        private TextBox txtid;
        private Label label1;
        private RichTextBox txtdescription;
        private Label lbcode;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label2;
        private Label lbimg;
        private TextBox txtImgLink;
    }
}