using AppWinPrácticaLab01Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinPrácticaLab01Banco.Controlador
{
    class ListaCuenta
    {
        public static List<Cuenta> listaCuenta = new List<Cuenta>();

        public static void Insertar(Cuenta oe)
        {
            listaCuenta.Add(oe);

        }
        
        public static int BuscarDato(int num)
        {
            int pos = -1;
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].Numero == num)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Cuenta GetCuenta(int pos)
        {
            return listaCuenta.ElementAtOrDefault(pos);
        }

        public static Cuenta mejorCuenta(string tipo)
        {
            Cuenta oC = null;
            double mayor = 0;
            for (int i = 0; i < listaCuenta.Count; i++)
            {
                if (listaCuenta[i].Tipo.Equals(tipo) && listaCuenta[i].Saldo > mayor)
                {
                    oC = listaCuenta[i];
                    mayor = listaCuenta[i].Saldo;
                }
            }
            return oC;
        }     
    }
}
