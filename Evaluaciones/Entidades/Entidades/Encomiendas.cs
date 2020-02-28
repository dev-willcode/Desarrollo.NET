namespace Entidades.Entidades
{
    public class Encomiendas
    {
        public Encomiendas()
        {
        }

        public Encomiendas(int id, int id_cliente, string codigo, decimal peso, string direccion, decimal costo_envio, string estado)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.codigo = codigo;
            this.peso = peso;
            this.direccion = direccion;
            this.costo_envio = costo_envio;
            this.estado = estado;
        }

        public int id { get; set; }
        public int id_cliente { get; set; }
        public string codigo { get; set; }
        public decimal peso { get; set; }
        public string direccion { get; set; }
        public decimal costo_envio { get; set; }
        public string estado { get; set; }
    }
}
