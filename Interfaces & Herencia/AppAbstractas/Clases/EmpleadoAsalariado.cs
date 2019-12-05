using System.Windows.Forms;

namespace AppAbstractas.Clases
{
    class EmpleadoAsalariado : Empleado
    {
        private double sueldoFijo;

        public EmpleadoAsalariado()
            : base()
        {
        }

        public EmpleadoAsalariado(Empleado empleado) : base(empleado)
        {
        }

        public double SueldoFijo { get => sueldoFijo; set => sueldoFijo = value; }

        public override double calcularSueldo()
        {
            return SueldoFijo;
        }

        public override void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
