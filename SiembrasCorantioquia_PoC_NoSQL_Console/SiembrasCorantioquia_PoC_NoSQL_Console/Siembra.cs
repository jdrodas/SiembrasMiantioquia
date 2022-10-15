using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SiembrasCorantioquia_PoC_NoSQL_Console
{
    public class Siembra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("Vereda")]
        public string Vereda { get; set; }

        [BsonElement("Fecha")]
        [BsonDateTimeOptions(Kind =DateTimeKind.Local)]
        public DateTime Fecha { get; set; }
    }
}
