using System.Windows.Forms;

namespace AppInterfaces.Clases
{
    class EmpleadoAsalariadoComision : EmpleadoComision
    {
        private double salarioBase;
        public EmpleadoAsalariadoComision()
        {
        }

        public EmpleadoAsalariadoComision(EmpleadoEmpresa empleadoSeleccionado)
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
