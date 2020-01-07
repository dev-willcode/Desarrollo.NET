using System;
using System.Windows.Forms;
using AppExamenHemisemestre01.Clases;

namespace AppExamenHemisemestre01
{
    public partial class FormFuncionCine : Form
    {
        BindingSource listaFuncionesCine;
        BindingSource listaPeliculas;
        
        public FormFuncionCine(BindingSource listaFuncionesCine, BindingSource listaPeliculas)
        {
            this.listaFuncionesCine = listaFuncionesCine;
            this.listaPeliculas = listaPeliculas;
            InitializeComponent();
            comboPeliculas.DataSource = listaPeliculas;
            comboPeliculas.SelectedIndex = 0;
            comboHorario.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionCine funcionCine = new FuncionCine();
                funcionCine.DiaFuncion = txtdiaFuncion.Value.Date;
                funcionCine.HoraFuncion = comboHorario.Text;
                comboHorario.Items.RemoveAt(comboHorario.SelectedIndex);
                funcionCine.Pelicula = (Pelicula)listaPeliculas.List[comboPeliculas.SelectedIndex];
                funcionCine.NombrePelicula = funcionCine.Pelicula.Titulo;
                funcionCine.EstadoPelicula = AdminCine.ESTADO_ABIERTO;
                funcionCine.PrecioEntrada = double.Parse(txtPrecio.Text);

                listaFuncionesCine.Add(funcionCine);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un precio válido!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPeliculas form = new FormAdminPeliculas(listaPeliculas);
            form.ShowDialog();
        }
    }
}
