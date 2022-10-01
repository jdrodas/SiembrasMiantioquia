using System;

namespace SiembrasCorantioquia_PoC_Console
{
    public class Siembra
    {
        public int Codigo_Siembra { get; set; }
        public int Codigo_Arbol { get; set; }
        public string Nombre_Arbol { get; set; }
        public int Codigo_Vereda { get; set; }
        public string Nombre_Vereda { get; set; }
        public int Codigo_Municipio { get; set; }
        public string Nombre_Municipio { get; set; }
        public int Codigo_Contratista { get; set; }
        public string Nombre_Contratista { get; set; }
        public int Total_Arboles { get; set; }
        public double Total_Hectareas { get; set; }
        public string Fecha_Siembra { get; set; }

        public Siembra()
        {
            Codigo_Siembra = 0;
            Codigo_Arbol = 0;
            Codigo_Contratista = 0;
            Codigo_Vereda = 0;
            Codigo_Municipio = 0;
            Total_Arboles = 0;
            Total_Hectareas = 0;
            Fecha_Siembra ="";
        }

        /// <summary>
        /// Obtiene la cadena de caracteres que describe la siembra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Nombre vereda: {Nombre_Vereda} " + Environment.NewLine +
                $"Nombre municipio: {Nombre_Municipio} " + Environment.NewLine +
                $"Nombre arbol: {Nombre_Arbol} " + Environment.NewLine +
                $"Nombre contratista: {Nombre_Contratista} " + Environment.NewLine +
                $"Total arboles: {Total_Arboles} " + Environment.NewLine +
                $"Total hectareas: {Total_Hectareas.ToString("0.00")} " + Environment.NewLine +
                $"Fecha: {Fecha_Siembra} ");
        }
    }
}

