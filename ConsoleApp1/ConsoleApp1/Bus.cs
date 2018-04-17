﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus : Vehiculo
    {
        string tipoDeBus { get; set; }

        public Bus(string miMarca, string miPatente,
            string miTipoDeBus, string miLicenciaVehiculo) : base(miMarca, miPatente, miLicenciaVehiculo)
        {
            tipoDeBus = miTipoDeBus;
        }
    }
}

