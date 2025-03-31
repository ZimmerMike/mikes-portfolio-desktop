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
            var mongo = new MongoService();
            _users = mongo.GetCollection<User>("users");
        }

        public bool Register(User user, out string message)
        {
            var existing = _users.Find(u => u.Email == user.Email).FirstOrDefault();
            if (existing != null)
            {
                message = "El correo ya está registrado.";
                return false;
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            user.CreatedAt = DateTime.UtcNow;

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

        public User? GetUserById(string userId)
        {
            try
            {
                return _users.Find(u => u.Id == userId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuario por ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
