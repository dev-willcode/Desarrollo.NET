using AppCalificacionesCurso.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalificacionesCurso
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 | txtNota1.Text.Length == 0 |
                txtNota2.Text.Length == 0 | txtNota3.Text.Length == 0)
            {
                MessageBox.Show("Revise que ha rellenado todos los campos!");
            }
            else
            {
                try
                {
                    // Generar estudiante
                    Estudiante estudiante = new Estudiante();
                    estudiante.Nombre = txtNombre.Text;
                    estudiante.Nota1 = Double.Parse(txtNota1.Text);
                    estudiante.Nota2 = Double.Parse(txtNota2.Text);
                    estudiante.Nota3 = Double.Parse(txtNota3.Text);
                    estudiante.Turno = comboTurno.SelectedItem.ToString();
                    bsEstudiantes.Add(estudiante);

                    //Limpiar
                    txtNombre.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();
                    comboTurno.SelectedIndex = 0;

                    actualizartotalAlumnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al crear el alumno\nERROR: " + ex.Message);
                }
            }


        }

        private void actualizartotalAlumnos()
        {
            txtTotal.Text = bsEstudiantes.List.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblAlumnos.CurrentRow != null)
            {
                if (MessageBox.Show("Desea Eliminar al estudiante?", "Cerrar sin Guardar?",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bsEstudiantes.RemoveAt(tblAlumnos.CurrentRow.Index);
                    actualizartotalAlumnos();
                }
            }
            else MessageBox.Show("Verifique que ha seleccionado una fila!");
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio1 = 0.00;
            double promedio2 = 0.00;
            double promedio3 = 0.00;
            double promedioTotal = 0.00;
            int estudiantes = bsEstudiantes.List.Count;
            foreach (Estudiante estudiante in bsEstudiantes)
            {
                promedio1 += estudiante.Nota1;
                promedio2 += estudiante.Nota2;
                promedio3 += estudiante.Nota3;
                promedioTotal += estudiante.promedio();
            }
            MessageBox.Show("----- PROMEDIOS -----" +
                "\nUNIDAD I: " + promedio1 / estudiantes +
                "\nUNIDAD II: " + promedio2 / estudiantes +
                "\nUNIDAD III: " + promedio3 / estudiantes +
                "\nPROMEDIO TOTAL: " + promedioTotal / estudiantes);
        }
    }
}
