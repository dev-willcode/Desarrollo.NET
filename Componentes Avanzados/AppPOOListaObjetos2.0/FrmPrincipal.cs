using AppPOOPractica2.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPOOPractica2
{
    public partial class FrmPrincipal : Form
    {
        public bool frmactivo = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Focus();
        }

        private void AdministrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FrmAdminEmpleados childForm = null;
            //Barremos las formas que hay en el parent para encontrar la referencia
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmAdminEmpleados)
                {
                    childForm = (FrmAdminEmpleados)f;
                    break;
                } 
            }
            //Si la encontró ya no necesita la instancia solo la mostramos
            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
            }
            else
            {
                //No se ha creado por lo tanto generamos la instancia
                childForm = new FrmAdminEmpleados();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }/*/
            if (Application.OpenForms["FrmAdminEmpleados"] ==null)
            {
                FrmAdminEmpleados f = new FrmAdminEmpleados
                {
                    MdiParent = this
                };
                f.Show();
            }

        }
        private void GestionProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           
        }

                 
       
        private void SentenciasLinqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmProcesos"] == null)
            {
                FrmProcesos f = new FrmProcesos
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void GestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
