using AppRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01
{
    public partial class Principal : Form
    {
        public BindingSource enlaceOrigen = new BindingSource();
        public BindingSource enlaceDestino = new BindingSource();
        public Principal()
        {
            InitializeComponent();
            crearIngredientes();
            establecerListeners();
        }
        private void crearIngredientes()
        {
            enlaceOrigen.DataSource = new List<Ingrediente>()
            {
                new Ingrediente("Ajo", 1.20),
                new Ingrediente("Salami", 3.10),
                new Ingrediente("Cebolla", 1.40),
                new Ingrediente("Tomate", 1.10),
                new Ingrediente("Tocino", 2.50),
                new Ingrediente("Extra queso", 2.00),
                new Ingrediente("Extra salsa", 1.50)
            };
            enlaceDestino.DataSource = new List<Ingrediente>();
            // Propiedades de las listbox´s
            listboxDestino.DataSource = enlaceDestino;
            listboxOrigen.DataSource = enlaceOrigen;
        }

        private void establecerListeners()
        {
            enlaceOrigen.ListChanged += new ListChangedEventHandler(cambioListaOrigen);
            enlaceDestino.ListChanged += new ListChangedEventHandler(cambioListaDestino);
            rbLlevar.CheckedChanged += new EventHandler(EventoParaLlevar);
        }

        private void cambioListaOrigen(object sender, ListChangedEventArgs args)
        {
            if (enlaceOrigen.Count == 0) btnAnadir.Enabled = false;
            else btnAnadir.Enabled = true;
        }

        private void cambioListaDestino(object sender, ListChangedEventArgs args)
        {
            if (enlaceDestino.Count == 0) btnQuitar.Enabled = false;
            else btnQuitar.Enabled = true;

        }

        private void EventoParaLlevar(object sender, EventArgs e)
        {
            if (!rbLlevar.Checked)
            {
                chPlastico.Enabled = false;
                chAluminio.Enabled = false;
                chIsopo.Enabled = false;
                chPlastico.Checked = false;
                chAluminio.Checked = false;
                chIsopo.Checked = false;
            }
            else
            {
                chPlastico.Enabled = true;
                chAluminio.Enabled = true;
                chIsopo.Enabled = true;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = (Ingrediente)listboxOrigen.SelectedItem;
            enlaceDestino.Add(ingrediente);
            enlaceOrigen.Remove(ingrediente);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = (Ingrediente)listboxDestino.SelectedItem;
            enlaceOrigen.Add(ingrediente);
            enlaceDestino.Remove(ingrediente);
        }

        private void btnNuevoPlato_Click(object sender, EventArgs e)
        {
            //Limpiar todo
            txtCliente.Clear();
            txtTotal.Clear();
            rbComerAqui.Checked = true;
            chJugo.Checked = false;
            chGaseosa.Checked = false;
            chCerveza.Checked = false;
            chVino.Checked = false;
            foreach (Ingrediente ingrediente in enlaceDestino)
                enlaceOrigen.Add(ingrediente);
            enlaceDestino.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length == 0) MessageBox.Show("Verifique que ha ingresado un cliente!");
            else if (enlaceDestino.Count == 0) MessageBox.Show("No hay ingredientes seleccionados, seleccione alguno!");
            else
            {
                double precioTotal = 0;
                foreach (Ingrediente ingrediente in enlaceDestino) 
                    precioTotal += ingrediente.PrecioIngrediente;
                
                // Envases
                if (rbLlevar.Checked)
                {
                    precioTotal += 0.25; // Costo agregado para llevar
                    if (chPlastico.Checked) precioTotal += 1.00;
                    if (chAluminio.Checked) precioTotal += 1.50;
                    if (chIsopo.Checked) precioTotal += 0.50;
                }

                //Bebidas
                if (chJugo.Checked) precioTotal += 1.20;
                if (chGaseosa.Checked) precioTotal += 1.80;
                if (chCerveza.Checked) precioTotal += 2.50;
                if (chVino.Checked) precioTotal += 5.40;

                txtTotal.Text = precioTotal.ToString();
            }
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            PlatoEspecial platoEspecial = new PlatoEspecial(enlaceDestino);
            platoEspecial.ShowDialog();
        }
    }
}
