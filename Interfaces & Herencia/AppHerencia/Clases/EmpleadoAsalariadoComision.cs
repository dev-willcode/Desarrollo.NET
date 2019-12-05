using System.Windows.Forms;

namespace AppHerencia.Clases
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


        override public double calcularSueldo()
        {
            return salarioBase + base.calcularSueldo();
        }

        override public void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
