using System;
using System.Collections.Generic;
using Datos;
using Datos.Inventario;
using Entidades.Inventario;

namespace Lógica.Inventario
{
    public class CategoriaLN
    {
        public List<Categoria> MostrarCategoriaFitro(string busqueda)
        {
            List<Categoria> Lista = new List<Categoria>();
            Categoria oc;
            try
            {
                List<SP_ListarCategoria_FiltroResult> auxLista = CategoriaCD.ListarCategoriasFiltro(busqueda);
                foreach (SP_ListarCategoria_FiltroResult aux in auxLista)
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

        public bool DeleteCategoria(Categoria oc)
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

        public static List<Categoria> mostrarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            List<SP_VerCategoriaResult> result = CategoriaCD.ListarCategoria();
            foreach (SP_VerCategoriaResult aux in result)
            {
                lista.Add(new Categoria(aux.IdCategoria, aux.Categoria, aux.Descripcion));
            }
            return lista;
        }
    }
}
