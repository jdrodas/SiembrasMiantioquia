using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SiembrasMiantioquia_NoSQL_WinForms
{
    public class Arbol
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("codigo")]
        public int Codigo { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        public Arbol()
        {
            Codigo = 0;
            Nombre = "";
        }
    }
}