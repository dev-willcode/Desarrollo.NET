using AppPruebaCalendario.Clases;
using System;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class DatosCompromiso : Form
    {
        private Persona personaSeleccionada;

        public DatosCompromiso()
        {
            InitializeComponent();
        }

        public DatosCompromiso(Persona personaSeleccionada)
        {
            InitializeComponent();
            this.personaSeleccionada = personaSeleccionada;
            txtCedula.Text = personaSeleccionada.Cedula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (personaSeleccionada == null)
            {
                MessageBox.Show("Valide primero la cedula especificada!");
            }
            else
            {
                Compromisos compromisos = crearCompromiso();
                if (compromisos != null)
                {
                    personaSeleccionada.Compromisos.Add(compromisos);
                    MessageBox.Show("Compromiso creado correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique que la fecha de reunion sea igual o después de hoy!");
                }
            }
        }

        private Compromisos crearCompromiso()
        {
            Compromisos compromisos = new Compromisos();
            compromisos.HoraReunion = txtHora.Text;
            compromisos.TipoReunion = txtTipo.Text;
            compromisos.LugarReunion = txtLugar.Text;
            compromisos.FechaReunion = dateFecha.Value;
            return validarCompromiso(compromisos);
        }

        private Compromisos validarCompromiso(Compromisos compromisos)
        {
            if (compromisos.FechaReunion.CompareTo(DateTime.Now) > 0 || 
                (compromisos.FechaReunion.Day == DateTime.Now.Day && compromisos.FechaReunion.Month == DateTime.Now.Month 
                && compromisos.FechaReunion.Year == DateTime.Now.Year))
            {
                return compromisos;
            }

            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length != 10)
            {
                MessageBox.Show("Ingrese una cedula con 10 digitos!");
            }
            else
            {
                foreach (Persona persona in Principal.listaPersonas)
                {
                    if (persona.Cedula.Equals(txtCedula.Text))
                    {
                        MessageBox.Show("Persona encontrada, validada correctamente!");
                        personaSeleccionada = persona;
                        break;
                    }
                }
                if (personaSeleccionada == null)
                {
                    MessageBox.Show("Persona no encontrada, verifique que " +
                        "\nexista una persona con la cedula especificada");
                }
            }
        }
    }
}
