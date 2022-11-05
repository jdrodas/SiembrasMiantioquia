using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SiembrasMiantioquiaAPI.Models
{
    public class Vereda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [BsonElement("Codigo")]
        [JsonPropertyName("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("Nombre")]
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; } = null!;

        [BsonElement("Nombre_Municipio")]
        [JsonPropertyName("Nombre_Municipio")]
        public string Nombre_Municipio { get; set; } = null!;

        public Vereda()
        {
            Codigo = 0;
            Nombre = "";
            Nombre_Municipio = "";
        }
    }
}