using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Inventario;
using Entidades.ClasesPersonalizadas;
using Datos.Inventario;
using Datos;

namespace Logica.Inventario
{
    public class ProductoLN
    {
        public List<ProductoCategoria> MostrarProductoFitro(string busqueda)
        {
            List<ProductoCategoria> Lista = new List<ProductoCategoria>();
            ProductoCategoria op;
            try
            {
                List<cp_ListarProducto_FiltroResult> auxLista = ProductoCD.ListarProductosFiltro(busqueda);
                foreach (cp_ListarProducto_FiltroResult aux in auxLista)
                {

                    op = new ProductoCategoria(aux.IdProducto,aux.Categoria, aux.Nombre, aux.UnidadMedida,Convert.ToDecimal(aux.PrecioProveedor), Convert.ToDecimal(aux.PrecioVenta),Convert.ToInt16(aux.StockActual), Convert.ToInt16(aux.StockMinimo));
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Producto.", ex);
            }
            return Lista;
        }
        public List<Producto> BuscaProducto(int id)
        {
            List<Producto> Lista = new List<Producto>();
            Producto op;
            try
            {
                List<cp_listarProductoResult> auxLista = ProductoCD.ListarProductos();
                foreach (cp_listarProductoResult aux in auxLista)
                {

                    op = new Producto(aux.IdProducto, aux.IdCategoria, aux.Nombre, aux.UnidadMedida, Convert.ToDecimal(aux.PrecioProveedor), Convert.ToDecimal(aux.PrecioVenta), Convert.ToInt16(aux.StockActual), Convert.ToInt16(aux.StockMinimo));
                    Lista.Add(op);
                                       
                }
                var sql = from lp in Lista
                          where lp.IdProducto == id
                          select lp;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Producto.", ex);
            }
            return Lista.Where(lp=>lp.IdProducto==id).ToList();
        }
        public bool CreateProducto(Producto op)
        {
            try
            {
                ProductoCD.InsertarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Crear Producto.", ex);
            }
        }
        public bool UpdateProducto(Producto op)
        {
            try
            {
                ProductoCD.ActualizarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Producto.", ex);
            }
        }

        public bool DeleteProducto(ProductoCategoria op)
        {
            try
            {
                ProductoCD.EliminarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Producto.", ex);
            }
        }
    }
}
