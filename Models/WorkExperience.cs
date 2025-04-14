using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class WorkExperience
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
    }
}
