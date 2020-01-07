using System;
using System.Windows.Forms;
using AppExamenHemisemestre01.Clases;

namespace AppExamenHemisemestre01
{
    public partial class FormAdminSalaCine : Form
    {
        public static FuncionCine funcion;
        private BindingSource listaEspectadores;

        public FormAdminSalaCine(FuncionCine funcionCine, BindingSource listaEspectadores)
        {
            funcion = funcionCine;
            this.listaEspectadores = listaEspectadores;
            InitializeComponent();
            comboEspectadores.DataSource = listaEspectadores;
            PintarInformacionFuncion();

        }

        private void PintarInformacionFuncion()
        {
            txtTitulo.Text = funcion.NombrePelicula;
            txtDia.Text = funcion.DiaFuncion.Date.ToString();
            txtHora.Text = funcion.HoraFuncion;
            txtPrecio.Text = funcion.PrecioEntrada.ToString();
            txtAsiento.Text = "NINGUNO";
            pintarArrayAsientos();
        }

        private void pintarArrayAsientos()
        {
            Asientos[,] array = funcion.ArrayAsientos;
            Asientos asiento;
            for (int i = 0; i < AdminCine.FILAS; i++)
            {
                for (int j = 0; j < AdminCine.COLUMNAS; j++)
                {
                    asiento = array[i, j];
                    tablaAsientos.Controls.Add(asiento.Etiqueta, j, i);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!txtAsiento.Text.Equals("NINGUNO"))
            {
                Asientos asiento = Asientos.buscarAsiento(funcion, txtAsiento.Text);
                asiento.Etiqueta.BackColor = System.Drawing.Color.DimGray;
            }
            Close();
        }

        public static void click_asiento(object sender, EventArgs e)
        {
            Label etiqueta = (Label)sender;
            Asientos asiento;
            if (etiqueta.BackColor != System.Drawing.Color.Red)
            {
                if (etiqueta.BackColor == System.Drawing.Color.DimGray)
                {
                    if (txtAsiento.Text.Equals("NINGUNO"))
                    {
                        etiqueta.BackColor = System.Drawing.Color.Green;
                        txtAsiento.Text = etiqueta.Text;
                    }
                    else
                    {
                        //despintar anterior
                        asiento = Asientos.buscarAsiento(funcion, txtAsiento.Text);
                        asiento.Etiqueta.BackColor = System.Drawing.Color.DimGray;
                        // pintar nuevo
                        etiqueta.BackColor = System.Drawing.Color.Green;
                        txtAsiento.Text = etiqueta.Text;
                    }
                }
                else
                {
                    if (etiqueta.Text.Equals(txtAsiento.Text))
                    {
                        MessageBox.Show("Ha seleccionado el mismo asiento.");
                    }

                }
            }
            else
            {
                MessageBox.Show("El asiento ya se ha vendido!");
            }
        }

        private void btnVenderBoleto_Click(object sender, EventArgs e)
        {
            if (!txtAsiento.Text.Equals("NINGUNO"))
            {
                Espectador espectador = (Espectador)listaEspectadores[comboEspectadores.SelectedIndex];
                if (espectador.Edad > funcion.Pelicula.EdadMinima)
                {
                    Asientos asiento = Asientos.buscarAsiento(funcion, txtAsiento.Text);
                    asiento.Etiqueta.BackColor = System.Drawing.Color.Red;
                    asiento.Ocupado = true;
                    funcion.NumeroEspectadores += 1;
                    Espectador espec = ((Espectador)listaEspectadores[comboEspectadores.SelectedIndex]);

                    MessageBox.Show("----- FACTURA DE BOLETO VENDIDO -----" + Environment.NewLine +
                        "ESPECTADOR: " + comboEspectadores.Text + Environment.NewLine +
                        "CEDULA: " + espec.Cedula + Environment.NewLine +
                        "EDAD: " + espec.Edad + Environment.NewLine +
                        "SEXO: " + espec.Sexo + Environment.NewLine +
                        "FECHA: " + (funcion.DiaFuncion.Day + "/" + funcion.DiaFuncion.Month + "/" + funcion.DiaFuncion.Year) + Environment.NewLine +
                        "HORA: " + txtHora.Text + Environment.NewLine +
                        "ASIENTO: " + txtAsiento.Text + Environment.NewLine +
                        "**** disfrute su pelicula *****"
                        );
                    Close();
                }
                else
                {
                    MessageBox.Show("El espectador no cumple con la edad minima: " + funcion.Pelicula.EdadMinima + " años");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un asiento primero!");
            }
        }
    }
}
