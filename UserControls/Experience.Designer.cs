namespace MyPortfolioDesktopApp.UserControls
{
    partial class Experience
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            PositionColumn = new DataGridViewTextBoxColumn();
            CompanyColumn = new DataGridViewTextBoxColumn();
            StartDateColumn = new DataGridViewTextBoxColumn();
            EndDateColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
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
            label1.Text = "Experiencia";
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PositionColumn, CompanyColumn, StartDateColumn, EndDateColumn, DescriptionColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(971, 581);
            dataGridView1.TabIndex = 2;
            // 
            // PositionColumn
            // 
            PositionColumn.HeaderText = "Puesto";
            PositionColumn.MinimumWidth = 6;
            PositionColumn.Name = "PositionColumn";
            // 
            // CompanyColumn
            // 
            CompanyColumn.HeaderText = "Empresa";
            CompanyColumn.MinimumWidth = 6;
            CompanyColumn.Name = "CompanyColumn";
            // 
            // StartDateColumn
            // 
            StartDateColumn.HeaderText = "Fecha de Inicio";
            StartDateColumn.MinimumWidth = 6;
            StartDateColumn.Name = "StartDateColumn";
            // 
            // EndDateColumn
            // 
            EndDateColumn.HeaderText = "Fecha de Salida";
            EndDateColumn.MinimumWidth = 6;
            EndDateColumn.Name = "EndDateColumn";
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Descripción";
            DescriptionColumn.MinimumWidth = 6;
            DescriptionColumn.Name = "DescriptionColumn";
            // 
            // Experience
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Experience";
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
        private DataGridViewTextBoxColumn PositionColumn;
        private DataGridViewTextBoxColumn CompanyColumn;
        private DataGridViewTextBoxColumn StartDateColumn;
        private DataGridViewTextBoxColumn EndDateColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
    }
}
