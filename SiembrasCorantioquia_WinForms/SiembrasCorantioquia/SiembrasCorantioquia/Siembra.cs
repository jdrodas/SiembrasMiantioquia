using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiembrasCorantioquia
{
    public class Siembra
    {
        public int Codigo_Siembra { get; set; }
        public string Nombre_Arbol { get; set; }
        public string Nombre_Vereda { get; set; }
        public string Nombre_Municipio { get; set; }
        public string Nombre_Contratista { get; set; }
        public int Total_Arboles { get; set; }
        public double Total_Hectareas { get; set; }
        public string Fecha_Siembra { get; set; }

        public Siembra()
        {
            Codigo_Siembra = 0;
            Nombre_Municipio = "";
            Nombre_Vereda = "";
            Nombre_Municipio = "";
            Nombre_Contratista = "";
            Total_Arboles = 0;
            Total_Hectareas = 0;
            Fecha_Siembra = "";
        }

        public Siembra(int codigo_siembra, string nombre_arbol, string nombre_vereda,
            string nombre_contratista, string nombre_municipio, int total_arboles,
            double total_hectareas, string fecha)
        {
            Codigo_Siembra = codigo_siembra;
            Nombre_Municipio = nombre_arbol;
            Nombre_Vereda = nombre_vereda;
            Nombre_Municipio = nombre_municipio;
            Nombre_Contratista = nombre_contratista;
            Total_Arboles = total_arboles;
            Total_Hectareas = total_hectareas;
            Fecha_Siembra = fecha;
        }

        /// <summary>
        /// Obtiene la cadena de caracteres que describe la siembra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Código: {Codigo_Siembra} " + Environment.NewLine +
                $"Nombre Vereda: {Nombre_Vereda} " + Environment.NewLine +
                $"Nombre Municipio: {Nombre_Municipio} " + Environment.NewLine +
                $"Nombre Arbol: {Nombre_Arbol} " + Environment.NewLine +
                $"Nombre Contratista: {Nombre_Contratista} " + Environment.NewLine +
                $"Total Árboles: {Total_Arboles} " + Environment.NewLine +
                $"Total Hectáreas: {Total_Hectareas} " + Environment.NewLine +
                $"Fecha: {Fecha_Siembra} ");
        }
    }
}
