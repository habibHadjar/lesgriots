using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesgriots.Application.Interfaces;
using Lesgriots.Domain.Entities;
using Lesgriots.Infrastructure.Data;
using MongoDB.Driver;

namespace Lesgriots.Infrastructure.Services
{
    public class AssetService : IAssetService
    {
        private readonly IMongoCollection<Asset> _assetsCollection;

        public AssetService(MongoDbContext dbContext)
        {
            _assetsCollection = dbContext.Assets;
        }

        public async Task<List<Asset>> GetAllAssetsAsync()
        {
            return await _assetsCollection
         .Find(_ => true)
         .Project(a => new Asset
         {
             Id = a.Id,  // `_id` sera automatiquement converti en `Id`
             Titre = a.Titre,
             Description = a.Description,
             Images = a.Images,
             URL = a.URL
         })
         .ToListAsync();
        }

        public async Task<Asset> GetAssetByIdAsync(int id)
        {
            return await _assetsCollection.Find(asset => asset.Id == id.ToString()).FirstOrDefaultAsync();
        }
    }
}
