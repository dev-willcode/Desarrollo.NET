﻿using System;
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
    public partial class FrmProcesos : Form
    {

        public FrmProcesos()
        {
            InitializeComponent();  
        }
       
       public void CargarDatos()
        {
            Empleado oe = new EmpleadoAsalariado("0706079217", "Robert", "Cun", 'M', 20, "Arenillas", "Asalariado", 2000);
            TLista.Insertar(oe);
            Empleado oe2 = new EmpleadoAsalariado("0806079216", "Fernanda", "Armijos", 'F', 17, "Machala", "Asalariado", 1200);
            TLista.Insertar(oe2);
            Empleado oe3 = new EmpleadoPorHoras("0706079217", "Pedro", "Tulio", 'M', 25, "Machala", "Por Horas", 20, 50);
            TLista.Insertar(oe3);
            Empleado oe4 = new EmpleadoPorComision("0106079214", "Maria", "Loayza", 'F', 25, "Sta Rosa", "Comision", 10000, 25);
            TLista.Insertar(oe4);
        }

        private void selectSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void FrmProcesos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            var sql = from le in TLista.listaEmpleados
                      select new { le.Cedula, le.Nombres, le.Apellidos, sueldo = le.CalcularSueldo() };
            dataGridView1.DataSource = sql.ToList();
           
        }

        private void selectUpperlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      select new { nombre = le.Nombres.ToUpper(), nombres = le.Nombres.ToLower(), apellido = le.Apellidos.ToUpper()};
            dataGridView1.DataSource = sql.ToList();
        }

        private void selectTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      select new { le.Cedula, le.Nombres, le.Apellidos};
            dataGridView1.DataSource = sql.ToList();
        }

        private void selectLamdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void whereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      where le.Edad >= 18
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void whereMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      where le.Edad < 18 && le.Sexo == 'F' && le.Tipo == "Asalariado" 
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void orderbyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sql = from le in TLista.listaEmpleados
                      orderby le.CalcularSueldo()// descending //ascending 
                      select new { le.Cedula, Nombres = le.Nombres + "" + le.Apellidos, le.Ciudad ,sueldo = le.CalcularSueldo() };
            dataGridView1.DataSource = sql.ToList();
        }
    }
}