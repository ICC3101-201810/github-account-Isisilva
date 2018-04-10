using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto : Vehiculo
    {
        string tipoDeAuto;

        public Auto(string miMarca, string miPatente, 
            string miTipoDeAuto, string miLicenciaVehiculo) : base(miMarca,miPatente, miLicenciaVehiculo)
        {
            tipoDeAuto = miTipoDeAuto;
        }
    }
}
