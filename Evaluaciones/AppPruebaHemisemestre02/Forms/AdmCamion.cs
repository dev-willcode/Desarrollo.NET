using System;
using System.Windows.Forms;
using AppPruebaHemisemestre02.Forms.Elems;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms
{
    public partial class AdmCamion : Form
    {
        private CamionLN CamionLN = new CamionLN();
        public AdmCamion()
        {
            InitializeComponent();
            cargarListado();
        }

        internal void cargarListado()
        {
            try
            {
                camionSource.DataSource = CamionLN.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CamionForm clienteForm = new CamionForm(this);
            clienteForm.ShowDialog();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Camion item in camionSource.List)
                {
                    if (!item.estado.Equals("DISPONIBLE"))
                    {
                        CamionLN.ActualizarEstadoDisponible(item.id);
                    }
                }
                MessageBox.Show("Se han liberado todos los camiones ocupados!");
                cargarListado();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
