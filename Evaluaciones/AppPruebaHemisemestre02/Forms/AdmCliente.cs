using System;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms.Elems;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms
{
    public partial class AdmCliente : Form
    {
        private ClienteLN ClienteLN = new ClienteLN();
        public AdmCliente()
        {
            InitializeComponent();
            cargarListado();
        }

        internal void cargarListado()
        {
            try
            {
                clienteSource.DataSource = ClienteLN.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(this);
            clienteForm.ShowDialog();
        }
    }
}
