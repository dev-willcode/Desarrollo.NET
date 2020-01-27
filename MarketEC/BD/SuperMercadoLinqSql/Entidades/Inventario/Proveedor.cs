﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Proveedor
    {
        private int idProveedor;
        private string cedProveedor;
        private string nombre;
        private string representante;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string fax;
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string CedProveedor { get => cedProveedor; set => cedProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Representante { get => representante; set => representante = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }

        public Proveedor(int idProveedor, string cedProveedor, string nombre, string representante, string direccion, string ciudad, string telefono, string fax)
        {
            this.IdProveedor = idProveedor;
            this.CedProveedor = cedProveedor;
            this.Nombre = nombre;
            this.Representante = representante;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Telefono = telefono;
            this.Fax = fax;
        }
       public Proveedor()
        {
        }

    }
}
