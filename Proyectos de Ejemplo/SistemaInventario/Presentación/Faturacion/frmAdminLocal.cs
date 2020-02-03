using System;
using System.Windows.Forms;
using Datos.Facturacion;
using Lógica.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmAdminLocal : Form
    {
        public frmAdminLocal()
        {
            InitializeComponent();
            Text = "Administrador Local";
            CenterToScreen();
        }

        private void frmAdminLocal_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        LocalLN oC = new LocalLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarLocalFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditLocal fec = new frmEditLocal();
                fec.Text = "Ingresar Local";
                fec.opc = 1;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Local oc = fec.crearObjeto();
                    oC.CreateLocal(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado un local...";
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
                toolStripLabel1.Text = "Error al insertar local " + ex.Message;
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
                        Local oc = dataGridView1.CurrentRow.DataBoundItem as Local;
                        if (oC.DeleteLocal(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el local seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar local " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditLocal fec = new frmEditLocal();
                    fec.Text = "Actualizar Local";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Local;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Local oc = fec.crearObjeto();
                        oC.UpdateLocal(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el local...";
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
                toolStripLabel1.Text = "Error al actualizar local " + ex.Message;
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
