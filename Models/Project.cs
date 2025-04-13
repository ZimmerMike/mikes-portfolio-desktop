using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RepoUrl { get; set; }
        public string LiveUrl { get; set; }
        public List<Skill> Skills { get; set; } = new();
    }
}
