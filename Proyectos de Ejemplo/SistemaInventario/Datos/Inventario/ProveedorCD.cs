using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Inventario;

namespace Datos.Inventario
{
    public class ProveedorCD
    {
        public static List<SP_ListarProveedor_FiltroResult> ListarProveedorFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarProveedor_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<PROVEEDOR> ListarProveedor()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.PROVEEDOR.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarProveedor(Proveedor oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarProveedor(oc.IdProveedor, oc.CedProveedor, oc.Nombre, oc.Representante,
                    oc.Direccion, oc.Ciudad, oc.Telefono, oc.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarProveedor(Proveedor oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarProveedor(oc.IdProveedor, oc.CedProveedor, oc.Nombre, oc.Representante,
                    oc.Direccion, oc.Ciudad, oc.Telefono, oc.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarProveedor(Proveedor oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarProveedor(oc.IdProveedor);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
