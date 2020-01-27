using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Inventario
{
    public partial class EditProveedor : Form
    {
        public EditProveedor()
        {
            InitializeComponent();
        }
        public int opc;
        public Proveedor aop=null;
        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtCedula.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }
        private void guardar()
        {
            try
            {
                if (validarDatos())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    toolStripLabel1.Text = "Los campos con (*) son obligatorios";
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = ex.Message;
            }
        }
        public Proveedor crearObjeto()
        {
            int id = int.Parse(txtId.Text);
            string ced = txtCedula.Text;
            string nom = txtNombre.Text;
            string rep = txtRepresentante.Text;
            string dir = txtDireccion.Text;
            string ciu = txtCiudad.Text;
            string tel = txtTelefonos.Text;
            string fax = txtFax.Text;
            Proveedor op = new Proveedor(id,ced,nom,rep,dir,ciu,tel,fax);
            return op;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void EditProveedor_Load(object sender, EventArgs e)
        {
            if (opc == 1 && aop != null)
            {
                verDatos();
            }
        }
        private void verDatos()
        {
            txtId.Text = aop.IdProveedor.ToString();
            txtCedula.Text= aop.CedProveedor;
            txtNombre.Text= aop.Nombre;
            txtRepresentante.Text = aop.Representante ;
            txtCiudad.Text = aop.Ciudad;
            txtDireccion.Text = aop.Direccion;
            txtTelefonos.Text = aop.Telefono;
            txtFax.Text = aop.Fax;
        }
    }
}
