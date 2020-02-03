using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Facturacion;

namespace Datos.Facturacion
{
    public class OrdenCD
    {
        public static List<SP_ListarOrden_FiltroResult> ListarOrdenFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarOrden_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<ORDEN> ListarOrden()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.ORDEN.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarOrden(Orden oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarOrden(
                        oc.FechaOrden,
                        oc.FechaEntrada);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Orden.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarOrden(Orden oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarOrden(
                        oc.IdOrden,
                        oc.FechaOrden.Date,
                        oc.FechaEntrada.Date);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarOrden(Orden oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarOrden(oc.IdOrden);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Orden.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
