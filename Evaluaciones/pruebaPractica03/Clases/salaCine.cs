namespace pruebaPractica03.Clases
{
    class salaCine
    {
        private string peliculaActual;
        private double precioEntrada;

        public salaCine()
        {
        }
        public string PeliculaActual { get => peliculaActual; set => peliculaActual = value; }
        public double PrecioEntrada { get => precioEntrada; set => precioEntrada = value; }
    }
}
