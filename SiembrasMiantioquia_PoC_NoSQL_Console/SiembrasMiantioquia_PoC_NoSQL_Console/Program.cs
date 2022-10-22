using System;
using System.Collections.Generic;

namespace SiembrasMiantioquia_PoC_NoSQL_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PoC para demostrar acciones CRUD en MongoDB\n");

            //Aqui demostramos consulta
            Console.WriteLine("\nVeredas que se encuentran vinculadas a Copacabana:");

            List<Vereda> listaVeredas = AccesoDatos.ObtieneListaNombreVeredasMunicipio("Copacabana");

            foreach (Vereda unaVereda in listaVeredas)
                Console.WriteLine($"- {unaVereda.Nombre}");

            //Aqui demostramos la lectura de un objeto desde la DB SQLite - Read del CRUD
            Console.WriteLine("\nInformación sobre la primera siembra:\n");

            Siembra unaSiembra = AccesoDatos.ObtieneUnaSiembra(1);

            if (unaSiembra.Codigo != 0)
                Console.WriteLine(unaSiembra.ToString());
            else
                Console.WriteLine($"No hay siembra registradas en la base de datos con ese código.");


            //Aqui demostramos la inserción de una nueva siembra - Create del CRUD
            Console.WriteLine("\nDemostrando inserción de una nueva siembra - Create del CRUD");

            Siembra nuevaSiembra = new Siembra()
            {
                Codigo = 2,
                Vereda = "Santa Rosita",
                Municipio = "Caucasia",
                Reforestadora = "Siembras de Occidente",
                Arbol = "Mango",
                Total_Arboles = 100,
                Total_Hectareas = 0.78,
                Fecha = DateTime.Now
            };

            AccesoDatos.CreaSiembra(nuevaSiembra);
            Console.WriteLine("Siembra registrada exitosamente!\n");

            Console.WriteLine("\n\n");
        }
    }
}
