using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SiembrasMiantioquia_NoSQL_WinForms
{
    public class Contador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("valor")]
        public int Valor { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        public Contador()
        {
            Valor = 0;
            Nombre = "";
        }
    }
}
