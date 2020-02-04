using System;
using System.Collections.Generic;
using Datos;
using Datos.Inventario;
using Entidades.Inventario;

namespace Lógica.Inventario
{
    public class ProductoLN
    {
        public List<Producto> MostrarProductoFitro(string busqueda)
        {
            List<Producto> Lista = new List<Producto>();
            Producto oc;
            try
            {
                List<SP_ListarProducto_FiltroResult> auxLista = ProductoCD.ListarProductoFiltro(busqueda);
                foreach (SP_ListarProducto_FiltroResult aux in auxLista)
                {

                    oc = new Producto(aux.IdProducto, aux.IdCategoria, aux.Nombre, aux.UnidadMedida, aux.PrecioProveedor,
                    aux.StockActual, aux.StockMinimo, aux.PrecioVenta);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Producto.", ex);
            }
            return Lista;
        }
        public List<Producto> MostrarProducto()
        {
            List<Producto> Lista = new List<Producto>();
            Producto oc;
            try
            {
                List<PRODUCTO> auxLista = ProductoCD.ListarProductos();
                foreach (PRODUCTO aux in auxLista)
                {

                    oc = new Producto(aux.IdProducto, aux.IdCategoria, aux.Nombre, aux.UnidadMedida, aux.PrecioProveedor.Value,
                    aux.StockActual.Value, aux.StockMinimo.Value, aux.PrecioVenta.Value);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Producto.", ex);
            }
            return Lista;
        }
        public int CreateProducto(Producto oc)
        {
            try
            {
                return ProductoCD.InsertarProducto(oc);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Producto.", ex);
            }
        }
        public bool UpdateProducto(Producto oc)
        {
            try
            {
                ProductoCD.ActualizarProducto(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Producto.", ex);
            }
        }

        public bool DeleteProducto(Producto oc)
        {
            try
            {
                ProductoCD.EliminarProducto(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Producto.", ex);
            }
        }
    }
}
