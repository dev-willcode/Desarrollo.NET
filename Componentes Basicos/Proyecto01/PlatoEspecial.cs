using Proyecto01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante
{
    public partial class PlatoEspecial : Form
    {
        private BindingSource enlace;

        public PlatoEspecial(BindingSource enlace)
        {
            this.enlace = enlace;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = Double.Parse(txtCosto.Text);
                Ingrediente ingrediente = new Ingrediente(txtNombre.Text, Double.Parse(txtCosto.Text));
                enlace.Add(ingrediente);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! \n" + ex.Message);
            }
        }
    }
}
