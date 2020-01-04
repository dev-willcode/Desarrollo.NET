using AppAlquilerAutomoviles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlquilerAutomoviles
{
    public partial class ClienteForm : Form
    {
        private AlquilerForm alquiler;
        public ClienteForm(AlquilerForm alquiler)
        {
            this.alquiler = alquiler;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = txtCedula.Text;
            cliente.Nombre = txtNombre.Text;
            Tlista.clientes.Add(cliente);
            alquiler.inicializarclientes();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
