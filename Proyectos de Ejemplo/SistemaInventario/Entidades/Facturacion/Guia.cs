using System;

namespace Entidades.Facturacion
{
    public class Guia
    {
        private int idGuia;
        private int idLocal;
        private DateTime fechaSalida;
        private string transportista;
        private decimal total;
        private int cantidad_item;

        public Guia()
        {
        }

        public Guia(int idGuia, int idLocal, DateTime fechaSalida, string transportista, decimal total, int cantidad_item)
        {
            IdGuia = idGuia;
            IdLocal = idLocal;
            FechaSalida = fechaSalida;
            Transportista = transportista;
            Total = total;
            Cantidad_item = cantidad_item;
        }

        public int IdGuia { get => idGuia; set => idGuia = value; }
        public int IdLocal { get => idLocal; set => idLocal = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Transportista { get => transportista; set => transportista = value; }
        public decimal Total { get => total; set => total = value; }
        public int Cantidad_item { get => cantidad_item; set => cantidad_item = value; }
    }
}
