using AppPelicula.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPelicula
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDuracion.Clear();
            txtActor.Clear();
            rbComedia.Checked = true;
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Nombre = txtNombre.Text;
                pelicula.Duracion = Double.Parse(txtDuracion.Text);
                pelicula.Actor = txtActor.Text;
                if (rbComedia.Checked) pelicula.Categoria = rbComedia.Text;
                else if (rbAccion.Checked) pelicula.Categoria = rbAccion.Text;
                else if (rbDibujos.Checked) pelicula.Categoria = rbDibujos.Text;
                else pelicula.Categoria = rbDrama.Text;
                
                bsPelicula.Add(pelicula);
                actualizarTotalPeliculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se consiguió crear la pelicula\nERROR: " + ex.Message);
            }
        }

        private void actualizarTotalPeliculas()
        {
            txtTotal.Text = bsPelicula.List.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblPelicula.CurrentRow != null)
            {
                if (MessageBox.Show("Desea Eliminar la pelicula?","ELIMINAR",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bsPelicula.RemoveAt(tblPelicula.CurrentRow.Index);
                    actualizarTotalPeliculas();
                }
            }
            else MessageBox.Show("Verifique que ha seleccionado una fila!");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
