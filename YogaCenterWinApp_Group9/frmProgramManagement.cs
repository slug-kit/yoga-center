﻿namespace YogaCenterWinApp_Group9;

using System.Security.Cryptography.X509Certificates;
using YogaCenter.Repository;
using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

public partial class frmProgramManagement : Form
{
    public frmProgramManagement()
    {
        InitializeComponent();
    }
    IProgramRepository programRepository = new ProgramRepository();


    //LOAD PROGRAMLIST------------------------------------------------------------------------------------------------------------------

    public void LoadProgramList()
    {
        var programList = programRepository.GetPrograms();
        BindingSource source = new BindingSource();
        source.DataSource = programList;

        txtboxdescription.DataBindings.Clear();
        txtfee.DataBindings.Clear();
        starRatingControl.DataBindings.Clear();

        txtfee.DataBindings.Add("Text", source, "Fee");
        txtboxdescription.DataBindings.Add("Text", source, "Description");
        starRatingControl.DataBindings.Add("SelectedStar", source, "Rating");

        dgvprogram.DataSource = null;
        dgvprogram.DataSource = source;
    }


    private void frmProgramManagement_Load(object sender, EventArgs e)
    {
        LoadProgramList();


    }
    //UPDATE PROGRAM------------------------------------------------------------------------------------------------------------------
    private void dgvprogram_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmProgramManagementDetail frmProgramManagementDetail = new frmProgramManagementDetail()
        {
            Text = "Update Program",
            InsertOrUpdate = true,
            Programme = GetProgram(),
            ProgramRepository = programRepository
        };
        if (frmProgramManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadProgramList();
        }
    }
    //GET PROGRAM FROM DATAGRIDVIEW------------------------------------------------------------------------------------------------------
    private YogaCenter.Repository.Models.Program GetProgram()
    {
        YogaCenter.Repository.Models.Program programs = null;
        try
        {
            if (dgvprogram.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvprogram.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvprogram.Rows[selectedRowIndex];

                programs = new YogaCenter.Repository.Models.Program
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    Fee = int.Parse(txtfee.Text),
                };
            }
        }
        catch (Exception)
        {
            throw;
        }

        return programs;
    }

    //ADD NEW PROGRAM------------------------------------------------------------------------------------------------------------------
    private void btnnew_Click(object sender, EventArgs e)
    {
        ClearText();
        frmProgramManagementDetail frmProgramManagementDetail = new frmProgramManagementDetail()
        {
            Text = "Add Program",
            InsertOrUpdate = false,
            Programme = new YogaCenter.Repository.Models.Program(),
            ProgramRepository = programRepository
        };
        if (frmProgramManagementDetail.ShowDialog() == DialogResult.OK)
        {
            LoadProgramList();
        }
    }


    //CLEAR TEXT------------------------------------------------------------------------------------------------------------------------   
    public void ClearText()
    {
        txtboxdescription.Text = string.Empty;
        txtfee.Text = string.Empty;
    }
    //REMOVE -------------------------------------------------------------
    private void btndelete_Click(object sender, EventArgs e)
    {
        DialogResult d;
        d = MessageBox.Show("Do you really want to delete this record?", "Program",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

        if (d == DialogResult.OK)
        {
            int selectedRowIndex = dgvprogram.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvprogram.Rows[selectedRowIndex];
            var p = new YogaCenter.Repository.Models.Program
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
            };
            programRepository.Delete(p);

            LoadProgramList();

        }
    }
    //SEARCH-------------------------------------------------------------------------------------------------
    private void btnsearch_Click(object sender, EventArgs e)
    {
        string searchText = txtSearchName.Text.Trim(); // Lấy giá trị tìm kiếm từ textbox

        if (!string.IsNullOrEmpty(searchText))
        {
            var programList = programRepository.SearchPrograms(searchText); // Gọi phương thức tìm kiếm từ lớp DAO

            if (programList != null && programList.Any())
            {
                BindingSource source = new BindingSource();
                source.DataSource = programList;

                txtboxdescription.DataBindings.Clear();
                txtfee.DataBindings.Clear();

                txtfee.DataBindings.Add("Text", source, "Fee");
                txtboxdescription.DataBindings.Add("Text", source, "Description");

                dgvprogram.DataSource = null;
                dgvprogram.DataSource = source;
            }
            else
            {
                MessageBox.Show("No matching programs found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            LoadProgramList(); // Nếu không có giá trị tìm kiếm, hiển thị tất cả chương trình
        }
    }
}
