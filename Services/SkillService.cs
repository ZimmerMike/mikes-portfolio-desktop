using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class SkillService
    {
        private readonly IMongoCollection<Skill> _collection;

        public SkillService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<Skill>("skills");
        }

        public List<Skill> GetByUserId(string userId)
        {
            return _collection.Find(t => t.UserId == userId).ToList();
        }

        public void SaveAll(string userId, List<Skill> list)
        {
            _collection.DeleteMany(t => t.UserId == userId);
            if (list.Any())
                _collection.InsertMany(list);
        }
    }
}
