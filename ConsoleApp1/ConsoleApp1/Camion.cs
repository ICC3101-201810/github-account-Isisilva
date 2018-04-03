using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Camion : Vehiculo
    {
        string tipoDeCamion;

        public Camion(string miMarca, string miPatente,
            string miTipoDeCamion) : base(miMarca, miPatente)
        {
            tipoDeCamion = miTipoDeCamion;
        }
    }
}

