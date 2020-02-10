using System;

namespace Entidades.Facturacion
{
    public class GuiaDetalle
    {
        public GuiaDetalle()
        {
        }

        public GuiaDetalle(int idGuia, int idProducto, int cantidad, decimal subtotal)
        {
            IdGuia = idGuia;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public int IdGuia { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
