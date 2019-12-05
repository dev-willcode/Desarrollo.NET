using System.Windows.Forms;

namespace AppHerencia.Clases
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

        public double calcularSueldo()
        {
            return SueldoFijo;
        }

        public void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
