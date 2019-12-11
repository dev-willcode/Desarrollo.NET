using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebaCalendario.Clases
{
    class Compromisos
    {
        private string horaReunion;
        private string tipoReunion;
        private string lugarReunion;
        private DateTime fechaReunion;

        public Compromisos()
        {
        }

        public string HoraReunion { get => horaReunion; set => horaReunion = value; }
        public string TipoReunion { get => tipoReunion; set => tipoReunion = value; }
        public string LugarReunion { get => lugarReunion; set => lugarReunion = value; }
        public DateTime FechaReunion { get => fechaReunion; set => fechaReunion = value; }
    }
}
