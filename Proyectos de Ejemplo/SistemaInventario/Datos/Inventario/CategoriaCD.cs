using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Inventario;

namespace Datos.Inventario
{
    public class CategoriaCD
    {
        public static List<SP_ListarCategoria_FiltroResult> ListarCategoriasFiltro(string busqueda)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_ListarCategoria_Filtro(busqueda).ToList();
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
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
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
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_InsertarCategoria(oc.Nombre, oc.Detalle);
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
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_ActualizarCategoria(oc.IdCategoria, oc.Nombre, oc.Detalle);
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
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.SP_EliminarCategoria(oc.IdCategoria);
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

        public static List<SP_VerCategoriaResult> ListarCategoria()
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    return DB.SP_VerCategoria().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al listar Categoria.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
