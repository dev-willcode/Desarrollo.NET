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

        public EmpleadoHora(string cedula, string nombre, string apellido, int edad, string estadoCivil, string ciudad, double horasTrabajadas, double costoHora)
            : base(cedula, nombre, apellido, edad, estadoCivil, ciudad)
        {
            this.HorasTrabajadas = horasTrabajadas;
            this.CostoHora = costoHora;
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
