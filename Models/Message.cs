using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MyPortfolioDesktopApp.Models
{
    public class MessageModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("contenido")]
        public string Contenido { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }
    }
}
