namespace MyPortfolioDesktopApp.UserControls
{
    partial class Projects
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
            dataGridView1 = new DataGridView();
            ProyectNameColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            RepositoryColumn = new DataGridViewTextBoxColumn();
            URLColumn = new DataGridViewTextBoxColumn();
            LiveURLColumn = new DataGridViewTextBoxColumn();
            TechsColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProyectNameColumn, DescriptionColumn, RepositoryColumn, URLColumn, LiveURLColumn, TechsColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(971, 621);
            dataGridView1.TabIndex = 1;
            // 
            // ProyectNameColumn
            // 
            ProyectNameColumn.HeaderText = "Nombre del Proyecto";
            ProyectNameColumn.MinimumWidth = 6;
            ProyectNameColumn.Name = "ProyectNameColumn";
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Descripción";
            DescriptionColumn.MinimumWidth = 6;
            DescriptionColumn.Name = "DescriptionColumn";
            // 
            // RepositoryColumn
            // 
            RepositoryColumn.HeaderText = "Repositorio";
            RepositoryColumn.MinimumWidth = 6;
            RepositoryColumn.Name = "RepositoryColumn";
            // 
            // URLColumn
            // 
            URLColumn.HeaderText = "URL";
            URLColumn.MinimumWidth = 6;
            URLColumn.Name = "URLColumn";
            // 
            // LiveURLColumn
            // 
            LiveURLColumn.HeaderText = "URL de Despliegue";
            LiveURLColumn.MinimumWidth = 6;
            LiveURLColumn.Name = "LiveURLColumn";
            // 
            // TechsColumn
            // 
            TechsColumn.HeaderText = "Tecnologías";
            TechsColumn.MinimumWidth = 6;
            TechsColumn.Name = "TechsColumn";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 621);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 40);
            panel1.TabIndex = 2;
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
            // Projects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Name = "Projects";
            Size = new Size(971, 661);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProyectNameColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn RepositoryColumn;
        private DataGridViewTextBoxColumn URLColumn;
        private DataGridViewTextBoxColumn LiveURLColumn;
        private DataGridViewTextBoxColumn TechsColumn;
        private Panel panel1;
        private Button button1;
    }
}
