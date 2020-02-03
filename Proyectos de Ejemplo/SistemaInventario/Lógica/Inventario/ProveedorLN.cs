using System;
using System.Collections.Generic;
using Datos;
using Datos.Inventario;
using Entidades.Inventario;

namespace Lógica.Inventario
{
    public class ProveedorLN
    {
        public static List<Proveedor> MostrarProveedorFitro(string busqueda)
        {
            List<Proveedor> Lista = new List<Proveedor>();
            Proveedor oc;
            try
            {
                List<SP_ListarProveedor_FiltroResult> auxLista = ProveedorCD.ListarProveedorFiltro(busqueda);
                foreach (SP_ListarProveedor_FiltroResult aux in auxLista)
                {

                    oc = new Proveedor(aux.IdProveedor, aux.CedProveedor, aux.Nombre, aux.Representante,
                    aux.Direccion, aux.Ciudad, aux.Telefono, aux.Fax);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Proveedor.", ex);
            }
            return Lista;
        }
        public static List<Proveedor> MostrarProveedor()
        {
            List<Proveedor> Lista = new List<Proveedor>();
            Proveedor oc;
            try
            {
                List<PROVEEDOR> auxLista = ProveedorCD.ListarProveedor();
                foreach (PROVEEDOR aux in auxLista)
                {

                    oc = new Proveedor(aux.IdProveedor, aux.CedProveedor, aux.Nombre, aux.Representante,
                    aux.Direccion, aux.Ciudad, aux.Telefono, aux.Fax);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Proveedor.", ex);
            }
            return Lista;
        }
        public bool CreateProveedor(Proveedor oc)
        {
            try
            {
                ProveedorCD.InsertarProveedor(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Proveedor.", ex);
            }
        }
        public bool UpdateProveedor(Proveedor oc)
        {
            try
            {
                ProveedorCD.ActualizarProveedor(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Proveedor.", ex);
            }
        }

        public bool DeleteProveedor(Proveedor oc)
        {
            try
            {
                ProveedorCD.EliminarProveedor(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Proveedor.", ex);
            }
        }
    }
}
