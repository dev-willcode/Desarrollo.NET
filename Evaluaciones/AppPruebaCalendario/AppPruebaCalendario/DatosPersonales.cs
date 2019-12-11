using AppPruebaCalendario.Clases;
using System;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = crearPersona();
            if (persona != null)
            {
                Principal.listaPersonas.Add(persona);
                MessageBox.Show("Registrado correctamente!");
                this.Close();
            }
        }

        private Persona crearPersona()
        {
            Persona persona = new Persona();
            persona.Cedula = txtCedula.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Telefono = txtTelefono.Text;
            persona.FechaNacimiento = dateFecha.Value;
            if (rbMasculino.Checked)
            {
                persona.Sexo = "MASCULINO";
            }
            else
            {
                persona.Sexo = "FEMENINO";
            }

            persona.EstadoCivil = comboEstadoCivil.Text;


            return validarPersona(persona);
        }

        private Persona validarPersona(Persona persona)
        {
            if (persona.Cedula.Length != 10)
            {
                MessageBox.Show("Verifique que la cedula tenga 10 digitos!");
                return null;
            }
            return persona;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
