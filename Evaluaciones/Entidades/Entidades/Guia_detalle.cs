namespace Entidades.Entidades
{
    public class Guia_detalle
    {
        public Guia_detalle()
        {
        }

        public Guia_detalle(int id_encomienda, int id_guia)
        {
            this.id_encomienda = id_encomienda;
            this.id_guia = id_guia;
        }

        public int id_encomienda { get; set; }
        public int id_guia { get; set; }
    }
}
