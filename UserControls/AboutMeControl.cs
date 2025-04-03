using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;
using MyPortfolioDesktopApp.Core;
using System.ComponentModel;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class AboutMeControl : UserControl
    {
        private AboutMeService? _aboutService;
        private SkillService? _skillService;
        private AboutMe? _currentAbout;

        public AboutMeControl()
        {
            InitializeComponent();
        }

        private void AboutMeControl_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _aboutService = new AboutMeService();
            _skillService = new SkillService();
            _currentAbout = _aboutService.GetByUserId(Session.UserId);

            if (_currentAbout != null)
            {
                txtResumen.Text = _currentAbout.Summary;
                txtCorreo.Text = _currentAbout.Contact.Email;
                txtTelefono.Text = _currentAbout.Contact.Phone;
                txtReunion.Text = _currentAbout.Contact.MeetingLink;

                lstIntereses.Items.Clear();
                foreach (var item in _currentAbout.Interests)
                    lstIntereses.Items.Add(item);

                dgvIdiomas.Rows.Clear();
                foreach (var lang in _currentAbout.Languages)
                    dgvIdiomas.Rows.Add(lang.Name, lang.Level);
            }

            // Cargar habilidades
            var habilidades = _skillService.GetByUserId(Session.UserId);
            dgvHabilidades.Rows.Clear();
            foreach (var skill in habilidades)
                dgvHabilidades.Rows.Add(skill.Name, skill.ExperienceYears);
        }

        private void btnAgregarInteres_Click(object sender, EventArgs e)
        {
            var interes = txtNuevoInteres.Text.Trim();
            if (!string.IsNullOrEmpty(interes) && !lstIntereses.Items.Contains(interes))
            {
                lstIntereses.Items.Add(interes);
                txtNuevoInteres.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var about = new AboutMe
            {
                UserId = Session.UserId,
                Summary = txtResumen.Text.Trim(),
                Interests = lstIntereses.Items.Cast<string>().ToList(),
                Contact = new ContactInfo
                {
                    Email = txtCorreo.Text.Trim(),
                    Phone = txtTelefono.Text.Trim(),
                    MeetingLink = txtReunion.Text.Trim()
                },
                Languages = dgvIdiomas.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value != null)
                    .Select(r => new Language
                    {
                        Name = r.Cells[0].Value?.ToString() ?? "",
                        Level = r.Cells[1].Value?.ToString() ?? ""
                    }).ToList()
            };

            // Guardar AboutMe
            _aboutService.SaveOrUpdate(about);

            // Guardar habilidades
            var skills = dgvHabilidades.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[0].Value != null && r.Cells[1].Value != null)
                .Select(r => new Skill
                {
                    UserId = Session.UserId,
                    Name = r.Cells[0].Value.ToString()!,
                    ExperienceYears = int.TryParse(r.Cells[1].Value.ToString(), out var years) ? years : 0
                }).ToList();

            _skillService.SaveAll(Session.UserId, skills);

            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
