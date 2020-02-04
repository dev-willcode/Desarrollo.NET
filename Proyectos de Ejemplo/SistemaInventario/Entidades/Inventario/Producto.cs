namespace Entidades.Inventario
{
    public class Producto
    {
        private int idProducto;
        private int idCategoria;
        private string nombre;
        private string unidadMedida;
        private decimal precioProveedor;
        private short stockActual;
        private short stockMinimo;
        private decimal precioVenta;

        public Producto()
        {
        }

        public Producto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public Producto(int idProducto, int idCategoria, string nombre, string unidadMedida,
            decimal precioProveedor, short stockActual, short stockMinimo, decimal precioVenta)
        {
            IdProducto = idProducto;
            IdCategoria = idCategoria;
            Nombre = nombre;
            UnidadMedida = unidadMedida;
            PrecioProveedor = precioProveedor;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
            PrecioVenta = precioVenta;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public short StockActual { get => stockActual; set => stockActual = value; }
        public short StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
    }
}
