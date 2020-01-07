using System;
using System.Windows.Forms;
using AppExamenHemisemestre01.Clases;

namespace AppExamenHemisemestre01
{
    public partial class FormEspectador : Form
    {
        private BindingSource listaEspectadores;
        public FormEspectador(BindingSource listaEspectadores)
        {
            this.listaEspectadores = listaEspectadores;
            InitializeComponent();
            tablaEspectadores.DataSource = listaEspectadores;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Espectador espectador = new Espectador();
                espectador.Cedula = txtCedula.Text;
                espectador.Nombre = txtNombre.Text;
                espectador.Edad = int.Parse(txtEdad.Text);
                if (rbM.Checked)
                {
                    espectador.Sexo = 'M';
                }
                else
                {
                    espectador.Sexo = 'F';
                }

                listaEspectadores.Add(espectador);
                limpiarRegistros();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese una edad correcta!");
            }
        }

        private void limpiarRegistros()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            rbM.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
