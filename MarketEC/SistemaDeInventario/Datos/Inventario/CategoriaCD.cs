using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.Inventario;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    class CategoriaCD
    {
        public static List<cp_ListarCategoria_FiltroResult> ListarCategoriasFiltro(string busqueda)
        {
            BDMarketECDataContext DB = null;
            try
            {
                using (DB = new BDMarketECDataContext())
                {
                    return DB.cp_ListarCategoria_Filtro(busqueda).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar categorias.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<CATEGORIA> ListarCategorias()
        {
            BDMarketECDataContext DB = null;
            try
            {
                using (DB = new BDMarketECDataContext())
                {
                    return DB.CATEGORIA.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar categorias.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarCategoria(ECategoria oc)
        {
            BDMarketECDataContext DB = null;
            try
            {
                using (DB = new BDMarketECDataContext())
                {
                    DB.cp_InsertarCategoria(oc.Categoria, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar Categoria.", ex);
            }
            finally
            {
                DB = null;
            }

        }
        public static void ActualizarCategoria(ECategoria oc)
        {
            BDMarketECDataContext DB = null;
            try
            {
                using (DB = new BDMarketECDataContext())
                {
                    DB.cp_ActualizarCategoria(oc.IdCategoria, oc.Categoria, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Categoria.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void EliminarCategoria(ECategoria oc)
        {
            BDMarketECDataContext DB = null;
            try
            {
                using (DB = new BDMarketECDataContext())
                {
                    DB.cp_EliminarCategoria(oc.IdCategoria);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar Categoria.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
