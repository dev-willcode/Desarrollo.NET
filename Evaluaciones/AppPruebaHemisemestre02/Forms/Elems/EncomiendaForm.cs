using System;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms.Elems
{
    public partial class EncomiendaForm : Form
    {
        private readonly ClienteLN ClienteLN = new ClienteLN();
        private readonly EncomiendaLN EncomiendaLN = new EncomiendaLN();
        private AdmEncomienda AdmEncomienda { get; }
        public EncomiendaForm(AdmEncomienda adm)
        {
            InitializeComponent();
            AdmEncomienda = adm;
            inicializarClientes();
        }

        private void inicializarClientes()
        {
            try
            {
                clienteSource.DataSource = ClienteLN.Listar();
                comboCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EncomiendaLN.Insertar(crearEncomienda());
                AdmEncomienda.cargarListado();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Encomiendas crearEncomienda()
        {
            return new Encomiendas(
                0,
                (int)comboCliente.SelectedValue,
                txtCodigo.Text,
                decimal.Parse(txtPeso.Text),
                txtDireccion.Text,
                decimal.Parse(txtCostoEnvio.Text),
                "EN ESPERA"
                );
        }
    }
}
