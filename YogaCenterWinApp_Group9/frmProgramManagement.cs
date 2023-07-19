using YogaCenter.Repository.Models;
using YogaCenter.Repository.Repos;

namespace YogaCenterWinApp_Group9;

public partial class frmProgramManagement : Form
{
    IProgramRepository programRepository = new ProgramRepository();
    BindingSource source = new BindingSource();

    public frmProgramManagement()
    {
        InitializeComponent();
    }

    //LOAD PROGRAMLIST------------------------------------------------------------------------------------------------------------------
    public void LoadProgramList()
    {
        var programList = programRepository.GetPrograms();
        source.DataSource = programList;

        txtboxdescription.DataBindings.Clear();
        txtFee.DataBindings.Clear();
        starRatingControl.DataBindings.Clear();
        txtName.DataBindings.Clear();
        txtCode.DataBindings.Clear();

        txtCode.DataBindings.Add("Text", source, "Code");
        txtName.DataBindings.Add("Text", source, "Name");
        txtFee.DataBindings.Add("Text", source, "Fee");
        txtboxdescription.DataBindings.Add("Text", source, "Description");
        starRatingControl.DataBindings.Add("SelectedStar", source, "Rating");

        dgvPrograms.DataSource = null;
        dgvPrograms.DataSource = source;
    }

    private void frmProgramManagement_Load(object sender, EventArgs e)
    {
        LoadProgramList();
    }

    //UPDATE PROGRAM------------------------------------------------------------------------------------------------------------------
    private void dgvprogram_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmProgramManagementEdit frmProgramManagementDetail = new frmProgramManagementEdit()
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
        return source.List[dgvPrograms.SelectedRows[0].Index] as YogaCenter.Repository.Models.Program
           ?? throw new Exception("Could not get object model.");
    }

    //ADD NEW PROGRAM------------------------------------------------------------------------------------------------------------------
    private void btnnew_Click(object sender, EventArgs e)
    {
        ClearText();
        frmProgramManagementEdit frmProgramManagementDetail = new frmProgramManagementEdit()
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
        txtFee.Text = string.Empty;
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
            int selectedRowIndex = dgvPrograms.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPrograms.Rows[selectedRowIndex];
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
        string searchText = txtSearchName.Text.Trim(); // Get the search value from the textbox
        string searchCode = txtSearchCode.Text.Trim(); // Get the search value for the Code field
        int? minFee = null;
        int? maxFee = null;
        int? minRating = null;
        int? maxRating = null;

        if (!string.IsNullOrEmpty(txtMinFee.Text))
        {
            minFee = int.Parse(txtMinFee.Text);
        }

        if (!string.IsNullOrEmpty(txtMaxFee.Text))
        {
            maxFee = int.Parse(txtMaxFee.Text);
        }

        if (!string.IsNullOrEmpty(txtMinRating.Text))
        {
            minRating = int.Parse(txtMinRating.Text);
        }

        if (!string.IsNullOrEmpty(txtMaxRating.Text))
        {
            maxRating = int.Parse(txtMaxRating.Text);
        }

        if (!string.IsNullOrEmpty(searchText) || !string.IsNullOrEmpty(searchCode) || minFee.HasValue || maxFee.HasValue || minRating.HasValue || maxRating.HasValue)
        {
            var programList = programRepository.SearchPrograms(searchText, searchCode, minFee, maxFee, minRating, maxRating);

            if (programList != null && programList.Any())
            {
                BindingSource source = new BindingSource();
                source.DataSource = programList;

                txtboxdescription.DataBindings.Clear();
                txtFee.DataBindings.Clear();

                txtFee.DataBindings.Add("Text", source, "Fee");
                txtboxdescription.DataBindings.Add("Text", source, "Description");

                dgvPrograms.DataSource = null;
                dgvPrograms.DataSource = source;
            }
            else
            {
                MessageBox.Show("No matching programs found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            LoadProgramList();
        }
    }
}
