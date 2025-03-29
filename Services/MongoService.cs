using MongoDB.Driver;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace MyPortfolioDesktopApp.Services
{
    public class MongoService
    {
        private const string ConnectionName = "MongoDBURI";
        private readonly IMongoDatabase? _database;

        public MongoService()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings[ConnectionName]?.ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                    throw new ConfigurationErrorsException($"No se encontró la cadena de conexión '{ConnectionName}' en App.config.");

                var client = new MongoClient(connectionString);
                _database = client.GetDatabase("portfolio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en MongoService: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            if (_database == null)
                throw new Exception("No se pudo inicializar la base de datos.");

            return _database.GetCollection<T>(collectionName);
        }
    }
}
