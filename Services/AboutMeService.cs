using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class AboutMeService
    {
        private readonly IMongoCollection<AboutMe> _collection;

        public AboutMeService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<AboutMe>("aboutme");
        }

        public AboutMe? GetByUserId(string userId)
        {
            return _collection.Find(a => a.UserId == userId).FirstOrDefault();
        }

        public void SaveOrUpdate(AboutMe data)
        {
            var existing = GetByUserId(data.UserId);
            if (existing == null)
            {
                _collection.InsertOne(data);
            }
            else
            {
                data.Id = existing.Id;
                _collection.ReplaceOne(a => a.Id == existing.Id, data);
            }
        }
    }
}
