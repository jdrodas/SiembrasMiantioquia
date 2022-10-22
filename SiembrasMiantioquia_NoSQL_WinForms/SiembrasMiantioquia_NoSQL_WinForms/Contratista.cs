using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SiembrasMiantioquia_NoSQL_WinForms
{
    public class Contratista
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("codigo")]
        public int Codigo { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        public Contratista()
        {
            Codigo = 0;
            Nombre = "";
        }
    }
}