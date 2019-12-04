using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHerencia.Clases
{
    abstract class Empleado
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private int edad;
        private string estadoCivil;
        private string ciudad;

        public Empleado()
        {
        }

        public Empleado(string cedula, string nombre, string apellido, int edad, string estadoCivil, string ciudad)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.estadoCivil = estadoCivil;
            this.ciudad = ciudad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public abstract double calcularSueldo();
        public abstract double imprimir();
    }
}
