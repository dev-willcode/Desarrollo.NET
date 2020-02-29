namespace Entidades.Entidades
{
    public class CabeceraDetalle
    {
        public CabeceraDetalle()
        {
        }

        public CabeceraDetalle(int id_guia, string codigo, decimal peso, string direccion, decimal costo_envio)
        {
            this.id_guia = id_guia;
            this.codigo = codigo;
            this.peso = peso;
            this.direccion = direccion;
            this.costo_envio = costo_envio;
        }

        public int id_guia { get; set; }
        public string codigo { get; set; }
        public decimal peso { get; set; }
        public string direccion { get; set; }
        public decimal costo_envio { get; set; }
    }
}
