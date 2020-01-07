using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    class EmpleadoPorComision : Empleado
    {
        private double ventBrut;
        private double porcentaje;
        public EmpleadoPorComision()
        {

        }
        public EmpleadoPorComision(string ced, string nom, string ape, char sexo, int edad, string ciudad, string tipo, double ventBrut, double porcentaje)
            : base(ced, nom, ape, sexo, edad, ciudad, tipo)
        {
            this.ventBrut = ventBrut;
            this.porcentaje = porcentaje;
        }

        public double VentBrut { get => ventBrut; set => ventBrut = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        public override double CalcularSueldo()
        {
            return ventBrut*porcentaje / 100;
        }
        public override string Imprimir()
        {
            return "Cedula: " + this.Cedula + "\nNombre: " + this.Nombres + "\nApellido: " + this.Apellidos + "\nNum Seg Social: " + "\nSexo: " + this.Sexo + "\nEdad: " + this.Edad + "\nCiudad: " + this.Ciudad + "\nSueldo: " + CalcularSueldo();

        }
    }
}
