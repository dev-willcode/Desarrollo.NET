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
        BindingSource enlaceOrigen = new BindingSource();
        BindingSource enlaceDestino = new BindingSource();
        public Principal()
        {
            InitializeComponent();
            crearIngredientes();
            establecerListeners();
        }
        private void crearIngredientes()
        {
            List<Ingrediente> listaIngredientesDestino = new List<Ingrediente>();
            List<Ingrediente> listaIngredientesOrigen = new List<Ingrediente>()
            {
                new Ingrediente("Ajo", 1.20),
                new Ingrediente("Salami", 3.10),
                new Ingrediente("Cebolla", 1.40),
                new Ingrediente("Tomate", 1.10),
                new Ingrediente("Tocino", 2.50),
                new Ingrediente("Extra queso", 2.00),
                new Ingrediente("Extra salsa", 1.50)
            };
            // Propiedades de las listbox´s
            listboxDestino.DisplayMember = "NombreIngrediente";
            listboxOrigen.DisplayMember = "NombreIngrediente";
            enlaceOrigen.DataSource = listaIngredientesOrigen;
            enlaceDestino.DataSource = listaIngredientesDestino;
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
    }
}
