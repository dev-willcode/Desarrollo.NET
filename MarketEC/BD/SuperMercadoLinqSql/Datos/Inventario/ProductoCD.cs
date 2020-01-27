using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Inventario;
using Entidades.ClasesPersonalizadas;

namespace Datos.Inventario
{
    public class ProductoCD
    {
        public static List<cp_ListarProducto_FiltroResult> ListarProductosFiltro(string busqueda)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    return DB.cp_ListarProducto_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static List<cp_listarProductoResult> ListarProductos()
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    return DB.cp_listarProducto().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Productos.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarProducto(Producto op)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                     DB.cp_InsertarProducto(op.IdProducto, op.IdCategoria, op.Nombre, op.UnidadMedida, op.PrecioProveedor, op.PrecioVenta,op.StockActual, op.StockMinimo);
                    //DB.cp_InsertarProducto(61,2, "yy", "xx",1,1,1,1);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Producto.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarProducto(Producto op)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_ActualizarProducto(op.IdProducto, op.IdCategoria, op.Nombre, op.UnidadMedida, op.PrecioProveedor, op.PrecioVenta, op.StockActual, op.StockMinimo);
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

        public static void EliminarProducto(ProductoCategoria op)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_EliminarPoducto(op.IdProducto);
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
