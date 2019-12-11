using AppPruebaCalendario.Clases;
using System;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class BuscarPersona : Form
    {
        private Persona personaSeleccionada = null;

        public BuscarPersona()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txCedula.Text.Length != 10)
            {
                MessageBox.Show("Ingrese una cedula con 10 digitos!");
            }
            else
            {
                foreach (Persona persona in Principal.listaPersonas)
                {
                    if (persona.Cedula.Equals(txCedula.Text))
                    {
                        // Rellena campos de la persona
                        lbCedula.Text = persona.Cedula;
                        lbNombre.Text = persona.Nombre;
                        lbApellido.Text = persona.Apellido;
                        lbDireccion.Text = persona.Direccion;
                        lbtelefono.Text = persona.Telefono;
                        lbFecha.Text = persona.FechaNacimiento.ToString();
                        lbSexo.Text = persona.Sexo;
                        lbEstadoCivil.Text = persona.EstadoCivil;
                        personaSeleccionada = persona;
                        break;
                    }
                }
                if (personaSeleccionada == null)
                {
                    MessageBox.Show("No se Encontró ninguna persona con la cedula especificada!");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompromiso_Click(object sender, EventArgs e)
        {
            if (personaSeleccionada == null)
            {
                MessageBox.Show("Primero seleccione una persona!");
            }
            else
            {
                DatosCompromiso compromiso = new DatosCompromiso(personaSeleccionada);
                compromiso.MdiParent = this.MdiParent;
                compromiso.Show();
            }
        }
    }
}
