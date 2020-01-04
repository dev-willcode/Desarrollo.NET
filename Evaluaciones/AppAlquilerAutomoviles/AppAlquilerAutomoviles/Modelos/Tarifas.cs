using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlquilerAutomoviles.Modelos
{
    public class Tarifas
    {
        private char modelo;
        private double precio;
        private string estimadoTiempo;

        public Tarifas()
        {
        }

        public Tarifas(char modelo, double precio, string estimadoTiempo)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.estimadoTiempo = estimadoTiempo;
        }

        public char Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string EstimadoTiempo { get => estimadoTiempo; set => estimadoTiempo = value; }
    }
}
