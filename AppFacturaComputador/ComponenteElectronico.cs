using System;

namespace AppFacturaComputador
{
    class ComponenteElectronico
    {
        private int cantidad;
        private String nombre;
        private double precio;
        private double iva;

        public ComponenteElectronico(string nombre, double precio)
        {
            this.Cantidad = 1;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Iva = precio * 0.12;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Iva { get => iva; set => iva = value; }

        public override string ToString() => Nombre;
    }
}
