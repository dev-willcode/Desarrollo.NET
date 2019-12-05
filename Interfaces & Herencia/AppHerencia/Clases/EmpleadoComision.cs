using System.Windows.Forms;

namespace AppHerencia.Clases
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

        public virtual double calcularSueldo()
        {
            return ventasBrutas * (porcentaje / 100);
        }

        public virtual void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
