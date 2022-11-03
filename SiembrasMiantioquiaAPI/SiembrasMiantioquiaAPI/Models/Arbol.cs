using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SiembrasMiantioquiaAPI.Models
{
    public class Arbol
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [BsonElement("Codigo")]
        [JsonPropertyName("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("Nombre")]
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; } = null!;
    }
}