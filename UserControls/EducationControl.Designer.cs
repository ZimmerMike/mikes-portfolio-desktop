namespace MyPortfolioDesktopApp.UserControls
{
    partial class EducationControl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtInstitution = new TextBox();
            txtDegree = new TextBox();
            txtField = new TextBox();
            nudStartYear = new NumericUpDown();
            nudEndYear = new NumericUpDown();
            dgvEducation = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Institution = new DataGridViewTextBoxColumn();
            Degree = new DataGridViewTextBoxColumn();
            Field = new DataGridViewTextBoxColumn();
            Start = new DataGridViewTextBoxColumn();
            End = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            chkCurrentlyStudying = new CheckBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudStartYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEducation).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1089, 40);
            label1.TabIndex = 0;
            label1.Text = "Educación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 145);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Institución";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 184);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Título o Grado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 222);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Área de estudio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 48);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 93);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Hasta";
            // 
            // txtInstitution
            // 
            txtInstitution.Location = new Point(220, 142);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "Institución";
            txtInstitution.Size = new Size(300, 27);
            txtInstitution.TabIndex = 6;
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(220, 181);
            txtDegree.Name = "txtDegree";
            txtDegree.PlaceholderText = "Título o Grado";
            txtDegree.Size = new Size(300, 27);
            txtDegree.TabIndex = 7;
            // 
            // txtField
            // 
            txtField.Location = new Point(220, 219);
            txtField.Name = "txtField";
            txtField.PlaceholderText = "Área de estudio";
            txtField.Size = new Size(300, 27);
            txtField.TabIndex = 8;
            // 
            // nudStartYear
            // 
            nudStartYear.Location = new Point(146, 46);
            nudStartYear.Name = "nudStartYear";
            nudStartYear.Size = new Size(200, 27);
            nudStartYear.TabIndex = 9;
            // 
            // nudEndYear
            // 
            nudEndYear.Location = new Point(146, 91);
            nudEndYear.Maximum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudEndYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudEndYear.Name = "nudEndYear";
            nudEndYear.Size = new Size(200, 27);
            nudEndYear.TabIndex = 10;
            nudEndYear.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // dgvEducation
            // 
            dgvEducation.AllowUserToAddRows = false;
            dgvEducation.AllowUserToDeleteRows = false;
            dgvEducation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEducation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEducation.Columns.AddRange(new DataGridViewColumn[] { Id, Institution, Degree, Field, Start, End });
            dgvEducation.Location = new Point(42, 392);
            dgvEducation.Name = "dgvEducation";
            dgvEducation.ReadOnly = true;
            dgvEducation.RowHeadersVisible = false;
            dgvEducation.RowHeadersWidth = 51;
            dgvEducation.Size = new Size(1004, 318);
            dgvEducation.TabIndex = 11;
            dgvEducation.CellClick += dgvEducation_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Institution
            // 
            Institution.HeaderText = "Institución";
            Institution.MinimumWidth = 6;
            Institution.Name = "Institution";
            Institution.ReadOnly = true;
            // 
            // Degree
            // 
            Degree.HeaderText = "Título";
            Degree.MinimumWidth = 6;
            Degree.Name = "Degree";
            Degree.ReadOnly = true;
            // 
            // Field
            // 
            Field.HeaderText = "Área";
            Field.MinimumWidth = 6;
            Field.Name = "Field";
            Field.ReadOnly = true;
            // 
            // Start
            // 
            Start.HeaderText = "Inicio";
            Start.MinimumWidth = 6;
            Start.Name = "Start";
            Start.ReadOnly = true;
            // 
            // End
            // 
            End.HeaderText = "Fin";
            End.MinimumWidth = 6;
            End.Name = "End";
            End.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(953, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(853, 357);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(753, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkCurrentlyStudying
            // 
            chkCurrentlyStudying.AutoSize = true;
            chkCurrentlyStudying.Location = new Point(145, 124);
            chkCurrentlyStudying.Name = "chkCurrentlyStudying";
            chkCurrentlyStudying.Size = new Size(201, 24);
            chkCurrentlyStudying.TabIndex = 15;
            chkCurrentlyStudying.Text = "Actualmente estudio aquí";
            chkCurrentlyStudying.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudStartYear);
            groupBox1.Controls.Add(chkCurrentlyStudying);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nudEndYear);
            groupBox1.Location = new Point(597, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 182);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // EducationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(dgvEducation);
            Controls.Add(txtField);
            Controls.Add(txtDegree);
            Controls.Add(txtInstitution);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EducationControl";
            Size = new Size(1089, 759);
            Load += EducationControl_Load;
            ((System.ComponentModel.ISupportInitialize)nudStartYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEducation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtInstitution;
        private TextBox txtDegree;
        private TextBox txtField;
        private NumericUpDown nudStartYear;
        private NumericUpDown nudEndYear;
        private DataGridView dgvEducation;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Institution;
        private DataGridViewTextBoxColumn Degree;
        private DataGridViewTextBoxColumn Field;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn End;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private CheckBox chkCurrentlyStudying;
        private GroupBox groupBox1;
    }
}
