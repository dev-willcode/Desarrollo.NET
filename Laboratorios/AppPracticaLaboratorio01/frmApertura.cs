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
    public partial class frmApertura : MetroForm
    {
        public frmApertura()
        {
            InitializeComponent();
            cBoxTipoCuenta.SelectedIndex = 0;
            this.CenterToParent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Cuenta cuentaNueva = new Cuenta();
            Random random = new Random();
            int numerC = random.Next(1000);
            if (txtCedula.TextLength > 0 && txtDireccion.TextLength > 0 && txtEdad.TextLength > 0 && txtNombre.TextLength > 0
                && txtSaldoCuenta.TextLength > 0 && txtTelefono.TextLength > 0)
            {
                if (cBoxTipoCuenta.SelectedIndex == 0)
                {
                    generarCuenta(cuentaNueva, numerC);
                    if (cuentaNueva.Saldo < 600)
                    {
                        MessageBox.Show("Para cuenta de corriente el saldo debe ser mayor o igual a 600$");
                    } else
                    {
                        MessageBox.Show("Cuenta Creada" + "\nCuenta " + cuentaNueva.Tipo + " con el número de cuenta: " + numerC);
                        ListaCuenta.Insertar(cuentaNueva);
                    }
                    
                } else
                {
                    generarCuenta(cuentaNueva, numerC);
                    if (cuentaNueva.Saldo < 100)
                    {
                        MessageBox.Show("Para cuenta de ahorro el saldo debe ser mayor o igual a 100$");
                    }
                    else
                    {
                        MessageBox.Show("Cuenta Creada" + "\nCuenta de " + cuentaNueva.Tipo + " con el número de cuenta: " + numerC);
                        ListaCuenta.Insertar(cuentaNueva);
                    }
                }   
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos");
            }
        }

        private void generarCuenta(Cuenta eA, int numerC)
        {
            eA.Cedula = txtCedula.Text;
            eA.Nombres = txtNombre.Text;
            eA.Direccion = txtDireccion.Text;
            eA.Telefono = txtTelefono.Text;
            eA.Edad = int.Parse(txtEdad.Text);
            eA.Saldo = double.Parse(txtSaldoCuenta.Text);
            eA.Tipo = cBoxTipoCuenta.SelectedItem.ToString();
            eA.Numero = numerC;
        }
    }
}
