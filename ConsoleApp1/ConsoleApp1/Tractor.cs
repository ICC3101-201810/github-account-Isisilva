using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tractor : Vehiculo
    {
        string tipoDeTractor;

        public Tractor(string miMarca, string miPatente,
            string miTipoDeTractor) : base(miMarca, miPatente)
        {
            tipoDeTractor = miTipoDeTractor;
        }
    }
}

