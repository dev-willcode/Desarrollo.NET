using System;
using System.Windows.Forms;
using Entidades.Inventario;
using Lógica.Inventario;

namespace Presentación.Inventario
{
    public partial class frmAdminProveedor : Form
    {
        public frmAdminProveedor()
        {
            InitializeComponent();
            Text = "Administrador Proveedor";
            CenterToScreen();
        }

        private void frmAdminProveedor_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        ProveedorLN oC = new ProveedorLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarProveedorFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditProveedor fec = new frmEditProveedor();
                fec.Text = "Ingresar Proveedor";
                fec.opc = 2;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Proveedor oc = fec.crearObjeto();
                    oC.CreateProveedor(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado el proveedor...";
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
                toolStripLabel1.Text = "Error al insertar proveedor " + ex.Message;
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
                        Proveedor oc = dataGridView1.CurrentRow.DataBoundItem as Proveedor;
                        if (oC.DeleteProveedor(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el proveedor seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar proveedor " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditProveedor fec = new frmEditProveedor();
                    fec.Text = "Actualizar Proveedor";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Proveedor;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Proveedor oc = fec.crearObjeto();
                        oC.UpdateProveedor(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el proveedor...";
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
                toolStripLabel1.Text = "Error al actualizar proveedor " + ex.Message;
            }

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

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }
    }
}
