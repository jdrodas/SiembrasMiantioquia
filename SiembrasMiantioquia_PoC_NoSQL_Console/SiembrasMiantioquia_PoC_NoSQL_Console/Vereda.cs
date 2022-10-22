using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SiembrasMiantioquia_PoC_NoSQL_Console
{
    public class Vereda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Codigo")]
        public int Codigo { get; set; }
        
        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Nombre_Municipio")]
        public string Nombre_Municipio { get; set; }

        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Vereda()
        {
            Codigo = 0;
            Nombre = "";
            Nombre_Municipio = "";
        }
    }
}
