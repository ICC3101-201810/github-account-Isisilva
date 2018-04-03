using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avion : Vehiculo
    {
        string tipoDeAvion;

        public Avion(string miMarca, string miPatente,
            string miTipoDeAvion) : base(miMarca, miPatente)
        {
            tipoDeAvion = miTipoDeAvion;
        }
    }
}

