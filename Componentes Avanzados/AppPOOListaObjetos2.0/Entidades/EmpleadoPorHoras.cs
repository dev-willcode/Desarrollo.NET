using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    class EmpleadoPorHoras : Empleado
    {
        private int numHoras;
        private double costoHora;
        public EmpleadoPorHoras()
        {

        }
        public EmpleadoPorHoras(string ced, string nom, string ape, char sexo, int edad, string ciudad, string tipo, int numHoras = 0, double costoHora = 0)
            : base(ced, nom, ape, sexo, edad, ciudad, tipo)
        {
            this.numHoras = numHoras;
            this.costoHora = costoHora;
        }

        public int NumHoras { get => numHoras; set => numHoras = value; }
        public double CostoHora { get => costoHora; set => costoHora = value; }

        public override double CalcularSueldo()
        {
            double sueldo;
            sueldo = numHoras * costoHora;
            if (numHoras > 40)
                sueldo += sueldo * 1.5;
            return sueldo;
        }

        public override string Imprimir()
        {
            return "Cedula: " + this.Cedula + "\nNombre: " + this.Nombres + "\nApellido: " + this.Apellidos + "\nSexo: " + this.Sexo + "\nEdad: " + this.Edad + "\nCiudad: " + this.Ciudad + "\nSueldo: " + CalcularSueldo();

        }

    }
}
