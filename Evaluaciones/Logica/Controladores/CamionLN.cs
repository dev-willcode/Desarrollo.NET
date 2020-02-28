using System;
using System.Collections.Generic;
using Datos.AccesoDatos;
using Entidades.Entidades;

namespace Logica.Controladores
{
    public class CamionLN : IControlador<Camion>
    {
        private readonly CamionCD camionCD = new CamionCD();
        public bool Actualizar(Camion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Camion entidad)
        {
            try
            {
                return camionCD.Insertar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Camion> Listar()
        {
            try
            {
                return camionCD.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Camion Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public void ActualizarEstadoOcupado(int id_camion)
        {
            try
            {
                camionCD.ActualizarEstadoOcupado(id_camion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarEstadoDisponible(int id_camion)
        {
            try
            {
                camionCD.ActualizarEstadoDisponible(id_camion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
