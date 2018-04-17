using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] arg)
        {
            List<Auto> autos = new List<Auto>();
            List<Avion> aviones = new List<Avion>();
            List<Tractor> tractores = new List<Tractor>();
            List<RetroExcavadora> retroExcabadoras = new List<RetroExcavadora>();
            List<Camion> camiones = new List<Camion>();
            List<Moto> motos = new List<Moto>();
            List<Bus> buses = new List<Bus>();
            List<Acuatico> acuaticos = new List<Acuatico>();

            Console.WriteLine("Hola");
            Console.WriteLine("Escriba 1 si es que quiere arrendar un vehiculo" +
                "2 si quiere recibir un vehiculo," +
                "3 si quiere salir del programa.");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine("Porfavor ingresa los siguientes datos: ");
                Console.WriteLine("Rut: ");
                string rut = Console.ReadLine();
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Licencia: ");
                string licencia = Console.ReadLine();
                Console.WriteLine("Tipo de Vehiculo (Auto, Moto, Retroexcabadora, avion, bus, acuatico, camion, tractor): ");
            }
            if (respuesta == 2)
            {
                Console.WriteLine("Porfavor ingresa los siguientes datos: ");
                Console.WriteLine("Patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Licencia necesaria para el vehículo: ");
                string licenciaVehiculo = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Chao!");
            }
        }
    }
}
