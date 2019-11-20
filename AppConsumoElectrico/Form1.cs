using AppConsumoElectrico.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsumoElectrico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsumoElectrico consumoElectrico = new ConsumoElectrico();
            consumoElectrico.Cedula = txtCedula.Text;
            consumoElectrico.Nombre = txtNombre.Text;
            consumoElectrico.Direccion = txtDireccion.Text;
            consumoElectrico.NumeroMedidor = txtMedidor.Text;
            consumoElectrico.Consumo = Double.Parse(txtConsumo.Text);

            MessageBox.Show("El cálculo del consumo es: " + consumoElectrico.calcularConsumo());
        }
    }
}
