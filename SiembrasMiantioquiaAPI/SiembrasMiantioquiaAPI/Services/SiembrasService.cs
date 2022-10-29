using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class SiembrasService
    {
        private readonly IMongoCollection<Siembra> _siembrasCollection;

        public SiembrasService(
                IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _siembrasCollection = mongoDatabase.GetCollection<Siembra>(
                siembrasMiantioquiaDatabaseSettings.Value.SiembrasCollectionName);
        }

        public async Task<List<Siembra>> GetAsync() =>
    await _siembrasCollection.Find(_ => true).ToListAsync();

        public async Task<Siembra?> GetAsync(string id) =>
            await _siembrasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Siembra newSiembra) =>
            await _siembrasCollection.InsertOneAsync(newSiembra);

        public async Task UpdateAsync(string id, Siembra updatedSiembra) =>
            await _siembrasCollection.ReplaceOneAsync(x => x.Id == id, updatedSiembra);

        public async Task RemoveAsync(string id) =>
            await _siembrasCollection.DeleteOneAsync(x => x.Id == id);
    }
}
