using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;
using MyPortfolioDesktopApp.Core;
using System.ComponentModel;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class ProjectControl : UserControl
    {
        private ProjectService _projectService;
        private SkillService _skillService;
        private string? _editingProjectId = null;

        public ProjectControl()
        {
            InitializeComponent();
        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _projectService = new ProjectService();
            _skillService = new SkillService();
            LoadSkills();
            LoadProjects();
        }

        private void LoadSkills()
        {
            clbSkills.Items.Clear();
            var skills = _skillService.GetByUserId(Session.UserId);
            foreach (var skill in skills)
            {
                clbSkills.Items.Add(skill);
            }
        }

        private void LoadProjects()
        {
            dgvProjects.Rows.Clear();
            var projects = _projectService.GetProjectsByUser(Session.UserId);
            foreach (var project in projects)
            {
                dgvProjects.Rows.Add(project.Id, project.Title, project.Description, project.RepoUrl, project.LiveUrl, string.Join(", ", project.Skills.Select(s => s.Name)));
            }
        }

        private void ClearFields()
        {
            _editingProjectId = null;
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtRepoUrl.Text = "";
            txtLiveUrl.Text = "";
            for (int i = 0; i < clbSkills.Items.Count; i++)
                clbSkills.SetItemChecked(i, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var desc = txtDescription.Text.Trim();
            var repo = txtRepoUrl.Text.Trim();
            var live = txtLiveUrl.Text.Trim();

            var skills = clbSkills.CheckedItems.Cast<Skill>().ToList();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("El título es obligatorio.");
                return;
            }

            var project = new Project
            {
                Id = _editingProjectId,
                UserId = Session.UserId,
                Title = title,
                Description = desc,
                RepoUrl = repo,
                LiveUrl = live,
                Skills = skills
            };

            if (string.IsNullOrEmpty(_editingProjectId))
                _projectService.CreateProject(project);
            else
                _projectService.UpdateProject(project);

            ClearFields();
            LoadProjects();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null) return;

            var id = dgvProjects.CurrentRow.Cells[0].Value?.ToString();
            if (id == null) return;

            var confirm = MessageBox.Show("¿Eliminar este proyecto?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _projectService.DeleteProject(id);
                ClearFields();
                LoadProjects();
            }
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = dgvProjects.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (id == null) return;

            var project = _projectService.GetById(id);
            if (project == null) return;

            _editingProjectId = project.Id;
            txtTitle.Text = project.Title;
            txtDescription.Text = project.Description;
            txtRepoUrl.Text = project.RepoUrl;
            txtLiveUrl.Text = project.LiveUrl;

            for (int i = 0; i < clbSkills.Items.Count; i++)
            {
                var skill = clbSkills.Items[i] as Skill;
                if (skill != null)
                    clbSkills.SetItemChecked(i, project.Skills.Any(s => s.Id == skill.Id));
            }
        }
    }
}
