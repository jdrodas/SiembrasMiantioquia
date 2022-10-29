namespace SiembrasMiantioquiaAPI.Models
{
    public class SiembrasMiantioquiaDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string SiembrasCollectionName { get; set; } = null!;

        public string MunicipiosCollectionName { get; set; } = null!;

        public string VeredasCollectionName { get; set; } = null!;

        public string ContratistasCollectionName { get; set; } = null!;

        public string ArbolesCollectionName { get; set; } = null!;

        public string ContadoresCollectionName { get; set; } = null!;
    }
}