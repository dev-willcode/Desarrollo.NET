using System.Windows.Forms;

namespace AppAbstractas.Clases
{
    class EmpleadoHora : Empleado
    {
        private double horasTrabajadas;
        private double costoHora;

        public EmpleadoHora()
        {
        }

        public EmpleadoHora(Empleado empleado) : base(empleado)
        {
        }

        public double HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double CostoHora { get => costoHora; set => costoHora = value; }

        public override double calcularSueldo()
        {
            double sueldo = HorasTrabajadas * CostoHora;
            if (HorasTrabajadas > 40)
            {
                sueldo = sueldo * 1.5;
            }

            return sueldo;
        }

        public override void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
