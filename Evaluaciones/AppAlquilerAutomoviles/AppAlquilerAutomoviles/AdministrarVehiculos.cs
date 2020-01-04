using AppAlquilerAutomoviles.Modelos;
using System;
using System.Windows.Forms;

namespace AppAlquilerAutomoviles
{
    public partial class AdministrarVehiculos : Form
    {

        public AdministrarVehiculos()
        {
            InitializeComponent();
            // Inicia las tarifas
            Tlista.tarifas.Add(new Tarifas('D', 3.00, "un día"));
            Tlista.tarifas.Add(new Tarifas('G', 3.50, "un día"));
            inicializarClientes();
        }

        private void inicializarClientes()
        {
            Tlista.clientes.Add(new Cliente("070023423", "Marcelo Diaz", 0));
            Tlista.clientes.Add(new Cliente("078934234", "Juan alvarez", 0));
            Tlista.clientes.Add(new Cliente("078098234", "Rodrigo villanueva", 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlquilerForm alquilarVehiculo = new AlquilerForm(listaAlquileresSource);
            alquilarVehiculo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double totalD = 0.00;
            double totalG = 0.00;
            foreach (Alquiler item in listaAlquileresSource)
            {
                if (item.ModeloVehiculo == 'D') totalD += item.ImporteTotal;
                if (item.ModeloVehiculo == 'G') totalG += item.ImporteTotal;
            }
            String resul = "TOTAL RECAUDADO MODELO D: " + totalD + Environment.NewLine
                + "TOTAL RECAUDADO MODELO G: " + totalG;

            MessageBox.Show(resul);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double totalD = 0.0;
            double totalG = 0.0;
            double total = 0.0;
            foreach (Alquiler item in listaAlquileresSource)
            {
                if (item.ModeloVehiculo == 'D') totalD++;
                if (item.ModeloVehiculo == 'G') totalG++;
                total++;
            }
            if (total != 0)
            {
                String resul = "MODELO D: " + Math.Round(((totalD / total) * 100.00), 2) + " %" + Environment.NewLine
                + "MODELO G: " + Math.Round(((totalG / total) * 100.00), 2) + " %" + Environment.NewLine;

                MessageBox.Show(resul);
            }
            else MessageBox.Show("No hay alquileres registrados!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalD = 0;
            int totalG = 0;
            foreach (Alquiler item in listaAlquileresSource)
            {
                if (item.ModeloVehiculo == 'D') totalD++;
                if (item.ModeloVehiculo == 'G') totalG++;
            }
            String resul = "MODELO MAS ALQUILADO: " + Environment.NewLine;
            if (totalD > totalG) resul += "Modelo D con " + totalD + " alquilados";
            else if (totalG > totalD) resul += "Modelo G con " + totalG + " alquilados";
            else resul += "Ambos modelos se alquilaron " + totalG + " veces";
            MessageBox.Show(resul);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = Tlista.obtenerMayor();
            MessageBox.Show("El cliente con más alquileres es: " + Environment.NewLine + 
                "CEDULA: " + cliente.Cedula + Environment.NewLine + 
                "NOMBRE: " + cliente.Nombre + Environment.NewLine +
                "N° dias alquilados:" + cliente.VehiculosAlquilados);
        }
    }
}
