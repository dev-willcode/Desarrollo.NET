using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Datos.Inventario
{
    public class ProveedorCD
    {
        public static List<cp_ListaProveedoresFiltroResult> ListarProveedoresFiltro(string busqueda)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    return DB.cp_ListaProveedoresFiltro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar Proveedores.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarProveedor(Proveedor op)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_InsertarProveedor(op.IdProveedor, op.CedProveedor, op.Nombre, op.Representante, op.Direccion, op.Ciudad, op.Telefono, op.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarProveedor(Proveedor op)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_ActualizarProveedor(op.IdProveedor,op.CedProveedor,op.Nombre,op.Representante,op.Direccion,op.Ciudad,op.Telefono,op.Fax);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarProveedor(Proveedor op)
        {
           BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_EliminarProveedor(op.IdProveedor);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
