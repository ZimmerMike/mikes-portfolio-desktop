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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblResumenLaboral = new System.Windows.Forms.Label();
            this.groupBoxMensajes = new System.Windows.Forms.GroupBox();
            this.dgvMensajes = new System.Windows.Forms.DataGridView();
            this.groupBoxMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(150, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(220, 25);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Bienvenido, Usuario!";
            // 
            // lblResumenLaboral
            // 
            this.lblResumenLaboral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResumenLaboral.AutoSize = true;
            this.lblResumenLaboral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResumenLaboral.Location = new System.Drawing.Point(150, 60);
            this.lblResumenLaboral.Name = "lblResumenLaboral";
            this.lblResumenLaboral.Size = new System.Drawing.Size(200, 19);
            this.lblResumenLaboral.TabIndex = 1;
            this.lblResumenLaboral.Text = "Resumen laboral del usuario";
            // 
            // groupBoxMensajes
            // 
            this.groupBoxMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                               | System.Windows.Forms.AnchorStyles.Left)
                                                                              | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMensajes.Controls.Add(this.dgvMensajes);
            this.groupBoxMensajes.Location = new System.Drawing.Point(20, 100);
            this.groupBoxMensajes.Name = "groupBoxMensajes";
            this.groupBoxMensajes.Size = new System.Drawing.Size(560, 300);
            this.groupBoxMensajes.TabIndex = 2;
            this.groupBoxMensajes.TabStop = false;
            this.groupBoxMensajes.Text = "Tus mensajes recientes";
            // 
            // dgvMensajes
            // 
            this.dgvMensajes.AllowUserToAddRows = false;
            this.dgvMensajes.AllowUserToDeleteRows = false;
            this.dgvMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                            | System.Windows.Forms.AnchorStyles.Left)
                                                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajes.Location = new System.Drawing.Point(10, 25);
            this.dgvMensajes.Name = "dgvMensajes";
            this.dgvMensajes.ReadOnly = true;
            this.dgvMensajes.Size = new System.Drawing.Size(540, 265);
            this.dgvMensajes.TabIndex = 0;
            // 
            // DashboardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMensajes);
            this.Controls.Add(this.lblResumenLaboral);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.groupBoxMensajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
