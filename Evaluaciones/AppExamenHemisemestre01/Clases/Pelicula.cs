namespace AppExamenHemisemestre01.Clases
{
    public class Pelicula
    {
        private string titulo;
        private double duracion;
        private int edadMinima;
        private string director;
        private string tipoPelicula;

        public Pelicula()
        {
        }

        public Pelicula(string titulo, double duracion, int edadMinima, string director, string tipoPelicula)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
            this.tipoPelicula = tipoPelicula;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Director { get => director; set => director = value; }
        public string TipoPelicula { get => tipoPelicula; set => tipoPelicula = value; }
    }
}
