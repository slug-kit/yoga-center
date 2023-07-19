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
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
                if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtFee.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Input Validation Error");
                    return;
                }

                var program = new YogaCenter.Repository.Models.Program
                {
                    Code = txtCode.Text,
                    Description = txtdescription.Text,
                    Name = txtName.Text,
                    Img = txtImgLink.Text,
                };

                if (!int.TryParse(txtFee.Text, out int fee))
                {
                    MessageBox.Show("Invalid fee value. Please enter a valid integer.", "Input Validation Error");
                    return;
                }

                program.Fee = fee;

                if (!InsertOrUpdate)
                {
                    // Check if the code is unique before adding the program
                    if (ProgramRepository.IsCodeUnique(program.Code))
                    {
                        ProgramRepository.Add(program);
                        MessageBox.Show("Program saved successfully.", "Add a new program");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Code must be unique. Please enter a different code.", "Code Validation Error");
                    }
                }
                else
                {
                    // Update the program without checking for code uniqueness
                    ProgramRepository.Update(program);
                    MessageBox.Show("Program updated successfully.", "Update a program");
                    Close();
                }
                DialogResult = DialogResult.OK;
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
                txtCode.Text = Programme.Code;
                txtdescription.Text = Programme.Description;
                txtid.Text = Programme.Id.ToString();
                txtFee.Text = Programme.Fee.ToString();
                txtName.Text = Programme?.Name?.ToString();
                txtImgLink.Text = Programme?.Img?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
