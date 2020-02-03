using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Facturacion;

namespace Datos.Facturacion
{
    public class GuiaCD
    {
        public static List<SP_ListarGuia_FiltroResult> ListarGuiaFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarGuia_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Guia.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<GUIA> ListarGuia()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.GUIA.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Guia.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarGuia(Guia oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarGuia(
                        oc.IdLocal,
                        oc.FechaSalida,
                        oc.Transportista,
                        oc.Total,
                        oc.Cantidad_item);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Guia.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarGuia(Guia oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarGuia(
                        oc.IdGuia,
                        oc.IdLocal,
                        oc.FechaSalida,
                        oc.Transportista,
                        oc.Total,
                        oc.Cantidad_item);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Guia.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarGuia(Guia oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarGuia(oc.IdGuia);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Guia.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
