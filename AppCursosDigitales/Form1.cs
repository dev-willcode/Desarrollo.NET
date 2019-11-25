using AppCursosDigitales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppCursosDigitales
{
    public partial class Form1 : Form
    {
        private List<Curso> cursoDiseno;
        private List<Curso> cursoIngenieria;
        private List<Curso> cursoEconomia;
        public Form1()
        {
            InitializeComponent();
            inicializarListado();
            establecerListeners();
        }

        private void establecerListeners()
        {
            bsCursoOfertado.ListChanged += new ListChangedEventHandler(eventoListaOfertado);
            bsCursoSeleccionado.ListChanged += new ListChangedEventHandler(eventoListaSeleccionado);
        }

        private void eventoListaOfertado(object sender, ListChangedEventArgs e)
        {
            if (ofertado.Items.Count == 0) btnAgregar.Enabled = false;
            else btnAgregar.Enabled = true;
        }

        private void eventoListaSeleccionado(object sender, ListChangedEventArgs e)
        {
            if (seleccionado.Items.Count == 0) btnEliminar.Enabled = false;
            else btnEliminar.Enabled = true;
        }

        private void inicializarListado()
        {
            cursoDiseno = new List<Curso>()
            {
                new Curso("Diseño gráfico","Corel Draw", 180),
                new Curso("Diseño gráfico","Photoshop", 200)
            };
            cursoIngenieria = new List<Curso>()
            {
            new Curso("Ingeniería","Matematicas discretas", 210),
            new Curso("Ingeniería","Metodos numéricos", 190),
            new Curso("Ingeniería","Analisis matemático", 150)
            };
            cursoEconomia = new List<Curso>()
            {
            new Curso("Economía","Probabilidad & Estadística", 120),
            new Curso("Economía","Probabilidad & Estadística II", 230),
            new Curso("Economía","Educación financiera", 210),
            new Curso("Economía","Profesional EXCEL 2003", 300)
            };
            comboCategoria.SelectedIndex = 0;
            comboFormaPago.SelectedIndex = 0;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtTotal.Clear();
            txtMensual.Clear();
        }

        private void eventoCambioCategoria(object sender, EventArgs e)
        {
            switch (comboCategoria.SelectedIndex)
            {
                case 0:
                    bsCursoOfertado.DataSource = cursoDiseno;
                    break;
                case 1:
                    bsCursoOfertado.DataSource = cursoIngenieria;
                    break;
                case 2:
                    bsCursoOfertado.DataSource = cursoEconomia;
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Curso curso = (Curso)ofertado.SelectedItem;
            bsCursoSeleccionado.Add(curso);
            bsCursoOfertado.Remove(curso);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Curso curso = (Curso)seleccionado.SelectedItem;
            switch (curso.Categoria)
            {
                case "Diseño gráfico":
                    comboCategoria.SelectedIndex = 0;
                    break;
                case "Ingeniería":
                    comboCategoria.SelectedIndex = 1;
                    break;
                case "Economía":
                    comboCategoria.SelectedIndex = 2;
                    break;
            }
            bsCursoOfertado.Add(curso);
            bsCursoSeleccionado.Remove(curso);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String errores = "";
            if (txtNombre.Text.Length == 0)
                errores += " - Ingrese un nombre valido!";
            if (bsCursoSeleccionado.List.Count == 0)
                errores += " - Debe seleccionar como mínimo un curso";
            if (errores.Length > 0) MessageBox.Show(errores);
            else
            {
                double total = 0;
                double matricula;
                foreach (Curso curso in bsCursoSeleccionado)
                    total += curso.Costo;

                if (bsCursoSeleccionado.List.Count == 1) matricula = total * 0.8;
                else if (bsCursoSeleccionado.List.Count == 2) matricula = total * 0.6;
                else matricula = total * 0.5;

                if (comboFormaPago.SelectedItem.ToString().Equals("CONTADO"))
                {
                    total = total - (total * 0.10);
                    txtMensual.Text = "0.00";
                }
                else
                {
                    total = total + (total * 0.10);
                    txtMensual.Text = (total / 4).ToString();
                }
                txtTotal.Text = total.ToString();
                txtMatricula.Text = matricula.ToString();
            }
        }
    }
}
