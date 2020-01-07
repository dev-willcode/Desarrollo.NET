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
    public partial class FrmEmpleado : Form
    {
        string op = "";
        int posEmp = -1;
        public FrmEmpleado(string opcion, int pos)
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            op = opcion;
            posEmp = pos;
            if (opcion.Equals("Editar"))
            {
                editarTrabajador(pos);
                label10.Text = "Editar Empleado";
            }
        }

        public void editarTrabajador(int pos)
        {
            string tipoEmpleado = TLista.GetEmpleado(pos).Tipo;
            if (tipoEmpleado.Equals("Asalariado"))
            {
                EmpleadoAsalariado eA = (EmpleadoAsalariado)TLista.GetEmpleado(pos);
                textBox1.Text = eA.Cedula;
                textBox2.Text = eA.Nombres;
                textBox3.Text = eA.Apellidos;
                comboBox2.SelectedItem = eA.Sexo.ToString();
                textBox8.Text = eA.Edad.ToString();
                textBox10.Text = eA.Ciudad;
                comboBox1.SelectedItem = eA.Tipo;
                textBox5.Text = eA.Salario.ToString();
            }
            else if (tipoEmpleado.Equals("Por Horas"))
            {
                EmpleadoPorHoras eA = (EmpleadoPorHoras)TLista.GetEmpleado(pos);
                textBox1.Text = eA.Cedula;
                textBox2.Text = eA.Nombres;
                textBox3.Text = eA.Apellidos;
                comboBox2.SelectedItem = eA.Sexo.ToString();
                textBox8.Text = eA.Edad.ToString();
                textBox10.Text = eA.Ciudad;
                comboBox1.SelectedItem = eA.Tipo;
                textBox5.Text = eA.NumHoras.ToString();
                textBox6.Text = eA.CostoHora.ToString();
            }
            else if (tipoEmpleado.Equals("Comision"))
            {
                EmpleadoPorComision eA = (EmpleadoPorComision)TLista.GetEmpleado(pos);
                textBox1.Text = eA.Cedula;
                textBox2.Text = eA.Nombres;
                textBox3.Text = eA.Apellidos;
                comboBox2.SelectedItem = eA.Sexo.ToString();
                textBox8.Text = eA.Edad.ToString();
                textBox10.Text = eA.Ciudad;
                comboBox1.SelectedItem = eA.Tipo;
                textBox5.Text = eA.VentBrut.ToString();
                textBox6.Text = eA.Porcentaje.ToString();
            }
            else if (tipoEmpleado.Equals("Base + Comision"))
            {
                EmpleadoBaseMasComision eA = (EmpleadoBaseMasComision)TLista.GetEmpleado(pos);
                textBox1.Text = eA.Cedula;
                textBox2.Text = eA.Nombres;
                textBox3.Text = eA.Apellidos;
                comboBox2.SelectedItem = eA.Sexo.ToString();
                textBox8.Text = eA.Edad.ToString();
                textBox10.Text = eA.Ciudad;
                comboBox1.SelectedItem = eA.Tipo;
                textBox5.Text = eA.VentBrut.ToString();
                textBox6.Text = eA.Porcentaje.ToString();
                textBox7.Text = eA.SalBase.ToString();
            }
            else if (tipoEmpleado.Equals("Por Piezas"))
            {
                TrabajadorPorPiezas eA = (TrabajadorPorPiezas)TLista.GetEmpleado(pos);
                textBox1.Text = eA.Cedula;
                textBox2.Text = eA.Nombres;
                textBox3.Text = eA.Apellidos;
                comboBox2.SelectedItem = eA.Sexo.ToString();
                textBox8.Text = eA.Edad.ToString();
                textBox10.Text = eA.Ciudad;
                comboBox1.SelectedItem = eA.Tipo;
                textBox5.Text = eA.Sueldo.ToString();
                textBox6.Text = eA.Piezas.ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label6.Text = "Salario";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;
                label6.Text = "Num Horas trabajadas";
                label7.Text = "Costo Hora:";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;
                label6.Text = "Ventas brutas";
                label7.Text = "Porcent. de ganancia";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                label6.Text = "Ventas brutas";
                label7.Text = "Porcent. de ganancia";
                label8.Text = "Salario base";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;
                label6.Text = "Sueldo por piezas";
                label7.Text = "Numero de Piezas";
            }
        }

      

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                EmpleadoAsalariado eA = new EmpleadoAsalariado();
                eA.Cedula = textBox1.Text;
                eA.Nombres = textBox2.Text;
                eA.Apellidos = textBox3.Text;
                eA.Sexo = char.Parse(comboBox2.SelectedItem.ToString());
                eA.Edad = int.Parse(textBox8.Text);
                eA.Ciudad = textBox10.Text;
                eA.Tipo = comboBox1.SelectedItem.ToString();
                eA.Salario = double.Parse(textBox5.Text);
                if (op.Equals("Editar"))
                    TLista.Editar(eA, posEmp);
                else
                    TLista.Insertar(eA);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                EmpleadoPorHoras eH = new EmpleadoPorHoras();
                eH.Cedula = textBox1.Text;
                eH.Nombres = textBox2.Text;
                eH.Apellidos = textBox3.Text;
                eH.Sexo = char.Parse(comboBox2.SelectedItem.ToString());
                eH.Edad = int.Parse(textBox8.Text);
                eH.Ciudad = textBox10.Text;
                eH.Tipo = comboBox1.SelectedItem.ToString();
                eH.NumHoras = int.Parse(textBox5.Text);
                eH.CostoHora = double.Parse(textBox6.Text);
                if (op.Equals("Editar"))
                    TLista.Editar(eH, posEmp);
                else
                    TLista.Insertar(eH);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                EmpleadoPorComision eC = new EmpleadoPorComision();
                eC.Cedula = textBox1.Text;
                eC.Nombres = textBox2.Text;
                eC.Apellidos = textBox3.Text;
                eC.Sexo = char.Parse(comboBox2.SelectedItem.ToString());
                eC.Edad = int.Parse(textBox8.Text);
                eC.Ciudad = textBox10.Text;
                eC.Tipo = comboBox1.SelectedItem.ToString();
                eC.VentBrut = double.Parse(textBox5.Text);
                eC.Porcentaje = double.Parse(textBox6.Text);
                if (op.Equals("Editar"))
                    TLista.Editar(eC, posEmp);
                else
                    TLista.Insertar(eC);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                EmpleadoBaseMasComision eBC = new EmpleadoBaseMasComision();
                eBC.Cedula = textBox1.Text;
                eBC.Nombres = textBox2.Text;
                eBC.Apellidos = textBox3.Text;
                eBC.Sexo = char.Parse(comboBox2.SelectedItem.ToString());
                eBC.Edad = int.Parse(textBox8.Text);
                eBC.Ciudad = textBox10.Text;
                eBC.Tipo = comboBox1.SelectedItem.ToString();
                eBC.VentBrut = double.Parse(textBox5.Text);
                eBC.Porcentaje = double.Parse(textBox6.Text);
                eBC.SalBase = double.Parse(textBox7.Text);
                if (op.Equals("Editar"))
                    TLista.Editar(eBC, posEmp);
                else
                    TLista.Insertar(eBC);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                TrabajadorPorPiezas eP = new TrabajadorPorPiezas();
                eP.Cedula = textBox1.Text;
                eP.Nombres = textBox2.Text;
                eP.Apellidos = textBox3.Text;
                eP.Sexo = char.Parse(comboBox2.SelectedItem.ToString());
                eP.Edad = int.Parse(textBox8.Text);
                eP.Ciudad = textBox10.Text;
                eP.Tipo = comboBox1.SelectedItem.ToString();
                eP.Sueldo = double.Parse(textBox5.Text);
                eP.Piezas = int.Parse(textBox6.Text);
                if (op.Equals("Editar"))
                    TLista.Editar(eP, posEmp);
                else
                    TLista.Insertar(eP);
            }
            FrmAdminEmpleados frm = new FrmAdminEmpleados();
            frm.ActualizarTabla();
            this.Hide();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
