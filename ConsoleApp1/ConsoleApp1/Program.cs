using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Porfavor ingresa los siguientes datos: ");
            Console.WriteLine("Rut: ");
            string rut = Console.ReadLine(); 
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Licencia: ");
            string licencia = Console.ReadLine();

            Sucursal s = new Sucursal();
            s.agregarVehiculos();
        }
    }
}
