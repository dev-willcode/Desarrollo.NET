using System;
using System.Windows.Forms;
using pruebaPractica03.Clases;

namespace pruebaPractica03
{
    public partial class AdministradorCine : Form
    {
        private Butaca[,] arrayButacas;
        public AdministradorCine()
        {
            InitializeComponent();
            arrayButacas = new Butaca[8, 9];
            RellenarButacas();
        }

        private void RellenarButacas()
        {
            int letra;
            int numeroFila = 8;
            Butaca butaca;
            for (int i = 0; i < tablaButacas.RowCount; i++)
            {
                letra = 65;
                for (int j = 0; j < tablaButacas.ColumnCount; j++)
                {
                    butaca = new Butaca();
                    butaca.Asiento = ((char)letra++) + numeroFila.ToString();
                    arrayButacas[i, j] = butaca;
                    //crea el conjunto de propiedades del label
                    butaca.generarEtiqueta();
                    // Agrega al TablePanel los labels generados
                    tablaButacas.Controls.Add(butaca.Etiqueta, j, i);
                }
                --numeroFila;
            }
        }

        private void btnCliente_Click(object sender, System.EventArgs e)
        {
            string log = "";
            string resp;
            Random random = new Random();
            for (int i = 0; i < contador.Value; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = "Will";
                cliente.Edad = 20;
                cliente.Dinero = 200.00;
                resp = asignarAsiento(cliente, random);
                log += resp;
                if (resp.Equals("Butacas llenas!"))
                    break;
            }

            MessageBox.Show("---- Resultados de la operación ----" + Environment.NewLine + log);
        }

        private string asignarAsiento(Cliente cliente, Random random)
        {
            Butaca butacaRandom = arrayButacas[random.Next(0, 8), random.Next(0, 9)];

            if (!butacaRandom.Ocupado)
            {
                butacaRandom.OcuparAsiento();
                return "Ocupado asiento: " + butacaRandom.Asiento + " correctamente!" + Environment.NewLine;
            }
            else
            {
                for (int i = 0; i < tablaButacas.RowCount; i++)
                {
                    for (int j = 0; j < tablaButacas.ColumnCount; j++)
                    {
                        if (!arrayButacas[i, j].Ocupado)
                        {
                            butacaRandom = arrayButacas[i, j];
                            butacaRandom.OcuparAsiento();
                            return "Ocupado asiento: " + butacaRandom.Asiento + " correctamente!" + Environment.NewLine;
                        }
                    }
                }
                return "Butacas llenas!";
            }
        }
    }
}
