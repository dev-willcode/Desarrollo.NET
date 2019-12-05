using System.Windows.Forms;

namespace AppAbstractas.Clases
{
    class EmpleadoAsalariadoComision : EmpleadoComision
    {
        private double salarioBase;
        public EmpleadoAsalariadoComision()
        {
        }

        public EmpleadoAsalariadoComision(Empleado empleadoSeleccionado)
            : base(empleadoSeleccionado)
        {
        }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }


        public override double calcularSueldo()
        {
            return salarioBase + base.calcularSueldo();
        }

        public override void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
