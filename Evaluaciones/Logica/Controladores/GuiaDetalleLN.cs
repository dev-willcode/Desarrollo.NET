using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.AccesoDatos;
using Entidades.Entidades;

namespace Logica.Controladores
{
    public class GuiaDetalleLN : IControlador<Guia_detalle>
    {
        Guia_detalleCD guia_DetalleCD = new Guia_detalleCD();
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
            try
            {
                return guia_DetalleCD.Insertar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
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
