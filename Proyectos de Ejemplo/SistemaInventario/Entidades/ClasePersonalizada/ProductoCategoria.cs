using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasePersonalizada
{
    public class ProductoCategoria
    {
        public ProductoCategoria()
        {
        }

        public ProductoCategoria(int idProducto, string categoria, string nombre, string proveedor,
            string unidadMedida, decimal precioProveedor, short stockActual, short stockMinimo, decimal precioVenta)
        {
            IdProducto = idProducto;
            Categoria = categoria;
            Nombre = nombre;
            Proveedor = proveedor;
            UnidadMedida = unidadMedida;
            PrecioProveedor = precioProveedor;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
            PrecioVenta = precioVenta;
        }

        public int IdProducto { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioProveedor { get; set; }
        public short StockActual { get; set; }
        public short StockMinimo { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
