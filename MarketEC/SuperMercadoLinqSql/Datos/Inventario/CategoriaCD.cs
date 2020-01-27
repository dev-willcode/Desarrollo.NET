using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Inventario;

namespace Datos.Inventario
{
    public class CategoriaCD
    {
        public static List<cp_ListarCategoria_FiltroResult> ListarCategoriasFiltro(string busqueda)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
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
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
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
        public static void InsertarCategoria(Categoria oc)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_InsertarCategoria(oc.Nombre, oc.Descripcion);
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
        public static void ActualizarCategoria(Categoria oc)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
                {
                    DB.cp_ActualizarCategoria(oc.IdCategoria,oc.Nombre, oc.Descripcion);
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

        public static void EliminarCategoria(Categoria oc)
        {
            BDSupermercadoDataContext DB = null;
            try
            {
                using (DB = new BDSupermercadoDataContext())
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
