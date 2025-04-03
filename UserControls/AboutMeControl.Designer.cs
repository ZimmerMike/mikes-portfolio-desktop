namespace MyPortfolioDesktopApp.UserControls
{
    partial class AboutMeControl
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
            txtResumen = new TextBox();
            label2 = new Label();
            txtNuevoInteres = new TextBox();
            lstIntereses = new ListBox();
            btnAgregarInteres = new Button();
            btnGuardar = new Button();
            dgvIdiomas = new DataGridView();
            LanguageColumn = new DataGridViewTextBoxColumn();
            LevelColumn = new DataGridViewTextBoxColumn();
            txtCorreo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtReunion = new TextBox();
            txtTelefono = new TextBox();
            groupBox2 = new GroupBox();
            dgvHabilidades = new DataGridView();
            SkillColumn = new DataGridViewTextBoxColumn();
            ExperienceColumn = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvIdiomas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            label1.Text = "Sobre Mí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(28, 98);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(405, 81);
            txtResumen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 2;
            label2.Text = "Resumen de Trayectoria";
            // 
            // txtNuevoInteres
            // 
            txtNuevoInteres.Location = new Point(6, 24);
            txtNuevoInteres.Name = "txtNuevoInteres";
            txtNuevoInteres.PlaceholderText = "Agrega un interes";
            txtNuevoInteres.Size = new Size(347, 27);
            txtNuevoInteres.TabIndex = 4;
            // 
            // lstIntereses
            // 
            lstIntereses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstIntereses.FormattingEnabled = true;
            lstIntereses.Location = new Point(6, 57);
            lstIntereses.Name = "lstIntereses";
            lstIntereses.Size = new Size(390, 84);
            lstIntereses.TabIndex = 5;
            // 
            // btnAgregarInteres
            // 
            btnAgregarInteres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarInteres.Location = new Point(359, 24);
            btnAgregarInteres.Name = "btnAgregarInteres";
            btnAgregarInteres.Size = new Size(40, 27);
            btnAgregarInteres.TabIndex = 6;
            btnAgregarInteres.Text = "+";
            btnAgregarInteres.UseVisualStyleBackColor = true;
            btnAgregarInteres.Click += btnAgregarInteres_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(801, 616);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 42);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvIdiomas
            // 
            dgvIdiomas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIdiomas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIdiomas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdiomas.Columns.AddRange(new DataGridViewColumn[] { LanguageColumn, LevelColumn });
            dgvIdiomas.Location = new Point(6, 26);
            dgvIdiomas.Name = "dgvIdiomas";
            dgvIdiomas.RowHeadersVisible = false;
            dgvIdiomas.RowHeadersWidth = 51;
            dgvIdiomas.Size = new Size(412, 172);
            dgvIdiomas.TabIndex = 11;
            // 
            // LanguageColumn
            // 
            LanguageColumn.HeaderText = "Idioma";
            LanguageColumn.MinimumWidth = 6;
            LanguageColumn.Name = "LanguageColumn";
            // 
            // LevelColumn
            // 
            LevelColumn.HeaderText = "Nivel";
            LevelColumn.MinimumWidth = 6;
            LevelColumn.Name = "LevelColumn";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(108, 41);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(287, 27);
            txtCorreo.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(41, 127);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 16;
            label9.Text = "Agenda";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(35, 85);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "Teléfono";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(56, 44);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtReunion);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(520, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 181);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Contacto";
            // 
            // txtReunion
            // 
            txtReunion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtReunion.Location = new Point(108, 124);
            txtReunion.Name = "txtReunion";
            txtReunion.Size = new Size(287, 27);
            txtReunion.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(108, 82);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(287, 27);
            txtTelefono.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHabilidades);
            groupBox2.Location = new Point(28, 361);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 204);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habilidades";
            // 
            // dgvHabilidades
            // 
            dgvHabilidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabilidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilidades.Columns.AddRange(new DataGridViewColumn[] { SkillColumn, ExperienceColumn });
            dgvHabilidades.Location = new Point(6, 26);
            dgvHabilidades.Name = "dgvHabilidades";
            dgvHabilidades.RowHeadersVisible = false;
            dgvHabilidades.RowHeadersWidth = 51;
            dgvHabilidades.Size = new Size(390, 172);
            dgvHabilidades.TabIndex = 0;
            // 
            // SkillColumn
            // 
            SkillColumn.HeaderText = "Habilidad";
            SkillColumn.MinimumWidth = 6;
            SkillColumn.Name = "SkillColumn";
            // 
            // ExperienceColumn
            // 
            ExperienceColumn.HeaderText = "Años de Experiencia";
            ExperienceColumn.MinimumWidth = 6;
            ExperienceColumn.Name = "ExperienceColumn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstIntereses);
            groupBox3.Controls.Add(txtNuevoInteres);
            groupBox3.Controls.Add(btnAgregarInteres);
            groupBox3.Location = new Point(28, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(405, 164);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intereses";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(dgvIdiomas);
            groupBox4.Location = new Point(520, 75);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(424, 204);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Idiomas";
            // 
            // AboutMeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtResumen);
            Controls.Add(label1);
            Name = "AboutMeControl";
            Size = new Size(971, 661);
            Load += AboutMeControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIdiomas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResumen;
        private Label label2;
        private TextBox txtNuevoInteres;
        private ListBox lstIntereses;
        private Button btnAgregarInteres;
        private Button btnGuardar;
        private DataGridView dgvIdiomas;
        private DataGridViewTextBoxColumn LanguageColumn;
        private DataGridViewTextBoxColumn LevelColumn;
        private TextBox txtCorreo;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtReunion;
        private TextBox txtTelefono;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvHabilidades;
        private DataGridViewTextBoxColumn SkillColumn;
        private DataGridViewTextBoxColumn ExperienceColumn;
    }
}
