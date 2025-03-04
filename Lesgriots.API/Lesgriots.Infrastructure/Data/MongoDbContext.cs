
using Lesgriots.Domain.Entities;
using MongoDB.Driver;

namespace Lesgriots.Infrastructure.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Asset> Assets => _database.GetCollection<Asset>("Assets");
    }
}
