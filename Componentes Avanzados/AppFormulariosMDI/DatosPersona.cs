using AppFormulariosMDI.Clases;
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
    public partial class DatosPersona : Form
    {
        private AdministrarPersona administrarPersona;
        private string operacion;
        private int index;

        public DatosPersona(AdministrarPersona administrarPersona, string operacion)
        {
            InitializeComponent();
            this.administrarPersona = administrarPersona;
            this.operacion = operacion;
            if (operacion.Equals("MODIFICAR")) lblTitulo.Text = "Modficar Persona:";
        }

        private Persona crearPersona()
        {
            Persona persona = new Persona();
            try
            {
                persona = new Persona();
                persona.Cedula = txtCedula.Text;
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Edad = int.Parse(txtEdad.Text);
                persona.Sexo = rbMasculino.Checked ? 'M' : 'F';
                persona.Ciudad = txtCiudad.Text;
                persona.EstadoCivil = comboEstadoCivil.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!\nCompruebe que ha rellenado correctamente los datos!\n" + ex.Message);
                persona = null;
            }
            return persona;
        }

        public void rellenarDatos(Persona persona, int index)
        {
            this.index = index;
            txtCedula.Text = persona.Cedula;
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtEdad.Text = persona.Edad.ToString();
            if (persona.Sexo.Equals('F')) rbFemenino.Checked = true;
            txtCiudad.Text = persona.Ciudad;
            comboEstadoCivil.Text = persona.EstadoCivil;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = crearPersona();
            if (persona != null)
            {
                if (operacion.Equals("INSERTAR"))
                    administrarPersona.InsertarPersona(persona);
                else
                    administrarPersona.ModificarPersona(persona, index);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
