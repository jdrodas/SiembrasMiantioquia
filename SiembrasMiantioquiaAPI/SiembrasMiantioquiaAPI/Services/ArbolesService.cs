using SiembrasMiantioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SiembrasMiantioquiaAPI.Services
{
    public class ArbolesService
    {
        private readonly IMongoCollection<Arbol> _arbolesCollection;

        public ArbolesService(IOptions<SiembrasMiantioquiaDatabaseSettings> siembrasMiantioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                siembrasMiantioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                siembrasMiantioquiaDatabaseSettings.Value.DatabaseName);

            _arbolesCollection = mongoDatabase.GetCollection<Arbol>(
                siembrasMiantioquiaDatabaseSettings.Value.ArbolesCollectionName);
        }

        public async Task<List<Arbol>> GetAsync()
        {
            var losArboles = await _arbolesCollection.Find(_ => true).ToListAsync();
            return losArboles;
        }

        public async Task<Arbol> GetAsync(int codigo)
        {
            var unArbol = await _arbolesCollection.Find(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return unArbol;
        }

        public async Task CreateAsync(Arbol arbolNuevo)
        {
            await _arbolesCollection.InsertOneAsync(arbolNuevo);
        }

        public async Task UpdateAsync(int codigo, Arbol arbolActualizado)
        {
            await _arbolesCollection.ReplaceOneAsync(x => x.Codigo == codigo, arbolActualizado);
        }

        public async Task RemoveAsync(int codigo)
        {
            await _arbolesCollection.DeleteOneAsync(x => x.Codigo == codigo);
        }            
    }
}
