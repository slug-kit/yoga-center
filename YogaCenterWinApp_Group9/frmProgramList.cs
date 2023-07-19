using System.ComponentModel;
using System.Globalization;
using Utils;
using YogaCenter.Repository.Repos;
using YogaCenterWinApp_Group9.Controls;
using ProgramModel = YogaCenter.Repository.Models.Program;

namespace YogaCenterWinApp_Group9;

public partial class frmProgramList : Form
{
    private const string DEFAULT_IMG_LOCATION = ".\\Images\\YogaIcon.jpg";

    private const NumberStyles CURRENCY_STYLE = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
    private readonly CultureInfo CULTURE = CultureInfo.CurrentCulture;

    private readonly IProgramRepository programRepository = new ProgramRepository();
    private readonly BindingSource bindingSource = new();

    private readonly bool _adminMode;
    public bool AdminMode
    {
        get => _adminMode;
        init => _adminMode = value;
    }

    public frmProgramList()
    {
        InitializeComponent();
    }

    #region Startup

    private void frmProgramList_Load(object sender, EventArgs e)
    {
        // 1. If user does not have admin privileges, start in limited mode
        // 2. Load data to grid view
        if (!_adminMode)
        {
            StartInLimitedMode();
        }
        BindPrimaryModel();
    }

    private void StartInLimitedMode()
    {
        // Admin mode not implemented, do nothing
    }

    private void BindPrimaryModel()
    {
        try
        {
            // 1. Clear bindings
            foreach (Control control in pnlDetails.Controls)
            {
                control.DataBindings.Clear();
            }
            dgvPrograms.Columns.Clear();
            dgvPrograms.DataSource = null;
            bindingSource.DataSource = null;

            // 2. Bind table to DGV + Customize columns
            var programs = programRepository.GetPrograms().ToList();
            bindingSource.DataSource = programs;
            dgvPrograms.DataSource = bindingSource;

            dgvPrograms.Columns[nameof(ProgramModel.Id)].Visible = false;
            dgvPrograms.Columns[nameof(ProgramModel.Img)].Visible = false;
            dgvPrograms.Columns[nameof(ProgramModel.Inactive)].Visible = false;
            dgvPrograms.Columns[nameof(ProgramModel.Courses)].Visible = false;
            dgvPrograms.Columns[nameof(ProgramModel.Instructors)].Visible = false;
            dgvPrograms.Columns[nameof(ProgramModel.Reviews)].Visible = false;

            // 3. Bind properties to output boxes
            // Image
            var imageBinding = new Binding(nameof(PictureBox.ImageLocation), bindingSource, nameof(ProgramModel.Img),
                true, DataSourceUpdateMode.Never);
            imageBinding.Format += EmptyImageLocationToDefaultImage!;
            pictureBox.DataBindings.Add(imageBinding);
            // ***
            txtName.DataBindings.Add(nameof(TextBox.Text), bindingSource, nameof(ProgramModel.Name),
                true, DataSourceUpdateMode.Never);
            starRatingControl.DataBindings.Add(nameof(StarRatingControl.SelectedStar), bindingSource, nameof(ProgramModel.Rating),
                true, DataSourceUpdateMode.Never);
            // Fee
            var feeBinding = new Binding(nameof(TextBox.Text), bindingSource, nameof(ProgramModel.Fee),
                true, DataSourceUpdateMode.Never);
            feeBinding.Format += DecimalToCurrencyString!;
            txtFee.DataBindings.Add(feeBinding);
            // ***
            rtbDescription.DataBindings.Add(nameof(RichTextBox.Text), bindingSource, nameof(ProgramModel.Description),
                true, DataSourceUpdateMode.Never);

            // 4. Update button states
            UpdateButtons();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR -- Load data");
        }
    }

    private void UpdateButtons()
    {
        var enable = dgvPrograms.RowCount > 0;

        btnCourses.Enabled = enable;
    }

    #endregion

    #region Format and Parse

