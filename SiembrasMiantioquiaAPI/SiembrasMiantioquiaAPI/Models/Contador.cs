using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SiembrasMiantioquiaAPI.Models
{
    public class Contador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [BsonElement("valor")]
        [JsonPropertyName("Valor")]
        public int Valor { get; set; }

        [BsonElement("nombre")]
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; } = null!;

        public Contador()
        {
            Valor = 0;
            Nombre = "";
        }
    }
}