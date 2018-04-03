using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RetroExcavadora : Vehiculo
    {
        string tipoDeRetroExcavadora;

        public RetroExcavadora(string miMarca, string miPatente,
            string miTipoDeRetroExcavadora) : base(miMarca, miPatente)
        {
            tipoDeRetroExcavadora = miTipoDeRetroExcavadora;
        }
    }
}

