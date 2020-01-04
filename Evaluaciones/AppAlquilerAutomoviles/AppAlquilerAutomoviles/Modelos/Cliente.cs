using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlquilerAutomoviles.Modelos
{
    class Cliente
    {
        private String cedula;
        private String nombre;
        private int vehiculosAlquilados;

        public Cliente()
        {
        }

        public Cliente(string cedula, string nombre, int vehiculosAlquilados)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.vehiculosAlquilados = vehiculosAlquilados;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int VehiculosAlquilados { get => vehiculosAlquilados; set => vehiculosAlquilados = value; }
    }
}
