using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Project
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public string RepoUrl { get; set; }
    public string LiveUrl { get; set; }
    public List<string> Technologies { get; set; }
}