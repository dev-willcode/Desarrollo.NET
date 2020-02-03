using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Facturacion;

namespace Datos.Facturacion
{
    public class TransportistaCD
    {
        public static List<SP_ListarTransportista_FiltroResult> ListarTransportistaFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarTransportista_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Transportista.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<TRANSPORTISTA> ListarTransportista()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.TRANSPORTISTA.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Transportista.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarTransportista(Transportista oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarTransportista(
                        oc.IdTransportista,
                        oc.CedTransportista,
                        oc.Nombre,
                        oc.Direccion,
                        oc.Ciudad,
                        oc.Telefono);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Transportista.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarTransportista(Transportista oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarTransportista(
                        oc.IdTransportista,
                        oc.CedTransportista,
                        oc.Nombre,
                        oc.Direccion,
                        oc.Ciudad,
                        oc.Telefono);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Transportista.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarTransportista(Transportista oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarTransportista(oc.IdTransportista);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Transportista.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
