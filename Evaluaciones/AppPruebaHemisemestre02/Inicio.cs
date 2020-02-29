using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms;
using AppPruebaHemisemestre02.Reportes;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02
{
    public partial class Inicio : Form
    {
        private readonly EncomiendaLN EncomiendaLN = new EncomiendaLN();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmCliente"] == null)
            {
                AdmCliente f = new AdmCliente
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmEncomienda"] == null)
            {
                AdmEncomienda f = new AdmEncomienda
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmCamion"] == null)
            {
                AdmCamion f = new AdmCamion
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnGuias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdmGuia"] == null)
            {
                AdmGuia f = new AdmGuia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
    }
}
