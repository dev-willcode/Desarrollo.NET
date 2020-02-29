using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Reportes
{
    public partial class Reporte : Form
    {
        GuiaLN GuiaLN = new GuiaLN();
        public Reporte()
        {
            InitializeComponent();
        }

        internal void mostrarReporte(int id)
        {
            try
            {
                DSReporte dataset = new DSReporte();
                GuiaCabecera aux = GuiaLN.obtenerCabecera(id);

                List<CabeceraDetalle> detalle = GuiaLN.obtenerDetalle(id);
                dataset.SP_CabeceraGuia.AddSP_CabeceraGuiaRow(
                    aux.id, aux.fecha_envio, aux.cantidad_encomiendas, aux.peso_total, aux.nombre, aux.peso_max
                    );
                detalle.ForEach(elem =>
                {
                    dataset.SP_DetalleGuia.AddSP_DetalleGuiaRow(
                        elem.id_guia, elem.codigo, elem.peso, elem.direccion, elem.costo_envio
                    );
                });
                CRGuia report = new CRGuia();
                report.SetDataSource(dataset);
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
