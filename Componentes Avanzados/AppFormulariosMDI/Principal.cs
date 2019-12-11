using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormulariosMDI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void administrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdministrarPersona"] == null)
            {
                AdministrarPersona administrarPersona = new AdministrarPersona();
                administrarPersona.MdiParent = this;
                administrarPersona.Show();
            }
        }

        private void gestionarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
