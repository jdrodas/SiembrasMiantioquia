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

        public async Task<Siembra?> GetAsync(int codigo) =>
            await _siembrasCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();

        public async Task CreateAsync(Siembra newSiembra) =>
            await _siembrasCollection.InsertOneAsync(newSiembra);

        public async Task UpdateAsync(int codigo, Siembra updatedSiembra) =>
            await _siembrasCollection.ReplaceOneAsync(x => x.Codigo == codigo, updatedSiembra);

        public async Task RemoveAsync(int codigo) =>
            await _siembrasCollection.DeleteOneAsync(x => x.Codigo == codigo);
    }
}
