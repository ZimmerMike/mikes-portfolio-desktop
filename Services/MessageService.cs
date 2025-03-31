using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class MessageService
    {
        private readonly IMongoCollection<MessageModel> _mensajes;

        public MessageService()
        {
            try
            {
                var mongo = new MongoService();
                _mensajes = mongo.GetCollection<MessageModel>("mensajes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con MongoDB (mensajes): " + ex.Message);
            }
        }

        public List<MessageModel> GetMessagesByUser(string userId)
        {
            try
            {
                return _mensajes.Find(m => m.UserId == userId)
                                .SortByDescending(m => m.Fecha)
                                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener mensajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<MessageModel>();
            }
        }

        // (Opcional) Método para insertar un mensaje
        public void AddMessage(MessageModel mensaje)
        {
            try
            {
                mensaje.Fecha = DateTime.UtcNow;
                _mensajes.InsertOne(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar mensaje: " + ex.Message);
            }
        }
    }
}
