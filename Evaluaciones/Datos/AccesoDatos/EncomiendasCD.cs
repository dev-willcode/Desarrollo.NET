using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelo;
using Entidades.Entidades;

namespace Datos.AccesoDatos
{
    public class EncomiendasCD : IAccesoDatos<Encomiendas>
    {
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
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_InsertarEncomienda(entidad.id_cliente, entidad.codigo, entidad.peso, entidad.direccion, entidad.costo_envio, entidad.estado);
                    DB.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar la encomienda.", ex);
            }
        }

        public List<Encomiendas> Listar()
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<Encomiendas> listado = new List<Encomiendas>();
                    DB.SP_ListarEncomiendas().ToList().ForEach(aux =>
                    {
                        listado.Add(new Encomiendas(
                            aux.id,
                            aux.id_cliente.GetValueOrDefault(),
                            aux.codigo,
                            aux.peso.GetValueOrDefault(),
                            aux.direccion,
                            aux.costo_envio.GetValueOrDefault(),
                            aux.estado
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar las encomiendas.", ex);
            }
        }

        public List<Encomiendas> ListarEncomiendasPorEntregar()
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<Encomiendas> listado = new List<Encomiendas>();
                    DB.SP_ListarEncomiendasPorEntregar().ToList().ForEach(aux =>
                    {
                        listado.Add(new Encomiendas(
                            aux.id,
                            aux.id_cliente.GetValueOrDefault(),
                            aux.codigo,
                            aux.peso.GetValueOrDefault(),
                            aux.direccion,
                            aux.costo_envio.GetValueOrDefault(),
                            aux.estado
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar las encomiendas.", ex);
            }
        }

        public void ActualizarEstado(int idGuia)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_ActualizarEncomiendaEstado(idGuia);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar la encomienda.", ex);
            }
        }

        public Encomiendas Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
