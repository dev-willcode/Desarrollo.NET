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

        public EmpleadoComision(string cedula, string nombre, string apellido, int edad, string estadoCivil, string ciudad, double ventasBrutas, double porcentaje)
            : base(cedula, nombre, apellido, edad, estadoCivil, ciudad)
        {
            this.VentasBrutas = ventasBrutas;
            this.Porcentaje = porcentaje;
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
