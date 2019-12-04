using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces.Clases
{
    interface IFecha
    {
        int Dia();
        int Mes();
        string MesConLetra();
        int Ano();
    }
}
