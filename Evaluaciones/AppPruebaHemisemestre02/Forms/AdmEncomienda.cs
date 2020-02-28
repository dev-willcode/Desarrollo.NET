using System;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms.Elems;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms
{
    public partial class AdmEncomienda : Form
    {
        private EncomiendaLN EncomiendaLN = new EncomiendaLN();
        public AdmEncomienda()
        {
            InitializeComponent();
            cargarListado();
        }

        internal void cargarListado()
        {
            try
            {
                encomiendasSource.DataSource = EncomiendaLN.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EncomiendaForm form = new EncomiendaForm(this);
            form.ShowDialog();
        }
    }
}
