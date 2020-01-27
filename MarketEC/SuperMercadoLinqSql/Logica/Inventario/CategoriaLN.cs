using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Inventario;
using Datos;
using Entidades.Inventario;

namespace Logica.Inventario
{
    public class CategoriaLN
    {
        public List<Categoria> MostrarCategoriaFitro(string busqueda)
        {
            List<Categoria> Lista = new List<Categoria>();
            Categoria oc;
            try
            {
                List<cp_ListarCategoria_FiltroResult> auxLista = CategoriaCD.ListarCategoriasFiltro(busqueda);
                foreach (cp_ListarCategoria_FiltroResult aux in auxLista)
                {

                    oc = new Categoria(aux.IdCategoria, aux.Categoria, aux.Descripcion);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listarCategoria.", ex);
            }
            return Lista;
        }
        public List<Categoria> MostrarCategoria()
        {
            List<Categoria> Lista = new List<Categoria>();
            Categoria oc;
            try
            {
                List<CATEGORIA> auxLista = CategoriaCD.ListarCategorias();
                foreach (CATEGORIA aux in auxLista)
                {

                    oc = new Categoria(aux.IdCategoria, aux.Categoria1, aux.Descripcion);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Categoria.", ex);
            }
            return Lista;
        }
        public bool CreateCategoria(Categoria oc)
        {
            try
            {
                CategoriaCD.InsertarCategoria(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Categoria.", ex);
            }
        }
        public bool UpdateCategoria(Categoria oc)
        {
            try
            {
               CategoriaCD.ActualizarCategoria(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Categoria.", ex);
            }
        }

        public bool DeleteCategoriar(Categoria oc)
        {
            try
            {
                CategoriaCD.EliminarCategoria(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Categoria.", ex);
            }
        }

    }
}
