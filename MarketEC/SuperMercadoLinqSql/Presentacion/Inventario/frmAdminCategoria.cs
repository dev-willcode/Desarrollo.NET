using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Inventario;
using Logica.Inventario;

namespace Presentacion.Inventario
{
    public partial class frmAdminCategoria : Form
    {
        public frmAdminCategoria()
        {
            InitializeComponent();
        }
        CategoriaLN ocln = new CategoriaLN();
        public void MostrarDatos()
        {
            dtgCategoria.DataSource = ocln.MostrarCategoriaFitro(txtBuscar.Text);
        }
        private void FrmAdminCategoria_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
