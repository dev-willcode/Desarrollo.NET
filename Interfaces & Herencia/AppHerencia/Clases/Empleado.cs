using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHerencia.Clases
{
    public class Empleado
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private int edad;
        private DateTime fechaNacimiento;
        private char sexo;
        private string estadoCivil;
        private string ciudad;

        public Empleado()
        {
        }

        public Empleado(Empleado empleado)
        {
            this.cedula = empleado.cedula;
            this.nombre = empleado.nombre;
            this.apellido = empleado.apellido;
            this.edad = empleado.edad;
            this.sexo = empleado.sexo;
            this.estadoCivil = empleado.estadoCivil;
            this.ciudad = empleado.ciudad;
        }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public void ImprimirDatos()
        {
            MessageBox.Show("EMPLEADO GENERADO CON EXITO\n" +
                "\n -Cedula: " + Cedula +
                "\n -Nombre: " + Nombre +
                "\n -Apellido: " + Apellido +
                "\n -Edad: " + Edad +
                "\n -Estado Civil: " + EstadoCivil +
                "\n -Ciudad: " + Ciudad);
        }
    }
}
