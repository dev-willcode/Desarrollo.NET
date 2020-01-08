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
    public partial class frmDepositoRetiro : MetroForm
    {
        public frmDepositoRetiro()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            int pos = ListaCuenta.BuscarDato(int.Parse(txtBuscarCuenta.Text));
            Cuenta oC = ListaCuenta.GetCuenta(pos);
            if (rbDepo.Checked)
            {
                oC.Saldo = double.Parse(txtSaldo.Text) + double.Parse(txtCantidad.Text);
                MessageBox.Show("Saldo Actual " + oC.Saldo);
            }
            if (rbReti.Checked)
            {
                if (oC.Tipo.Equals("Ahorros"))
                {
                    if (double.Parse(txtCantidad.Text) < double.Parse(txtSaldo.Text))
                    {
                        oC.Saldo = double.Parse(txtSaldo.Text) - double.Parse(txtCantidad.Text);
                        MessageBox.Show("Saldo Actual " + oC.Saldo);
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para realizar el retiro");
                    }
                }
                if (oC.Tipo.Equals("Corriente"))
                {
                    if (double.Parse(txtCantidad.Text) < double.Parse(txtSaldo.Text) && double.Parse(txtSaldo.Text) > 100)
                    {
                        oC.Saldo = double.Parse(txtSaldo.Text) - double.Parse(txtCantidad.Text);
                        MessageBox.Show("Saldo Actual " + oC.Saldo);
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para realizar el retiro");
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {      
            Cuenta oP = ListaCuenta.GetCuenta(ListaCuenta.BuscarDato(int.Parse(txtBuscarCuenta.Text)));
            txtNumerCuenta.Text = oP.Numero.ToString();
            txtNombre.Text = oP.Nombres;
            txtTipoCuenta.Text = oP.Tipo;
            txtSaldo.Text = oP.Saldo.ToString();
        }
    }
}
