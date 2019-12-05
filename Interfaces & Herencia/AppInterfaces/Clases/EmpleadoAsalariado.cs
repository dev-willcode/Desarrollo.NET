using System.Windows.Forms;

namespace AppInterfaces.Clases
{
    class EmpleadoAsalariado : EmpleadoEmpresa
    {
        private double sueldoFijo;

        public EmpleadoAsalariado()
            : base()
        {
        }

        public EmpleadoAsalariado(EmpleadoEmpresa empleado) : base(empleado)
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
