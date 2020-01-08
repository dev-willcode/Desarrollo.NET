using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinPrácticaLab01Banco.Entidades
{
    class Cuenta : Persona
    {
        protected int numero;
        private double saldo;
        private string tipo;

        public Cuenta()
        {
        }

        public Cuenta(string cedula, string nombres, string direccion, string telefono, int edad, int numero, double saldo, string tipo) : base(cedula, nombres, direccion, telefono, edad)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.Tipo = tipo;
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
