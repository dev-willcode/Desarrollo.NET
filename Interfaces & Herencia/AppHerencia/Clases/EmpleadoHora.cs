using System.Windows.Forms;

namespace AppHerencia.Clases
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

        public double calcularSueldo()
        {
            double sueldo = HorasTrabajadas * CostoHora;
            if (HorasTrabajadas > 40)
            {
                sueldo = sueldo * 1.5;
            }

            return sueldo;
        }

        public void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
