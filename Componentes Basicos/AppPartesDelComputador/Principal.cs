using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPartesDelComputador
{
    public partial class Principal : Form
    {
        BindingSource bsDisco = new BindingSource();
        BindingSource bsAccesorios = new BindingSource();
        List<String> listaProcesadores;
        List<String> listaMemoria;
        public Principal()
        {
            InitializeComponent();
            generarListados();
        }

        private void generarListados()
        {
            listaProcesadores = new List<String>()
            {
                "Procesador ELESTRA",
                "Procesador SXM",
                "Procesador EMPTION",
                "Procesador MDA"
            };  
            listaMemoria = new List<String>()
            {
                "Memoria 512 GB",
                "Memoria 1 TB",
                "Memoria 4 TB",
                "Memoria 16 TB"
            };
            bsAccesorios.DataSource = new List<String>()
            {
                "Teclado",
                "Ratón",
                "Micrófono"
            };
            bsDisco.DataSource = new List<String>()
            {
                "disco IDE",
                "disco SATA"
            };
            comboDisco.DataSource = bsDisco;
            chAccesorios.DataSource = bsAccesorios;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String cadena = "";
            
            if (rbElestra.Checked) cadena += listaProcesadores[0];
            else if (rbSXM.Checked) cadena += listaProcesadores[1];
            else if (rbEption.Checked) cadena += listaProcesadores[2];
            else if (rbMDA.Checked) cadena += listaProcesadores[3];
            cadena += ",\n";

            if (rb512gb.Checked) cadena += listaMemoria[0];
            else if (rb1tb.Checked) cadena += listaMemoria[1];
            else if (rb4tb.Checked) cadena += listaMemoria[2];
            else if (rb16tb.Checked) cadena += listaMemoria[3];
            cadena += ",\n";

            if (chRaid.Checked) cadena += chRaid.Text +",\n";
            if (chVideo.Checked) cadena += chRaid.Text + ",\n";
            cadena += comboDisco.SelectedItem + ",\n";

            if (chAccesorios.CheckedItems.Count != 0)
            {
                foreach (String accesorio in chAccesorios.CheckedItems)
                    cadena += accesorio + ",\n";
                txtGuardadas.Text = cadena.Substring(0, cadena.Length - 2);
            } else 
                MessageBox.Show("Añada como mínimo un accesorio!");
        }
    }
}
