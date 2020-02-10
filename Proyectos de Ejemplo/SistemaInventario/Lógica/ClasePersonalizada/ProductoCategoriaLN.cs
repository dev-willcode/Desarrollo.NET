using System;
using System.Collections.Generic;
using Datos;
using Datos.ClasePersonalizada;
using Entidades.ClasePersonalizada;

namespace Lógica.ClasePersonalizada
{
    public class ProductoCategoriaLN
    {
        public List<ProductoCategoria> MostrarProductoCategoriaFitro(string busqueda)
        {
            List<ProductoCategoria> Lista = new List<ProductoCategoria>();
            ProductoCategoria oc;
            try
            {
                List<SP_ListarProductoCategoriaFiltroResult> auxLista = ProductoCategoriaCD.ListarProductoCategoriaFiltro(busqueda);
                foreach (SP_ListarProductoCategoriaFiltroResult aux in auxLista)
                {
                    oc = new ProductoCategoria(
                        aux.IdProducto,
                        aux.Categoria,
                        aux.Nombre,
                        aux.Proveedor,
                        aux.UnidadMedida,
                        aux.PrecioProveedor,
                        aux.StockActual,
                        aux.StockMinimo,
                        aux.PrecioVenta);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listarCategoria.", ex);
            }
            return Lista;
        }
    }
}
