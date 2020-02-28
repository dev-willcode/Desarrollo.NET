using System;
using System.Collections.Generic;
using Datos.AccesoDatos;
using Entidades.Entidades;

namespace Logica.Controladores
{
    public class ClienteLN : IControlador<Cliente>
    {
        private readonly ClienteCD clienteCD = new ClienteCD();
        public bool Actualizar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Cliente entidad)
        {
            try
            {
                return clienteCD.Insertar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Cliente> Listar()
        {
            try
            {
                return clienteCD.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Cliente Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
