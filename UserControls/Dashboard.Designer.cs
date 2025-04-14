namespace MyPortfolioDesktopApp.UserControls
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblBienvenida;
        private Label lblResumenLaboral;
        private DataGridView dgvMensajes;
        private GroupBox groupBoxMensajes;
        // Puedes agregar un ProgressBar u otros controles si lo deseas.

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

        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            lblResumenLaboral = new Label();
            groupBoxMensajes = new GroupBox();
            dgvMensajes = new DataGridView();
            groupBoxMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMensajes).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBienvenida.Location = new Point(394, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(260, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido, Usuario!";
            // 
            // lblResumenLaboral
            // 
            lblResumenLaboral.Anchor = AnchorStyles.Top;
            lblResumenLaboral.AutoSize = true;
            lblResumenLaboral.Font = new Font("Segoe UI", 10F);
            lblResumenLaboral.Location = new Point(394, 60);
            lblResumenLaboral.Name = "lblResumenLaboral";
            lblResumenLaboral.Size = new Size(226, 23);
            lblResumenLaboral.TabIndex = 1;
            lblResumenLaboral.Text = "Resumen laboral del usuario";
            // 
            // groupBoxMensajes
            // 
            groupBoxMensajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMensajes.Controls.Add(dgvMensajes);
            groupBoxMensajes.Location = new Point(20, 100);
            groupBoxMensajes.Name = "groupBoxMensajes";
            groupBoxMensajes.Size = new Size(1049, 609);
            groupBoxMensajes.TabIndex = 2;
            groupBoxMensajes.TabStop = false;
            groupBoxMensajes.Text = "Tus mensajes recientes";
            // 
            // dgvMensajes
            // 
            dgvMensajes.AllowUserToAddRows = false;
            dgvMensajes.AllowUserToDeleteRows = false;
            dgvMensajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMensajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMensajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMensajes.Location = new Point(10, 25);
            dgvMensajes.Name = "dgvMensajes";
            dgvMensajes.ReadOnly = true;
            dgvMensajes.RowHeadersWidth = 51;
            dgvMensajes.Size = new Size(1029, 574);
            dgvMensajes.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxMensajes);
            Controls.Add(lblResumenLaboral);
            Controls.Add(lblBienvenida);
            Name = "Dashboard";
            Size = new Size(1089, 759);
            Load += DashboardControl_Load;
            groupBoxMensajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMensajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
