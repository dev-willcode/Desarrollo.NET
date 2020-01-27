using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Inventario;
using Presentacion.Inventario;

namespace Presentacion
{
    public partial class AdminProveedor : Form
    {
        public AdminProveedor()
        {
            InitializeComponent();
        }
        ProveedorLN opln = new ProveedorLN();
        public void MostrarDatos()
        {
           
            dtgProductos.DataSource = opln.MostrarProveedorFitro(txtBuscar.Text);
        }
        private void nuevo()
        {
            try
            {
                EditProveedor fep = new EditProveedor();
                fep.Text = "Ingresar Proveedor";
                fep.opc =1 ;
                fep.ShowDialog();
                if (fep.DialogResult == DialogResult.OK)
                {
                    Proveedor op = fep.crearObjeto();
                    opln.CreateProveedor(op);
                    fep.Close();
                    lblEstado.Text = "Se ha ingresado el departamento...";
                }
                else
                {
                    fep.Close();
                    lblEstado.Text = "Ingreso cancelado...";
                }
                MostrarDatos();
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al insertar proveedor " + ex.Message;
            }
        }
        private void actualizar()
        {
            try
            {
                if (dtgProductos.CurrentRow != null)
                {
                    EditProveedor fep = new EditProveedor();
                    fep.Text = "Actualizar Proveedor";
                    fep.opc = 2;
                    fep.aop = dtgProductos.CurrentRow.DataBoundItem as Proveedor;
                    fep.ShowDialog();
                    if (fep.DialogResult == DialogResult.OK)
                    {
                        Proveedor op = fep.crearObjeto();
                        opln.UpdateProveedor(op);
                        fep.Close();
                        lblEstado.Text = "Se ha actualizado el departamento...";
                    }
                    else
                    {
                        fep.Close();
                        lblEstado.Text = "Actualizacion cancelada...";
                    }
                }
               MostrarDatos();
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al actualizar proveedor " + ex.Message;
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
                        Proveedor op = dtgProductos.CurrentRow.DataBoundItem as Proveedor;
                        if (opln.DeleteProveedor(op))
                            lblEstado.Text = "Se ha eliminado el proveedor seleccionado...";
                        else
                            lblEstado.Text = "Elimación cancelada...";
                    }
                }
                MostrarDatos();
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error al eliminar proveedor " + ex.Message;
            }
        }
        private void AdminProveedor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
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
