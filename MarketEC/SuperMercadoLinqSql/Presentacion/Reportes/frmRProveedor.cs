using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Inventario;
using Entidades.Inventario;
using Entidades.Entidades;

namespace Presentacion.Reportes
{
    public partial class frmRProveedor : Form
    {
        public frmRProveedor()
        {
            InitializeComponent();
        }
        ProveedorLN opln = new ProveedorLN();
        private void FrmRProveedor_Load(object sender, EventArgs e)
        {
            DSReportes ds = new DSReportes();
            try
            {
                List<Proveedor> lp = opln.MostrarProveedorFitro("");
                foreach (Proveedor p in lp)
                {
                    ds.PROVEEDOR.AddPROVEEDORRow(p.IdProveedor, p.CedProveedor, p.Nombre, p.Representante, p.Direccion, p.Ciudad, p.Telefono, p.Fax);
                }

                CRProveedor rpt = new CRProveedor();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception men)
            {
                MessageBox.Show(men.ToString());
            }
        }
    }
}
