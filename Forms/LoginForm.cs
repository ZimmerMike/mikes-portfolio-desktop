using MyPortfolioDesktopApp.Services;
using MyPortfolioDesktopApp.Core;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp
{
    public partial class LoginForm : Form
    {
        private readonly AuthService? _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (_authService.Login(email, password, out User? user, out string message))
            {
                Session.UserId = user!.Id;
                Session.UserEmail = user.Email;
                MessageBox.Show("Bienvenido " + user.Email);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (_authService.Register(email, password, out string message))
            {
                MessageBox.Show("Usuario registrado correctamente.");
            }
            else
            {
                MessageBox.Show(message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
