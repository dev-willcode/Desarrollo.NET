using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlquilerAutomoviles.Modelos
{
    class Alquiler
    {
        private string cliente;
        private char modeloVehiculo;
        private DateTime fechaEntrega;
        private DateTime fechaDevolucion;
        private int dias;
        private double importe;
        private double descuento;
        private double importeTotal;

        public Alquiler()
        {
        }

        public Alquiler(string cliente, char modeloVehiculo, DateTime fechaEntrega, DateTime fechaDevolucion)
        {
            this.cliente = cliente;
            this.modeloVehiculo = modeloVehiculo;
            this.fechaEntrega = fechaEntrega;
            this.fechaDevolucion = fechaDevolucion;
            calcularDatosInternos();

        }

        private void calcularDatosInternos()
        {
            // Un dia por defecto, si las fechas son iguales.
            if (this.fechaEntrega.Equals(this.fechaDevolucion)) this.dias = 1;
            else
            {
                TimeSpan tiempoEntre = this.FechaDevolucion - this.fechaEntrega;
                this.dias = tiempoEntre.Days;
            }

            importe = this.dias * devolverTarifa(this.modeloVehiculo);
            if (this.dias > 15) this.descuento = Math.Round(importe * 0.10, 2);
            else descuento = 0.00;
            this.importeTotal = this.importe - this.descuento;
        }

        private double devolverTarifa(char modeloVehiculo)
        {
            foreach (Tarifas item in Tlista.tarifas)
            {
                if (item.Modelo == modeloVehiculo)
                    return item.Precio;
            }
            return 1;
        }

        public string Cliente { get => cliente; set => cliente = value; }
        public char ModeloVehiculo { get => modeloVehiculo; set => modeloVehiculo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int Dias { get => dias; set => dias = value; }
        public double Importe { get => importe; set => importe = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }
    }
}
