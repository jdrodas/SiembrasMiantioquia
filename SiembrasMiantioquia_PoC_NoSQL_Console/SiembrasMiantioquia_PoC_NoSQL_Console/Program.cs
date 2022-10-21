using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiembrasMiantioquia_PoC_NoSQL_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PoC para demostrar acciones CRUD en MongoDB\n");

            //Aqui realizamos una consulta
            Console.WriteLine("Consultar la siembra con Código 1: \n");
            Siembra unaSiembra = AccesoDatos.ObtieneUnaSiembra(1);
            Console.WriteLine(unaSiembra.ToString());
        }
    }
}
