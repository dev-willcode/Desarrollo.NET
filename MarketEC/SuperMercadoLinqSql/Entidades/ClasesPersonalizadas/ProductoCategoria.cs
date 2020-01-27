using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesPersonalizadas
{
    public class ProductoCategoria
    {
        private int idProducto;
        private string categoria;
        private string nombre;
        private string unidadMedida;
        private decimal precioProveedor;
        private short stockActual;
        private short stockMinimo;
        private decimal precioVenta;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public decimal PrecioProveedor { get => precioProveedor; set => precioProveedor = value; }
        public short StockActual { get => stockActual; set => stockActual = value; }
        public short StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }

        public ProductoCategoria(int idProducto, string categoria, string nombre, string unidadMedida, decimal precioProveedor, decimal precioVenta, short stockActual, short stockMinimo)
        {
            this.idProducto = idProducto;
            this.categoria = categoria;
            this.nombre = nombre;
            this.UnidadMedida = unidadMedida;
            this.precioProveedor = precioProveedor;
            this.stockActual = stockActual;
            this.stockMinimo = stockMinimo;
            this.precioVenta = precioVenta;
        }

        public ProductoCategoria()
        {
        }
    }
}
