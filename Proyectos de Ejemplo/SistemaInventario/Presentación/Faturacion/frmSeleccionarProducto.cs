using System;
using System.Windows.Forms;
using Entidades.ClasePersonalizada;
using Entidades.Facturacion;
using Lógica.ClasePersonalizada;

namespace Presentación.Inventario
{
    public partial class frmSeleccionarProducto : Form
    {
        public ProductoCategoria ProductoSeleccionado { get; set; }
        public frmSeleccionarProducto()
        {
            InitializeComponent();
            Text = "Seleccione un Producto";
            CenterToScreen();
        }

        ProductoCategoriaLN ProductoCategoriaLN = new ProductoCategoriaLN();

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = ProductoCategoriaLN.MostrarProductoCategoriaFitro(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        private void frmAdminProducto_Load(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProductoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as ProductoCategoria;
                txtCantidad.Maximum = ProductoSeleccionado.StockActual;
            }
        }

        internal GuiaDetalle crearGuiaDetalle()
        {
            GuiaDetalle guiaDetalle = new GuiaDetalle();
            guiaDetalle.Cantidad = (int)txtCantidad.Value;
            guiaDetalle.IdProducto = ProductoSeleccionado.IdProducto;
            guiaDetalle.Subtotal = guiaDetalle.Cantidad * ProductoSeleccionado.PrecioProveedor;
            return guiaDetalle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductoSeleccionado != null)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
