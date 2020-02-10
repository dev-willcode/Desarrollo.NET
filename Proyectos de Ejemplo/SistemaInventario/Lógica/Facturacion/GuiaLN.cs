using System;
using System.Collections.Generic;
using Datos;
using Datos.Facturacion;
using Entidades.Facturacion;

namespace Lógica.Facturacion
{
    public class GuiaLN
    {
        public List<Guia> MostrarGuiaFitro(string busqueda)
        {
            List<Guia> Lista = new List<Guia>();
            Guia oc;
            try
            {
                List<SP_ListarGuia_FiltroResult> auxLista = GuiaCD.ListarGuiaFiltro(busqueda);
                foreach (SP_ListarGuia_FiltroResult aux in auxLista)
                {

                    oc = new Guia(
                        aux.IdGuia,
                        aux.IdLocal,
                        aux.FechaSalida,
                        aux.Transportista,
                        aux.Total.GetValueOrDefault(),
                        aux.cantidad_Item.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Guia.", ex);
            }
            return Lista;
        }
        public List<Guia> MostrarGuia()
        {
            List<Guia> Lista = new List<Guia>();
            Guia oc;
            try
            {
                List<GUIA> auxLista = GuiaCD.ListarGuia();
                foreach (GUIA aux in auxLista)
                {

                    oc = new Guia(
                        aux.IdGuia,
                        aux.IdLocal,
                        aux.FechaSalida,
                        aux.Transportista,
                        aux.Total.GetValueOrDefault(),
                        aux.cantidad_Item.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Guia.", ex);
            }
            return Lista;
        }

        public List<GuiaDetalle> ListarGuiaDetalle(int idGuia)
        {
            List<GuiaDetalle> Lista = new List<GuiaDetalle>();
            GuiaDetalle oc;
            try
            {
                List<SP_ListarGuiaDetalleResult> auxLista = GuiaCD.ListarGuiaDetalle(idGuia);
                auxLista.ForEach(aux =>
                {
                    oc = new GuiaDetalle(
                        aux.IdGuia,
                        aux.IdProducto,
                        aux.Cantidad,
                        aux.Subtotal.GetValueOrDefault());
                    Lista.Add(oc);
                });
                return Lista;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Guia.", ex);
            }
        }

        public void InsertarGuiaDetalle(List<GuiaDetalle> list)
        {
            try
            {
                GuiaCD.InsertarGuiaDetalle(list);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar los detalles", ex);
            }
        }

        public Guia GetGuia(Guia oc)
        {
            try
            {
                return GuiaCD.GetGuia(oc);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al obtener la Guia.", ex);
            }

        }

        public bool CreateGuia(Guia oc)
        {
            try
            {
                GuiaCD.InsertarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Guia.", ex);
            }
        }

        public void BorrarGuiaDetalle(int idGuia)
        {
            try
            {
                GuiaCD.EliminarGuiaDetalle(idGuia);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar GuiaDetalle.", ex);
            }
        }

        public bool UpdateGuia(Guia oc)
        {
            try
            {
                GuiaCD.ActualizarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Guia.", ex);
            }
        }

        public bool DeleteGuia(Guia oc)
        {
            try
            {
                GuiaCD.EliminarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Guia.", ex);
            }
        }
    }
}
