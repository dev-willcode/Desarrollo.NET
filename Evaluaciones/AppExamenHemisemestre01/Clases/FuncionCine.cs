using System;

namespace AppExamenHemisemestre01.Clases
{
    public class FuncionCine
    {
        private string nombrePelicula;
        private DateTime diaFuncion;
        private string horaFuncion;
        private Pelicula pelicula;
        private double precioEntrada;
        private string estadoPelicula;

        private Asientos[,] arrayAsientos;
        private int numeroEspectadores;

        public FuncionCine()
        {
            generarMatrizAsientos();
            numeroEspectadores = 0;
        }
        public void generarMatrizAsientos()
        {
            int letra;
            Asientos asiento;
            ArrayAsientos = new Asientos[AdminCine.FILAS, AdminCine.COLUMNAS];
            int numeroFila = AdminCine.FILAS;

            for (int i = 0; i < AdminCine.FILAS; i++)
            {
                letra = 65;
                for (int j = 0; j < AdminCine.COLUMNAS; j++)
                {
                    asiento = new Asientos();
                    asiento.NombreAsiento = ((char)letra++) + numeroFila.ToString();
                    ArrayAsientos[i, j] = asiento;
                    asiento.Etiqueta.Click += new EventHandler(FormAdminSalaCine.click_asiento);
                    asiento.generarEtiqueta();
                }
                --numeroFila;
            }
        }
        public DateTime DiaFuncion { get => diaFuncion; set => diaFuncion = value; }
        public string HoraFuncion { get => horaFuncion; set => horaFuncion = value; }
        public double PrecioEntrada { get => precioEntrada; set => precioEntrada = value; }
        public string EstadoPelicula { get => estadoPelicula; set => estadoPelicula = value; }
        public string NombrePelicula { get => nombrePelicula; set => nombrePelicula = value; }
        internal Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        internal Asientos[,] ArrayAsientos { get => arrayAsientos; set => arrayAsientos = value; }
        public int NumeroEspectadores { get => numeroEspectadores; set => numeroEspectadores = value; }
    }
}
