using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPortfolioDesktopApp.Models
{
    public class AboutMe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public List<string> Interests { get; set; } = new();

        public List<Language> Languages { get; set; } = new();

        public ContactInfo Contact { get; set; } = new();
    }

    public class Language
    {
        public string Name { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
    }

    public class ContactInfo
    {
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string MeetingLink { get; set; } = string.Empty;
    }
}
