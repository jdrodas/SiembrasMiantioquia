using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SiembrasMiantioquiaAPI.Models
{
    public class Contratista
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [BsonElement("codigo")]
        [JsonPropertyName("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("nombre")]
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; } = null!;

        public Contratista()
        {
            Codigo = 0;
            Nombre = "";
        }
    }
}