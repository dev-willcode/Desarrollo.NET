using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturaComputador
{
    class ComponenteElectronico
    {
        private String Nombre;
        private double Precio;

        public ComponenteElectronico(string nombre, double precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public override string ToString() => Nombre;

        public String NombreComponente() => Nombre;

        public double PrecioComponente() => Precio;

        public double IVAComponente() => Precio * 0.12;
    }
}
