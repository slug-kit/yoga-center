namespace YogaCenterWinApp_Group9
{
    partial class frmResolveAssignmentRequests
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
            splitContainer1 = new SplitContainer();
            btnCancel = new Button();
            label1 = new Label();
            pictureBoxNew = new PictureBox();
            txtCodeNew = new TextBox();
            lbCodeNew = new Label();
            txtNameNew = new TextBox();
            lbNameNew = new Label();
            lbOld = new Label();
            btnAccept = new Button();
            pictureBoxOld = new PictureBox();
            txtCodeOld = new TextBox();
            lbCodeOld = new Label();
            txtNameOld = new TextBox();
            lbNameOld = new Label();
            dgvRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancel);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(lbCodeOld);
            splitContainer1.Panel1.Controls.Add(lbNameOld);
            splitContainer1.Panel1.Controls.Add(txtCodeOld);
            splitContainer1.Panel1.Controls.Add(pictureBoxOld);
            splitContainer1.Panel1.Controls.Add(txtNameOld);
            splitContainer1.Panel1.Controls.Add(pictureBoxNew);
            splitContainer1.Panel1.Controls.Add(txtCodeNew);
            splitContainer1.Panel1.Controls.Add(lbCodeNew);
            splitContainer1.Panel1.Controls.Add(lbOld);
            splitContainer1.Panel1.Controls.Add(txtNameNew);
            splitContainer1.Panel1.Controls.Add(lbNameNew);
            splitContainer1.Panel1.Controls.Add(btnAccept);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvRequests);
            splitContainer1.Size = new Size(1029, 630);
            splitContainer1.SplitterDistance = 679;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(457, 534);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 11;
            label1.Text = "To be assigned";
            // 
            // pictureBoxNew
            // 
            pictureBoxNew.Location = new Point(130, 88);
            pictureBoxNew.Name = "pictureBoxNew";
            pictureBoxNew.Size = new Size(121, 170);
            pictureBoxNew.TabIndex = 10;
            pictureBoxNew.TabStop = false;
            // 
            // txtCodeNew
            // 
            txtCodeNew.Location = new Point(105, 360);
            txtCodeNew.Name = "txtCodeNew";
            txtCodeNew.Size = new Size(226, 29);
            txtCodeNew.TabIndex = 9;
            // 
            // lbCodeNew
            // 
            lbCodeNew.AutoSize = true;
            lbCodeNew.Location = new Point(31, 363);
            lbCodeNew.Name = "lbCodeNew";
            lbCodeNew.Size = new Size(46, 21);
            lbCodeNew.TabIndex = 8;
            lbCodeNew.Text = "Code";
            // 
            // txtNameNew
            // 
            txtNameNew.Location = new Point(105, 286);
            txtNameNew.Name = "txtNameNew";
            txtNameNew.Size = new Size(226, 29);
            txtNameNew.TabIndex = 7;
            // 
            // lbNameNew
            // 
            lbNameNew.AutoSize = true;
            lbNameNew.Location = new Point(31, 289);
            lbNameNew.Name = "lbNameNew";
            lbNameNew.Size = new Size(52, 21);
            lbNameNew.TabIndex = 6;
            lbNameNew.Text = "Name";
            // 
            // lbOld
            // 
            lbOld.AutoSize = true;
            lbOld.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbOld.Location = new Point(393, 20);
            lbOld.Name = "lbOld";
            lbOld.Size = new Size(195, 30);
            lbOld.TabIndex = 5;
            lbOld.Text = "Currently assigned";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(117, 534);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(134, 40);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept request";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // pictureBoxOld
            // 
            pictureBoxOld.Location = new Point(436, 88);
            pictureBoxOld.Name = "pictureBoxOld";
            pictureBoxOld.Size = new Size(121, 170);
            pictureBoxOld.TabIndex = 4;
            pictureBoxOld.TabStop = false;
            // 
            // txtCodeOld
            // 
            txtCodeOld.Location = new Point(419, 360);
            txtCodeOld.Name = "txtCodeOld";
            txtCodeOld.Size = new Size(226, 29);
            txtCodeOld.TabIndex = 3;
            // 
            // lbCodeOld
            // 
            lbCodeOld.AutoSize = true;
            lbCodeOld.Location = new Point(351, 363);
            lbCodeOld.Name = "lbCodeOld";
            lbCodeOld.Size = new Size(46, 21);
            lbCodeOld.TabIndex = 2;
            lbCodeOld.Text = "Code";
            // 
            // txtNameOld
            // 
            txtNameOld.Location = new Point(419, 286);
            txtNameOld.Name = "txtNameOld";
            txtNameOld.Size = new Size(226, 29);
            txtNameOld.TabIndex = 1;
            // 
            // lbNameOld
            // 
            lbNameOld.AutoSize = true;
            lbNameOld.Location = new Point(351, 289);
            lbNameOld.Name = "lbNameOld";
            lbNameOld.Size = new Size(52, 21);
            lbNameOld.TabIndex = 0;
            lbNameOld.Text = "Name";
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.AllowUserToResizeRows = false;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Dock = DockStyle.Fill;
            dgvRequests.Location = new Point(0, 0);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowTemplate.Height = 25;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(345, 630);
            dgvRequests.TabIndex = 0;
            // 
            // frmResolveAssignmentRequests
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmResolveAssignmentRequests";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resolve Assignment Requests";
            Load += frmResolveAssignmentRequests_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtNameOld;
        private Label lbNameOld;
        private PictureBox pictureBoxOld;
        private TextBox txtCodeOld;
        private Label lbCodeOld;
        private DataGridView dgvRequests;
        private Button btnAccept;
        private Label lbOld;
        private Label label1;
        private PictureBox pictureBoxNew;
        private TextBox txtCodeNew;
        private Label lbCodeNew;
        private TextBox txtNameNew;
        private Label lbNameNew;
        private Button btnCancel;
    }
}