using AppPruebaCalendario.Clases;
using System;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class BuscarCompromiso : Form
    {
        public BuscarCompromiso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string compromisos = "";
            foreach (Persona persona in Principal.listaPersonas)
            {
                if (persona.Cedula.Equals(txtCedula.Text))
                {
                    foreach (Compromisos item in persona.Compromisos)
                    {
                        compromisos += item.LugarReunion + " - " + item.FechaReunion.ToString() + Environment.NewLine;
                    }
                }
            }
            textBox1.Text = compromisos;
        }
    }
}
