using System;
using System.Collections.Generic;

namespace SiembrasMiantioquia_PoC_NoSQL_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PoC para demostrar acciones CRUD en MongoDB\n");

            //Aqui demostramos consulta a una colección de Veredas
            Console.WriteLine("\nVeredas que se encuentran vinculadas a Tarso:");

            List<Vereda> listaVeredas = AccesoDatos.ObtieneListaVeredasMunicipio("Tarso");

            foreach (Vereda unaVereda in listaVeredas)
                Console.WriteLine($"- {unaVereda.Nombre}");

            //Aqui demostramos la lectura de un objeto desde la DB MongoDB - Read del CRUD
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
                Codigo = 3,
                Vereda = "Tocamocho",
                Municipio = "Tarso",
                Reforestadora = "Reforestadora del Sur",
                Arbol = "Cedro",
                Total_Arboles = 180,
                Total_Hectareas = 2.5,
                Fecha = DateTime.Now
            };

            AccesoDatos.CreaSiembra(nuevaSiembra);
            Console.WriteLine("Siembra registrada exitosamente!\n");

            //Aqui demostramos la actualización de una siembra existente - Update del CRUD
            Siembra otraSiembra = AccesoDatos.ObtieneUnaSiembra(3);

            otraSiembra.Vereda = "La Linda";
            otraSiembra.Fecha = DateTime.Now;

            AccesoDatos.ActualizaSiembra(otraSiembra);
            Console.WriteLine("Siembra actualizada exitosamente!\n");
            Console.WriteLine(otraSiembra.ToString());

            //Aqui demostramos el borrado de una siembra existente - Delete del CRUD            
            if (otraSiembra is null)
            {
                Console.WriteLine("No se encontró en la DB siembras con ese código");
            }
            else
            {
                AccesoDatos.BorraSiembra(otraSiembra);
                Console.WriteLine("Siembra borrada exitosamente!\n");           
            }

            Console.WriteLine("\n\n");
        }
    }
}
