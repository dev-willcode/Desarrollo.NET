using System;
using System.Collections.Generic;
using Datos;
using Datos.Facturacion;
using Entidades.Facturacion;

namespace Lógica.Facturacion
{
    public class TransportistaLN
    {
        public List<Transportista> MostrarTransportistaFitro(string busqueda)
        {
            List<Transportista> Lista = new List<Transportista>();
            Transportista oc;
            try
            {
                List<SP_ListarTransportista_FiltroResult> auxLista = TransportistaCD.ListarTransportistaFiltro(busqueda);
                foreach (SP_ListarTransportista_FiltroResult aux in auxLista)
                {

                    oc = new Transportista(
                        aux.IdTransportista,
                        aux.CedTransportista,
                        aux.Nombre,
                        aux.Direccion,
                        aux.Ciudad,
                        aux.Telefono);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Transportista.", ex);
            }
            return Lista;
        }
        public List<Transportista> MostrarTransportista()
        {
            List<Transportista> Lista = new List<Transportista>();
            Transportista oc;
            try
            {
                List<TRANSPORTISTA> auxLista = TransportistaCD.ListarTransportista();
                foreach (TRANSPORTISTA aux in auxLista)
                {

                    oc = new Transportista(
                        aux.IdTransportista,
                        aux.CedTransportista,
                        aux.Nombre,
                        aux.Direccion,
                        aux.Ciudad,
                        aux.Telefono);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Transportista.", ex);
            }
            return Lista;
        }
        public bool CreateTransportista(Transportista oc)
        {
            try
            {
                TransportistaCD.InsertarTransportista(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Transportista.", ex);
            }
        }
        public bool UpdateTransportista(Transportista oc)
        {
            try
            {
                TransportistaCD.ActualizarTransportista(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Transportista.", ex);
            }
        }

        public bool DeleteTransportista(Transportista oc)
        {
            try
            {
                TransportistaCD.EliminarTransportista(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Transportista.", ex);
            }
        }
    }
}
