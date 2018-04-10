using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : Persona, IArrendar
    {
        string categoria;
        string licencia;

        public Cliente(string miNombre, string miRut, string miLicencia, 
                        string miCategoria) : base(miNombre, miRut)
        {
            categoria = miCategoria;
            licencia = miLicencia;
            
        }

        public void PoderArrendar(string licencia)
        {
           
        }
    }
}
