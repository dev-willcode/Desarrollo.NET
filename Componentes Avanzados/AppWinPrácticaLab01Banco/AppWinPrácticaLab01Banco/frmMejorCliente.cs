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
    public partial class frmCliente : MetroForm
    {
        public frmCliente()
        {
            InitializeComponent();
            this.CenterToParent();
            Cuenta eA = ListaCuenta.mejorCuenta("Ahorros");
            Cuenta eC = ListaCuenta.mejorCuenta("Corriente");

            txtNombreA.Text = eA.Nombres.ToString();
            txtNumerCuentaA.Text = eA.Numero.ToString();
            txtSaldoA.Text = eA.Saldo.ToString();
            txtTipoCuentaA.Text = eA.Tipo.ToString();
            
            txtNombreC.Text = eC.Nombres.ToString();
            txtNumerCuentaC.Text = eC.Numero.ToString();
            txtSaldoC.Text = eC.Saldo.ToString();
            txtTipoCuentaC.Text = eC.Tipo.ToString();
        }

        private void frmMejorCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
