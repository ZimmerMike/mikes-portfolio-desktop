using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;
using MyPortfolioDesktopApp.Core;
using System.ComponentModel;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class WorkExperienceControl : UserControl
    {
        private WorkExperienceService? _service;
        private string? _editingId;

        public WorkExperienceControl()
        {
            InitializeComponent();
        }

        private void WorkExperienceControl_Load(object sender, EventArgs e)
        {
            nudStartYear.Maximum = DateTime.Now.Year + 10;
            nudEndYear.Maximum = DateTime.Now.Year + 10;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _service = new WorkExperienceService();
            dgvExperiences.Rows.Clear();

            var experiencias = _service.GetByUserId(Session.UserId);
            foreach (var exp in experiencias)
            {
                dgvExperiences.Rows.Add(exp.Id, exp.JobTitle, exp.Company, exp.Description, exp.StartYear, exp.EndYear);
            }

            LimpiarFormulario();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text) || string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                MessageBox.Show("El puesto y la empresa son obligatorios.");
                return;
            }

            int? endYear = chkCurrentlyWorking.Checked ? null : (int?)nudEndYear.Value;

            var experiencia = new WorkExperience
            {
                Id = _editingId,
                UserId = Session.UserId,
                JobTitle = txtJobTitle.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                StartYear = (int)nudStartYear.Value,
                EndYear = endYear
            };

            _service!.SaveOrUpdate(experiencia);
            CargarDatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExperiences.CurrentRow == null) return;

            var id = dgvExperiences.CurrentRow.Cells[0].Value?.ToString();
            if (id == null) return;

            var confirm = MessageBox.Show("¿Deseas eliminar esta experiencia?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _service!.Delete(id);
                CargarDatos();
            }
        }

        private void dgvExperiences_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = dgvExperiences.CurrentRow.Cells[0].Value?.ToString();
            if (id == null) return;

            var exp = _service!.GetByUserId(Session.UserId).FirstOrDefault(x => x.Id == id);
            if (exp == null) return;

            _editingId = exp.Id;
            txtJobTitle.Text = exp.JobTitle;
            txtCompany.Text = exp.Company;
            txtDescription.Text = exp.Description;
            nudStartYear.Value = exp.StartYear;
            if (exp.EndYear.HasValue)
            {
                chkCurrentlyWorking.Checked = false;
                nudEndYear.Enabled = true;
                nudEndYear.Value = exp.EndYear.Value;
            }
            else
            {
                chkCurrentlyWorking.Checked = true;
                nudEndYear.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _editingId = null;
            txtJobTitle.Text = "";
            txtCompany.Text = "";
            txtDescription.Text = "";
            nudStartYear.Value = DateTime.Now.Year;
            nudEndYear.Value = DateTime.Now.Year;
            chkCurrentlyWorking.Checked = false;
            nudEndYear.Enabled = true;
        }

        private void chkCurrentlyWorking_CheckedChanged(object sender, EventArgs e)
        {
            nudEndYear.Enabled = !chkCurrentlyWorking.Checked;
        }

    }
}