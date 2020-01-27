using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Inventario;
using Logica.Inventario;
using Entidades.ClasesPersonalizadas;

namespace Presentacion.Inventario
{
    public partial class frmEditProducto : Form
    {
        public frmEditProducto()
        {
            InitializeComponent();
        }
        public int opc;
        public ProductoCategoria aop = null;
        public void llenarCombo()
        {
            try
            {
                CategoriaLN ocln = new CategoriaLN();
                comboBox1.DataSource = ocln.MostrarCategoria();
                comboBox1.SelectedIndex = 0;
                comboBox1.DisplayMember = "Nombre";
                comboBox1.SelectedValue = "IdCategoria";
             
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = ex.Message;
            }
        }
        private void FrmEditProducto_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (opc == 2 && aop != null)
            {
                verDatos();
            }
        }
        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtId.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }
        private void guardar()
        {
            try
            {
                if (validarDatos())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    toolStripLabel1.Text = "Los campos con (*) son obligatorios";
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = ex.Message;
            }
        }
        private void verDatos()
        {
            txtId.Text = aop.IdProducto.ToString();
            comboBox1.SelectedValue = 2;
            txtNombre.Text = aop.Nombre;
            txtUnidad.Text = aop.UnidadMedida;
            txtPrecioP.Text =  aop.PrecioProveedor.ToString();
            txtPrecioV.Text = aop.PrecioVenta.ToString();
            txtStockA.Text = aop.StockActual.ToString();
            txtStockM.Text = aop.StockMinimo.ToString();
            
        }
        public Producto crearObjeto()
        {
            int id = int.Parse(txtId.Text);
            int idc = int.Parse(comboBox1.SelectedValue.ToString());
            string nom = txtNombre.Text;
            string um = txtUnidad.Text;
            decimal pp = Decimal.Parse(txtPrecioP.Text);
            decimal pv = Decimal.Parse(txtPrecioV.Text);
            short sa = short.Parse(txtStockA.Text);
            short sm = short.Parse(txtStockM.Text);
            Producto op = new Producto(id,idc,nom, um,pv,pv,sa,sm);
            return op;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
}
