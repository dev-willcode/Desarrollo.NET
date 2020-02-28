using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelo;
using Entidades.Entidades;

namespace Datos.AccesoDatos
{
    public class ClienteCD : IAccesoDatos<Cliente>
    {
        public bool Actualizar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insertar(Cliente entidad)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_InsertarCliente(entidad.cedula, entidad.nombres, entidad.telefono, entidad.direccion);
                    DB.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar el cliente.", ex);
            }
        }

        public List<Cliente> Listar()
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<Cliente> listado = new List<Cliente>();
                    DB.SP_ListarClientes().ToList().ForEach(aux =>
                    {
                        listado.Add(new Cliente(
                            aux.id,
                            aux.cedula,
                            aux.nombres,
                            aux.telefono,
                            aux.direccion
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar los clientes.", ex);
            }
        }

        public Cliente Obtener(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
