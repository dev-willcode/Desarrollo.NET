using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Facturacion
{
    public class LocalCD
    {
        public static List<SP_ListarLocal_FiltroResult> ListarLocalFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarLocal_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar local.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<LOCAL> ListarLocal()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.LOCAL.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar local.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarLocal(Local oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarLocal(oc.IdLocal, oc.Direccion, oc.Ciudad, oc.Telefono, oc.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Local.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarLocal(Local oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarLocal(oc.IdLocal, oc.Direccion, oc.Ciudad, oc.Telefono, oc.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Local.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarLocal(Local oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarLocal(oc.IdLocal);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Local.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
