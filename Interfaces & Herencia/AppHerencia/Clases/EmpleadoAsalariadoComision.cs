using System.Windows.Forms;

namespace AppHerencia.Clases
{
    class EmpleadoAsalariadoComision : EmpleadoComision
    {
        private double salarioBase;

        public EmpleadoAsalariadoComision()
        {
        }

        public EmpleadoAsalariadoComision(string cedula, string nombre, string apellido, int edad, string estadoCivil, string ciudad, double ventasBrutas, double porcentaje, double salarioBase) 
            : base(cedula, nombre, apellido, edad, estadoCivil, ciudad, ventasBrutas, porcentaje)
        {
            this.salarioBase = salarioBase;
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
