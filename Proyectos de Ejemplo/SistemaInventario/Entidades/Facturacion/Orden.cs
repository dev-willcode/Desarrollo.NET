using System;

namespace Entidades.Facturacion
{
    public class Orden
    {
        private int idOrden;
        private DateTime fechaOrden;
        private DateTime fechaEntrada;

        public Orden()
        {
        }

        public Orden(int idOrden, DateTime fechaOrden, DateTime fechaEntrega)
        {
            IdOrden = idOrden;
            FechaOrden = fechaOrden;
            FechaEntrada = fechaEntrega;
        }

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
    }
}
