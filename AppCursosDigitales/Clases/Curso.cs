using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCursosDigitales.Clases
{
    class Curso
    {
        private String categoria;
        private String nombre;
        private int costo;

        public Curso(string categoria, string nombre, int costo)
        {
            this.categoria = categoria;
            this.nombre = nombre;
            this.costo = costo;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}
