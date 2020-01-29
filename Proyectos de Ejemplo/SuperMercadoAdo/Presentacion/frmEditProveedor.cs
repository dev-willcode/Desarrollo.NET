using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmEditProveedor : Form
    {
        public frmEditProveedor()
        {
            InitializeComponent();
        }
        private Proveedor crearObjeto()
        {
            int id = int.Parse(txtId.Text);
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string rep = txtRepresentante.Text;
            string dir = txtDireccion.Text;
            string ciu = txtCiudad.Text;
            string tel = txtTelefonos.Text;
            string fax = txtFax.Text;
            Proveedor prov = new Proveedor(id, cedula, nombre,rep,
                dir, ciu, tel, fax);
            return prov;
        }
        private void FrmEditProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
