using MyPortfolioDesktopApp.Core;
using MyPortfolioDesktopApp.Services;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authService.Login(email, password, out User? user, out string message))
            {
                Session.UserId = user!.Id;
                Session.UserEmail = user.Email;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("El correo y la contraseña son obligatorios.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new User
            {
                Email = email,
                PasswordHash = password, // Aquí se cifra en el servicio
                Nombres = txtName.Text.Trim(),
                ApellidoPaterno = txtPaternalSurname.Text.Trim(),
                ApellidoMaterno = txtMaternalSurname.Text.Trim(),
                FechaNacimiento = dtpBirthDate.Value,
                LugarResidencia = txtCurrentResidence.Text.Trim(),
                FechaInicioLaboral = dtpStartWorkingDate.Value,
                TipoTrabajo = cmbJobType.Text,
                ModalidadTrabajo = cmbModality.Text
            };

            if (_authService.Register(user, out string message))
            {
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedTab = tabLogin;
            }
            else
            {
                MessageBox.Show(message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
