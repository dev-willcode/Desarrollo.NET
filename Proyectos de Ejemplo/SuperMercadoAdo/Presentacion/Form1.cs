using Logica;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProveedorLN pln = new ProveedorLN();

        private void Form1_Load(object sender, EventArgs e)
        {
            listarProveedores();
        }
        private void listarProveedores()
        {
            dtgProductos.DataSource = pln.ListarProveedores(txtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            listarProveedores();
        }
    }
}
