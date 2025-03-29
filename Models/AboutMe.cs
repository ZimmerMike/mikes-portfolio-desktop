using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

public class AboutMe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("summary")]
    public string Summary { get; set; }

    [BsonElement("interests")]
    public List<string> Interests { get; set; }

    [BsonElement("technologies")]
    public List<Technology> Technologies { get; set; }

    [BsonElement("languages")]
    public List<Language> Languages { get; set; }

    [BsonElement("contact")]
    public ContactInfo Contact { get; set; }

    public AboutMe()
    {
        Interests = new List<string>();
        Technologies = new List<Technology>();
        Languages = new List<Language>();
        Contact = new ContactInfo();
    }
}

public class KnownTechnology
{
    public string TechnologyId { get; set; }
    public int Years { get; set; }
}

public class Language
{
    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("level")]
    public string Level { get; set; }
}

public class ContactInfo
{
    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("phone")]
    public string Phone { get; set; }

    [BsonElement("scheduleLink")]
    public string? ScheduleLink { get; set; }
}
