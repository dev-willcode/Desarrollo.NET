using AppHerencia.Clases;
using System;
using System.Windows.Forms;

namespace AppHerencia
{
    public partial class PanelComision : UserControl
    {
        private IngresoEmpleado panelPadre;
        public PanelComision(IngresoEmpleado panelPadre)
        {
            this.panelPadre = panelPadre;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EmpleadoComision empleado = new EmpleadoComision(panelPadre.empleadoSeleccionado);
            try
            {
                empleado.VentasBrutas = double.Parse(txtVentas.Text);
                empleado.Porcentaje = double.Parse(txtPorcentaje.Text);
                empleado.ImprimirDatos();
                empleado.imprimir();
                if (panelPadre.recibeBono())
                    MessageBox.Show("Es el cumpleaños del empleado! recibe un bono de $200!" +
                        "\n sueldo total: " + (empleado.calcularSueldo() + 200));
                
                    panelPadre.limpiarFormulario();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise que ha ingresado un valor entero o decimal");
            }
        }
    }
}
