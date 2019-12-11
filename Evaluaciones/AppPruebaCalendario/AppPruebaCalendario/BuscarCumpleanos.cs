using AppPruebaCalendario.Clases;
using System;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class BuscarCumpleanos : Form
    {
        public BuscarCumpleanos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cumpleanos = "";
            foreach (Persona persona in Principal.listaPersonas)
            {
                DateTime fechaPersona = persona.FechaNacimiento;
                DateTime hoy = fecha.Value;
                if (fechaPersona.Day == hoy.Day && fechaPersona.Month == hoy.Month)
                {
                    cumpleanos += persona.Nombre + " " + persona.Apellido + Environment.NewLine;
                }
            }
            textBox1.Text = cumpleanos;
        }
    }
}
