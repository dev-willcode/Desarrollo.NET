using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlquilerAutomoviles.Modelos
{
    class Tlista
    {
        public static List<Tarifas> tarifas = new List<Tarifas>();
        public static IList<Cliente> clientes = new List<Cliente>();
        public static Cliente obtenerMayor()
        {
            var sql = from s in clientes 
                      orderby s.VehiculosAlquilados descending
                      select s;
            return sql.ToList()[0];
        }
    }
}
