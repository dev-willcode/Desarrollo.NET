using System;
using System.Windows.Forms;
using Entidades.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmEditTransportista : Form
    {
        public frmEditTransportista()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public int opc;
        public Transportista aoc = new Transportista();

        private void verDatos()
        {
            txtId.Text = aoc.IdTransportista;
            txtCedula.Text = aoc.CedTransportista;
            txtNombre.Text = aoc.Nombre;
            txtCiudad.Text = aoc.Ciudad;
            txtDireccion.Text = aoc.Direccion;
            txtTelefono.Text = aoc.Telefono;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0
                && txtCiudad.Text.Trim().Length == 0 && txtTelefono.Text.Trim().Length == 0
                && txtCedula.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Transportista crearObjeto()
        {
            Transportista oc = new Transportista(
                txtId.Text,
                txtCedula.Text,
                txtNombre.Text,
                txtDireccion.Text,
                txtCiudad.Text,
                txtTelefono.Text);
            return oc;
        }

        private void guardar()
        {
            try
            {
                if (validarDatos())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    toolStripLabel1.Text = "Los campos con (*) son obligatorios";
                }
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = ex.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditTransportista_Load(object sender, EventArgs e)
        {
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
