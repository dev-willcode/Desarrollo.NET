using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;
using Datos.Inventario;
using Datos;

namespace Logica.Inventario
{
    public class ProveedorLN
    {

        public List<Proveedor> MostrarProveedorFitro(string busqueda)
        {
            List<Proveedor> Lista = new List<Proveedor>();
            Proveedor op;
            try
            {
                List<cp_ListaProveedoresFiltroResult> auxLista = ProveedorCD.ListarProveedoresFiltro(busqueda);
                foreach (cp_ListaProveedoresFiltroResult aux in auxLista)
                {

                    op = new Proveedor(aux.IdProveedor, aux.CedProveedor, aux.Nombre, aux.Representante, aux.Direccion, aux.Ciudad, aux.Telefono, aux.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Proveedor.", ex);
            }
            return Lista;
        }
        public bool CreateProveedor(Proveedor op)
        {
            try
            {
                ProveedorCD.InsertarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Proveedor.", ex);
            }
        }
        public bool UpdateProveedor(Proveedor op)
        {
            try
            {
                ProveedorCD.ActualizarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar Proveedor.", ex);
            }
        }

        public bool DeleteProveedor(Proveedor op)
        {
            try
            {
                ProveedorCD.EliminarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Proveedor.", ex);
            }
        }




    }
}
