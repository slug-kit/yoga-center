namespace YogaCenterWinApp_Group9
{
    partial class frmTimetable
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Nothing = new DataGridViewTextBoxColumn();
            colMonday = new DataGridViewTextBoxColumn();
            colTuesday = new DataGridViewTextBoxColumn();
            colWednesday = new DataGridViewTextBoxColumn();
            colThursday = new DataGridViewTextBoxColumn();
            colFriday = new DataGridViewTextBoxColumn();
            colSaturday = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nothing, colMonday, colTuesday, colWednesday, colThursday, colFriday, colSaturday });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(890, 638);
            dataGridView1.TabIndex = 0;
            // 
            // Nothing
            // 
            Nothing.Frozen = true;
            Nothing.HeaderText = "";
            Nothing.Name = "Nothing";
            Nothing.ReadOnly = true;
            // 
            // colMonday
            // 
            colMonday.HeaderText = "Monday";
            colMonday.Name = "colMonday";
            colMonday.ReadOnly = true;
            // 
            // colTuesday
            // 
            colTuesday.HeaderText = "Tuesday";
            colTuesday.Name = "colTuesday";
            colTuesday.ReadOnly = true;
            // 
            // colWednesday
            // 
            colWednesday.HeaderText = "Wednesday";
            colWednesday.Name = "colWednesday";
            colWednesday.ReadOnly = true;
            // 
            // colThursday
            // 
            colThursday.HeaderText = "Thursday";
            colThursday.Name = "colThursday";
            colThursday.ReadOnly = true;
            // 
            // colFriday
            // 
            colFriday.HeaderText = "Friday";
            colFriday.Name = "colFriday";
            colFriday.ReadOnly = true;
            // 
            // colSaturday
            // 
            colSaturday.HeaderText = "Saturday";
            colSaturday.Name = "colSaturday";
            colSaturday.ReadOnly = true;
            // 
            // frmTimetable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 638);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTimetable";
            Text = "TimeTable";
            Load += frmTimetable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nothing;
        private DataGridViewTextBoxColumn colMonday;
        private DataGridViewTextBoxColumn colTuesday;
        private DataGridViewTextBoxColumn colWednesday;
        private DataGridViewTextBoxColumn colThursday;
        private DataGridViewTextBoxColumn colFriday;
        private DataGridViewTextBoxColumn colSaturday;
    }
}
