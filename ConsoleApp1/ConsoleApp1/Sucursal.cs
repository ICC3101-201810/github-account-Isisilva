using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Sucursal
    {
        string nombre;
        string direccion;
        public Sucursal(string miNombre, string miDireccion)
        {
            nombre = miNombre;
            direccion = miDireccion;
        }

        internal void agregarVehiculos()
        {
            throw new NotImplementedException();
        }

        public abstract void AgregarVehiculos(Vehiculo vehiculo);
            
    }
}
