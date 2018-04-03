using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus : Vehiculo
    {
        string tipoDeBus;

        public Bus(string miMarca, string miPatente,
            string miTipoDeBus) : base(miMarca, miPatente)
        {
            tipoDeBus = miTipoDeBus;
        }
    }
}

