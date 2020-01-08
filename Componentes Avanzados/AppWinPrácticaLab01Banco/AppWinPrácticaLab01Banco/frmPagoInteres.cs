using AppWinPrácticaLab01Banco.Controlador;
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
    public partial class frmPagoInteres : MetroForm
    {
        public frmPagoInteres()
        {
            InitializeComponent();
            this.CenterToParent();
            var sql = from le in ListaCuenta.listaCuenta
                      where le.Tipo == "Ahorros" && le.Saldo > 10
                      select new { Cédula = le.Cedula, Nombre = le.Nombres, Dirección = le.Direccion, Edad = le.Edad, Tipo = le.Tipo, Número = le.Numero, Saldo = le.Saldo, Interes = (le.Saldo * 0.05) + le.Saldo };
            dataGridView1.DataSource = sql.ToList();

            var sql2 = from le in ListaCuenta.listaCuenta
                       where le.Tipo == "Corriente" && le.Saldo > 100
                       select new { Cédula = le.Cedula, Nombre = le.Nombres, Dirección = le.Direccion, Edad = le.Edad, Tipo = le.Tipo, Número = le.Numero, Saldo = le.Saldo, Interes = (le.Saldo * 0.09) + le.Saldo };
            dataGridView2.DataSource = sql2.ToList();
        }
    }
}
