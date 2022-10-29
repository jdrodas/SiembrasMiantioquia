using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using System.Data;

namespace SiembrasMiantioquia_NoSQL_WinForms
{
    public class AccesoDatos
    {
        const string nombreDB = "SiembrasMiantioquia";
        const string idStringConexion = "SiembrasMiantioquiaDB";

        private static string ObtieneCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static Siembra ObtieneSiembra(int codigoSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            var filtroSiembra = new BsonDocument { { "Codigo", codigoSiembra } };

            var unaSiembra = miColeccion.Find(filtroSiembra).FirstOrDefault();

            return unaSiembra;
        }

        public static string ObtieneObjectIdSiembra(int codigoSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            var filtroSiembra = new BsonDocument { { "Codigo", codigoSiembra } };

            var unaSiembra = miColeccion.Find(filtroSiembra).FirstOrDefault();

            return unaSiembra.Id;
        }

        public static void ActualizaSiembra(Siembra unaSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la siembra existente para obtener el ObjectId
            Siembra siembraExistente = ObtieneSiembra(unaSiembra.Codigo);
            unaSiembra.Id = siembraExistente.Id;

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.ReplaceOne(documento => documento.Codigo == unaSiembra.Codigo, unaSiembra);
        }

        public static void BorraSiembra(int codigoSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la siembra existente para obtener el ObjectId
            Siembra siembraExistente = ObtieneSiembra(codigoSiembra);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.DeleteOne(documento => documento.Id == siembraExistente.Id);
        }

        public static void GuardaSiembra(Siembra unaSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Aqui le asignamos el siguiente consecutivo para la siembra
            unaSiembra.Codigo = ObtieneSiguienteValorContador("Siembras");

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.InsertOne(unaSiembra);
        }

        public static List<Vereda> ObtieneListaVeredasMunicipio(string nombreMunicipio)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Vereda>("Veredas");

            var filtroVereda = new BsonDocument { { "Nombre_Municipio", nombreMunicipio } };
            var lasVeredas = miColeccion.Find(filtroVereda);

            return lasVeredas.ToList();
        }



        /// <summary>
        /// Obtiene el detalle de las siembras registradas en la DB
        /// </summary>
        /// <returns>DataTable con la información requerida</returns>
        public static DataTable ObtenerDetalleSiembras()
        {

            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            var lasSiembras = miColeccion.Find(new BsonDocument()).ToList();

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

            DataRow filaSiembra;

            foreach (Siembra unaSiembra in lasSiembras)
            {
                filaSiembra = tablaResultado.NewRow();

                filaSiembra["codigo_siembra"] = unaSiembra.Codigo;
                filaSiembra["nombre_vereda"] = unaSiembra.Vereda;
                filaSiembra["nombre_municipio"] = unaSiembra.Municipio;
                filaSiembra["nombre_contratista"] = unaSiembra.Contratista;
                filaSiembra["nombre_arbol"] = unaSiembra.Arbol;
                filaSiembra["fecha_siembra"] = unaSiembra.Fecha.ToShortDateString();
                filaSiembra["total_arboles"] = unaSiembra.Total_Arboles;
                filaSiembra["total_hectareas"] = unaSiembra.Total_Hectareas;

                tablaResultado.Rows.Add(filaSiembra);
            }

            return tablaResultado;
        }

        public static List<string> ObtieneListaNombreMunicipios()
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Municipio>("Municipios");
            var losMunicipios = miColeccion.Find(new BsonDocument()).ToList();

            List<string> nombresMunicipios = new List<string>();

            foreach (Municipio unMunicipio in losMunicipios)
                nombresMunicipios.Add(unMunicipio.Nombre);

            return nombresMunicipios;
        }

        public static List<string> ObtieneListaNombresVeredasMunicipio(string nombreMunicipio)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Vereda>("Veredas");

            var filtroVereda = new BsonDocument { { "Nombre_Municipio", nombreMunicipio } };
            var lasVeredas = miColeccion.Find(filtroVereda).ToList();

            List<string> nombresVeredas = new List<string>();

            foreach (Vereda unaVereda in lasVeredas)
                nombresVeredas.Add(unaVereda.Nombre);

            return nombresVeredas;
        }

        public static List<string> ObtieneListaNombreContratistas()
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Contratista>("Contratistas");
            var losContratistas = miColeccion.Find(new BsonDocument()).ToList();

            List<string> nombresContratistas = new List<string>();

            foreach (Contratista unContratista in losContratistas)
                nombresContratistas.Add(unContratista.Nombre);

            return nombresContratistas;
        }

        public static List<string> ObtieneListaNombreArboles()
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Arbol>("Arboles");
            var losArboles = miColeccion.Find(new BsonDocument()).ToList();

            List<string> nombresArboles = new List<string>();

            foreach (Arbol unArbol in losArboles)
                nombresArboles.Add(unArbol.Nombre);

            return nombresArboles;
        }

        /// <summary>
        /// Obtiene el siguiente valor para ser utilizado en las acciones de inserción de las colecciones
        /// </summary>
        /// <param name="nombreContador">nombre del contador asociado a la colección</param>
        /// <returns>el siguiente valor del contador</returns>
        private static int ObtieneSiguienteValorContador(string nombreContador)
        {
            int siguienteValor=0;

            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Obtenemos el valor actual del contador
            var miColeccion = miDB.GetCollection<Contador>("Contadores");
            var filtroContador = new BsonDocument { { "nombre", nombreContador } };

            var elContador = miColeccion.Find(filtroContador).FirstOrDefault();

            siguienteValor = elContador.Valor++;

            //Actualizamos el contador con ese valor
            miColeccion.ReplaceOne(unContador => unContador.Nombre == elContador.Nombre, elContador);
            return siguienteValor;
        }

        /// <summary>
        /// Obtiene lista con información ampliada de la siembra
        /// </summary>
        /// <returns>Lista con información de la siembra</returns>
        public static List<string> ObtieneListaInfoSiembras()
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            var lasSiembras = miColeccion.Find(new BsonDocument()).ToList();

            //Aqui creamos la lista de resultados
            List<string> listaResultado = new List<string>();
            string registroSiembra;

            foreach (Siembra unaSiembra in lasSiembras)
            {
                registroSiembra = $"{unaSiembra.Codigo} - " +
                    $"{unaSiembra.Vereda} - " +
                    $"{unaSiembra.Municipio} - " +
                    $"{unaSiembra.Contratista} - " +
                    $"{unaSiembra.Fecha.ToShortDateString()}";

                listaResultado.Add(registroSiembra);
            }

            return listaResultado;
        }
    }
}
