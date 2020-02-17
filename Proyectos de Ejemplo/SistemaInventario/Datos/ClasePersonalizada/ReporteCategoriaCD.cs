using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ClasePersonalizada
{
    public class ReporteCategoriaCD
    {
        public static List<SP_ReporteCategoriasResult> listarProductoPorCategoria(int idCategoria)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ReporteCategorias(idCategoria).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar producto por categoria.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
