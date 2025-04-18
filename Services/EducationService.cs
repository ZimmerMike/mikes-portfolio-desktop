using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class EducationService
    {
        private readonly IMongoCollection<Education> _collection;

        public EducationService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<Education>("education");
        }

        public List<Education> GetByUserId(string userId)
        {
            return _collection.Find(e => e.UserId == userId).ToList();
        }

        public Education? GetById(string id)
        {
            return _collection.Find(e => e.Id == id).FirstOrDefault();
        }

        public void SaveOrUpdate(Education data)
        {
            if (string.IsNullOrEmpty(data.Id))
            {
                _collection.InsertOne(data);
            }
            else
            {
                _collection.ReplaceOne(e => e.Id == data.Id, data);
            }
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(e => e.Id == id);
        }
    }
}
