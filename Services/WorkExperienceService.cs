using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class WorkExperienceService
    {
        private readonly IMongoCollection<WorkExperience> _collection;

        public WorkExperienceService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<WorkExperience>("workexperience");
        }

        public List<WorkExperience> GetByUserId(string userId)
        {
            return _collection.Find(w => w.UserId == userId).ToList();
        }

        public void SaveOrUpdate(WorkExperience experience)
        {
            if (experience.Id == null)
            {
                _collection.InsertOne(experience);
            }
            else
            {
                _collection.ReplaceOne(w => w.Id == experience.Id, experience);
            }
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(w => w.Id == id);
        }
    }
}
