using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica.ClasePersonalizada;
using Presentación.Reportes;

namespace Presentación.Inventario
{
    public partial class frmReporteProductoProveedor : Form
    {
        ProductoCategoriaLN ProductoCategoriaLN = new ProductoCategoriaLN();
        public frmReporteProductoProveedor()
        {
            InitializeComponent();
            cargarReporte();
        }

        private void cargarReporte()
        {
            try
            {
                DataSetReporteProductoProveedor dataSet = new DataSetReporteProductoProveedor();
                List<Entidades.ClasePersonalizada.ProductoCategoria> list = ProductoCategoriaLN.MostrarProductoCategoriaFitro("");
                list.ForEach(aux =>
                {
                    dataSet.Vista_ProductoCategoria.AddVista_ProductoCategoriaRow(
                        aux.Categoria,
                        aux.Nombre,
                        aux.UnidadMedida,
                        aux.IdProducto,
                        aux.PrecioProveedor,
                        aux.StockActual,
                        aux.StockMinimo,
                        aux.PrecioVenta,
                        aux.Proveedor
                        );
                });
                CRReporteProductoProveedor cr = new CRReporteProductoProveedor();
                cr.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = cr;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
