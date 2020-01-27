﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre;
        private string descripcion;
                public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public Categoria()
        {
        }
    }
}
