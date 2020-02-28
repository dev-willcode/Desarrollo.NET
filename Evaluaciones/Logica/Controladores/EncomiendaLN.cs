using System;
using System.Collections.Generic;
using Datos.AccesoDatos;
using Entidades.Entidades;

namespace Logica.Controladores
{
    public class EncomiendaLN : IControlador<Encomiendas>
    {
        private readonly EncomiendasCD encomiendasCD = new EncomiendasCD();
        public bool Actualizar(Encomiendas entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Encomiendas entidad)
        {
            try
            {
                return encomiendasCD.Insertar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Encomiendas> Listar()
        {
            try
            {
                return encomiendasCD.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Encomiendas Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public void ActualizarEstado(int idGuia)
        {
            try
            {
                encomiendasCD.ActualizarEstado(idGuia);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Encomiendas> ListarEncomiendasPorEntregar()
        {
            try
            {
                return encomiendasCD.ListarEncomiendasPorEntregar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
