using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    class EmpleadoAsalariado : Empleado
    {
        private double salario;
        public EmpleadoAsalariado()
        {

        }
        public EmpleadoAsalariado(string ced, string nom, string ape, char sexo, int edad, string ciudad, string tipo, double salario)
            : base(ced, nom, ape, sexo, edad, ciudad, tipo) 
        {
            this.salario = salario;
            
        }

        public double Salario { get => salario; set => salario = value; }

        public override double CalcularSueldo()
        {
            return salario;
        }
        public override string Imprimir()
        {
            return "Cedula: " + this.Cedula + "\nNombre: " + this.Nombres + "\nApellido: " + this.Apellidos + "\nSexo: " + this.Sexo + "\nEdad: " + this.Edad + "\nCiudad: " + this.Ciudad + "\nSueldo: " + CalcularSueldo();

        }
    }
}
