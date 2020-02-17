using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasePersonalizada
{
    public class ReporteCategoria
    {
        public ReporteCategoria(int idProducto, string nombre, string categoria, decimal precioProveedor, int stockActual, decimal precioVenta, int idCategoria)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Categoria = categoria;
            PrecioProveedor = precioProveedor;
            StockActual = stockActual;
            PrecioVenta = precioVenta;
            IdCategoria = idCategoria;
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioProveedor { get; set; }
        public int StockActual { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdCategoria { get; set; }
    }
}
