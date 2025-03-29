using MongoDB.Driver;
using System.Linq;

namespace MyPortfolioDesktopApp.Services
{
    public class AboutMeService
    {
        private readonly IMongoCollection<AboutMe> _collection;

        public AboutMeService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<AboutMe>("aboutMe");
        }

        public AboutMe? GetAboutMe()
        {
            return _collection.Find(_ => true).FirstOrDefault();
        }

        public void SaveAboutMe(AboutMe aboutMe)
        {
            var existing = GetAboutMe();
            if (existing != null && !string.IsNullOrEmpty(existing.Id))
            {
                aboutMe.Id = existing.Id;
                _collection.ReplaceOne(a => a.Id == aboutMe.Id, aboutMe);
            }
            else
            {
                _collection.InsertOne(aboutMe);
            }
        }
    }
}
