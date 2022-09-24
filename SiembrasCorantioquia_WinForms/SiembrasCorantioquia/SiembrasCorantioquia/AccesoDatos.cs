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

        public static List<string> ObtenerNombresContratistas()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select nombre from contratistas order by nombre", new DynamicParameters());
                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene la lista de los árboles disponibles para las siembras
        /// </summary>
        /// <returns>Lista de Strings con los nombres de los árboles</returns>
        public static List<string> ObtenerNombresArboles()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select nombre from arboles order by nombre", new DynamicParameters());
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

        public static DataTable ObtenerDetalleSiembras()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //Aqui creamos la dataTable de resultados
                DataTable tablaResultado = new DataTable();


                //Aqui le definimos las columnas que utilizará
                tablaResultado.Columns.Add(new DataColumn("codigo_siembra", typeof(int)));
                tablaResultado.Columns.Add(new DataColumn("nombre_vereda", typeof(string)));
                tablaResultado.Columns.Add(new DataColumn("nombre_municipio", typeof(string)));
                tablaResultado.Columns.Add(new DataColumn("nombre_contratista", typeof(string)));
                tablaResultado.Columns.Add(new DataColumn("nombre_arbol", typeof(string)));
                tablaResultado.Columns.Add(new DataColumn("fecha_siembra", typeof(string)));
                tablaResultado.Columns.Add(new DataColumn("total_arboles", typeof(int)));
                tablaResultado.Columns.Add(new DataColumn("total_hectareas", typeof(double)));

                string sentenciaSQL = "select codigo_siembra, nombre_vereda, nombre_municipio, nombre_contratista, nombre_arbol, fecha_siembra, total_arboles, total_hectareas from v_detalle_siembra;";
                var salida = cxnDB.Query<Siembra>(sentenciaSQL, new DynamicParameters());

                DataRow filaSiembra;

                foreach (Siembra unaSiembra in salida)
                {
                    filaSiembra = tablaResultado.NewRow();

                    filaSiembra["codigo_siembra"] = unaSiembra.Codigo_Siembra;
                    filaSiembra["nombre_vereda"] = unaSiembra.Nombre_Vereda;
                    filaSiembra["nombre_municipio"] = unaSiembra.Nombre_Municipio;
                    filaSiembra["nombre_contratista"] = unaSiembra.Nombre_Contratista;
                    filaSiembra["nombre_arbol"] = unaSiembra.Nombre_Arbol;
                    filaSiembra["fecha_siembra"] = unaSiembra.Fecha_Siembra;
                    filaSiembra["total_arboles"] = unaSiembra.Total_Arboles;
                    filaSiembra["total_hectareas"] = unaSiembra.Total_Hectareas;

                    tablaResultado.Rows.Add(filaSiembra);
                }
                return tablaResultado;
            }
        }
    }
}
