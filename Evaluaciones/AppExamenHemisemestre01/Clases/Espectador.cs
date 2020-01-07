namespace AppExamenHemisemestre01.Clases
{
    class Espectador
    {
        private string nombre;
        private string cedula;
        private int edad;
        private char sexo;

        public Espectador()
        {
        }

        public Espectador(string nombre, string cedula, int edad, char sexo)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
    }
}
