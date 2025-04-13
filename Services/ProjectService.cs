using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;
using MongoDB.Bson;

namespace MyPortfolioDesktopApp.Services
{
    public class ProjectService
    {
        private readonly IMongoCollection<Project> _projects;

        public ProjectService()
        {
            var mongo = new MongoService();
            _projects = mongo.GetCollection<Project>("projects");
        }

        public List<Project> GetProjectsByUser(string userId)
        {
            return _projects.Find(p => p.UserId == userId).ToList();
        }

        public void CreateProject(Project project)
        {
            _projects.InsertOne(project);
        }

        public void UpdateProject(Project project)
        {
            _projects.ReplaceOne(p => p.Id == project.Id, project);
        }

        public void DeleteProject(string projectId)
        {
            _projects.DeleteOne(p => p.Id == projectId);
        }

        public Project? GetById(string projectId)
        {
            return _projects.Find(p => p.Id == projectId).FirstOrDefault();
        }
    }
}
