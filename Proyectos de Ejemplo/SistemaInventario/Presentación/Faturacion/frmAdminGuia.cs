using System;
using System.Windows.Forms;
using Entidades.Facturacion;
using Lógica.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmAdminGuia : Form
    {
        public frmAdminGuia()
        {
            InitializeComponent();
            Text = "Administrador Guia";
            CenterToScreen();
        }

        private void frmAdminGuia_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        GuiaLN oC = new GuiaLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarGuiaFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditGuia fec = new frmEditGuia();
                fec.Text = "Ingresar Guia";
                fec.opc = 1;
                fec.ocultar();
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Guia oc = fec.crearObjeto();
                    oC.CreateGuia(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado un Guia...";
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
                toolStripLabel1.Text = "Error al insertar Guia " + ex.Message;
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
                        Guia oc = dataGridView1.CurrentRow.DataBoundItem as Guia;
                        if (oC.DeleteGuia(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el Guia seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar Guia " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditGuia fec = new frmEditGuia();
                    fec.Text = "Actualizar Guia";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Guia;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Guia oc = fec.crearObjeto();
                        oC.UpdateGuia(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el Guia...";
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
                toolStripLabel1.Text = "Error al actualizar Guia " + ex.Message;
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
