using System;
using System.Windows.Forms;
using Entidades.ClasePersonalizada;
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
        public ProductoCategoria aoc = new ProductoCategoria();

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
            comboCategoria.SelectedIndex = buscarIndice(comboCategoria, aoc.Categoria);
            comboProveedor.SelectedIndex = buscarIndice(comboProveedor, aoc.Proveedor);
        }

        private int buscarIndice(ComboBox combobox, string value)
        {
            foreach (object item in combobox.Items)
            {
                if (item.GetType() == typeof(Categoria))
                {
                    if ((item as Categoria).Nombre.Equals(value))
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
                else
                {
                    if ((item as Proveedor).Nombre.Equals(value))
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
            }
            return -1;
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

        public Producto crearProducto()
        {
            int id = aoc.IdProducto;
            int cat = (int)comboCategoria.SelectedValue;
            string nom = txtNombre.Text;
            string unidad = txtUnidad.Text;
            decimal precioProv = decimal.Parse(txtPrecio.Text);
            short stockA = short.Parse(txtStockA.Text);
            short stockM = short.Parse(txtStockM.Text);
            decimal precioV = decimal.Parse(txtPrecioV.Text);
            Producto oc = new Producto(id, cat, nom, unidad, precioProv, stockA, stockM, precioV);
            return oc;
        }

        public ProveedorProducto crearProveedorProducto(int id)
        {
            int idProveedor = (int)comboProveedor.SelectedValue;
            DateTime fecha = DateTime.Today;
            ProveedorProducto oc = new ProveedorProducto(id, idProveedor, fecha);
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
            mostrarCategorias();
            mostrarProveedores();
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }

        }

        private void mostrarProveedores()
        {
            comboProveedor.DataSource = ProveedorLN.MostrarProveedor();
            comboProveedor.SelectedIndex = 0;
            comboProveedor.DisplayMember = "nombre";
            comboProveedor.ValueMember = "idProveedor";
        }

        private void mostrarCategorias()
        {
            comboCategoria.DataSource = CategoriaLN.mostrarCategorias();
            comboCategoria.SelectedIndex = 0;
            comboCategoria.DisplayMember = "Nombre";
            comboCategoria.ValueMember = "IdCategoria";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
