namespace Datos.Facturacion
{
    public class Local
    {
        private int idLocal;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string fax;

        public Local()
        {
        }

        public Local(int idLocal, string direccion, string ciudad, string telefono, string fax)
        {
            IdLocal = idLocal;
            Direccion = direccion;
            Ciudad = ciudad;
            Telefono = telefono;
            Fax = fax;
        }

        public int IdLocal { get => idLocal; set => idLocal = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
    }
}
