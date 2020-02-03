namespace Entidades.Facturacion
{
    public class Transportista
    {
        public Transportista()
        {
        }

        public Transportista(string idTransportista, string cedTransportista, string nombre, string direccion, string ciudad, string telefono)
        {
            IdTransportista = idTransportista;
            CedTransportista = cedTransportista;
            Nombre = nombre;
            Direccion = direccion;
            Ciudad = ciudad;
            Telefono = telefono;
        }

        public string IdTransportista { get; set; }
        public string CedTransportista { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
    }
}
