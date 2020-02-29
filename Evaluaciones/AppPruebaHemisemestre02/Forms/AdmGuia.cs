using System;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms.Elems;
using AppPruebaHemisemestre02.Reportes;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms
{
    public partial class AdmGuia : Form
    {
        private GuiaLN GuiaLN = new GuiaLN();
        public AdmGuia()
        {
            InitializeComponent();
            cargarListado();
        }

        internal void cargarListado()
        {
            try
            {
                guiaSource.DataSource = GuiaLN.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            GuiaForm form = new GuiaForm(this);
            form.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Reporte reporte = new Reporte()
                {
                    MdiParent = this.MdiParent
                };
                reporte.mostrarReporte((dataGridView1.CurrentRow.DataBoundItem as Guia).id);
                reporte.Show();
            }
        }
    }
}
