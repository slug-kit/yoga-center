using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9
{
    public partial class frmProgramManagementEdit : Form
    {
        public frmProgramManagementEdit()
        {
            InitializeComponent();
        }
        public IProgramRepository ProgramRepository { get; set; }
        public bool InsertOrUpdate { get; set; }

        public YogaCenter.Repository.Models.Program Programme { get; set; }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var program = new YogaCenter.Repository.Models.Program
                {
                    //Id = int.Parse(txtid.Text),
                    Description = txtdescription.Text,
                    Fee = int.Parse(txtfee.Text),
                };
                if (InsertOrUpdate == false)
                {
                    ProgramRepository.Add(program);
                }
                else { ProgramRepository.Update(program); }

                MessageBox.Show("Program saved successfully.", InsertOrUpdate == true ? "Update a program" : "Add a new program");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmProgramManagementDetail_Load(object sender, EventArgs e)
        {
            txtid.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtdescription.Text = Programme.Description;
                txtid.Text = Programme.Id.ToString();
                txtfee.Text = Programme.Fee.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
