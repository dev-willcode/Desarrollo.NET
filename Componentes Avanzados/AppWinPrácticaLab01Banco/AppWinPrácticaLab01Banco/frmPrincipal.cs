using AppWinPrácticaLab01Banco.Controlador;
using AppWinPrácticaLab01Banco.Entidades;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinPrácticaLab01Banco
{
    public partial class frmPrincipal : MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.CenterToParent();
            Cuenta eC1 = new Cuenta("0707072153","Jorge","25 de Junio", "0968073394", 20, 125, 600, "Corriente");
            ListaCuenta.Insertar(eC1);
            Cuenta eC2 = new Cuenta("0707072180", "Alex", "Buena Vista", "0968073444", 30, 126, 1200, "Corriente");
            ListaCuenta.Insertar(eC2);
            Cuenta eA1 = new Cuenta("0707072145", "Norma", "Rocafuerte", "0968073555", 35, 127, 700, "Ahorros");
            ListaCuenta.Insertar(eA1);
            Cuenta eA2 = new Cuenta("0707072112", "Maria", "Vela y Junin", "0968073857", 42, 128, 250, "Ahorros");
            ListaCuenta.Insertar(eA2);
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
             dataGridView1.DataSource = ListaCuenta.listaCuenta.ToList();
        }

        private void toolStripDepRe_ButtonClick(object sender, EventArgs e)
        {
            frmDepositoRetiro f = new frmDepositoRetiro();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void toolStripMejorC_ButtonClick(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void toolStripPagoI_ButtonClick(object sender, EventArgs e)
        {
            frmPagoInteres f = new frmPagoInteres();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void toolStripAperturaC_Click(object sender, EventArgs e)
        {
            frmApertura f = new frmApertura();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void btnApertura_Click(object sender, EventArgs e)
        {
            frmApertura f = new frmApertura();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            frmDepositoRetiro f = new frmDepositoRetiro();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void btnMejorCliente_Click(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void btnPagoInteres_Click(object sender, EventArgs e)
        {
            frmPagoInteres f = new frmPagoInteres();
            f.ShowDialog();
            ActualizarTabla();
        }
    }
}
