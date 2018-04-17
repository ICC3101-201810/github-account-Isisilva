using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Moto : Vehiculo
    {
        string tipoDeMoto { get; set; }

        public Moto(string miMarca, string miPatente,
            string miTipoDeMoto, string miLicenciaVehiculo) : base(miMarca, miPatente, miLicenciaVehiculo)
        {
            tipoDeMoto = miTipoDeMoto;
        }
    }
}

