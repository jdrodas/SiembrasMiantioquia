using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class SiembrasService
    {
        private readonly IMongoCollection<Siembra> _siembrasCollection;

        public SiembrasService(IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _siembrasCollection = mongoDatabase.GetCollection<Siembra>(
                siembrasMiantioquiaDatabaseSettings.Value.SiembrasCollectionName);
        }

        public async Task<List<Siembra>> GetAsync()
        {
            var lasSiembras = await _siembrasCollection.Find(_ => true).ToListAsync();
            return lasSiembras;
        }

        public async Task<Siembra> GetAsync(int codigo)
        {
            var unaSiembra = await _siembrasCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return unaSiembra;
        }

        public async Task CreateAsync(Siembra siembraNueva)
        {
            await _siembrasCollection.InsertOneAsync(siembraNueva);
        }

        public async Task UpdateAsync(int codigo, Siembra siembraActualizada)
        {
            await _siembrasCollection.ReplaceOneAsync(x => x.Codigo == codigo, siembraActualizada);
        }

        public async Task RemoveAsync(int codigo)
        {
            await _siembrasCollection.DeleteOneAsync(x => x.Codigo == codigo);
        }            
    }
}
