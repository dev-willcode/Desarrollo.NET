using System;
using System.Windows.Forms;
using Entidades.Inventario;

namespace Presentación.Inventario
{
    public partial class frmEditCategoria : Form
    {
        public frmEditCategoria()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public int opc;
        public Categoria aoc = new Categoria();

        private void verDatos()
        {
            txtNombre.Text = aoc.Nombre;
            txtDescripcion.Text = aoc.Detalle;
        }


        private bool validarDatos()
        {
            bool verificar = true;
            if (txtNombre.Text.Trim().Length == 0 && txtDescripcion.Text.Trim().Length == 0)
            {
                verificar = false;
            }
            return verificar;
        }

        public Categoria crearObjeto()
        {
            int id = aoc.IdCategoria;
            string nom = txtNombre.Text;
            string des = txtDescripcion.Text;
            Categoria oc = new Categoria(id, nom, des);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditCategoria_Load(object sender, EventArgs e)
        {
            if (opc == 2 && aoc != null)
            {
                verDatos();
            }
        }
    }
}
