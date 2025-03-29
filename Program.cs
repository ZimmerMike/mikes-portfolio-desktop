namespace MyPortfolioDesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar LoginForm primero
            var loginForm = new LoginForm(); // o LoginFormFix si usaste ese nombre
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el login fue exitoso, abrir MainForm
                Application.Run(new MainForm()); // asegúrate que sea tu form principal
            }
            else
            {
                // Si cierra o falla login, salir de la app
                Application.Exit();
            }
        }
    }
}