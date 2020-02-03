namespace Entidades.Inventario
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre;
        private string detalle;

        public Categoria()
        {
        }

        public Categoria(int idCategoria, string nombre, string detalle)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Detalle = detalle;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
