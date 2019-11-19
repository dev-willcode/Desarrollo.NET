using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturaComputador
{
    public partial class Form1 : Form
    {
        BindingSource bsMonitores = new BindingSource();
        BindingSource bsAccesorios = new BindingSource();
        List<ComponenteElectronico> listaProcesadores;
        List<ComponenteElectronico> listaMemoria;
        public Form1()
        {
            InitializeComponent();
            generarListados();
        }

        private void generarListados()
        {
            listaProcesadores = new List<ComponenteElectronico>()
            {
                new ComponenteElectronico("Procesador P4",200.50),
                new ComponenteElectronico("Procesador AMD",320.00),
                new ComponenteElectronico("Procesador DualCore",360.50),
                new ComponenteElectronico("Procesador Core 2 DUO",380.20)
            };
            listaMemoria = new List<ComponenteElectronico>()
            {
                new ComponenteElectronico("Memoria 256MB",20.00),
                new ComponenteElectronico("Memoria 512MB",35.00),
                new ComponenteElectronico("Memoria 1GB",48.75),
                new ComponenteElectronico("Memoria 2GB",78.99)
            };
            bsMonitores.DataSource = new List<ComponenteElectronico>()
            {
                new ComponenteElectronico("Acer R241YWMID",200.50),
                new ComponenteElectronico("Asus VZ249HE",380.00),
                new ComponenteElectronico("Samsung C24F390",520.00),
                new ComponenteElectronico("Dell P2319H",200.00),
                new ComponenteElectronico("BenQ GW2780",180.50),
                new ComponenteElectronico("ViewSonic VG2437Smc",228.90),
                new ComponenteElectronico("Dell 2417H",199.99),
                new ComponenteElectronico("BenQ EX3200R",500.20),
                new ComponenteElectronico("Asus MB16AP",400.80)
            };
            bsAccesorios.DataSource = new List<ComponenteElectronico>()
            {
                new ComponenteElectronico("Tarjeta de video", 80.20),
                new ComponenteElectronico("Tarjeta de sonido 5.1", 120.10),
                new ComponenteElectronico("Parlantes 5.1", 35.40)
            };
            comboMonitor.DataSource = bsMonitores;
            chAccesorios.DataSource = bsAccesorios;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ComponenteElectronico procesadorSeleccionado = DevolverProveedorSeleccionado();
            ComponenteElectronico memoriaSeleccionada = DevolverMemoriaSeleccionada();
            ComponenteElectronico monitorSeleccionado = (ComponenteElectronico)comboMonitor.SelectedItem;
            double subtotal = 0;
            double iva = 0;

            subtotal += procesadorSeleccionado.PrecioComponente();
            subtotal += memoriaSeleccionada.PrecioComponente();
            subtotal += monitorSeleccionado.PrecioComponente();
            iva += procesadorSeleccionado.IVAComponente();
            iva += memoriaSeleccionada.IVAComponente();
            iva += monitorSeleccionado.IVAComponente();

            foreach (ComponenteElectronico accesorio in chAccesorios.CheckedItems)
            {
                subtotal += accesorio.PrecioComponente();
                iva += accesorio.IVAComponente();
            }
            txtSubtotal.Text = subtotal.ToString();
            txtIVA.Text = iva.ToString();
            txtTotal.Text = (subtotal + iva).ToString();
        }

        private ComponenteElectronico DevolverProveedorSeleccionado()
        {
            if (rbP4.Checked) return listaProcesadores[0];
            else if (rbAMD.Checked) return listaProcesadores[1];
            else if (rbDualCore.Checked) return listaProcesadores[2];
            else if (rbCoreDuo.Checked) return listaProcesadores[3];
            return null;
        }

        private ComponenteElectronico DevolverMemoriaSeleccionada()
        {
            if (rb256mb.Checked) return listaMemoria[0];
            else if (rb512mb.Checked) return listaMemoria[1];
            else if (rb1gb.Checked) return listaMemoria[2];
            else if (rb2gb.Checked) return listaMemoria[3];
            return null;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            ComponenteElectronico procesadorSeleccionado = DevolverProveedorSeleccionado();
            ComponenteElectronico memoriaSeleccionada = DevolverMemoriaSeleccionada();
            ComponenteElectronico monitorSeleccionado = (ComponenteElectronico)comboMonitor.SelectedItem;
            tblFactura.Rows.Clear();

            tblFactura.Rows.Add(new String[] { "1",
                procesadorSeleccionado.NombreComponente(),
                procesadorSeleccionado.PrecioComponente().ToString(),
                procesadorSeleccionado.IVAComponente().ToString()});

            tblFactura.Rows.Add(new String[] { "1",
                memoriaSeleccionada.NombreComponente(),
                memoriaSeleccionada.PrecioComponente().ToString(),
                memoriaSeleccionada.IVAComponente().ToString()});

            tblFactura.Rows.Add(new String[] { "1",
                monitorSeleccionado.NombreComponente(),
                monitorSeleccionado.PrecioComponente().ToString(),
                monitorSeleccionado.IVAComponente().ToString()});

            foreach (ComponenteElectronico accesorio in chAccesorios.CheckedItems)
            {
                tblFactura.Rows.Add(new String[] { "1",
                    accesorio.NombreComponente(),
                    accesorio.PrecioComponente().ToString(),
                    accesorio.IVAComponente().ToString()});
            }
        }
    }
}
