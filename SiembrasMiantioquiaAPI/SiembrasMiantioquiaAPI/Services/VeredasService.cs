using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class VeredasService
    {
        private readonly IMongoCollection<Vereda> _veredasCollection;

        public VeredasService(IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _veredasCollection = mongoDatabase.GetCollection<Vereda>(
                siembrasMiantioquiaDatabaseSettings.Value.VeredasCollectionName);
        }

        public async Task<List<Vereda>> GetAsync()
        {
            var lasVeredas = await _veredasCollection.Find(_ => true).ToListAsync();
            return lasVeredas;
        }

        public async Task<Vereda> GetAsync(int codigo)
        {
            var unaVereda = await _veredasCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return unaVereda;
        }

        public async Task CreateAsync(Vereda veredaNueva)
        {
            await _veredasCollection.InsertOneAsync(veredaNueva);
        }

        public async Task UpdateAsync(int codigo, Vereda veredaActualizada)
        {
            await _veredasCollection.ReplaceOneAsync(x => x.Codigo == codigo, veredaActualizada);
        }

        public async Task RemoveAsync(int codigo)
        {
            await _veredasCollection.DeleteOneAsync(x => x.Codigo == codigo);
        }            
    }
}
