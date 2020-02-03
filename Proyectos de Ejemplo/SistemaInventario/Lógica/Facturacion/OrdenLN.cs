using System;
using System.Collections.Generic;
using Datos;
using Datos.Facturacion;
using Entidades.Facturacion;

namespace Lógica.Facturacion
{
    public class OrdenLN
    {
        public List<Orden> MostrarOrdenFitro(string busqueda)
        {
            List<Orden> Lista = new List<Orden>();
            Orden oc;
            try
            {
                List<SP_ListarOrden_FiltroResult> auxLista = OrdenCD.ListarOrdenFiltro(busqueda);
                foreach (SP_ListarOrden_FiltroResult aux in auxLista)
                {

                    oc = new Orden(
                        aux.IdOrden,
                        aux.FechaOrden,
                        aux.FechaEntrada.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Orden.", ex);
            }
            return Lista;
        }
        public List<Orden> MostrarOrden()
        {
            List<Orden> Lista = new List<Orden>();
            Orden oc;
            try
            {
                List<ORDEN> auxLista = OrdenCD.ListarOrden();
                foreach (ORDEN aux in auxLista)
                {

                    oc = new Orden(
                        aux.IdOrden,
                        aux.FechaOrden,
                        aux.FechaEntrada.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Orden.", ex);
            }
            return Lista;
        }
        public bool CreateOrden(Orden oc)
        {
            try
            {
                OrdenCD.InsertarOrden(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Orden.", ex);
            }
        }
        public bool UpdateOrden(Orden oc)
        {
            try
            {
                OrdenCD.ActualizarOrden(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Orden.", ex);
            }
        }

        public bool DeleteOrden(Orden oc)
        {
            try
            {
                OrdenCD.EliminarOrden(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Orden.", ex);
            }
        }
    }
}
