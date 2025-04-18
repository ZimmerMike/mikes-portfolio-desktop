using MyPortfolioDesktopApp.Core;
using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;
using System.ComponentModel;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class CertificationControl : UserControl
    {
        private CertificationService? _certificationService;
        private string? _editingId;

        public CertificationControl()
        {
            InitializeComponent();
        }

        private void CertificationControl_Load(object sender, EventArgs e)
        {
            nudYear.Maximum = DateTime.Now.Year + 10;
            LoadCertifications();
        }

        private void LoadCertifications()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _certificationService = new();
            dgvCertifications.Rows.Clear();
            var list = _certificationService.GetByUserId(Session.UserId);
            foreach (var cert in list)
            {
                dgvCertifications.Rows.Add(cert.Id, cert.Title, cert.Issuer, cert.Year, cert.FileUrl);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtIssuer.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            var cert = new Certification
            {
                Id = _editingId,
                UserId = Session.UserId,
                Title = txtTitle.Text.Trim(),
                Issuer = txtIssuer.Text.Trim(),
                Year = (int)nudYear.Value,
                FileUrl = txtFileUrl.Text.Trim()
            };

            _certificationService.SaveOrUpdate(cert);
            ClearFields();
            LoadCertifications();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCertifications.CurrentRow == null) return;

            var id = dgvCertifications.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            var confirm = MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _certificationService.Delete(id);
                ClearFields();
                LoadCertifications();
            }
        }

        private void dgvCertifications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = dgvCertifications.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            var cert = _certificationService.GetById(id);
            if (cert == null) return;

            _editingId = cert.Id;
            txtTitle.Text = cert.Title;
            txtIssuer.Text = cert.Issuer;
            nudYear.Value = cert.Year;
            txtFileUrl.Text = cert.FileUrl;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            _editingId = null;
            txtTitle.Clear();
            txtIssuer.Clear();
            txtFileUrl.Clear();
            nudYear.Value = DateTime.Now.Year;
        }
    }
}
