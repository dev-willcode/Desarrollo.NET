using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAbstractas.Clases
{
    class EmpleadoPorPiezas : Empleado
    {
        private double sueldo;
        private int piezas;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int Piezas { get => piezas; set => piezas = value; }

        public override double calcularSueldo()
        {
            return sueldo * piezas;
        }

        public override void imprimir()
        {
            MessageBox.Show("Sueldo a percibir: " + calcularSueldo());
        }
    }
}
