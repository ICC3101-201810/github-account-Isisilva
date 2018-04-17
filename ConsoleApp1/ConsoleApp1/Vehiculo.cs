using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Vehiculo
    {
        string marca;
        string patente;
        string licenciaVehiculo;
 
        public Vehiculo(string miMarca, string miPatente, string miLicenciaVehiculo)
        {
            marca = miMarca;
            patente = miPatente;
            licenciaVehiculo = miLicenciaVehiculo;

        }
    }
}
