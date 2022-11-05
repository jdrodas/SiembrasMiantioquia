using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SiembrasMiantioquiaAPI.Models
{
    public class Siembra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [BsonElement("Codigo")]
        [JsonPropertyName("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("Vereda")]
        [JsonPropertyName("Vereda")]
        public string Vereda { get; set; } = null!;

        [BsonElement("Municipio")]
        [JsonPropertyName("Municipio")]
        public string Municipio { get; set; } = null!;

        [BsonElement("Contratista")]
        [JsonPropertyName("Contratista")]
        public string Contratista { get; set; } = null!;

        [BsonElement("Arbol")]
        [JsonPropertyName("Arbol")]
        public string Arbol { get; set; } = null!;

        [BsonElement("Total_Arboles")]
        [JsonPropertyName("Total_Arboles")]
        public int Total_Arboles { get; set; } 

        [BsonElement("Total_Hectareas")]
        [JsonPropertyName("Total_Hectareas")]
        public double Total_Hectareas { get; set; }

        [BsonElement("Fecha")]
        [JsonPropertyName("Fecha")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Fecha { get; set; }

    }
}