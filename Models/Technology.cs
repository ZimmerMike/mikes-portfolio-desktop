using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Technology
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("category")]
    public string? Category { get; set; }

    [BsonElement("icon")]
    public string? Icon { get; set; }

    [BsonElement("years")]
    public int? Years { get; set; } // Solo si aplica
}
