using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    class TrabajadorPorPiezas : Empleado
    {
        private double sueldo;
        private int piezas;
        public TrabajadorPorPiezas()
        {

        }
        public TrabajadorPorPiezas(string ced, string nom, string ape, char sexo, int edad, string ciudad, string tipo, double sueldo, int piezas)
            : base(ced, nom, ape, sexo, edad, ciudad, tipo)
        {
            this.Sueldo = sueldo;
            this.Piezas = piezas;
        }

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int Piezas { get => piezas; set => piezas = value; }

        public override double CalcularSueldo()
        {
            return sueldo * piezas;
        }

        public override string Imprimir()
        {
            return "Cedula: " + this.Cedula + "\nNombre: " + this.Nombres + "\nApellido: " + this.Apellidos + "\nSexo: " + this.Sexo + "\nEdad: " + this.Edad + "\nCiudad: " + this.Ciudad + "\nSueldo: " + CalcularSueldo();

        }
    }
}
