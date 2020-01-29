using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using Entidades.Inventario;
using Logica.Inventario;

namespace Presentacion.Inventario
{
    public partial class AdminCategoria : Window
    {
        CategoriaLN categoriaLN = new CategoriaLN();
        public AdminCategoria()
        {
            InitializeComponent();
            cargarListado();
        }

        public void cargarListado()
        {
            ((CollectionViewSource)FindResource("categoriaViewSource")).Source = categoriaLN.MostrarCategoria();
        }

        public void cargarListado(string filtro)
        {
            ((CollectionViewSource)FindResource("categoriaViewSource")).Source = categoriaLN.MostrarCategoriaFitro(filtro);
        }

        private void BtnAnadir(object sender, RoutedEventArgs e)
        {
            FormCategoria form = new FormCategoria(this);
            form.ShowDialog();
        }

        private void BtnModificar(object sender, RoutedEventArgs e)
        {
            Categoria categoria = CapturarSeleccionado();
            if (categoria != null)
            {
                FormCategoria form = new FormCategoria(this, categoria);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No ha selecionado ningun item!");
            }
        }

        private Categoria CapturarSeleccionado()
        {
            Categoria categoria = null;
            if (categoriaDataGrid.SelectedItem != null)
            {
                categoria = categoriaDataGrid.SelectedItem as Categoria;
            }
            return categoria;
        }

        private void BtnEliminar(object sender, RoutedEventArgs e)
        {
            try
            {
                categoriaLN.DeleteCategoriar(CapturarSeleccionado());
                cargarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void evento_filtrar(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                cargarListado(txtFiltro.Text);
            } else
            {
                cargarListado();
            }
        }
    }
}
