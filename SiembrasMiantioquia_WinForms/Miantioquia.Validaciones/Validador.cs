using System;
using Miantioquia.Modelos;

namespace Miantioquia.Validaciones
{
    public class Validador
    {
        /// <summary>
        /// Valida si los datos de la siembra ingresados por el usuario son correctos
        /// </summary>
        /// <param name="unaSiembra">La siembra a validar</param>
        /// <param name="mensajeError">mensaje de error en caso de fallo</param>
        /// <returns>Resultado validación</returns>
        static public bool DatosSiembra(Siembra unaSiembra, out string mensajeError)
        {
            bool resultado = true;
            mensajeError = "";

            //Aqui validamos que no haya siembras en fechas futuras
            string[] laFecha = unaSiembra.Fecha_Siembra.Split('/');
            DateTime fechaResultado = new DateTime(
                int.Parse(laFecha[2]),
                int.Parse(laFecha[1]),
                int.Parse(laFecha[0])
                );

            if (fechaResultado > DateTime.Now)
            {
                mensajeError = "No se puede registrar una siembra en fecha futura.";
                return false;
            }

            //Aqui validamos que el valor de las hectáreas sea positivo
            if (unaSiembra.Total_Hectareas <= 0)
            {
                mensajeError = "El valor de las hectáreas sembradas debe ser mayor que cero.";
                return false;
            }

            //Aqui validamos que el valor del total de los árboles sea positivo
            if (unaSiembra.Total_Arboles <= 0)
            {
                mensajeError = "El valor del total de árboles debe ser mayor que cero.";
                return false;
            }

            return resultado;
        }
    }
}
