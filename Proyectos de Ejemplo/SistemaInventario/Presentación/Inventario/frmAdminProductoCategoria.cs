using System;
using System.Windows.Forms;
using Entidades.ClasePersonalizada;
using Entidades.Inventario;
using Lógica.ClasePersonalizada;
using Lógica.Inventario;

namespace Presentación.Inventario
{
    public partial class frmAdminProductoCategoria : Form
    {
        public frmAdminProductoCategoria()
        {
            InitializeComponent();
            Text = "Administrador Producto";
            CenterToScreen();
        }

        ProductoCategoriaLN oC = new ProductoCategoriaLN();
        ProductoLN oCP = new ProductoLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarProductoCategoriaFitro(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        private void frmAdminProducto_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        public void nuevo()
        {
            try
            {
                frmEditProducto fec = new frmEditProducto();
                fec.Text = "Ingresar Producto";
                fec.opc = 1;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Producto oc = fec.crearObjeto();
                    oCP.CreateProducto(oc);
                    fec.Close();
                    toolStripLabel1.Text = "Se ha ingresado el producto...";
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
                toolStripLabel1.Text = "Error al insertar producto " + ex.Message;
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
                        Producto oc = dataGridView1.CurrentRow.DataBoundItem as Producto;
                        if (oCP.DeleteProducto(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado el producto seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar producto " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditProducto fec = new frmEditProducto();
                    fec.Text = "Actualizar Producto";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as ProductoCategoria;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Producto oc = fec.crearObjeto();
                        oCP.UpdateProducto(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el producto...";
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
                toolStripLabel1.Text = "Error al actualizar producto " + ex.Message;
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
    }
}
