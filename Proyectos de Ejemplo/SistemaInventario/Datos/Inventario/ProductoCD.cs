using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Inventario;

namespace Datos.Inventario
{
    public class ProductoCD
    {
        public static List<SP_ListarProducto_FiltroResult> ListarProductoFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarProducto_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<PRODUCTO> ListarProductos()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.PRODUCTO.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarProducto(Producto oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarProducto(oc.IdCategoria, oc.Nombre, oc.UnidadMedida, oc.PrecioProveedor,
                    oc.StockActual, oc.StockMinimo, oc.PrecioVenta);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Productos.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarProducto(Producto oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarProducto(oc.IdProducto, oc.IdCategoria, oc.Nombre, oc.UnidadMedida, oc.PrecioProveedor,
                    oc.StockActual, oc.StockMinimo, oc.PrecioVenta);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarProducto(Producto oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarProducto(oc.IdProducto);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
