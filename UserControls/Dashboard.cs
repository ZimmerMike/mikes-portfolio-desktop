using System;
using System.ComponentModel;
using System.Windows.Forms;
using MyPortfolioDesktopApp.Core;
using MyPortfolioDesktopApp.Models;
using MyPortfolioDesktopApp.Services;

namespace MyPortfolioDesktopApp.UserControls
{
    public partial class Dashboard : UserControl
    {
        // Suponiendo que tienes un servicio para usuarios y mensajes
        private AuthService? _authService;
        private MessageService? _mensajeService;

        public Dashboard()
        {
            InitializeComponent();
        }

        // Método para cargar la información del usuario y mensajes
        public void CargarDatos()
        {
            // Evita errores en el diseñador
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _authService = new AuthService();
            _mensajeService = new MessageService();

            var user = _authService.GetUserById(Session.UserId);
            if (user == null) return;

            lblBienvenida.Text = $"¡Bienvenido, {user.Nombres}!";
            TimeSpan ts = DateTime.Now - user.FechaInicioLaboral;
            int años = (int)(ts.TotalDays / 365);
            int meses = (int)((ts.TotalDays % 365) / 30);
            lblResumenLaboral.Text = $"Llevas {años} años y {meses} meses trabajando.";

            dgvMensajes.DataSource = _mensajeService.GetMessagesByUser(user.Id);
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CargarDatos(); // O lo que quieras hacer al cargar el dashboard
            }
        }
    }
}
