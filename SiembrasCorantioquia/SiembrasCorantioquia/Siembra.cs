using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiembrasCorantioquia
{
    public class Siembra
    {
        public int Codigo { get; set; }
        public int Codigo_Arbol { get; set; }
        public int Codigo_Vereda { get; set; }
        public int Codigo_Contratista { get; set; }
        public int Total_Arboles { get; set; }
        public double Total_Hectareas { get; set; }
        public string Fecha { get; set; }

        public Siembra()
        {
            Codigo = 0;
            Codigo_Arbol = 0;
            Codigo_Vereda = 0;
            Codigo_Contratista = 0;
            Total_Arboles = 0;
            Total_Hectareas = 0;
            Fecha = "";
        }

        public Siembra(int codigo, int codigo_arbol, int codigo_vereda,
            int codigo_contratista, int total_arboles,
            double total_hectareas, string fecha)
        {
            Codigo = codigo;
            Codigo_Arbol = codigo_arbol;
            Codigo_Vereda = codigo_vereda;
            Codigo_Contratista = codigo_contratista;
            Total_Arboles = total_arboles;
            Total_Hectareas = total_hectareas;
            Fecha = fecha;
        }

        /// <summary>
        /// Obtiene la cadena de caracteres que describe la siembra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Código: {Codigo} " + Environment.NewLine +
                $"Código Vereda: {Codigo_Vereda} " + Environment.NewLine +
                $"Código Arbol: {Codigo_Arbol} " + Environment.NewLine +
                $"Código Contratista: {Codigo_Contratista} " + Environment.NewLine +
                $"Total Árboles: {Total_Arboles} " + Environment.NewLine +
                $"Total Hectáreas: {Total_Hectareas} " + Environment.NewLine +
                $"Fecha: {Fecha} ");
        }





    }
}
