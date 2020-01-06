using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPOOPractica2.Entidades;

namespace AppPOOPractica2.Controlador
{
    class TLista
    {
        public static List<Empleado> listaEmpleados = new List<Empleado>();
        public static List<Empleado> listaEmpleadosF = new List<Empleado>();

        public static void Insertar(Empleado oe)
        {
            listaEmpleados.Add(oe);
        }
        public static void Editar(Empleado oe, int pos)
        {
            listaEmpleados[pos] = oe;
        }
        public static void Eliminar(int pos)
        {
            listaEmpleados.Remove(listaEmpleados.ElementAtOrDefault(pos));
        }
        public static int BuscarDato(string clave)
        {
            int pos = -1;
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Cedula.Equals(clave))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static string ImprimirLista()
        {
            string men = "";
            foreach (Empleado oe in listaEmpleados)
            {
                men += oe.Imprimir() + "\n";
            }
            return men;
        }

        public static Empleado GetEmpleado(int pos)
        {
            return listaEmpleados.ElementAtOrDefault(pos);
        }

        public static string PorcentGenero()
        {
            int numM = 0;
            int numF = 0;
            foreach (Empleado oe in listaEmpleados)
            {
                if (oe.Sexo == 'M')
                    numM++;
                else
                    numF++;
            }
            numM = numM * 100 / listaEmpleados.Count;
            numF = numF * 100 / listaEmpleados.Count;
            return "Porcentaje de hombres: " + numM + "%\nPorcentaje de mujeres: " + numF + "%";
        }
        public static string PorcentTipoEmp()
        {
            int numAsalaria = 0;
            int numComision = 0;
            int numPorHoras = 0;
            int numBasComis = 0;
            int numPorPieza = 0;
            foreach (Empleado oe in listaEmpleados)
            {
                if (oe.Tipo.Equals("Asalariado"))
                    numAsalaria++;
                else if (oe.Tipo.Equals("Por Horas"))
                    numPorHoras++;
                else if (oe.Tipo.Equals("Comision"))
                    numComision++;
                else if (oe.Tipo.Equals("Base + Comision"))
                    numBasComis++;
                else if (oe.Tipo.Equals("Por Piezas"))
                    numPorPieza++;
            }
            numAsalaria = numAsalaria * 100 / listaEmpleados.Count;
            numPorHoras = numPorHoras * 100 / listaEmpleados.Count;
            numComision = numComision * 100 / listaEmpleados.Count;
            numBasComis = numBasComis * 100 / listaEmpleados.Count;
            numPorPieza = numPorPieza * 100 / listaEmpleados.Count;
            return "Porcentaje E. Asalariados: " + numAsalaria +
                "%\nPorcentaje E. Por Horas: " + numPorHoras +
                "%\nPorcentaje E. Por Comision: " + numComision +
                "%\nPorcentaje E. Base + Comision: " + numBasComis +
                "%\nPorcentaje E. Por Piezas: " + numPorPieza +"%";
        }

        internal static void FiltrarEmpleados(string tipo)
        {
            foreach (Empleado oe in listaEmpleados)
            {
                if (oe.Tipo.Equals(tipo))
                    listaEmpleadosF.Add(oe);
                
            }
        }

        public static string ListEmpMayorEdad()
        {
            string men = "";
            foreach (Empleado oe in listaEmpleados)
            {
                if (oe.Edad > 17)
                    men+= oe.Imprimir() + "\n\n";
            }
            return men;
        }
    }
}
