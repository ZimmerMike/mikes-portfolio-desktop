using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class Skill
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int ExperienceYears { get; set; }
        public override string ToString()
        {
            return $"{Name} ({ExperienceYears} año{(ExperienceYears != 1 ? "s" : "")})";
        }
    }

}
