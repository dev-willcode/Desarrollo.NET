using System;
using System.Windows.Forms;
using Entidades.Facturacion;

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

        private void verDatos()
        {
            txtGuia.Text = aoc.IdGuia.ToString();
            txtLocal.Text = aoc.IdLocal.ToString();
            txtFechaSalida.Value = aoc.FechaSalida;
            txtTransportista.Text = aoc.Transportista;
            txtTotal.Text = aoc.Total.ToString();
            txtCantidad.Text = aoc.Cantidad_item.ToString();
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtGuia.Text.Trim().Length == 0 && txtLocal.Text.Trim().Length == 0
                && txtFechaSalida.Value == null && txtTransportista.Text.Trim().Length == 0
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
                int.Parse(txtLocal.Text),
                txtFechaSalida.Value,
                txtTransportista.Text,
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
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
