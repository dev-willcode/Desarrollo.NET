namespace pruebaPractica03.Clases
{
    class Cliente
    {
        private string nombre;
        private int edad;
        private double dinero;

        public Cliente()
        {
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
    }
}
