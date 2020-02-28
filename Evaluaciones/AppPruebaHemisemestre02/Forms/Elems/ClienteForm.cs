using System;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms.Elems
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteLN clienteLN = new ClienteLN();
        private AdmCliente AdmCliente { get; }
        public ClienteForm(AdmCliente admCliente)
        {
            InitializeComponent();
            AdmCliente = admCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteLN.Insertar(crearCliente());
                AdmCliente.cargarListado();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Cliente crearCliente()
        {
            return new Cliente(
                0,
                txtCedula.Text,
                txtNombres.Text,
                txtTelefono.Text,
                txtDireccion.Text
                );
        }
    }
}
