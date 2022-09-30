using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace SiembrasCorantioquia_PoC_Console
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
        /// Obtiene una lista con las veredas asociadas al municipio
        /// </summary>
        /// <param name="municipio">Nombre del municipio</param>
        /// <returns>Lista de las veredas asociadas</returns>
        public static List<string> ObtieneVeredasMunicipio(string municipio)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");
            
            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //El nombre del municipio se pasa como parámetro dinámico 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@nombre_municipio", municipio, DbType.String, ParameterDirection.Input);

                string laSentenciaSQL = "SELECT nombre_vereda FROM v_detalle_vereda " +
                                        "WHERE nombre_municipio = @nombre_municipio ORDER BY nombre_vereda";

                var salida = cxnDB.Query<string>(laSentenciaSQL, parametrosSentencia);
                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene la primera siembra registrada en la base de datos
        /// </summary>
        /// <returns>Objeto siembra con la información requeridos</returns>
        public static Siembra ObtieneSiembra(int codigoSiembra)
        {
            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                Siembra siembraResultado = new Siembra();

                //El código de la siembra se pasa como parámetro de la consulta 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigoSiembra", codigoSiembra, DbType.Int32, ParameterDirection.Input);

                // se define la sentencia SQL a utilizar
                string sentenciaSQL = "SELECT DISTINCT codigo_siembra, codigo_vereda, nombre_vereda, codigo_municipio, " +
                    "nombre_municipio, codigo_contratista, nombre_contratista, codigo_arbol, nombre_arbol, fecha_siembra, " +
                    "total_arboles, total_hectareas FROM v_detalle_siembra WHERE codigo_siembra = @codigoSiembra";

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
        /// Inserta una nueva siembra
        /// </summary>
        /// <param name="nuevaSiembra">Información recibida desde la UI</param>
        /// <returns>resultado de la inserción</returns>
        public static bool InsertaSiembra(Siembra nuevaSiembra)
        {
            bool resultado = false;

            //Completamos el objeto con los códigos correspondientes a los nombres contenidos en los atributos
            CompletaCodigosSiembra(nuevaSiembra);

            //Validamos que la siembra tenga valores válidos en los campos correspondientes a códigos
            if (ValidaSiembra(nuevaSiembra))
            {
                string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

                using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
                {
                    int cantidadFilas = cxnDB.Execute("INSERT INTO siembras (codigo_vereda, codigo_arbol, codigo_contratista, fecha, total_arboles, total_hectareas) " +
                        "VALUES (@Codigo_Vereda,@codigo_Arbol,@codigo_Contratista,@Fecha_Siembra,@Total_Arboles,@Total_Hectareas)", nuevaSiembra);

                    //Si la inserción fue correcta, obtenemos el objeto actualizado con la información que acabamos de insertar
                    if (cantidadFilas > 0) 
                        resultado = true;                                        
                }
            }
            return resultado;
        }

        /// <summary>
        /// Actualiza una siembra existente
        /// </summary>
        /// <param name="unaSiembra">la siembra</param>
        /// <returns>resultado de la actualización</returns>
        public static bool ActualizaSiembra(Siembra unaSiembra)
        {
            bool resultado = false;

            //Actualizamos los nombres de acuerdo a los codigos que se actualizaron
            CompletaNombresSiembra(unaSiembra);

            //Validamos que la siembra tenga valores válidos en los campos correspondientes a códigos
            if (ValidaSiembra(unaSiembra))
            {
                string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

                using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
                {
                    int cantidadFilas = cxnDB.Execute("UPDATE siembras SET " +
                    "codigo_vereda = @Codigo_Vereda, " +
                    "fecha = @Fecha_Siembra " +
                    "WHERE codigo = @Codigo_Siembra", unaSiembra);

                    //Si la actualización fue correcta, obtenemos el objeto actualizado con la información que acabamos de insertar
                    if (cantidadFilas > 0)
                        resultado = true;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Elimina una siembra existente
        /// </summary>
        /// <param name="unaSiembra">la siembra</param>
        /// <returns>resultado de la eliminación</returns>
        public static bool EliminaSiembra(Siembra unaSiembra)
        {
            bool resultado = false;

            string cadenaConexion = ObtenerCadenaConexion("SiembrasDB");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "DELETE FROM siembras WHERE codigo = @codigo";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@codigo", unaSiembra.Codigo_Siembra, DbType.Int32, ParameterDirection.Input);

                int cantidadFilas = cxnDB.Execute(sentenciaSQL, parametrosSentencia);

                // Si la cantidad de registros es diferente de 0, se encontró y eliminó registro
                if (cantidadFilas > 0)
                    resultado = true;
            }
            return resultado;
        }


        /// <summary>
        /// Valida si la siembra tiene valores válidos para operaciones CRUD
        /// </summary>
        /// <param name="unaSiembra">Objeto siembra</param>
        /// <returns>Verdadero si tiene todos los valores requeridos</returns>
        private static bool ValidaSiembra(Siembra unaSiembra)
        {
            bool resultado = false;

            if (unaSiembra.Codigo_Arbol != 0 && unaSiembra.Codigo_Contratista != 0 &&
                    unaSiembra.Codigo_Municipio !=0 && unaSiembra.Codigo_Vereda !=0)
                resultado = true;

            return resultado;
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


    }
}
