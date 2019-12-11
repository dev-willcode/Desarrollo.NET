using AppPruebaCalendario.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppPruebaCalendario
{
    public partial class Principal : Form
    {
        public static List<Persona> listaPersonas = new List<Persona>();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DatosPersonales"] == null)
            {
                DatosPersonales datosPersonales = new DatosPersonales();
                datosPersonales.MdiParent = this;
                datosPersonales.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuscarPersona"] == null)
            {
                BuscarPersona buscarPersona = new BuscarPersona();
                buscarPersona.MdiParent = this;
                buscarPersona.Show();
            }
        }

        private void btnCumpleanos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuscarCumpleanos"] == null)
            {
                BuscarCumpleanos buscarCumpleanos = new BuscarCumpleanos();
                buscarCumpleanos.MdiParent = this;
                buscarCumpleanos.Show();
            }
        }

        private void btnCompromiso_Click(object sender, EventArgs e)
        {
            BuscarCompromiso buscarCompromiso = new BuscarCompromiso();
            buscarCompromiso.MdiParent = this;
            buscarCompromiso.Show();
        }
    }
}
