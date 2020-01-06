using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPOOPractica2.Controlador;
using AppPOOPractica2.Entidades;

namespace AppPOOPractica2
{
    public partial class FrmAdminEmpleados : Form
    {
        public FrmAdminEmpleados()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            FrmPrincipal frm = new FrmPrincipal();
            frm.frmactivo = true;
        }
        public void ActualizarTabla()
        {
            dataGridView1.DataSource = TLista.listaEmpleados.ToList();
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado("Agregar", -1);
            frm.ShowDialog();
            ActualizarTabla();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            int pos = dataGridView1.CurrentCell.RowIndex;
            FrmEmpleado frm = new FrmEmpleado("Editar", pos);
            frm.ShowDialog();
            ActualizarTabla();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TLista.listaEmpleados.Count == 0)
            {
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
            else
            {
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            int pos = dataGridView1.CurrentCell.RowIndex;
            TLista.Eliminar(pos);
            ActualizarTabla();
            if (TLista.listaEmpleados.Count == 0)
            {
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdminEmpleados_Load(object sender, EventArgs e)
        {
            if (TLista.listaEmpleados.Count == 0)
            {
                Empleado oe = new EmpleadoAsalariado("0706079217", "Robert", "Cun", 'M', 20, "Arenillas", "Asalariado", 2000);
                TLista.Insertar(oe);
                Empleado oe2 = new EmpleadoAsalariado("0806079216", "Fernanda", "Armijos", 'F', 17, "Machala", "Asalariado", 1200);
                TLista.Insertar(oe2);
                Empleado oe3 = new EmpleadoPorHoras("0906079215", "Pedro", "Tulio", 'M', 25, "Machala", "Por Horas", 20, 50);
                TLista.Insertar(oe3);
                Empleado oe4 = new EmpleadoPorComision("0106079214", "Maria", "Loayza", 'F', 25, "Sta Rosa", "Comision", 10000, 25);
                TLista.Insertar(oe4);
            }
            ActualizarTabla();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = TLista.listaEmpleados.ToList();
            }
            else
            {
                TLista.listaEmpleadosF.Clear();
                string tipo = comboBox1.SelectedItem.ToString();
                TLista.FiltrarEmpleados(tipo);
                dataGridView1.DataSource = TLista.listaEmpleadosF.ToList();
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.frmactivo = false;
            this.Hide();
        }
    }
}
