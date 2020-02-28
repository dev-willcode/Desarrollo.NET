using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelo;
using Entidades.Entidades;

namespace Datos.AccesoDatos
{
    public class CamionCD : IAccesoDatos<Camion>
    {
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
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_InsertarCamion(entidad.nombre, entidad.peso_max, entidad.estado, entidad.numero_viajes);
                    DB.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar el camion.", ex);
            }
        }

        public List<Camion> Listar()
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<Camion> listado = new List<Camion>();
                    DB.SP_ListarCamiones().ToList().ForEach(aux =>
                    {
                        listado.Add(new Camion(
                            aux.id,
                            aux.nombre,
                            aux.peso_max.GetValueOrDefault(),
                            aux.estado,
                            aux.numero_viajes.GetValueOrDefault()
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar los camiones.", ex);
            }
        }

        public void ActualizarEstadoOcupado(int id_camion)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_ActualizarCamionOcupado(id_camion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar el camion.", ex);
            }
        }


        public void ActualizarEstadoDisponible(int id_camion)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_ActualizarCamionDisponible(id_camion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar el camion.", ex);
            }
        }

        public Camion Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
