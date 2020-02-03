using System;
using System.Windows.Forms;
using Presentación.Faturacion;
using Presentación.Inventario;

namespace Presentación
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Text = ("MARKET ECUADOR");
            CenterToScreen();
        }

        private void administrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCategoria"] == null)
            {
                frmAdminCategoria f = new frmAdminCategoria
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void administrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminProveedor"] == null)
            {
                frmAdminProveedor f = new frmAdminProveedor
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void administrarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminProductoCategoria"] == null)
            {
                frmAdminProductoCategoria f = new frmAdminProductoCategoria
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void administrarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminLocal"] == null)
            {
                frmAdminLocal f = new frmAdminLocal
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void abrirTransportista(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminTransportista"] == null)
            {
                frmAdminTransportista f = new frmAdminTransportista
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void abrirGuia(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminGuia"] == null)
            {
                frmAdminGuia f = new frmAdminGuia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void abrirOrden(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminOrden"] == null)
            {
                frmAdminOrden f = new frmAdminOrden
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
    }
}
