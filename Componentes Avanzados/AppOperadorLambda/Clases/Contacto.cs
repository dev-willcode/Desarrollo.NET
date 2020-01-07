namespace AppOperadorLambda.Clases
{
    class Contacto
    {
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string sexo;
        private string ciudad;
        private int edad;

        public Contacto(string nombre, string apellido, string email, string telefono, string sexo, string ciudad, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.sexo = sexo;
            this.ciudad = ciudad;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
