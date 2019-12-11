using System;
using System.Collections.Generic;

namespace AppPruebaCalendario.Clases
{
    public class Persona
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private DateTime fechaNacimiento;
        private string sexo;
        private string estadoCivil;
        private List<Compromisos> compromisos = new List<Compromisos>();

        public Persona()
        {
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        internal List<Compromisos> Compromisos { get => compromisos; set => compromisos = value; }
    }
}
