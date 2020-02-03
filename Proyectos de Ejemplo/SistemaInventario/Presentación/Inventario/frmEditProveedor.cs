using System;
using System.Windows.Forms;
using Entidades.Inventario;

namespace Presentación.Inventario
{
    public partial class frmEditProveedor : Form
    {
        public frmEditProveedor()
        {
            InitializeComponent();
            CenterToScreen();
        }


        public int opc;
        public Proveedor aoc = new Proveedor();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verDatos()
        {
            txtId.Text = aoc.IdProveedor.ToString();
            txtCedula.Text = aoc.CedProveedor;
            txtCiudad.Text = aoc.Ciudad;
            txtDireccion.Text = aoc.Direccion;
            txtFax.Text = aoc.Fax;
            txtNombre.Text = aoc.Nombre;
            txtRepresentante.Text = aoc.Representante;
            txtTelefonos.Text = aoc.Telefono;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtCedula.Text.Trim().Length == 0
                && txtCiudad.Text.Trim().Length == 0
                && txtDireccion.Text.Trim().Length == 0 && txtFax.Text.Trim().Length == 0
                && txtNombre.Text.Trim().Length == 0 && txtRepresentante.Text.Trim().Length == 0
                && txtTelefonos.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Proveedor crearObjeto()
        {
            int id = int.Parse(txtId.Text);
            string ced = txtCedula.Text;
            string nom = txtNombre.Text;
            string repre = txtRepresentante.Text;
            string direc = txtDireccion.Text;
            string ciu = txtCiudad.Text; ;
            string telefo = txtTelefonos.Text;
            string fax = txtFax.Text;
            Proveedor oc = new Proveedor(id, ced, nom, repre, direc, ciu, telefo, fax);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void frmEditProveedor_Load_1(object sender, EventArgs e)
        {
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }
        }
    }
}
