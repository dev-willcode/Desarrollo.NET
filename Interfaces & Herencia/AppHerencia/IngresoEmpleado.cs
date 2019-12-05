using AppHerencia.Clases;
using System;
using System.Windows.Forms;

namespace AppHerencia
{
    public partial class IngresoEmpleado : Form
    {
        public Empleado empleadoSeleccionado;
        public IngresoEmpleado()
        {
            InitializeComponent();
            comboTipoEmpleado.selectedIndex = 0;
            comboEstadoCivil.selectedIndex = 0;
            fechaNacimiento.Value = new DateTime(2001, 2, 19);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventoCambioTipo(object sender, EventArgs e)
        {
            empleadoSeleccionado = crearEmpleado();
            panelInterno.Controls.Clear();

            if (empleadoSeleccionado != null)
            {
                switch (comboTipoEmpleado.selectedIndex)
                {
                    case 1:
                        panelInterno.Controls.Add(new PanelAsalariado(this));
                        break;
                    case 2:
                        panelInterno.Controls.Add(new PanelAsalariadoComision(this));
                        break;
                    case 3:
                        panelInterno.Controls.Add(new PanelComision(this));
                        break;
                    case 4:
                        panelInterno.Controls.Add(new PanelHora(this));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                comboTipoEmpleado.selectedIndex = 0;
            }
        }

        private Empleado crearEmpleado()
        {
            Empleado empleado = new Empleado();
            String errores = "";

            if (txtCedula.Text.Length == 0 | txtApellido.Text.Length == 0 | txtNombre.Text.Length == 0
                | txtEdad.Text.Length == 0 | txtCiudad.Text.Length == 0 | comboEstadoCivil.selectedIndex == 0)
                errores += " - Verifique que ha completado el formulario Empleado correctamente";
            else
            {
                empleado.Cedula = txtCedula.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Nombre = txtNombre.Text;
                empleado.Ciudad = txtCedula.Text;
                empleado.EstadoCivil = comboEstadoCivil.selectedValue;
                empleado.FechaNacimiento = fechaNacimiento.Value;
                if (rbMasculino.Checked) empleado.Sexo = 'M';
                else empleado.Sexo = 'F';
                try
                {
                    empleado.Edad = int.Parse(txtEdad.Text);
                }
                catch (Exception)
                {
                    errores += "\n - verifique que la edad sea un numero entero";
                }
            }
            if (errores.Length == 0)
                return empleado;
            else
            {
                if (comboTipoEmpleado.selectedIndex != 0) MessageBox.Show(errores);
                return null;
            }

        }

        public Boolean recibeBono()
        {
            DateTime hoy = DateTime.Now;
            DateTime cumpleano = empleadoSeleccionado.FechaNacimiento;
            return (hoy.Day == cumpleano.Day && hoy.Month == cumpleano.Month);
        }

        public void limpiarFormulario()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCiudad.Text = "";
            txtEdad.Text = "";
            rbMasculino.Checked = true;
            comboEstadoCivil.selectedIndex = 0;
            comboTipoEmpleado.selectedIndex = 0;
        }

        private void cambioFecha(object sender, EventArgs e)
        {
            if (fechaNacimiento.Value.Year >= DateTime.Now.Year)
            {
                fechaNacimiento.Value = new DateTime(2001, 2, 19);
                MessageBox.Show("La fecha de nacimiento no puede ser mayor al año actual");
            } else
            {
                txtEdad.Text = (DateTime.Now.Year - fechaNacimiento.Value.Year).ToString();
            }
        }
    }
}
