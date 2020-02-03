using System;
using System.Windows.Forms;
using Entidades.Inventario;
using Lógica.Inventario;

namespace Presentación.Inventario
{
    public partial class frmEditProducto : Form
    {
        public frmEditProducto()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public int opc;
        public Producto aoc = new Producto();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verDatos()
        {
            txtNombre.Text = aoc.Nombre;
            txtPrecio.Text = aoc.PrecioProveedor.ToString();
            txtPrecioV.Text = aoc.PrecioVenta.ToString();
            txtStockA.Text = aoc.StockActual.ToString();
            txtStockM.Text = aoc.StockMinimo.ToString();
            txtUnidad.Text = aoc.UnidadMedida;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtNombre.Text.Trim().Length == 0 && txtPrecio.Text.Trim().Length == 0 && txtPrecioV.Text.Trim().Length == 0
                && txtStockA.Text.Trim().Length == 0 && txtStockM.Text.Trim().Length == 0 && txtUnidad.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Producto crearObjeto()
        {
            int id = aoc.IdProducto;
            int cat = int.Parse(cBidCategoria.SelectedValue.ToString());
            string nom = txtNombre.Text;
            string unidad = txtUnidad.Text;
            decimal precioProv = decimal.Parse(txtPrecio.Text);
            short stockA = short.Parse(txtStockA.Text);
            short stockM = short.Parse(txtStockM.Text);
            decimal precioV = decimal.Parse(txtPrecioV.Text);
            Producto oc = new Producto(id, cat, nom, unidad, precioProv, stockA, stockM, precioV);
            return oc;
        }

        private void guardar()
        {
            try
            {
                if (validarDatos())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    toolStripLabel1.Text = "Los campos con (*) son obligatorios";
                }
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = ex.Message;
            }
        }

        private void frmEditProducto_Load(object sender, EventArgs e)
        {
            if (opc == 2 && aoc != null)
            {
                verDatos();
                cBidCategoria.DataSource = CategoriaLN.mostrarCategorias();
                cBidCategoria.SelectedIndex = 0;
                cBidCategoria.DisplayMember = "Nombre";
                cBidCategoria.ValueMember = "IdCategoria";
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
