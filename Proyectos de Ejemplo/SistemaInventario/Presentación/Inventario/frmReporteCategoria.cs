using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lógica.ClasePersonalizada;
using Lógica.Inventario;
using Presentación.Reportes;

namespace Presentación.Inventario
{
    public partial class frmReporteCategoria : Form
    {
        ReporteCategoriaLN ReporteCategoriaLN = new ReporteCategoriaLN();
        public frmReporteCategoria()
        {
            InitializeComponent();
            mostrarCategorias();
        }

        private void mostrarCategorias()
        {
            comboCategoria.DataSource = CategoriaLN.mostrarCategorias();
            comboCategoria.SelectedIndex = 0;
            comboCategoria.DisplayMember = "Nombre";
            comboCategoria.ValueMember = "IdCategoria";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetReporteCategoria dataSet = new DataSetReporteCategoria();
                List<Entidades.ClasePersonalizada.ReporteCategoria> list = ReporteCategoriaLN.MostrarReporteCategoriaFitro((int)comboCategoria.SelectedValue);
                list.ForEach(item =>
                {
                    dataSet.Vista_ReporteCategoria.AddVista_ReporteCategoriaRow(
                        item.IdProducto,
                        item.Nombre,
                        item.Categoria,
                        item.PrecioProveedor,
                        item.StockActual,
                        item.PrecioVenta
                        );
                });
                CRReporteCategoria cRCategoria = new CRReporteCategoria();
                cRCategoria.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = cRCategoria;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
