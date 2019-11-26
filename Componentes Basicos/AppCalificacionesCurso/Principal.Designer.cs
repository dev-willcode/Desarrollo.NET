using AppCalificacionesCurso.Clases;
using System.Collections.Generic;

namespace AppCalificacionesCurso
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tblAlumnos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEstudiantes = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificaciones del curso de programación visual";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(459, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota Unidad I:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(128, 97);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(163, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota Unidad II:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(128, 123);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(163, 20);
            this.txtNota2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota Unidad III:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(404, 97);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(151, 20);
            this.txtNota3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modalidad:";
            // 
            // comboTurno
            // 
            this.comboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Items.AddRange(new object[] {
            "Presencial",
            "Semi-presencial",
            "Distancia"});
            this.comboTurno.Location = new System.Drawing.Point(404, 123);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(151, 21);
            this.comboTurno.TabIndex = 11;
            this.comboTurno.SelectedIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(120, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(238, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tblAlumnos
            // 
            this.tblAlumnos.AllowUserToAddRows = false;
            this.tblAlumnos.AutoGenerateColumns = false;
            this.tblAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.tblAlumnos.DataSource = this.bsEstudiantes;
            this.tblAlumnos.Location = new System.Drawing.Point(26, 202);
            this.tblAlumnos.MultiSelect = false;
            this.tblAlumnos.Name = "tblAlumnos";
            this.tblAlumnos.ReadOnly = true;
            this.tblAlumnos.Size = new System.Drawing.Size(543, 150);
            this.tblAlumnos.TabIndex = 14;
            this.tblAlumnos.VirtualMode = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsEstudiantes
            // 
            this.bsEstudiantes.DataSource = typeof(AppCalificacionesCurso.Clases.Estudiante);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total de alumnos:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(487, 379);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(356, 161);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(112, 35);
            this.btnPromedio.TabIndex = 17;
            this.btnPromedio.Text = "Calcular promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 440);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.tblAlumnos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tblAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView tblAlumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.BindingSource bsEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPromedio;
    }
}

