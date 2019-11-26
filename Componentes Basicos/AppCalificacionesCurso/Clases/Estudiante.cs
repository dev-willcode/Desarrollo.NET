using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalificacionesCurso.Clases
{
    class Estudiante
    {
        private String nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private String turno;

        public Estudiante()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public string Turno { get => turno; set => turno = value; }

        public double promedio() => (nota1 + nota2 + nota3) / 2;
    }
}
