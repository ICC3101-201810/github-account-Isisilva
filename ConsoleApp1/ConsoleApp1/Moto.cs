﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Moto : Vehiculo
    {
        string tipoDeMoto;

        public Moto(string miMarca, string miPatente,
            string miTipoDeMoto) : base(miMarca, miPatente)
        {
            tipoDeMoto = miTipoDeMoto;
        }
    }
}
