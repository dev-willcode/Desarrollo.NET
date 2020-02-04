using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.ClasePersonalizada
{
    public class ProductoCategoriaCD
    {
        public static List<SP_ListarProductoCategoriaFiltroResult> ListarProductoCategoriaFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarProductoCategoriaFiltro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar producto con su categoria.", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
