using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Camion : Vehiculo
    {
        string tipoDeCamion { get; set; }

        public Camion(string miMarca, string miPatente,
            string miTipoDeCamion, string miLicenciaVehiculo) : base(miMarca, miPatente, miLicenciaVehiculo)
        {
            tipoDeCamion = miTipoDeCamion;
        }
    }
}

