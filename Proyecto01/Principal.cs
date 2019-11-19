using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eventoParaLlevar(object sender, EventArgs e)
        {
            if (!rbLlevar.Checked)
            {
                chPlastico.Enabled = false;
                chAluminio.Enabled = false;
                chIsopo.Enabled = false;
            } else
            {
                chPlastico.Enabled = true;
                chAluminio.Enabled = true;
                chIsopo.Enabled = true;
            }
        }
    }
}
