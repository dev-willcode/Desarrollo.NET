using System;
using Entidades.Inventario;

namespace Datos.Inventario
{
    public class ProveedorProductoCD
    {
        public static void InsertarProveedorProducto(ProveedorProducto oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_Insertar_RelProveedorProducto(
                        oc.IdProducto,
                        oc.IdProveedor,
                        oc.FechaEntrega);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar ProveedorProducto.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static void ActualizarProveedorProducto(ProveedorProducto oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarRelProveedorProducto(oc.IdProducto, oc.IdProveedor, oc.FechaEntrega);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar ProveedorProducto.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarProveedorProducto(int ID)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_Eliminar_RelProveedorProducto(ID);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar ProveedorProducto.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
