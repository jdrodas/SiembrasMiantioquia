using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class ContratistasService
    {
        private readonly IMongoCollection<Contratista> _contratistasCollection;

        public ContratistasService(IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _contratistasCollection = mongoDatabase.GetCollection<Contratista>(
                siembrasMiantioquiaDatabaseSettings.Value.ContratistasCollectionName);
        }

        public async Task<List<Contratista>> GetAsync()
        {
            var losContratistas = await _contratistasCollection.Find(_ => true).ToListAsync();
            return losContratistas;
        }

        public async Task<Contratista> GetAsync(int codigo)
        {
            var unContratista = await _contratistasCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return unContratista;
        }

        public async Task CreateAsync(Contratista contratistaNuevo)
        {
            await _contratistasCollection.InsertOneAsync(contratistaNuevo);
        }

        public async Task UpdateAsync(int codigo, Contratista contratistaActualizado)
        {
            await _contratistasCollection.ReplaceOneAsync(x => x.Codigo == codigo, contratistaActualizado);
        }

        public async Task RemoveAsync(int codigo)
        {
            await _contratistasCollection.DeleteOneAsync(x => x.Codigo == codigo);
        }            
    }
}
