using System.Windows.Forms;

namespace AppAbstractas.Clases
{
    class EmpleadoComision : Empleado
    {
        private double ventasBrutas;
        private double porcentaje;

        public EmpleadoComision()
        {
        }

        public EmpleadoComision(Empleado empleado) : base(empleado)
        {
        }
        public double VentasBrutas { get => ventasBrutas; set => ventasBrutas = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        public override double calcularSueldo()
        {
            return ventasBrutas * (porcentaje / 100);
        }

        public override void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
