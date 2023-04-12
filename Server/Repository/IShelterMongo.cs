using Shelter.Shared;
using Server.Repository;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Server.Repository
{
    public class IShelterMongo : IShelterRepo
    {
        private const string connectionString = @"mongodb+srv://eaa:87654321@clusterboys.7blwzny.mongodb.net/test";
        private const string databaseName = "shelterDB";
        private const string collectionName = "shelter";
        private IMongoCollection<ShelterItem> collection;


        public IShelterMongo()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<ShelterItem>(collectionName);
        }

        public void Add(ShelterItem item)
        {
            collection.InsertOne(item);
        }

        public void Remove(int id)
        {
            collection.DeleteOne(item => item.Id == id);
        }

        public ShelterItem[] getAll()
        {
            return collection.Find(i => true).ToList().ToArray();
        }

        public void Update(ShelterItem item)
        {
            collection.ReplaceOne(i => i.Id == item.Id, item);
        }
    }
}
