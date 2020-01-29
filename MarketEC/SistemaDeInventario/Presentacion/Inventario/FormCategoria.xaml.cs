using System;
using System.Windows;
using Entidades.Inventario;
using Logica.Inventario;

namespace Presentacion.Inventario
{
    public partial class FormCategoria : Window
    {
        CategoriaLN categoriaLN = new CategoriaLN();
        private Categoria categoria;
        private string accion;
        private readonly AdminCategoria adminCategoria;

        public FormCategoria(AdminCategoria adminCategoria)
        {
            InitializeComponent();
            accion = "INSERTAR";
            this.adminCategoria = adminCategoria;
            labelID.Visibility = Visibility.Hidden;
            txtId.Visibility = Visibility.Hidden;
        }

        public FormCategoria(AdminCategoria adminCategoria, Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.adminCategoria = adminCategoria;
            accion = "EDITAR";
            rellenarCategoria();
        }

        private void rellenarCategoria()
        {
            txtId.Text = categoria.IdCategoria.ToString();
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
        }

        private void BtnCancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAceptar(object sender, RoutedEventArgs e)
        {
            try
            {
                if (accion.Equals("INSERTAR"))
                {
                    categoriaLN.CreateCategoria(construirCategoria());
                }
                else
                {
                    categoriaLN.UpdateCategoria(construirCategoria());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            adminCategoria.cargarListado();
            Close();
        }

        private Categoria construirCategoria()
        {
            Categoria categoria = new Categoria();
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtDescripcion.Text;
            if (accion.Equals("EDITAR"))
            {
                categoria.IdCategoria = int.Parse(txtId.Text);
            }

            return categoria;
        }
    }
}
