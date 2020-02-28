using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms;
using AppPruebaHemisemestre02.Reportes;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02
{
    public partial class Inicio : Form
    {
        private readonly EncomiendaLN EncomiendaLN = new EncomiendaLN();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmCliente"] == null)
            {
                AdmCliente f = new AdmCliente
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmEncomienda"] == null)
            {
                AdmEncomienda f = new AdmEncomienda
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmCamion"] == null)
            {
                AdmCamion f = new AdmCamion
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnGuias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmGuia"] == null)
            {
                AdmGuia f = new AdmGuia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnEncomiendas_Click(object sender, EventArgs e)
        {
            try
            {
                DSEncomiendas dataset = new DSEncomiendas();
                List<Encomiendas> lista = EncomiendaLN.ListarEncomiendasPorEntregar();
                lista.ForEach(aux =>
                {
                    dataset.SP_ListarEncomiendasPorEntregar.AddSP_ListarEncomiendasPorEntregarRow(
                        aux.id,
                        aux.codigo,
                        aux.peso,
                        aux.direccion,
                        aux.costo_envio,
                        aux.estado
                        );
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
