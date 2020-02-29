using System;

namespace Entidades.Entidades
{
    public class GuiaCabecera
    {
        public GuiaCabecera()
        {
        }

        public GuiaCabecera(int id, DateTime fecha_envio, int cantidad_encomiendas, decimal peso_total, string nombre, decimal peso_max)
        {
            this.id = id;
            this.fecha_envio = fecha_envio;
            this.cantidad_encomiendas = cantidad_encomiendas;
            this.peso_total = peso_total;
            this.nombre = nombre;
            this.peso_max = peso_max;
        }

        public int id { get; set; }
        public DateTime fecha_envio { get; set; }
        public int cantidad_encomiendas { get; set; }
        public decimal peso_total { get; set; }
        public string nombre { get; set; }
        public decimal peso_max { get; set; }

    }
}
