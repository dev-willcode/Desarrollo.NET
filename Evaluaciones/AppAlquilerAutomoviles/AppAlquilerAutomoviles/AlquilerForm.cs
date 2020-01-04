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
    public partial class AlquilerForm : Form
    {
        private BindingSource alquilerLista;
        public AlquilerForm(BindingSource lista)
        {
            InitializeComponent();
            this.alquilerLista = lista;
            inicializarclientes();
        }

        public void inicializarclientes()
        {
            txtCliente.DataSource = new List<Cliente>();
            txtCliente.DataSource = Tlista.clientes;
            txtCliente.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            char tipo = (rbG.Checked) ? 'G' : 'D';
            DateTime fechaE = fechaEntrega.Value.Date;
            DateTime fechaR = fechaRecogida.Value.Date;

            if (fechaR.CompareTo(fechaE) >= 0)
            {
                Cliente cliente = Tlista.clientes[txtCliente.SelectedIndex];
                Alquiler alquiler = new Alquiler(cliente.Nombre, tipo, fechaE, fechaR);
                cliente.VehiculosAlquilados += alquiler.Dias;
                alquilerLista.Add(alquiler);
                this.Close();
            }
            else MessageBox.Show("No se puede asignar una fecha de recogida, " + Environment.NewLine
                + "antes de la fecha de entrega del vehiculo especificada.");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(this);
            clienteForm.Show();
        }
    }
}
