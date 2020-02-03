using System;
using System.Windows.Forms;
using Entidades.Facturacion;
using Lógica.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmAdminOrden : Form
    {
        public frmAdminOrden()
        {
            InitializeComponent();
            Text = "Administrador Orden";
            CenterToScreen();
        }

        private void frmAdminOrden_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        OrdenLN oC = new OrdenLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarOrdenFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditOrden fec = new frmEditOrden();
                fec.Text = "Ingresar Orden";
                fec.opc = 1;
                fec.ocultar();
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Orden oc = fec.crearObjeto();
                    oC.CreateOrden(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado un Orden...";
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
                toolStripLabel1.Text = "Error al insertar Orden " + ex.Message;
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
                        Orden oc = dataGridView1.CurrentRow.DataBoundItem as Orden;
                        if (oC.DeleteOrden(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el Orden seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar Orden " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditOrden fec = new frmEditOrden();
                    fec.Text = "Actualizar Orden";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Orden;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Orden oc = fec.crearObjeto();
                        oC.UpdateOrden(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el Orden...";
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
                toolStripLabel1.Text = "Error al actualizar Orden " + ex.Message;
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
