using MongoDB.Driver;

public class MongoService
{
    private readonly IMongoCollection<Project> _projects;

    public MongoService()
    {
        var connectionString = "mongodb+srv://angelmetalhj:zWzyI4BWLK0nMADe@portfolio.gtluj19.mongodb.net";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("portfolio");

        _projects = database.GetCollection<Project>("projects");
    }

    public List<Project> GetAllProjects() =>
        _projects.Find(p => true).ToList();

    public void InsertProject(Project project) =>
        _projects.InsertOne(project);

    public void UpdateProject(Project project) =>
        _projects.ReplaceOne(p => p.Id == project.Id, project);

    public void DeleteProject(string id) =>
        _projects.DeleteOne(p => p.Id == id);
}