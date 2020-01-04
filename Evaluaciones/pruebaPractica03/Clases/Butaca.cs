using System;
using System.Windows.Forms;

namespace pruebaPractica03.Clases
{
    class Butaca
    {
        private string asiento;
        private bool estaOcupado;
        private Label etiqueta;

        public Butaca()
        {
            etiqueta = new Label();
            estaOcupado = false;
        }

        public string Asiento { get => asiento; set => asiento = value; }
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
            etiqueta.Text = this.Asiento;
            etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}
