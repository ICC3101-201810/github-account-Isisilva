using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : Persona
    {
        string categoria;

        public Cliente(string miNombre, string miRut, string miLicencia, 
                        string miCategoria) : base(miNombre, miRut, miLicencia)
        {
            categoria = miCategoria;
        }
    }
}
