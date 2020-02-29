using System;
using System.Collections.Generic;
using Datos.AccesoDatos;
using Entidades.Entidades;

namespace Logica.Controladores
{
    public class GuiaLN : IControlador<Guia>
    {
        private readonly GuiaCD guiaCD = new GuiaCD();
        public bool Actualizar(Guia entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public GuiaCabecera obtenerCabecera(int id)
        {
            try
            {
                return guiaCD.obtenerCabecera(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CabeceraDetalle> obtenerDetalle(int id)
        {
            try
            {
                return guiaCD.obtenerDetalle(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insertar(Guia entidad)
        {
            try
            {
                return guiaCD.Insertar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Guia> Listar()
        {
            try
            {
                return guiaCD.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Guia Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Guia Obtener(Guia guia)
        {
            try
            {
                return guiaCD.Obtener(guia);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
