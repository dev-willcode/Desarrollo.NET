using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.ClasePersonalizada;
using Entidades.ClasePersonalizada;

namespace Lógica.ClasePersonalizada
{
    public class ReporteCategoriaLN
    {
        public List<ReporteCategoria> MostrarReporteCategoriaFitro(int idCategoria)
        {
            List<ReporteCategoria> Lista = new List<ReporteCategoria>();
            ReporteCategoria oc;
            try
            {
                List<SP_ReporteCategoriasResult> auxLista = ReporteCategoriaCD.listarProductoPorCategoria(idCategoria);
                foreach (SP_ReporteCategoriasResult aux in auxLista)
                {
                    oc = new ReporteCategoria(
                        aux.IdProducto,
                        aux.Nombre,
                        aux.Categoria,
                        aux.PrecioProveedor,
                        aux.StockActual,
                        aux.PrecioVenta,
                        aux.IdCategoria);
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar producto por categoria.", ex);
            }
            return Lista;
        }
    }
}
