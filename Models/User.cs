using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("passwordHash")]
        public string PasswordHash { get; set; }

        [BsonElement("nombres")]
        public string Nombres { get; set; }

        [BsonElement("apellidoPaterno")]
        public string ApellidoPaterno { get; set; }

        [BsonElement("apellidoMaterno")]
        public string ApellidoMaterno { get; set; }

        [BsonElement("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [BsonElement("lugarResidencia")]
        public string LugarResidencia { get; set; }

        [BsonElement("fechaInicioLaboral")]
        public DateTime FechaInicioLaboral { get; set; }

        [BsonElement("tipoTrabajo")]
        public string TipoTrabajo { get; set; }

        [BsonElement("modalidadTrabajo")]
        public string ModalidadTrabajo { get; set; } // Ej: "Remoto", "Presencial", "Híbrido"

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
