using AppFormulariosMDI.Clases;
using System;
using System.Windows.Forms;

namespace AppFormulariosMDI
{
    public partial class AdministrarPersona : Form
    {
        public AdministrarPersona()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DatosPersona"] == null)
            {
                DatosPersona datosPersona = new DatosPersona(this, "INSERTAR");
                datosPersona.MdiParent = this.MdiParent;
                datosPersona.Show();
            }
        }

        public void InsertarPersona(Persona persona)
        {
            bsListadoPersonas.Add(persona);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblPersonas.CurrentRow != null)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?",
                    "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    bsListadoPersonas.RemoveAt(tblPersonas.CurrentRow.Index);
            }
            else MessageBox.Show("ERROR!\nVerifique que ha seleccionado un registro");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tblPersonas.CurrentRow != null)
            {
                if (Application.OpenForms["DatosPersona"] == null)
                {
                    DatosPersona datosPersona = new DatosPersona(this, "MODIFICAR");
                    datosPersona.MdiParent = this.MdiParent;
                    datosPersona.rellenarDatos((Persona)tblPersonas.CurrentRow.DataBoundItem, tblPersonas.CurrentRow.Index);
                    datosPersona.Show();
                }
            }
            else MessageBox.Show("ERROR!\nVerifique que ha seleccionado un registro");
        }

        internal void ModificarPersona(Persona persona, int index)
        {
            bsListadoPersonas.List[index] = persona;
        }
    }
}
