

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Datos.Facturacion;
using Entidades.Facturacion;
using Lógica.Facturacion;
using Presentación.Inventario;

namespace Presentación.Faturacion
{
    public partial class frmEditGuia : Form
    {
        public frmEditGuia()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public int opc;
        public Guia aoc = new Guia();
        TransportistaLN TransportistaLN = new TransportistaLN();
        LocalLN LocalLN = new LocalLN();
        GuiaLN GuiaLN = new GuiaLN();

        private void verDatos()
        {
            txtGuia.Text = aoc.IdGuia.ToString();
            comboLocales.SelectedIndex = buscarIndice(comboLocales, aoc.IdLocal);
            comboTransportista.SelectedIndex = buscarIndice(comboTransportista, aoc.Transportista);
            txtFechaSalida.Value = aoc.FechaSalida;
            txtTotal.Text = aoc.Total.ToString();
            txtCantidad.Text = aoc.Cantidad_item.ToString();
            cargarDetalles();
        }

        private void cargarDetalles()
        {
            List<GuiaDetalle> lista = GuiaLN.ListarGuiaDetalle(aoc.IdGuia);
            lista.ForEach(elem => listaDetalle.Add(elem));
        }

        private int buscarIndice(ComboBox combobox, int value)
        {
            foreach (object item in combobox.Items)
            {
                if (item.GetType() == typeof(Local))
                {
                    if ((item as Local).IdLocal == value)
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
                else
                {
                    if ((item as Transportista).IdTransportista == value)
                    {
                        return combobox.Items.IndexOf(item);
                    }
                }
            }
            return -1;
        }

        public List<GuiaDetalle> obtenerListadoDetalle(int idGuia)
        {
            List<GuiaDetalle> lista = new List<GuiaDetalle>();
            foreach (GuiaDetalle item in listaDetalle.List)
            {
                item.IdGuia = idGuia;
                lista.Add(item);
            }
            return lista;
        }

        private bool validarDatos()
        {
            bool verificar = true;
            if (txtGuia.Text.Trim().Length == 0 && txtFechaSalida.Value == null
                && txtTotal.Text.Trim().Length == 0 && txtCantidad.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Guia crearObjeto()
        {
            Guia oc = new Guia(
                opc == 1 ? 0 : int.Parse(txtGuia.Text),
                (int)comboLocales.SelectedValue,
                txtFechaSalida.Value,
                (int)comboTransportista.SelectedValue,
                decimal.Parse(txtTotal.Text),
                int.Parse(txtCantidad.Text));
            return oc;
        }

        internal void ocultar()
        {
            lbid.Visible = false;
            txtGuia.Visible = false;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditGuia_Load(object sender, EventArgs e)
        {
            mostrarTransportistas();
            mostrarLocales();
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }
        }

        private void mostrarLocales()
        {
            comboLocales.DataSource = LocalLN.MostrarLocal();
            comboLocales.SelectedIndex = 0;
            comboLocales.DisplayMember = "Direccion";
            comboLocales.ValueMember = "IdLocal";
        }

        private void mostrarTransportistas()
        {
            comboTransportista.DataSource = TransportistaLN.MostrarTransportista();
            comboTransportista.SelectedIndex = 0;
            comboTransportista.DisplayMember = "Nombre";
            comboTransportista.ValueMember = "IdTransportista";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            frmSeleccionarProducto frm = new frmSeleccionarProducto();
            frm.ShowDialog();
            if (frm.ProductoSeleccionado != null)
            {
                GuiaDetalle guiaDetalle = frm.crearGuiaDetalle();
                listaDetalle.Add(guiaDetalle);
            }
        }

        private void listaProductos_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            txtCantidad.Text = listaDetalle.Count.ToString();
            decimal total = 0;
            foreach (GuiaDetalle item in listaDetalle.List)
            {
                total += item.Subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("¿Desea borrar el producto?", "ATENCION", MessageBoxButtons.YesNo);
                if ((int)result == 6)
                {
                    listaDetalle.Remove(dataGridView1.CurrentRow.DataBoundItem as GuiaDetalle);
                }
            }

        }
    }
}
