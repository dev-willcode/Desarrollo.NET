﻿using System.Windows.Forms;

namespace AppHerencia.Clases
{
    class EmpleadoAsalariado : Empleado
    {
        private double sueldoFijo;

        public EmpleadoAsalariado()
            : base()
        {
        }

        public EmpleadoAsalariado(string cedula, string nombre, string apellido, int edad, string estadoCivil, string ciudad, double sueldoFijo)
            : base(cedula, nombre, apellido, edad, estadoCivil, ciudad)
        {
            this.SueldoFijo = sueldoFijo;
        }

        public double SueldoFijo { get => sueldoFijo; set => sueldoFijo = value; }

        public double calcularSueldo()
        {
            return SueldoFijo;
        }

        public void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}