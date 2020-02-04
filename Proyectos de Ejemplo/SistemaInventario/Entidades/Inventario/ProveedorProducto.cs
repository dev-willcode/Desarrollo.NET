using System;

namespace Entidades.Inventario
{
    public class ProveedorProducto
    {
        public ProveedorProducto()
        {
        }

        public ProveedorProducto(int idProducto, int idProveedor, DateTime fechaEntrega)
        {
            IdProducto = idProducto;
            IdProveedor = idProveedor;
            FechaEntrega = fechaEntrega;
        }

        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
