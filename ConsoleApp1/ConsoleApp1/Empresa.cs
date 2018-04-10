using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa : Persona, IArrendar
    {
        string autorizacion; 

        public Empresa(string miNombre, string miRut,
                        string miAutorizacion) : base(miNombre, miRut)
        {
            autorizacion = miAutorizacion;

        }

        public void PoderArrendar(string autorizacion)
        {

        }
    }

}
