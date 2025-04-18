namespace MyPortfolioDesktopApp.UserControls
{
    partial class CertificationControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            txtIssuer = new TextBox();
            txtFileUrl = new TextBox();
            nudYear = new NumericUpDown();
            dgvCertifications = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TitleColumn = new DataGridViewTextBoxColumn();
            Issuer = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            URL = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCertifications).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(1089, 40);
            Title.TabIndex = 0;
            Title.Text = "Cursos y Certificaciones";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 158);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Título del curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 198);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 2;
            label2.Text = "Plataforma o institución";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 236);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 3;
            label3.Text = "Año de emisión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 277);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 4;
            label4.Text = "URL al archivo o certificado";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(526, 155);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Título del curso";
            txtTitle.Size = new Size(300, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtIssuer
            // 
            txtIssuer.Location = new Point(526, 195);
            txtIssuer.Name = "txtIssuer";
            txtIssuer.PlaceholderText = "Plataforma o intitución";
            txtIssuer.Size = new Size(300, 27);
            txtIssuer.TabIndex = 6;
            // 
            // txtFileUrl
            // 
            txtFileUrl.Location = new Point(526, 274);
            txtFileUrl.Name = "txtFileUrl";
            txtFileUrl.PlaceholderText = "URL";
            txtFileUrl.Size = new Size(300, 27);
            txtFileUrl.TabIndex = 7;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(526, 234);
            nudYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(300, 27);
            nudYear.TabIndex = 8;
            nudYear.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // dgvCertifications
            // 
            dgvCertifications.AllowUserToAddRows = false;
            dgvCertifications.AllowUserToDeleteRows = false;
            dgvCertifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCertifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertifications.Columns.AddRange(new DataGridViewColumn[] { Id, TitleColumn, Issuer, Year, URL });
            dgvCertifications.Location = new Point(43, 437);
            dgvCertifications.Name = "dgvCertifications";
            dgvCertifications.ReadOnly = true;
            dgvCertifications.RowHeadersVisible = false;
            dgvCertifications.RowHeadersWidth = 51;
            dgvCertifications.Size = new Size(1001, 280);
            dgvCertifications.TabIndex = 9;
            dgvCertifications.CellClick += dgvCertifications_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // TitleColumn
            // 
            TitleColumn.HeaderText = "Título";
            TitleColumn.MinimumWidth = 6;
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // Issuer
            // 
            Issuer.HeaderText = "Institución";
            Issuer.MinimumWidth = 6;
            Issuer.Name = "Issuer";
            Issuer.ReadOnly = true;
            // 
            // Year
            // 
            Year.HeaderText = "Año";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            // 
            // URL
            // 
            URL.HeaderText = "URL";
            URL.MinimumWidth = 6;
            URL.Name = "URL";
            URL.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 414);
            label5.Name = "label5";
            label5.Size = new Size(234, 20);
            label5.TabIndex = 10;
            label5.Text = "Cursos/Cerficicaciones registradas";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(950, 402);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(850, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(750, 402);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CertificationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(dgvCertifications);
            Controls.Add(nudYear);
            Controls.Add(txtFileUrl);
            Controls.Add(txtIssuer);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "CertificationControl";
            Size = new Size(1089, 759);
            Load += CertificationControl_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCertifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtIssuer;
        private TextBox txtFileUrl;
        private NumericUpDown nudYear;
        private DataGridView dgvCertifications;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn Issuer;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn URL;
        private Label label5;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
    }
}
