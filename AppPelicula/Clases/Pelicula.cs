using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPelicula.Clases
{
    class Pelicula
    {
        private String nombre;
        private String categoria;
        private double duracion;
        private String actor;

        public Pelicula()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public string Actor { get => actor; set => actor = value; }
    }
}
