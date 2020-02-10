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

        public static Guia GetGuia(Guia oc)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    SP_GetGuiaResult aux = DB.SP_GetGuia(oc.IdLocal, oc.Transportista, oc.Total, oc.Cantidad_item).ToList()[0];
                    return new Guia(
                        aux.IdGuia,
                        aux.IdLocal,
                        aux.FechaSalida,
                        aux.Transportista,
                        aux.Total.GetValueOrDefault(),
                        aux.cantidad_Item.GetValueOrDefault());
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

        public static List<SP_ListarGuiaDetalleResult> ListarGuiaDetalle(int idGuia)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarGuiaDetalle(idGuia).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar GuiaDetalle.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarGuiaDetalle(List<GuiaDetalle> list)
        {
            BDMarketDataContext DB = null;
            try
            {
                list.ForEach(oc =>
                {
                    using (DB = new BDMarketDataContext())
                    {
                        DB.SP_InsertarGuiaDetalle(
                            oc.IdGuia,
                            oc.IdProducto,
                            oc.Cantidad,
                            oc.Subtotal);
                        DB.SubmitChanges();
                    }
                });
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar las GuiaDetalle.", ex);
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
