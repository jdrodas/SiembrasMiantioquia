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
        public static List<string> ObtenerNombreVeredas()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct nombre from veredas order by nombre", new DynamicParameters());
                return salida.ToList();
            }
        }

        public static List<string> ObtieneMunicipios(string nombreVereda)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre_vereda", nombreVereda, DbType.String, ParameterDirection.Input);
                string laSentenciaSQL = "select nombre_municipio from v_detalle_vereda " +
                    "where nombre_vereda = @nombre_vereda order by nombre_municipio";

                var salida = cxnDB.Query<string>(laSentenciaSQL, parametrosSentencia);
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

        static public bool GuardarSiembra(Siembra laSiembra)
        {
            bool resultado = false;

            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            //Obtener los codigos de las tablas foraneas
            laSiembra.Codigo_Municipio = ObtieneCodigoMunicipio(laSiembra.Nombre_Municipio);
            laSiembra.Codigo_Contratista = ObtieneCodigoContratista(laSiembra.Nombre_Contratista);
            laSiembra.Codigo_Arbol = ObtieneCodigoArbol(laSiembra.Nombre_Arbol);
            laSiembra.Codigo_Vereda = ObtieneCodigoVereda(laSiembra.Nombre_Vereda, laSiembra.Codigo_Municipio);

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                int cantidadFilas = cxnDB.Execute("insert into siembras (codigo_vereda, codigo_arbol, codigo_contratista, fecha, total_arboles, total_hectareas) " +
                    "values (@Codigo_Vereda,@codigo_Arbol,@codigo_Contratista,@Fecha_Siembra,@Total_Arboles,@Total_Hectareas)", laSiembra);

                if (cantidadFilas > 0)
                    resultado = true;
            }
            return resultado;

        }

        static private int ObtieneCodigoVereda(string nombre_vereda, int codigo_municipio)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            int codigo_vereda = 0;

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre_vereda", nombre_vereda, DbType.String, ParameterDirection.Input);
                parametrosSentencia.Add("@codigo_municipio", codigo_municipio, DbType.Int32, ParameterDirection.Input);

                string sentenciaSQL = "select codigo from veredas where nombre = @nombre_vereda"  +
                    " and codigo_municipio = @codigo_municipio";
                var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    codigo_vereda = salida.First();
                }
                return codigo_vereda;
            }
        }


        static private int ObtieneCodigoArbol(string nombreArbol)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            int codigo_arbol = 0;

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreArbol, DbType.String, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select codigo from arboles where nombre = @nombre";
                var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    codigo_arbol = salida.First();
                }
                return codigo_arbol;
            }
        }

        static private int ObtieneCodigoContratista(string nombreContratista)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            int codigo_contratista = 0;

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreContratista, DbType.String, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select codigo from contratistas where nombre = @nombre";
                var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    codigo_contratista = salida.First();
                }
                return codigo_contratista;
            }
        }

        static private int ObtieneCodigoMunicipio(string nombreMunicipio)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            int codigoMunicipio = 0;

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreMunicipio, DbType.String, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select codigo from municipios where nombre = @nombre";
                var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    codigoMunicipio = salida.First();
                }
                return codigoMunicipio;
            }
        }
    }
}
