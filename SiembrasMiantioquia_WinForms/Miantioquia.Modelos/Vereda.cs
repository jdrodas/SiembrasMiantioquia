namespace Miantioquia.Modelos
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
