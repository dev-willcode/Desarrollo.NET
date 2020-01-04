namespace pruebaPractica03.Clases
{
    class pelicula
    {
        private string titulo;
        private double duracion;
        private int edadMinima;
        private string director;

        public pelicula()
        {
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Director { get => director; set => director = value; }
    }
}
