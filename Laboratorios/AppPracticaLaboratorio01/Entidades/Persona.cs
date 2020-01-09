using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinPrácticaLab01Banco.Entidades
{
    class Persona
    {
        private string cedula;
        private string nombres;
        private string direccion;
        private string telefono;
        private int edad;

        public Persona()
        {
        }

        public Persona(string cedula, string nombres, string direccion, string telefono, int edad)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Edad = edad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
