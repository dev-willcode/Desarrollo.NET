using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelo;
using Entidades.Entidades;

namespace Datos.AccesoDatos
{
    public class GuiaCD : IAccesoDatos<Guia>
    {
        public bool Actualizar(Guia entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Guia entidad)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_InsertarGuia(entidad.id_camion, entidad.fecha_envio, entidad.cantidad_encomiendas, entidad.peso_total);
                    DB.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Cliente.", ex);
            }
        }

        public List<Guia> Listar()
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<Guia> listado = new List<Guia>();
                    DB.SP_ListarGuia().ToList().ForEach(aux =>
                    {
                        listado.Add(new Guia(
                            aux.id,
                            aux.id_camion.GetValueOrDefault(),
                            aux.fecha_envio.GetValueOrDefault(),
                            aux.cantidad_encomiendas.GetValueOrDefault(),
                            aux.peso_total.GetValueOrDefault()
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar las guias.", ex);
            }
        }

        public Guia Obtener(Guia guia)
        {
            CamionesdbDataContext DB = null;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    SP_ObtenerGuiaObjetoResult aux = DB.SP_ObtenerGuiaObjeto(
                        guia.id_camion,
                        guia.fecha_envio,
                        guia.cantidad_encomiendas,
                        guia.peso_total
                        ).ToList()[0];
                    return new Guia(
                        aux.id,
                        aux.id_camion.GetValueOrDefault(),
                        aux.fecha_envio.GetValueOrDefault(),
                        aux.cantidad_encomiendas.GetValueOrDefault(),
                        aux.peso_total.GetValueOrDefault()
                        );
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al obtener Guia.", ex);
            }
        }

        public Guia Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