    private void dgvPrograms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = dgvPrograms.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains('.'))
        {
            object data = dgvPrograms.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
                data = data.GetType().GetProperty(properties[i])?.GetValue(data)!;
            dgvPrograms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }

    private void EmptyImageLocationToDefaultImage(object sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        cevent.Value ??= DEFAULT_IMG_LOCATION;
    }

    private void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
    {
        if (cevent.DesiredType != typeof(string)) return;
        if (cevent.Value == null) return;

        cevent.Value = ((decimal)cevent.Value).ToString("C", CULTURE);
    }

    #endregion

    #region Validation

    #region FilterFee

    private void FilterFee_KeyPress(object sender, KeyPressEventArgs e)
    {
        // This breaks if any of the symbols is more than 1 char long,
        // which is a very rare case anyway.
        char decimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator[0];
        char groupSeparator = NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator[0];
        char currencySymbol = NumberFormatInfo.CurrentInfo.CurrencySymbol[0];
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
            && e.KeyChar != decimalSeparator && e.KeyChar != groupSeparator && e.KeyChar != currencySymbol)
        {
            e.Handled = true;
            return;
        }
        if (e.KeyChar == decimalSeparator && (sender as TextBoxBase)?.Text.IndexOf(decimalSeparator) > -1)
        {
            e.Handled = true;
            return;
        }
        if (e.KeyChar == currencySymbol && sender is TextBoxBase { Text.Length: > 0 })
        {
            e.Handled = true;
            return;
        }
    }

    private bool IsValidPrice(string text) => decimal.TryParse(text, CURRENCY_STYLE, CULTURE, out decimal p)
        && p >= 0;

    private void FilterFee_Validating(object sender, CancelEventArgs e)
    {
        string errorMsg = "Invalid price format. Price must be a positive number.";
        string errorCaption = "Invalid Value";
        try
        {
            TextBoxBase txtb = (TextBoxBase)sender;
            if (string.IsNullOrWhiteSpace(txtb.Text))
                return;

            string trimmedStr = txtb.Text.ReplaceWhitespace("");
            if (!IsValidPrice(trimmedStr))
            {
                MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtb.Focus();
                txtb.SelectAll();
            }
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    private void FilterFee_Validated(object sender, EventArgs e)
    {
        try
        {
            TextBoxBase txtb = (TextBoxBase)sender;
            if (string.IsNullOrWhiteSpace(txtb.Text)) return;

            string trimmedStr = txtb.Text.ReplaceWhitespace("");
            _ = decimal.TryParse(trimmedStr, CURRENCY_STYLE, CULTURE, out decimal value);
            txtb.Text = value.ToString("C", CULTURE);
        }
        catch (InvalidCastException ex)
        {
            MessageBox.Show($"{ex.Message} /n*** It would seem a Programmer had set up the UI incorrectly. ***");
        }
    }

    #endregion

    #endregion

    #region Filter

    private void btnApply_Click(object sender, EventArgs e) => PerformFilter();

    private void FilterField_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && Validate())
        {
            PerformFilter();
        }
    }

    private void PerformFilter()
    {
        if (!ValidateCriteria()) return;

        try
        {
            bool byName = !string.IsNullOrWhiteSpace(txtFilterName.Text);
            bool byLowerFee = decimal.TryParse(txtFilterFeeLow.Text, CURRENCY_STYLE, CULTURE, out var lowerFee);
            bool byUpperFee = decimal.TryParse(txtFilterFeeHigh.Text, CURRENCY_STYLE, CULTURE, out var upperFee);
            bool byInstructor = !string.IsNullOrWhiteSpace(txtFilterInstructor.Text);

            var name = txtFilterName.Text.Trim();
            var instructorNames = txtFilterInstructor.Text.Split(',').Select(str => str.Trim()).ToHashSet();

            // HACK: Intersect() is implemented by looping _secondSet.Remove(_firstSetElement).
            // Thus we need to invert string.Contains()'s caller and argument.
            var instructorNameComparer = new LambdaComparer<string>((s1, s2) => s2.Contains(s1, StringComparison.InvariantCultureIgnoreCase));
            var searchResults = programRepository.GetPrograms()
                .Where(p => (!byName || (p.Name != null && p.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase)))
                    && (!byLowerFee || p.Fee >= lowerFee)
                    && (!byUpperFee || p.Fee <= upperFee)
                    && (!byInstructor || p.Instructors.Select(i => i.Fullname).Intersect(instructorNames, instructorNameComparer).Any())
                )
                .ToList();
            bindingSource.DataSource = searchResults;
            bindingSource.ResetBindings(false);
            UpdateButtons();
            if (!searchResults.Any())
            {
                MessageBox.Show("No program matching such criteria was found.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR -- Search");
        }
    }

    private bool ValidateCriteria()
    {
        if (decimal.TryParse(txtFilterFeeLow.Text, CURRENCY_STYLE, CULTURE, out var lowerFee)
            && decimal.TryParse(txtFilterFeeHigh.Text, CURRENCY_STYLE, CULTURE, out var upperFee))
        {
            if (lowerFee > upperFee)
            {
                MessageBox.Show("Lower fee limit cannot exceed upper fee limit!", "Invalid Criteria Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        return true;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        foreach (Control control in pnlFilters.Controls)
        {
            if (control is TextBoxBase or UpDownBase) { control.Text = string.Empty; }
            else if (control is DateTimePicker dtp) { dtp.Value = DateTime.Now; }
            else if (control is ListControl lsc) { lsc.SelectedIndex = -1; }
        };
        PerformFilter();
    }

    #endregion

    private void btnCourses_Click(object sender, EventArgs e)
    {
        if (dgvPrograms.SelectedRows.Count > 0)
        {
            int selectedRowIndex = dgvPrograms.SelectedRows[0].Index;
            DataGridViewRow selectedRow = dgvPrograms.Rows[selectedRowIndex];
            int programId = (int)selectedRow.Cells[nameof(ProgramModel.Id)].Value;

            frmCourseList frmCourseList = new frmCourseList(programId);
            frmCourseList.ShowDialog();
        }
        else
        {
            MessageBox.Show("Please select a program.");
        }
    }

}
