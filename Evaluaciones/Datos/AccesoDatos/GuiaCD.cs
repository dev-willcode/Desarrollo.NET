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

        public List<CabeceraDetalle> obtenerDetalle(int id)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    List<CabeceraDetalle> listado = new List<CabeceraDetalle>();
                    DB.SP_DetalleGuia(id).ToList().ForEach(aux =>
                    {
                        listado.Add(new CabeceraDetalle(
                            aux.id_guia,
                            aux.codigo,
                            aux.peso.GetValueOrDefault(),
                            aux.direccion,
                            aux.costo_envio.GetValueOrDefault()
                            ));
                    }
                    );
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar los detalles.", ex);
            }
        }

        public GuiaCabecera obtenerCabecera(int id)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    SP_CabeceraGuiaResult aux = DB.SP_CabeceraGuia(id).ToList()[0];
                    return new GuiaCabecera(
                        aux.id,
                        aux.fecha_envio.GetValueOrDefault(),
                        aux.cantidad_encomiendas.GetValueOrDefault(),
                        aux.peso_total.GetValueOrDefault(),
                        aux.nombre,
                        aux.peso_max.GetValueOrDefault()
                        );
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar la cabecera.", ex);
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
