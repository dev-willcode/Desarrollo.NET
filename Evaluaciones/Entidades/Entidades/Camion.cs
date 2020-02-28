namespace Entidades.Entidades
{
    public class Camion
    {
        public Camion()
        {
        }

        public Camion(int id, string nombre, decimal peso_max, string estado, int numero_viajes)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso_max = peso_max;
            this.estado = estado;
            this.numero_viajes = numero_viajes;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public decimal peso_max { get; set; }
        public string estado { get; set; }
        public int numero_viajes { get; set; }
    }
}
