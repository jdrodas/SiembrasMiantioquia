using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SiembrasMiantioquia_NoSQL_WinForms
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

        [BsonElement("Contratista")]
        public string Contratista { get; set; }

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
            string informacion = $"Código: {Codigo}" + Environment.NewLine +
                $"Realizada en {Vereda} - {Municipio}" + Environment.NewLine +
                $"Ejecutor: {Contratista}" + Environment.NewLine +
                $"Variedad de arbol: {Arbol}" + Environment.NewLine +
                $"Cantidad de arboles: {Total_Arboles}" + Environment.NewLine +
                $"Total Hectáreas: {Total_Hectareas}" + Environment.NewLine +
                $"Fecha actividad {Fecha.ToString()}";

            return informacion;
        }
    }
}
