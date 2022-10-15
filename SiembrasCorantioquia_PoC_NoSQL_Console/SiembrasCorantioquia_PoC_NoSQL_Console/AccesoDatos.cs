﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;

namespace SiembrasCorantioquia_PoC_NoSQL_Console
{
    public class AccesoDatos
    {
        const string nombreDB = "SiembrasCorantioquia";
        const string idStringConexion = "SiembrasCorantioquiaDB";

        private static string ObtieneCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static Siembra ObtieneUnaSiembra(int codigoSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            var filtroSiembra = new BsonDocument { { "Codigo", codigoSiembra } };

            var unaSiembra = miColeccion.Find(filtroSiembra).FirstOrDefault();

            return unaSiembra;
        }

        public static void ActualizaSiembra(Siembra unaSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.ReplaceOne(documento => documento.Codigo == unaSiembra.Codigo, unaSiembra);
        }

        public static void BorraSiembra(Siembra unaSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.DeleteOne(documento => documento.Codigo == unaSiembra.Codigo);
        }

        public static void CreaSiembra(Siembra unaSiembra)
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Siembra>("Siembras");
            miColeccion.InsertOne(unaSiembra);
        }
    }
}
