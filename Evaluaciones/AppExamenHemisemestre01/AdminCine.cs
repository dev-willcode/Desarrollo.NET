using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppExamenHemisemestre01.Clases;

namespace AppExamenHemisemestre01
{
    public partial class AdminCine : Form
    {
        public const string ESTADO_CERRADO = "CERRADO";
        public const string ESTADO_EMISION = "EN CURSO";
        public const string ESTADO_ABIERTO = "ABIERTO";

        public const int FILAS = 8;
        public const int COLUMNAS = 9;

        public AdminCine()
        {
            InitializeComponent();
            cargarListas();
        }

        private void cargarListas()
        {
            listaEspectadores.Add(new Espectador("Will", "0700887516", 20, 'M'));
            listaEspectadores.Add(new Espectador("Carla", "07003247516", 16, 'F'));
            listaEspectadores.Add(new Espectador("Gabriela", "07676787516", 24, 'F'));

            listaPeliculas.Add(new Pelicula("AVENGERS: ENGAME", 180, 16, "Mark Russo", "ACCION, SUPERHEROES"));
            listaPeliculas.Add(new Pelicula("ANT MAN AND THE WASP", 180, 16, "Mark Russo", "ACCION, SUPERHEROES"));
            listaPeliculas.Add(new Pelicula("CAPITAN AMERICA Y EL SOLDADO DEL INIVERNO", 180, 16, "Mark Russo", "ACCION, SUPERHEROES"));
            listaPeliculas.Add(new Pelicula("CAPITAN AMERICA: CIVIL WAR", 180, 16, "Mark Russo", "ACCION, SUPERHEROES"));
        }

        private void btnAgregarFuncion_Click(object sender, EventArgs e)
        {
            FormFuncionCine form = new FormFuncionCine(listaFuncionesCine, listaPeliculas);
            form.ShowDialog();
        }

        private void btnAgregarEspectadores_Click(object sender, EventArgs e)
        {
            FormEspectador formEspectador = new FormEspectador(listaEspectadores);
            formEspectador.ShowDialog();
        }

        private void btnVentaBoleto_Click(object sender, EventArgs e)
        {
            if (tablaFunciones.CurrentRow != null)
            {
                int indice = tablaFunciones.CurrentRow.Index;
                FuncionCine funcion = (FuncionCine)listaFuncionesCine[indice];
                if (funcion.EstadoPelicula.Equals(ESTADO_ABIERTO))
                {
                    FormAdminSalaCine salaCine = new FormAdminSalaCine(funcion, listaEspectadores);
                    salaCine.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La función ya está cerrada!");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una funcion de cine para agregar boletos!");
            }
        }

        private void btnMasEspectadores_Click(object sender, EventArgs e)
        {
            if (listaFuncionesCine.Count > 0)
            {
                IList<FuncionCine> listado = new List<FuncionCine>();

                for (int i = 0; i < listaFuncionesCine.Count; i++)
                {
                    listado.Add((FuncionCine)listaFuncionesCine.List[i]);
                }

                IOrderedEnumerable<FuncionCine> sql = from s in listado
                                                      orderby s.NumeroEspectadores descending
                                                      select s;

                MessageBox.Show("La pelicula con más espectadores fue: " + Environment.NewLine +
                    sql.ToList()[0].Pelicula.Titulo);
            }
            else
            {
                MessageBox.Show("No hay funciones de peliculas!");
            }
        }

        private void btnTotalRecaudado_Click(object sender, EventArgs e)
        {
            if (tablaFunciones.CurrentRow != null)
            {
                int indice = tablaFunciones.CurrentRow.Index;
                FuncionCine funcion = (FuncionCine)listaFuncionesCine[indice];
                MessageBox.Show("Pelicula: " + funcion.Pelicula.Titulo + Environment.NewLine +
                    "Espectadores: " + funcion.NumeroEspectadores.ToString() + Environment.NewLine +
                    " Precio: " + funcion.PrecioEntrada.ToString() + Environment.NewLine +
                    "Total recaudado: " + (funcion.PrecioEntrada * funcion.NumeroEspectadores));
            }
            else
            {
                MessageBox.Show("No ha seleccionado una función de pelicula!");
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            String result = "PORNCENTAJE DE PELICULAs" + Environment.NewLine;
            FuncionCine funcion;
            double acumulado = 0;
            if (listaFuncionesCine.Count > 0)
            {
                for (int i = 0; i < listaFuncionesCine.Count; i++)
                {
                    funcion = (FuncionCine)listaFuncionesCine[i];
                    acumulado += funcion.NumeroEspectadores;
                }
                for (int i = 0; i < listaFuncionesCine.Count; i++)
                {
                    funcion = (FuncionCine)listaFuncionesCine[i];
                    result += "Pelicula: " + funcion.Pelicula.Titulo + Environment.NewLine +
                        "Porcentaje de vistas:" + Math.Round((((funcion.NumeroEspectadores + 0.00) / acumulado) * 100), 2).ToString()
                        + " % " + Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                result += "No hay funciones de peliculas para mostrar";
            }

            MessageBox.Show(result);
        }
    }
}
