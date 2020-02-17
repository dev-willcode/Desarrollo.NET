using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Inventario;
using Lógica.Inventario;

namespace Presentación.Reportes
{
    public partial class ReporteCategoria : Form
    {
        DataSetReportes dataset = new DataSetReportes();
        CategoriaLN categoriaLN = new CategoriaLN();

        public ReporteCategoria()
        {
            InitializeComponent();
            iniciarReporte();
        }

        private void iniciarReporte()
        {
            try
            {
                List<Categoria> lista = categoriaLN.MostrarCategoria();
                lista.ForEach(categoria =>
                {
                    dataset.CATEGORIA.AddCATEGORIARow(categoria.IdCategoria, categoria.Nombre, categoria.Detalle);
                });
                CRCategoria cRCategoria = new CRCategoria();

                cRCategoria.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = cRCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
