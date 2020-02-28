namespace Entidades.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int id, string cedula, string nombres, string telefono, string direccion)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombres = nombres;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int id { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
    }
}
