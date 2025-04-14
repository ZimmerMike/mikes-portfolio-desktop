
namespace MyPortfolioDesktopApp.UserControls
{
    partial class ProjectControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtRepoUrl = new TextBox();
            txt = new Label();
            txtLiveUrl = new TextBox();
            label4 = new Label();
            clbSkills = new CheckedListBox();
            label5 = new Label();
            dgvProjects = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            projectTitle = new DataGridViewTextBoxColumn();
            projectDescription = new DataGridViewTextBoxColumn();
            repoURL = new DataGridViewTextBoxColumn();
            liveURL = new DataGridViewTextBoxColumn();
            skillsApplied = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(971, 40);
            Title.TabIndex = 0;
            Title.Text = "Proyectos";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 614);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 47);
            panel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(662, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 42);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar proyecto";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(818, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 62);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 3;
            label1.Text = "Título del proyecto";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(50, 85);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Título del proyecto";
            txtTitle.Size = new Size(350, 27);
            txtTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(50, 144);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descripción";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(350, 200);
            txtDescription.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 496);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 7;
            label3.Text = "URL del repositorio";
            // 
            // txtRepoUrl
            // 
            txtRepoUrl.Location = new Point(425, 519);
            txtRepoUrl.Name = "txtRepoUrl";
            txtRepoUrl.PlaceholderText = "URL del repositorio";
            txtRepoUrl.Size = new Size(500, 27);
            txtRepoUrl.TabIndex = 8;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(425, 549);
            txt.Name = "txt";
            txt.Size = new Size(92, 20);
            txt.TabIndex = 9;
            txt.Text = "URL del sitio";
            // 
            // txtLiveUrl
            // 
            txtLiveUrl.Location = new Point(425, 572);
            txtLiveUrl.Name = "txtLiveUrl";
            txtLiveUrl.PlaceholderText = "URL del sitio";
            txtLiveUrl.Size = new Size(500, 27);
            txtLiveUrl.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 353);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 11;
            label4.Text = "Habilidades utilizadas";
            // 
            // clbSkills
            // 
            clbSkills.CheckOnClick = true;
            clbSkills.FormattingEnabled = true;
            clbSkills.Location = new Point(50, 376);
            clbSkills.Name = "clbSkills";
            clbSkills.Size = new Size(350, 224);
            clbSkills.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 62);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 13;
            label5.Text = "Proyectos registrados";
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.AllowUserToDeleteRows = false;
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Columns.AddRange(new DataGridViewColumn[] { id, projectTitle, projectDescription, repoURL, liveURL, skillsApplied });
            dgvProjects.Location = new Point(425, 85);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.RowHeadersVisible = false;
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(500, 377);
            dgvProjects.TabIndex = 14;
            dgvProjects.CellClick += dgvProjects_CellClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 51;
            // 
            // projectTitle
            // 
            projectTitle.HeaderText = "Título del proyecto";
            projectTitle.MinimumWidth = 6;
            projectTitle.Name = "projectTitle";
            projectTitle.ReadOnly = true;
            projectTitle.Width = 150;
            // 
            // projectDescription
            // 
            projectDescription.HeaderText = "Descripción";
            projectDescription.MinimumWidth = 6;
            projectDescription.Name = "projectDescription";
            projectDescription.ReadOnly = true;
            projectDescription.Width = 116;
            // 
            // repoURL
            // 
            repoURL.HeaderText = "URL Repositorio";
            repoURL.MinimumWidth = 6;
            repoURL.Name = "repoURL";
            repoURL.ReadOnly = true;
            repoURL.Width = 133;
            // 
            // liveURL
            // 
            liveURL.HeaderText = "URL Sitio";
            liveURL.MinimumWidth = 6;
            liveURL.Name = "liveURL";
            liveURL.ReadOnly = true;
            liveURL.Width = 91;
            // 
            // skillsApplied
            // 
            skillsApplied.HeaderText = "Habilidades utilizadas";
            skillsApplied.MinimumWidth = 6;
            skillsApplied.Name = "skillsApplied";
            skillsApplied.ReadOnly = true;
            skillsApplied.Width = 169;
            // 
            // ProjectControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProjects);
            Controls.Add(label5);
            Controls.Add(clbSkills);
            Controls.Add(label4);
            Controls.Add(txtLiveUrl);
            Controls.Add(txt);
            Controls.Add(txtRepoUrl);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Title);
            Name = "ProjectControl";
            Size = new Size(971, 661);
            Load += ProjectControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Panel panel1;
        private Button btnSave;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtRepoUrl;
        private Label txt;
        private TextBox txtLiveUrl;
        private Label label4;
        private CheckedListBox clbSkills;
        private Label label5;
        private DataGridView dgvProjects;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn projectTitle;
        private DataGridViewTextBoxColumn projectDescription;
        private DataGridViewTextBoxColumn repoURL;
        private DataGridViewTextBoxColumn liveURL;
        private DataGridViewTextBoxColumn skillsApplied;
        private Button btnDelete;
    }
}
