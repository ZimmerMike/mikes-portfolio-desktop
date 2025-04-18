using MyPortfolioDesktopApp.Core;
using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;
using System.ComponentModel;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class EducationControl : UserControl
    {
        private EducationService _educationService;
        private string? _editingId;

        public EducationControl()
        {
            InitializeComponent();
        }

        private void EducationControl_Load(object sender, EventArgs e)
        {

            nudStartYear.Maximum = DateTime.Now.Year + 10;
            nudEndYear.Maximum = DateTime.Now.Year + 10;

            CargarDatos();
        }

        private void CargarDatos()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _educationService = new();
            dgvEducation.Rows.Clear();
            var list = _educationService.GetByUserId(Session.UserId);

            foreach (var edu in list)
            {
                dgvEducation.Rows.Add(edu.Id, edu.Institution, edu.Degree, edu.Field, edu.StartYear, edu.EndYear);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstitution.Text) || string.IsNullOrWhiteSpace(txtDegree.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            var education = new Education
            {
                Id = _editingId,
                UserId = Session.UserId,
                Institution = txtInstitution.Text.Trim(),
                Degree = txtDegree.Text.Trim(),
                Field = txtField.Text.Trim(),
                StartYear = (int)nudStartYear.Value,
                EndYear = (int)nudEndYear.Value
            };

            _educationService.SaveOrUpdate(education);
            ClearFields();
            CargarDatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEducation.CurrentRow == null) return;

            var id = dgvEducation.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            var confirm = MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _educationService.Delete(id);
                ClearFields();
                CargarDatos();
            }
        }

        private void dgvEducation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = dgvEducation.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            var edu = _educationService.GetById(id);
            if (edu == null) return;

            _editingId = edu.Id;
            txtInstitution.Text = edu.Institution;
            txtDegree.Text = edu.Degree;
            txtField.Text = edu.Field;
            nudStartYear.Value = edu.StartYear;
            if (edu.EndYear.HasValue)
            {
                chkCurrentlyStudying.Checked = false;
                nudEndYear.Enabled = true;
                nudEndYear.Value = edu.EndYear.Value;
            }
            else
            {
                chkCurrentlyStudying.Checked = true;
                nudEndYear.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            _editingId = null;
            txtInstitution.Clear();
            txtDegree.Clear();
            txtField.Clear();
            nudStartYear.Value = nudStartYear.Minimum;
            nudEndYear.Value = nudEndYear.Minimum;
        }
    }
}
