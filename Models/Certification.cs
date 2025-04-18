using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class Certification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public int Year { get; set; }
        public string FileUrl { get; set; } = string.Empty;
    }
}
