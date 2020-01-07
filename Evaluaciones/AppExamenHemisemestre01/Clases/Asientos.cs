using System.Windows.Forms;

namespace AppExamenHemisemestre01.Clases
{
    class Asientos
    {
        private string nombreAsiento;
        private bool estaOcupado;
        private Label etiqueta;

        public Asientos()
        {
            etiqueta = new Label();
            estaOcupado = false;
        }

        public string NombreAsiento { get => nombreAsiento; set => nombreAsiento = value; }
        public bool Ocupado { get => estaOcupado; set => estaOcupado = value; }
        public Label Etiqueta { get => etiqueta; set => etiqueta = value; }

        internal void OcuparAsiento()
        {
            etiqueta.BackColor = System.Drawing.Color.Green;
            estaOcupado = true;
        }

        internal void generarEtiqueta()
        {
            etiqueta.AutoSize = true;
            etiqueta.BackColor = System.Drawing.Color.DimGray;
            etiqueta.Dock = DockStyle.Fill;
            etiqueta.Size = new System.Drawing.Size(42, 34);
            etiqueta.Margin = new Padding(3, 3, 3, 3);
            etiqueta.Text = NombreAsiento;
            etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        public static Asientos buscarAsiento(FuncionCine funcion, string nombre)
        {
            Asientos[,] array = funcion.ArrayAsientos;
            Asientos asientos;
            for (int i = 0; i < AdminCine.FILAS; i++)
            {
                for (int j = 0; j < AdminCine.COLUMNAS; j++)
                {
                    asientos = array[i, j];
                    if (asientos.NombreAsiento.Equals(nombre))
                    {
                        return asientos;
                    }
                }
            }
            return null;
        }
    }
}
