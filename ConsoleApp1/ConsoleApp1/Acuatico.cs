using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Acuatico : Vehiculo
    {
        string tipoDeAcuatico;

        public Acuatico(string miMarca, string miPatente,
            string miTipoDeAcuatico, string miLicenciaVehiculo) : base(miMarca, miPatente, miLicenciaVehiculo)
        {
            tipoDeAcuatico = miTipoDeAcuatico;
        }
    }
}

