using System;
using System.Windows.Forms;
using Entidades.Facturacion;

namespace Presentación.Faturacion
{
    public partial class frmEditOrden : Form
    {
        public frmEditOrden()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public int opc;
        public Orden aoc = new Orden();

        private void verDatos()
        {
            txtId.Text = aoc.IdOrden.ToString();
            txtFechaOrden.Value = aoc.FechaOrden;
            txtFechaEntrada.Value = aoc.FechaEntrada;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtId.Text.Trim().Length == 0 && txtFechaOrden.Value == null
                && txtFechaEntrada.Value == null)
            {
                verificar = false;
            }
            return verificar;
        }

        public void ocultar()
        {
            lbid.Visible = false;
            txtId.Visible = false;
        }
        public Orden crearObjeto()
        {
            Orden oc = new Orden(
                opc == 1 ? 0 : int.Parse(txtId.Text),
                txtFechaOrden.Value,
                txtFechaEntrada.Value
                );
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditOrden_Load(object sender, EventArgs e)
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
