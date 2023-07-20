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
            splitContainer = new SplitContainer();
            dgvRequests = new DataGridView();
            btnCancel = new Button();
            label1 = new Label();
            lbCodeOld = new Label();
            lbNameOld = new Label();
            txtCodeOld = new TextBox();
            pictureBoxOld = new PictureBox();
            txtNameOld = new TextBox();
            pictureBoxNew = new PictureBox();
            txtCodeNew = new TextBox();
            lbCodeNew = new Label();
            lbOld = new Label();
            txtNameNew = new TextBox();
            lbNameNew = new Label();
            btnAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvRequests);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(btnCancel);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.Controls.Add(lbCodeOld);
            splitContainer.Panel2.Controls.Add(lbNameOld);
            splitContainer.Panel2.Controls.Add(txtCodeOld);
            splitContainer.Panel2.Controls.Add(pictureBoxOld);
            splitContainer.Panel2.Controls.Add(txtNameOld);
            splitContainer.Panel2.Controls.Add(pictureBoxNew);
            splitContainer.Panel2.Controls.Add(txtCodeNew);
            splitContainer.Panel2.Controls.Add(lbCodeNew);
            splitContainer.Panel2.Controls.Add(lbOld);
            splitContainer.Panel2.Controls.Add(txtNameNew);
            splitContainer.Panel2.Controls.Add(lbNameNew);
            splitContainer.Panel2.Controls.Add(btnAccept);
            splitContainer.Size = new Size(1029, 630);
            splitContainer.SplitterDistance = 259;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
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
            dgvRequests.Size = new Size(259, 630);
            dgvRequests.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(502, 552);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 38);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 25;
            label1.Text = "To be assigned";
            // 
            // lbCodeOld
            // 
            lbCodeOld.AutoSize = true;
            lbCodeOld.Location = new Point(396, 381);
            lbCodeOld.Name = "lbCodeOld";
            lbCodeOld.Size = new Size(46, 21);
            lbCodeOld.TabIndex = 16;
            lbCodeOld.Text = "Code";
            // 
            // lbNameOld
            // 
            lbNameOld.AutoSize = true;
            lbNameOld.Location = new Point(396, 307);
            lbNameOld.Name = "lbNameOld";
            lbNameOld.Size = new Size(52, 21);
            lbNameOld.TabIndex = 13;
            lbNameOld.Text = "Name";
            // 
            // txtCodeOld
            // 
            txtCodeOld.Location = new Point(464, 378);
            txtCodeOld.Name = "txtCodeOld";
            txtCodeOld.Size = new Size(226, 29);
            txtCodeOld.TabIndex = 17;
            // 
            // pictureBoxOld
            // 
            pictureBoxOld.Location = new Point(502, 106);
            pictureBoxOld.Name = "pictureBoxOld";
            pictureBoxOld.Size = new Size(120, 160);
            pictureBoxOld.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOld.TabIndex = 18;
            pictureBoxOld.TabStop = false;
            // 
            // txtNameOld
            // 
            txtNameOld.Location = new Point(464, 304);
            txtNameOld.Name = "txtNameOld";
            txtNameOld.Size = new Size(226, 29);
            txtNameOld.TabIndex = 14;
            // 
            // pictureBoxNew
            // 
            pictureBoxNew.Location = new Point(175, 106);
            pictureBoxNew.Name = "pictureBoxNew";
            pictureBoxNew.Size = new Size(120, 160);
            pictureBoxNew.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNew.TabIndex = 24;
            pictureBoxNew.TabStop = false;
            // 
            // txtCodeNew
            // 
            txtCodeNew.Location = new Point(150, 378);
            txtCodeNew.Name = "txtCodeNew";
            txtCodeNew.Size = new Size(226, 29);
            txtCodeNew.TabIndex = 23;
            // 
            // lbCodeNew
            // 
            lbCodeNew.AutoSize = true;
            lbCodeNew.Location = new Point(76, 381);
            lbCodeNew.Name = "lbCodeNew";
            lbCodeNew.Size = new Size(46, 21);
            lbCodeNew.TabIndex = 22;
            lbCodeNew.Text = "Code";
            // 
            // lbOld
            // 
            lbOld.AutoSize = true;
            lbOld.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbOld.Location = new Point(464, 38);
            lbOld.Name = "lbOld";
            lbOld.Size = new Size(195, 30);
            lbOld.TabIndex = 19;
            lbOld.Text = "Currently assigned";
            // 
            // txtNameNew
            // 
            txtNameNew.Location = new Point(150, 304);
            txtNameNew.Name = "txtNameNew";
            txtNameNew.Size = new Size(226, 29);
            txtNameNew.TabIndex = 21;
            // 
            // lbNameNew
            // 
            lbNameNew.AutoSize = true;
            lbNameNew.Location = new Point(76, 307);
            lbNameNew.Name = "lbNameNew";
            lbNameNew.Size = new Size(52, 21);
            lbNameNew.TabIndex = 20;
            lbNameNew.Text = "Name";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(162, 552);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(134, 40);
            btnAccept.TabIndex = 15;
            btnAccept.Text = "Accept request";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // frmResolveAssignmentRequests
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmResolveAssignmentRequests";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resolve Assignment Requests";
            Load += frmResolveAssignmentRequests_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Button btnCancel;
        private Label label1;
        private Label lbCodeOld;
        private Label lbNameOld;
        private TextBox txtCodeOld;
        private PictureBox pictureBoxOld;
        private TextBox txtNameOld;
        private PictureBox pictureBoxNew;
        private TextBox txtCodeNew;
        private Label lbCodeNew;
        private Label lbOld;
        private TextBox txtNameNew;
        private Label lbNameNew;
        private Button btnAccept;
        private DataGridView dgvRequests;
    }
}