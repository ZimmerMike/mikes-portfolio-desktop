using MongoDB.Driver;
using MongoDB.Bson;
using BCrypt.Net;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class AuthService
    {
        private readonly IMongoCollection<User> _users;

        public AuthService()
        {
            try
            {
                var mongo = new MongoService();
                _users = mongo.GetCollection<User>("users");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AuthService: " + ex.Message);
            }
        }

        public bool Register(string email, string password, out string message)
        {
            var existing = _users.Find(u => u.Email == email).FirstOrDefault();
            if (existing != null)
            {
                message = "El correo ya está registrado.";
                return false;
            }

            var user = new User
            {
                Email = email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                CreatedAt = DateTime.UtcNow
            };

            _users.InsertOne(user);
            message = "Registro exitoso.";
            return true;
        }

        public bool Login(string email, string password, out User? user, out string message)
        {
            user = _users.Find(u => u.Email == email).FirstOrDefault();
            if (user == null)
            {
                message = "Usuario no encontrado.";
                return false;
            }

            bool valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            if (!valid)
            {
                message = "Contraseña incorrecta.";
                user = null;
                return false;
            }

            message = "Inicio de sesión exitoso.";
            return true;
        }
    }
}
