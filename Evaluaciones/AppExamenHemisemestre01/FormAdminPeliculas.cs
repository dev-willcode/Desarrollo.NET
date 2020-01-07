using System;
using System.Windows.Forms;
using AppExamenHemisemestre01.Clases;

namespace AppExamenHemisemestre01
{
    public partial class FormAdminPeliculas : Form
    {
        private BindingSource listaPeliculas;
        public FormAdminPeliculas(BindingSource listaPeliculas)
        {
            this.listaPeliculas = listaPeliculas;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula pelicula = new Pelicula(txtTitulo.Text, double.Parse(txtDuracion.Text),
                int.Parse(txtEdad.Text), txtDirector.Text, txtTipo.Text);
                listaPeliculas.Add(pelicula);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que la edad sea entera y la duración decimal!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
