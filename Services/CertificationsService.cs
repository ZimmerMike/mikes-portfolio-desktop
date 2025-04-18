using MongoDB.Driver;
using MyPortfolioDesktopApp.Models;

namespace MyPortfolioDesktopApp.Services
{
    public class CertificationService
    {
        private readonly IMongoCollection<Certification> _collection;

        public CertificationService()
        {
            var mongo = new MongoService();
            _collection = mongo.GetCollection<Certification>("certifications");
        }

        public List<Certification> GetByUserId(string userId)
        {
            return _collection.Find(c => c.UserId == userId).ToList();
        }

        public Certification? GetById(string id)
        {
            return _collection.Find(c => c.Id == id).FirstOrDefault();
        }

        public void SaveOrUpdate(Certification cert)
        {
            if (string.IsNullOrEmpty(cert.Id))
                _collection.InsertOne(cert);
            else
                _collection.ReplaceOne(c => c.Id == cert.Id, cert);
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(c => c.Id == id);
        }
    }
}
