using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante
{
    class Ingrediente
    {
        private String Nombre;
        private double Precio;

        public Ingrediente(string nombre, double precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
        public override string ToString() => Nombre;

        public string NombreIngrediente => Nombre;

        public double PrecioIngrediente => Precio;
    }
}
