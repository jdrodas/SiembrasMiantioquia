using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace SiembrasCorantioquia
{
    public class AccesoDatos
    {
        /// <summary>
        /// Obtiene la cadena de conexión a la DB a partir del archivo de configuración de la App
        /// </summary>
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Obtiene una lista con los nombres de las Veredas y Municipios
        /// </summary>
        public static List<string> ObtenerVeredasMunicipios()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct (nombre_vereda || \" - \" || nombre_municipio) nombre from v_detalle_vereda order by nombre_municipio", new DynamicParameters());
                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene la información de una siembra
        /// </summary>
        /// <param name="codigoSiembra">ID que identifica una siembra</param>
        /// <returns></returns>
        public static Siembra ObtenerSiembra(int codigoSiembra)
        {
            Siembra siembraResultado = new Siembra();
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select s.codigo, s.fecha, s.total_hectareas, s.total_arboles, s.codigo_vereda, s.codigo_contratista, s.codigo_arbol from siembras s where s.codigo = @codigo";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", codigoSiembra, DbType.Int32, ParameterDirection.Input);

                var salida = cxnDB.Query<Siembra>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    siembraResultado = salida.First();
                }
                return siembraResultado;
            }
        }
    }


}
