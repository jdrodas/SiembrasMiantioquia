using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SiembrasMiantioquia_PoC_NoSQL_Console
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

        [BsonElement("Municipio")]
        public string Municipio { get; set; }

        [BsonElement("Reforestadora")]
        public string Reforestadora { get; set; }

        [BsonElement("Arbol")]
        public string Arbol { get; set; }
        
        [BsonElement("Total_Arboles")]
        public int Total_Arboles { get; set; }
        
        [BsonElement("Total_Hectareas")]
        public double Total_Hectareas { get; set; }

        [BsonElement("Fecha")]
        [BsonDateTimeOptions(Kind =DateTimeKind.Local)]
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            string informacion = $"Código: {Codigo}\n" +
                $"Realizada en {Vereda} - {Municipio}\n" +
                $"Ejecutor: {Reforestadora}\n" +
                $"Variedad de arbol: {Arbol}\n" +
                $"Cantidad de arboles: {Total_Arboles}\n"+
                $"Total Hectáreas: {Total_Hectareas}\n" +
                $"Fecha actividad {Fecha.ToString()}";

            return informacion;
        }
    }
}
