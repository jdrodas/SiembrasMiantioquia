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

        #region CRUD de Siembra

        /// <summary>
        /// Valida si la siembra tiene valores válidos para operaciones CRUD
        /// </summary>
        /// <param name="unaSiembra">Objeto siembra</param>
        /// <returns>Verdadero si tiene todos los valores requeridos</returns>
        private static bool ValidaSiembra(Siembra unaSiembra)
        {
            bool resultado = false;

            if (unaSiembra.Codigo_Arbol != 0 && unaSiembra.Codigo_Contratista != 0 &&
                    unaSiembra.Codigo_Municipio != 0 && unaSiembra.Codigo_Vereda != 0)
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Obtiene el detalle de las siembras registradas en la DB
        /// </summary>
        /// <returns>DataTable con la información requerida</returns>
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

        /// <summary>
        /// Completa el objeto siembra con los códigos correspondientes a los nombres contenidos en los atributos
        /// </summary>
        /// <param name="unaSiembra">Objeto para completar</param>
        private static void CompletaCodigosSiembra(Siembra unaSiembra)
        {
            unaSiembra.Codigo_Municipio = ObtieneCodigoMunicipio(unaSiembra.Nombre_Municipio);
            unaSiembra.Codigo_Vereda = ObtieneCodigoVereda(unaSiembra.Nombre_Vereda, unaSiembra.Codigo_Municipio);
            unaSiembra.Codigo_Contratista = ObtieneCodigoContratista(unaSiembra.Nombre_Contratista);
            unaSiembra.Codigo_Arbol = ObtieneCodigoArbol(unaSiembra.Nombre_Arbol);
        }

        /// <summary>
        /// Completa el objeto siembra con los nombres correspondientes a los codigos contenidos en los atributos
        /// </summary>
        /// <param name="unaSiembra">Objeto para completar</param>
        private static void CompletaNombresSiembra(Siembra unaSiembra)
        {
            unaSiembra.Nombre_Municipio = ObtieneNombreMunicipio(unaSiembra.Codigo_Municipio);
            unaSiembra.Nombre_Contratista = ObtieneNombreContratista(unaSiembra.Codigo_Contratista);
            unaSiembra.Nombre_Vereda = ObtieneNombreVereda(unaSiembra.Codigo_Vereda);
            unaSiembra.Nombre_Arbol = ObtieneNombreArbol(unaSiembra.Codigo_Arbol);
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

        /// <summary>
        /// Guarda la información del objeto siembra en la DB
        /// </summary>
        /// <param name="laSiembra">Objeto siembra</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns></returns>
        static public bool GuardarSiembra(Siembra laSiembra, out string mensajeError)
        {
            bool resultado = false;
            int cantidadFilas;
            mensajeError = "";

            //Completamos el objeto con los códigos correspondientes a los nombres contenidos en los atributos
            CompletaCodigosSiembra(laSiembra);

            //Validamos que la siembra tenga valores válidos en los campos correspondientes a códigos
            if (ValidaSiembra(laSiembra))
            {
                string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

                using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
                {
                    try
                    {
                        cantidadFilas = cxnDB.Execute("INSERT INTO siembras (codigo_vereda, codigo_arbol, codigo_contratista, fecha, total_arboles, total_hectareas) " +
                        "VALUES (@Codigo_Vereda,@codigo_Arbol,@codigo_Contratista,@Fecha_Siembra,@Total_Arboles, @Total_Hectareas)", laSiembra);
                    }
                    catch (SQLiteException unaExcepcion)
                    {
                        resultado = false;
                        mensajeError = unaExcepcion.Message;
                        cantidadFilas = 0;
                    }

                    //Si la inserción fue correcta, obtenemos el objeto actualizado con la información que acabamos de insertar
                    if (cantidadFilas > 0)
                        resultado = true;
                }
            }
            return resultado;
        }

        #endregion CRUD de Siembra

        #region CRUD de Veredas

        /// <summary>
        /// Obtiene el código de la vereda a partir del nombre y el código del municipio
        /// </summary>
        /// <param name="nombre_vereda">Nombre de la vereda</param>
        /// <param name="codigo_municipio">codigo del municipio</param>
        /// <returns>Codigo de la vereda</returns>
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

                string sentenciaSQL = "select codigo from veredas where nombre = @nombre_vereda" +
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

        /// <summary>
        /// Obtiene el nombre de la vereda a partir del codigo
        /// </summary>
        /// <param name="nombre_vereda"Codigo de la vereda</param>
        /// <returns>Nombre de la vereda</returns>
        static private string ObtieneNombreVereda(int codigo_vereda)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            string nombre_vereda = "";

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", codigo_vereda, DbType.Int32, ParameterDirection.Input);

                string sentenciaSQL = "select nombre from veredas where codigo = @codigo";
                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    nombre_vereda = salida.First();
                }
                return nombre_vereda;
            }
        }

        /// <summary>
        /// Obtiene una lista con los nombres de las Veredas y Municipios
        /// </summary>
        public static List<string> ObtieneListaVeredas()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct nombre from veredas order by nombre", new DynamicParameters());
                return salida.ToList();
            }
        }

        public static List<string> ObtieneListaVeredas(string nombreMunicipio)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre", nombreMunicipio, DbType.String, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "SELECT nombre_vereda FROM v_detalle_vereda " +
                    "WHERE nombre_municipio = @nombre";
                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                    return salida.ToList();
                else
                    return new List<string>();
            }
        }

        #endregion CRUD de Veredas

        #region CRUD de Contratistas

        /// <summary>
        /// Obtiene el Código del Contratista a partir del nombre
        /// </summary>
        /// <param name="nombreContratista">Nombre del Contratista</param>
        /// <returns>el código del contratista</returns>
        private static int ObtieneCodigoContratista(string nombreContratista)
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

        /// <summary>
        /// Obtiene el nombre del Contratista a partir del Código
        /// </summary>
        /// <param name="codigoContratista">el código del contratista</param>
        /// <returns>Nombre del Contratista</returns>
        private static string ObtieneNombreContratista(int codigoContratista)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            string nombre_contratista = "";

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", codigoContratista, DbType.Int32, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select nombre from contratistas where codigo = @codigo";
                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    nombre_contratista = salida.First();
                }
                return nombre_contratista;
            }
        }

        /// <summary>
        /// Obtiene el nombre de los contratistas registrados en la DB
        /// </summary>
        /// <returns>Lista con el nombre de los contratistas</returns>
        public static List<string> ObtieneListaContratistas()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select nombre from contratistas order by nombre", new DynamicParameters());
                return salida.ToList();
            }
        }

        #endregion CRUD de Contratistas

        #region CRUD de Municipios

        /// <summary>
        /// Obtiene El código del Municipio a partir del nombre
        /// </summary>
        /// <param name="nombreMunicipio">Nombre del municipio</param>
        /// <returns>Codigo del Municipio</returns>
        private static int ObtieneCodigoMunicipio(string nombreMunicipio)
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

        /// <summary>
        /// Obtiene El nombre del Municipio a partir del código
        /// </summary>
        /// <param name="codigoMunicipio">Codigo del Municipio</param>
        /// <returns>Nombre del Municipio</returns>
        private static string ObtieneNombreMunicipio(int codigoMunicipio)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            string nombreMunicipio = "";

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", codigoMunicipio, DbType.Int32, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select nombre from municipios where codigo = @codigo";
                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    nombreMunicipio = salida.First();
                }
                return nombreMunicipio;
            }
        }

        /// <summary>
        /// Obtiene el nombre de los municipios registrados en la DB
        /// </summary>
        /// <returns>Lista con el nombre de los municipios</returns>
        public static List<string> ObtieneListaMunicipios()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                string laSentenciaSQL = "SELECT DISTINCT nombre FROM municipios " +
                    "ORDER BY nombre";

                var salida = cxnDB.Query<string>(laSentenciaSQL, new DynamicParameters());
                return salida.ToList();
            }
        }

        #endregion CRUD de Municipios

        #region CRUD de Arboles

        /// <summary>
        /// Obtiene la lista de los árboles disponibles para las siembras
        /// </summary>
        /// <returns>Lista de Strings con los nombres de los árboles</returns>
        public static List<string> ObtieneListaArboles()
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select nombre from arboles order by nombre", new DynamicParameters());
                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene el código del Arbol a partir del nombre
        /// </summary>
        /// <param name="nombreArbol">Nombre del Árbol</param>
        /// <returns>código del arbol</returns>
        private static int ObtieneCodigoArbol(string nombreArbol)
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

        /// <summary>
        /// Obtiene el nombre del Arbol a partir del codigo
        /// </summary>
        /// <param name="codigo_arbol">Nombre del Árbol</param>
        /// <returns>nombre del arbol</returns>
        private static string ObtieneNombreArbol(int codigo_arbol)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            string nombre_arbol = "";

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", codigo_arbol, DbType.String, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select nombre from arboles where codigo = @codigo";
                var salida = cxnDB.Query<string>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                {
                    nombre_arbol = salida.First();
                }
                return nombre_arbol;
            }
        }

        #endregion CRUD de Arboles

    }
}
