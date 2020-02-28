using System;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms.Elems
{
    public partial class CamionForm : Form
    {
        private readonly CamionLN camionLN = new CamionLN();
        private AdmCamion AdmCamion { get; }
        public CamionForm(AdmCamion adm)
        {
            InitializeComponent();
            AdmCamion = adm;
            comboEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                camionLN.Insertar(crearCamion());
                AdmCamion.cargarListado();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Camion crearCamion()
        {
            return new Camion(
                0,
                txtNombre.Text,
                decimal.Parse(txtPeso.Text),
                comboEstado.SelectedItem.ToString(),
                int.Parse(txtNumViajes.Text)
                );
        }
    }
}
