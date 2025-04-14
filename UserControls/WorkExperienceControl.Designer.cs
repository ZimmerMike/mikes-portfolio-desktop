namespace MyPortfolioDesktopApp.UserControls
{
    partial class WorkExperienceControl
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
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            txtJobTitle = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtCompany = new TextBox();
            txtDescription = new TextBox();
            nudStartYear = new NumericUpDown();
            nudEndYear = new NumericUpDown();
            chkCurrentlyWorking = new CheckBox();
            dgvExperiences = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            jobTitle = new DataGridViewTextBoxColumn();
            company = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            startYear = new DataGridViewTextBoxColumn();
            endYear = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudStartYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExperiences).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(971, 40);
            label1.TabIndex = 0;
            label1.Text = "Experiencia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(99, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 27);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 101);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Puesto o título";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(205, 98);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.PlaceholderText = "Puesto";
            txtJobTitle.Size = new Size(300, 27);
            txtJobTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 134);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 167);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 284);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 7;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(205, 131);
            txtCompany.Name = "txtCompany";
            txtCompany.PlaceholderText = "Empresa";
            txtCompany.Size = new Size(300, 27);
            txtCompany.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(205, 164);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descripción del empleo";
            txtDescription.Size = new Size(300, 200);
            txtDescription.TabIndex = 9;
            // 
            // nudStartYear
            // 
            nudStartYear.Location = new Point(99, 46);
            nudStartYear.Name = "nudStartYear";
            nudStartYear.Size = new Size(200, 27);
            nudStartYear.TabIndex = 10;
            // 
            // nudEndYear
            // 
            nudEndYear.Location = new Point(99, 89);
            nudEndYear.Name = "nudEndYear";
            nudEndYear.Size = new Size(200, 27);
            nudEndYear.TabIndex = 11;
            // 
            // chkCurrentlyWorking
            // 
            chkCurrentlyWorking.AutoSize = true;
            chkCurrentlyWorking.Location = new Point(99, 122);
            chkCurrentlyWorking.Name = "chkCurrentlyWorking";
            chkCurrentlyWorking.Size = new Size(200, 24);
            chkCurrentlyWorking.TabIndex = 12;
            chkCurrentlyWorking.Text = "Actualmente trabajo aquí";
            chkCurrentlyWorking.UseVisualStyleBackColor = true;
            chkCurrentlyWorking.CheckedChanged += chkCurrentlyWorking_CheckedChanged;
            // 
            // dgvExperiences
            // 
            dgvExperiences.AllowUserToAddRows = false;
            dgvExperiences.AllowUserToDeleteRows = false;
            dgvExperiences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExperiences.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExperiences.Columns.AddRange(new DataGridViewColumn[] { id, jobTitle, company, description, startYear, endYear });
            dgvExperiences.Location = new Point(99, 431);
            dgvExperiences.Name = "dgvExperiences";
            dgvExperiences.ReadOnly = true;
            dgvExperiences.RowHeadersVisible = false;
            dgvExperiences.RowHeadersWidth = 51;
            dgvExperiences.Size = new Size(773, 188);
            dgvExperiences.TabIndex = 13;
            dgvExperiences.CellClick += dgvExperiences_CellClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // jobTitle
            // 
            jobTitle.HeaderText = "Puesto o título";
            jobTitle.MinimumWidth = 6;
            jobTitle.Name = "jobTitle";
            jobTitle.ReadOnly = true;
            // 
            // company
            // 
            company.HeaderText = "Empresa";
            company.MinimumWidth = 6;
            company.Name = "company";
            company.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Descripción";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // startYear
            // 
            startYear.HeaderText = "Año de inicio";
            startYear.MinimumWidth = 6;
            startYear.Name = "startYear";
            startYear.ReadOnly = true;
            // 
            // endYear
            // 
            endYear.HeaderText = "Año de fin";
            endYear.MinimumWidth = 6;
            endYear.Name = "endYear";
            endYear.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(205, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 27);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(311, 398);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 27);
            btnClear.TabIndex = 15;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nudStartYear);
            groupBox1.Controls.Add(nudEndYear);
            groupBox1.Controls.Add(chkCurrentlyWorking);
            groupBox1.Location = new Point(516, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 182);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 91);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 11;
            label7.Text = "Hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 48);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "Desde";
            // 
            // WorkExperienceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dgvExperiences);
            Controls.Add(txtDescription);
            Controls.Add(txtCompany);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtJobTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WorkExperienceControl";
            Size = new Size(971, 661);
            Load += WorkExperienceControl_Load;
            ((System.ComponentModel.ISupportInitialize)nudStartYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExperiences).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnSave;
        private Label label2;
        private TextBox txtJobTitle;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtCompany;
        private TextBox txtDescription;
        private NumericUpDown nudStartYear;
        private NumericUpDown nudEndYear;
        private CheckBox chkCurrentlyWorking;
        private DataGridView dgvExperiences;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jobTitle;
        private DataGridViewTextBoxColumn company;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn startYear;
        private DataGridViewTextBoxColumn endYear;
    }
}
