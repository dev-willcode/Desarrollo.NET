using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHerencia.Clases;

namespace AppHerencia
{
    public partial class PanelHora : UserControl
    {
        private IngresoEmpleado panelPadre;
        public PanelHora(IngresoEmpleado panelPadre)
        {
            this.panelPadre = panelPadre;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EmpleadoHora empleado = new EmpleadoHora(panelPadre.empleadoSeleccionado);
            try
            {
                empleado.HorasTrabajadas = double.Parse(txtHora.Text);
                empleado.CostoHora = double.Parse(txtCostoHora.Text);
                empleado.ImprimirDatos();
                empleado.imprimir();
                if (panelPadre.recibeBono())
                    MessageBox.Show("Es el cumpleaños del empleado! recibe un bono de $200!" +
                        "\n sueldo total: " + (empleado.calcularSueldo() + 200));
                if (MessageBox.Show("¿Desea limpiar el formulario?", "LIMPIAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    panelPadre.limpiarFormulario();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise que ha ingresado un valor entero o decimal");
            }
        }
    }
}
