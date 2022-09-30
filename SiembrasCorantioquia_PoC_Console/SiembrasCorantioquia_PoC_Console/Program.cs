using System;
using System.Collections.Generic;

namespace SiembrasCorantioquia_PoC_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siembras Corantioquia - PoC para conectividad a SQLite");

            //Aqui demostramos consulta
            Console.WriteLine("\nVeredas que se encuentran vinculadas a Medellín:");

            List<string> listaVeredas = AccesoDatos.ObtieneVeredasMunicipio("Medellín");

            foreach (string unaVereda in listaVeredas)
                Console.WriteLine($"- {unaVereda}");

            //Aqui demostramos la lectura de un objeto desde la DB SQLite - Read del CRUD
            Console.WriteLine("\nInformación sobre la primera siembra:\n");

            Siembra unaSiembra = AccesoDatos.ObtieneSiembra(1);

            if (unaSiembra.Codigo_Siembra != 0)
                Console.WriteLine(unaSiembra.ToString());
            else
                Console.WriteLine($"No hay siembra registradas en la base de datos");

            //Aqui demostramos la inserción de una nueva siembra - Create del CRUD

            Console.WriteLine("\nDemostrando inserción de una nueva siembra - Create del CRUD");

            Siembra nuevaSiembra = new Siembra()
            {
                Nombre_Vereda = "Santa Rosita",
                Nombre_Municipio = "Caucasia",
                Nombre_Contratista = "Siembras de Occidente",
                Nombre_Arbol = "Mango",
                Total_Arboles = 100,
                Total_Hectareas = 0.78d,
                Fecha_Siembra = DateTime.Now.ToShortDateString()
            };

            bool resultadoInsercion = AccesoDatos.InsertaSiembra(nuevaSiembra);

            if (resultadoInsercion)
            {
                Console.WriteLine("Siembra registrada exitosamente!\n");
                Console.WriteLine(nuevaSiembra.ToString());
            }
            else
            {
                Console.WriteLine("Fallo en la inserción. Revisa los datos ingresados e intentamente!");
            }


            //Aqui demostramos la actualización de una siembra existente - Update del CRUD
            Console.WriteLine("\nDemostrando la actualización de una siembra existente - Update del CRUD");
            //leemos una siembra existente
            unaSiembra = AccesoDatos.ObtieneSiembra(2);

            //Aqui actualizamos el contratista
            unaSiembra.Codigo_Contratista = 2;
            unaSiembra.Codigo_Arbol = 1;
            //Aqui actualizamos la cantidad de árboles y fecha de la siembra
            unaSiembra.Total_Arboles = 50;
            unaSiembra.Fecha_Siembra = DateTime.Now.ToShortDateString();

            //Aqui invocamos la función de actualización
            bool resultadoActualizacion = AccesoDatos.ActualizaSiembra(unaSiembra);

            if (resultadoActualizacion)
            {
                Console.WriteLine("Siembra actualizada exitosamente!\n");
                Console.WriteLine(unaSiembra.ToString());
            }
            else
            {
                Console.WriteLine("Fallo en la actualización. Revisa los datos ingresados e intentamente!");
            }

            //Aqui demostramos la eliminación de una siembra existente - delete del CRUD
            Console.WriteLine("\nDemostrando la eliminación de una siembra existente - delete del CRUD");
            //leemos una siembra existente
            unaSiembra = AccesoDatos.ObtieneSiembra(2);

            //Aqui invocamos la función de actualización
            bool resultadoEliminacion = AccesoDatos.EliminaSiembra(unaSiembra);

            if (resultadoEliminacion)
                Console.WriteLine("Siembra eliminada exitosamente!\n");
            else
                Console.WriteLine("Fallo en la actualización. Revisa los datos ingresados e intentamente!");

            Console.WriteLine("\n\nFin del programa.");

        }
    }
}

