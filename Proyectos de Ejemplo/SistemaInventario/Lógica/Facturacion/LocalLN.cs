using System;
using System.Collections.Generic;
using Datos;
using Datos.Facturacion;

namespace Lógica.Facturacion
{
    public class LocalLN
    {
        public List<Local> MostrarLocalFitro(string busqueda)
        {
            List<Local> Lista = new List<Local>();
            Local oc;
            try
            {
                List<SP_ListarLocal_FiltroResult> auxLista = LocalCD.ListarLocalFiltro(busqueda);
                foreach (SP_ListarLocal_FiltroResult aux in auxLista)
                {

                    oc = new Local(aux.IdLocal, aux.Direccion, aux.Ciudad, aux.Telefono, aux.Fax);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Local.", ex);
            }
            return Lista;
        }
        public List<Local> MostrarLocal()
        {
            List<Local> Lista = new List<Local>();
            Local oc;
            try
            {
                List<LOCAL> auxLista = LocalCD.ListarLocal();
                foreach (LOCAL aux in auxLista)
                {

                    oc = new Local(aux.IdLocal, aux.Direccion, aux.Ciudad, aux.Telefono, aux.Fax);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Local.", ex);
            }
            return Lista;
        }
        public bool CreateLocal(Local oc)
        {
            try
            {
                LocalCD.InsertarLocal(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Local.", ex);
            }
        }
        public bool UpdateLocal(Local oc)
        {
            try
            {
                LocalCD.ActualizarLocal(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Local.", ex);
            }
        }

        public bool DeleteLocal(Local oc)
        {
            try
            {
                LocalCD.EliminarLocal(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Local.", ex);
            }
        }
    }
}
