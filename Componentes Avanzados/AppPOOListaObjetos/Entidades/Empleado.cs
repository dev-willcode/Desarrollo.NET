using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    public abstract class Empleado
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private char sexo;
        private int edad;
        private string ciudad;
        private string tipo;

        public Empleado()
        {
            
        }

        public Empleado(string cedula, string nombres, string apellidos, char sexo, int edad, string ciudad, string tipo)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Ciudad = ciudad;
            this.Tipo = tipo;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public abstract double CalcularSueldo();
        public abstract string Imprimir();
    }
}
