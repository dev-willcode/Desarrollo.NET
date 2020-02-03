using System;
using System.Windows.Forms;
using Datos.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmEditLocal : Form
    {
        public frmEditLocal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public int opc;
        public Local aoc = new Local();

        private void verDatos()
        {
            txtId.Text = aoc.IdLocal.ToString();
            txtDireccion.Text = aoc.Direccion;
            txtCiudad.Text = aoc.Ciudad;
            txtTelefono.Text = aoc.Telefono;
            txtFax.Text = aoc.Fax;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtDireccion.Text.Trim().Length == 0
                && txtCiudad.Text.Trim().Length == 0 && txtTelefono.Text.Trim().Length == 0
                && txtFax.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Local crearObjeto()
        {
            int id = int.Parse(txtId.Text);
            string dire = txtDireccion.Text;
            string ciu = txtCiudad.Text;
            string tele = txtTelefono.Text;
            string fax = txtFax.Text;
            Local oc = new Local(id, dire, ciu, tele, fax);
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

        private void frmEditLocal_Load(object sender, EventArgs e)
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
