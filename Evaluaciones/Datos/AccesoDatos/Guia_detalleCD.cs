using System;
using System.Collections.Generic;
using Datos.Modelo;
using Entidades.Entidades;

namespace Datos.AccesoDatos
{
    public class Guia_detalleCD : IAccesoDatos<Guia_detalle>
    {
        public bool Actualizar(Guia_detalle entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Guia_detalle entidad)
        {
            CamionesdbDataContext DB;
            try
            {
                using (DB = new CamionesdbDataContext())
                {
                    DB.SP_InsertarGuiaDetalle(entidad.id_encomienda, entidad.id_guia);
                    DB.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Cliente.", ex);
            }
        }

        public List<Guia_detalle> Listar()
        {
            throw new NotImplementedException();
        }

        public Guia_detalle Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
