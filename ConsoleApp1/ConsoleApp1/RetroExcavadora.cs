using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RetroExcavadora : Vehiculo
    {
        string tipoDeRetroExcavadora { get; set; }

        public RetroExcavadora(string miMarca, string miPatente,
            string miTipoDeRetroExcavadora, string miLicenciaVehiculo) : base(miMarca, miPatente, miLicenciaVehiculo)
        {
            tipoDeRetroExcavadora = miTipoDeRetroExcavadora;
        }
    }
}

