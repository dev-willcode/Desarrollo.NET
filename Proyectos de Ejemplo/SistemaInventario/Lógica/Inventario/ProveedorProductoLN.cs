using System;
using Datos.Inventario;
using Entidades.Inventario;

namespace Lógica.Inventario
{
    public class ProveedorProductoLN
    {
        public bool CreateProveedorProducto(ProveedorProducto oc)
        {
            try
            {
                ProveedorProductoCD.InsertarProveedorProducto(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear ProveedorProducto.", ex);
            }
        }
        public bool UpdateProveedorProducto(ProveedorProducto oc)
        {
            try
            {
                ProveedorProductoCD.ActualizarProveedorProducto(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Proveedor.", ex);
            }
        }

        public bool DeleteProveedorProducto(int ID)
        {
            try
            {
                ProveedorProductoCD.EliminarProveedorProducto(ID);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Proveedor.", ex);
            }
        }
    }
}
