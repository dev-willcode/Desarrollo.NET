using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFormulariosMDI.Clases
{
    public class Persona
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private char sexo;
        private int edad;
        private string estadoCivil;
        private string ciudad;

        public Persona()
        {
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
