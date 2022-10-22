using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiembrasMiantioquia_WinForms
{
    public class Vereda
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
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
