using System;

namespace Entidades.Entidades
{
    public class Guia
    {
        public Guia()
        {
        }

        public Guia(int id, int id_camion, DateTime fecha_envio, int cantidad_encomiendas, decimal peso_total)
        {
            this.id = id;
            this.id_camion = id_camion;
            this.fecha_envio = fecha_envio;
            this.cantidad_encomiendas = cantidad_encomiendas;
            this.peso_total = peso_total;
        }

        public int id { get; set; }
        public int id_camion { get; set; }
        public DateTime fecha_envio { get; set; }
        public int cantidad_encomiendas { get; set; }
        public decimal peso_total { get; set; }
    }
}
