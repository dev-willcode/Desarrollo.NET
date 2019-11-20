using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsumoElectrico.Clases
{
    class ConsumoElectrico
    {
        private string cedula;
        private string nombre;
        private string direccion;
        private string numeroMedidor;
        private double consumo;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NumeroMedidor { get => numeroMedidor; set => numeroMedidor = value; }
        public double Consumo { get => consumo; set => consumo = value; }

        public double calcularConsumo()
        {
            double pago = 0;
            if (consumo <= 100) pago += 0.10 * consumo;
            else if (consumo <= 200) pago += (0.10 * 100) + (0.12 * (consumo - 100));
            else pago += (0.10 * 100) + (0.12 * 100) + (0.15 * (consumo - 200));

            return pago;
        }
    }
}
