using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        string nombre;
        string rut;
        string licencia;

        public Persona(string miNombre, string miRut, string miLicencia)
        {
            nombre = miNombre;
            rut = miRut;
            licencia = miLicencia;
        }
    }
}