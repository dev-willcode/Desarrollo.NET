using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Inventario;
using Entidades.Inventario;
using Entidades.ClasesPersonalizadas;


namespace Presentacion.Inventario
{
    public partial class frmAdminProducto : Form
    {
        public frmAdminProducto()
        {
            InitializeComponent();
        }
        
        private void FrmAdminProducto_Load(object sender, EventArgs e)
        {
            MostarDatos();
        }
        ProductoLN opln = new ProductoLN();
        private void MostarDatos()
        {
          
            dtgProductos.DataSource = opln.MostrarProductoFitro(txtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostarDatos();
        }
        private void nuevo()
        {
            try
            {
                frmEditProducto fep = new frmEditProducto();
                fep.Text = "Ingresar Producto";
                fep.opc = 1;
                fep.ShowDialog();
                if (fep.DialogResult == DialogResult.OK)
                {
                    Producto op = fep.crearObjeto();
                    opln.CreateProducto(op);
                    fep.Close();
                    toolStripStatusLabel1.Text = "Se ha ingresado el producto...";
                }
                else
                {
                    fep.Close();
                    toolStripStatusLabel1.Text = "Ingreso cancelado...";
                }
                MostarDatos();
            }
            catch (Exception ex)
            {
                
                toolStripStatusLabel1.Text = "Error al insertar producto " + ex.Message;
            }
        }
        private void actualizar()
        {
            try
            {
                if (dtgProductos.CurrentRow != null)
                {
                    frmEditProducto fep = new frmEditProducto();
                    fep.Text = "Actualizar Producto";
                    fep.opc = 2;
                    fep.aop = dtgProductos.CurrentRow.DataBoundItem as ProductoCategoria;
                    fep.ShowDialog();
                    if (fep.DialogResult == DialogResult.OK)
                    {
                        Producto op = fep.crearObjeto();
                        opln.UpdateProducto(op);
                        fep.Close();
                        toolStripStatusLabel1.Text = "Se ha actualizado el Producto...";
                    }
                    else
                    {
                        fep.Close();
                        toolStripStatusLabel1.Text = "Actualizacion cancelada...";
                    }
                }
                MostarDatos();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error al actualizar producto " + ex.Message;
            }
        }
        private void eliminar()
        {
            try
            {
                if (dtgProductos.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        ProductoCategoria op = dtgProductos.CurrentRow.DataBoundItem as ProductoCategoria;
                        if (opln.DeleteProducto(op))
                            toolStripStatusLabel1.Text = "Se ha eliminado el producto seleccionado...";
                        else
                            toolStripStatusLabel1.Text = "Elimación cancelada...";
                    }
                }
                MostarDatos();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error al eliminar producto " + ex.Message;
            }
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
