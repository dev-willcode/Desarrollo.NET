using System;
using System.Windows.Forms;
using Entidades.Facturacion;
using Lógica.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmAdminTransportista : Form
    {
        public frmAdminTransportista()
        {
            InitializeComponent();
            Text = "Administrador Transportista";
            CenterToScreen();
        }

        private void frmAdminTransportista_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        TransportistaLN oC = new TransportistaLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarTransportistaFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditTransportista fec = new frmEditTransportista();
                fec.Text = "Ingresar Transportista";
                fec.opc = 1;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Transportista oc = fec.crearObjeto();
                    oC.CreateTransportista(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado un Transportista...";
                }
                else
                {
                    fec.Close();
                    toolStripLabel1.Text = "Ingreso cancelado...";
                }
                mostrarDatos(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = "Error al insertar Transportista " + ex.Message;
            }
        }

        private void eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DialogResult res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        Transportista oc = dataGridView1.CurrentRow.DataBoundItem as Transportista;
                        if (oC.DeleteTransportista(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el Transportista seleccionado...";
                        }
                        else
                        {
                            toolStripLabel1.Text = "Elimación cancelada...";
                        }
                    }
                }
                mostrarDatos(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = "Error al eliminar Transportista " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditTransportista fec = new frmEditTransportista();
                    fec.Text = "Actualizar Transportista";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Transportista;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Transportista oc = fec.crearObjeto();
                        oC.UpdateTransportista(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el Transportista...";
                    }
                    else
                    {
                        fec.Close();
                        toolStripLabel1.Text = "Actualizacion cancelada...";
                    }
                }
                mostrarDatos(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = "Error al actualizar Transportista " + ex.Message;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        private void insertarStripButton1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void actualizarStripButton2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void eliminarStripButton3_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
