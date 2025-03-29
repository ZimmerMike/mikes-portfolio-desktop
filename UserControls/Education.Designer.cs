namespace MyPortfolioDesktopApp.UserControls
{
    partial class Education
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            TitleColumn = new DataGridViewTextBoxColumn();
            InstitutionColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            StartYearColumn = new DataGridViewTextBoxColumn();
            EndYearColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Text = "Educación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 621);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 40);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, InstitutionColumn, StatusColumn, StartYearColumn, EndYearColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(971, 581);
            dataGridView1.TabIndex = 2;
            // 
            // TitleColumn
            // 
            TitleColumn.HeaderText = "Título";
            TitleColumn.MinimumWidth = 6;
            TitleColumn.Name = "TitleColumn";
            // 
            // InstitutionColumn
            // 
            InstitutionColumn.HeaderText = "Institución";
            InstitutionColumn.MinimumWidth = 6;
            InstitutionColumn.Name = "InstitutionColumn";
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Estado";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            // 
            // StartYearColumn
            // 
            StartYearColumn.HeaderText = "Año de Inicio";
            StartYearColumn.MinimumWidth = 6;
            StartYearColumn.Name = "StartYearColumn";
            // 
            // EndYearColumn
            // 
            EndYearColumn.HeaderText = "Año de Salida";
            EndYearColumn.MinimumWidth = 6;
            EndYearColumn.Name = "EndYearColumn";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(818, 8);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 0;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = true;
            // 
            // Education
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Education";
            Size = new Size(971, 661);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn InstitutionColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn StartYearColumn;
        private DataGridViewTextBoxColumn EndYearColumn;
    }
}
