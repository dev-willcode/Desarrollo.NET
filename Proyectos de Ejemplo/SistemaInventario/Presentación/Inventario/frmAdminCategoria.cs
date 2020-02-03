using System;
using System.Windows.Forms;
using Entidades.Inventario;
using Lógica.Inventario;
using Presentación.Inventario;

namespace Presentación
{
    public partial class frmAdminCategoria : Form
    {
        public frmAdminCategoria()
        {
            InitializeComponent();
            Text = "Administrador Categoria";
            CenterToScreen();
        }

        CategoriaLN oC = new CategoriaLN();
        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = oC.MostrarCategoriaFitro(buscar);
        }

        public void nuevo()
        {
            try
            {
                frmEditCategoria fec = new frmEditCategoria();
                fec.Text = "Ingresar Categoria";
                fec.opc = 1;
                fec.ShowDialog();
                if (fec.DialogResult == DialogResult.OK)
                {
                    Categoria oc = fec.crearObjeto();
                    oC.CreateCategoria(oc);
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
                toolStripLabel1.Text = "Error al insertar categoria " + ex.Message;
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
                        Categoria oc = dataGridView1.CurrentRow.DataBoundItem as Categoria;
                        if (oC.DeleteCategoria(oc))
                        {
                            toolStripLabel1.Text = "Se ha eliminado la categoria seleccionado...";
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
                toolStripLabel1.Text = "Error al eliminar categoria " + ex.Message;
            }
        }

        private void actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditCategoria fec = new frmEditCategoria();
                    fec.Text = "Actualizar Categoria";
                    fec.opc = 2;
                    fec.aoc = dataGridView1.CurrentRow.DataBoundItem as Categoria;
                    fec.ShowDialog();
                    if (fec.DialogResult == DialogResult.OK)
                    {
                        Categoria oc = fec.crearObjeto();
                        oC.UpdateCategoria(oc);
                        fec.Close();
                        toolStripLabel1.Text = "Se ha actualizado el departamento...";
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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }
    }
}
