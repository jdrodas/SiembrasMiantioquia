using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class MunicipiosService
    {
        private readonly IMongoCollection<Municipio> _municipiosCollection;

        public MunicipiosService(IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _municipiosCollection = mongoDatabase.GetCollection<Municipio>(
                siembrasMiantioquiaDatabaseSettings.Value.MunicipiosCollectionName);
        }

        public async Task<List<Municipio>> GetAsync()
        {
            var losMunicipios = await _municipiosCollection.Find(_ => true).ToListAsync();
            return losMunicipios;
        }

        public async Task<Municipio> GetAsync(int codigo)
        {
            var unMunicipio = await _municipiosCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return unMunicipio;
        }

        public async Task CreateAsync(Municipio municipioNuevo)
        {
            await _municipiosCollection.InsertOneAsync(municipioNuevo);
        }

        public async Task UpdateAsync(int codigo, Municipio municipioActualizado)
        {
            await _municipiosCollection.ReplaceOneAsync(x => x.Codigo == codigo, municipioActualizado);
        }

        public async Task RemoveAsync(int codigo)
        {
            await _municipiosCollection.DeleteOneAsync(x => x.Codigo == codigo);
        }            
    }
}
