namespace AppCursosDigitales
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboFormaPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMensual = new System.Windows.Forms.TextBox();
            this.ofertado = new System.Windows.Forms.ListBox();
            this.bsCursoOfertado = new System.Windows.Forms.BindingSource(this.components);
            this.ofertadoCosto = new System.Windows.Forms.ListBox();
            this.seleccionadoCosto = new System.Windows.Forms.ListBox();
            this.bsCursoSeleccionado = new System.Windows.Forms.BindingSource(this.components);
            this.seleccionado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsCursoOfertado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCursoSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría de cursos:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Diseño Gráfico",
            "Ingeniería",
            "Economía"});
            this.comboCategoria.Location = new System.Drawing.Point(178, 52);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(209, 21);
            this.comboCategoria.TabIndex = 3;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.eventoCambioCategoria);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cursos ofertados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cursos seleccionados:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(178, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(178, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboFormaPago
            // 
            this.comboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormaPago.FormattingEnabled = true;
            this.comboFormaPago.Items.AddRange(new object[] {
            "CONTADO",
            "CRÉDITO"});
            this.comboFormaPago.Location = new System.Drawing.Point(192, 230);
            this.comboFormaPago.Name = "comboFormaPago";
            this.comboFormaPago.Size = new System.Drawing.Size(156, 21);
            this.comboFormaPago.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Forma de pago:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(111, 268);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(192, 268);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(273, 268);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(99, 331);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(81, 20);
            this.txtMatricula.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Costo total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pago mensual:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(186, 331);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // txtMensual
            // 
            this.txtMensual.Location = new System.Drawing.Point(274, 331);
            this.txtMensual.Name = "txtMensual";
            this.txtMensual.Size = new System.Drawing.Size(81, 20);
            this.txtMensual.TabIndex = 20;
            // 
            // ofertado
            // 
            this.ofertado.DataSource = this.bsCursoOfertado;
            this.ofertado.DisplayMember = "Nombre";
            this.ofertado.FormattingEnabled = true;
            this.ofertado.Location = new System.Drawing.Point(12, 107);
            this.ofertado.Name = "ofertado";
            this.ofertado.Size = new System.Drawing.Size(103, 108);
            this.ofertado.TabIndex = 0;
            // 
            // bsCursoOfertado
            // 
            this.bsCursoOfertado.DataSource = typeof(AppCursosDigitales.Clases.Curso);
            // 
            // ofertadoCosto
            // 
            this.ofertadoCosto.DataSource = this.bsCursoOfertado;
            this.ofertadoCosto.DisplayMember = "Costo";
            this.ofertadoCosto.FormattingEnabled = true;
            this.ofertadoCosto.Location = new System.Drawing.Point(121, 106);
            this.ofertadoCosto.Name = "ofertadoCosto";
            this.ofertadoCosto.Size = new System.Drawing.Size(51, 108);
            this.ofertadoCosto.TabIndex = 21;
            // 
            // seleccionadoCosto
            // 
            this.seleccionadoCosto.DataSource = this.bsCursoSeleccionado;
            this.seleccionadoCosto.DisplayMember = "Costo";
            this.seleccionadoCosto.FormattingEnabled = true;
            this.seleccionadoCosto.Location = new System.Drawing.Point(368, 105);
            this.seleccionadoCosto.Name = "seleccionadoCosto";
            this.seleccionadoCosto.Size = new System.Drawing.Size(51, 108);
            this.seleccionadoCosto.TabIndex = 23;
            // 
            // bsCursoSeleccionado
            // 
            this.bsCursoSeleccionado.DataSource = typeof(AppCursosDigitales.Clases.Curso);
            // 
            // seleccionado
            // 
            this.seleccionado.DataSource = this.bsCursoSeleccionado;
            this.seleccionado.DisplayMember = "Nombre";
            this.seleccionado.FormattingEnabled = true;
            this.seleccionado.Location = new System.Drawing.Point(259, 106);
            this.seleccionado.Name = "seleccionado";
            this.seleccionado.Size = new System.Drawing.Size(103, 108);
            this.seleccionado.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 367);
            this.Controls.Add(this.seleccionadoCosto);
            this.Controls.Add(this.seleccionado);
            this.Controls.Add(this.ofertadoCosto);
            this.Controls.Add(this.ofertado);
            this.Controls.Add(this.txtMensual);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboFormaPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsCursoOfertado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCursoSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboFormaPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMensual;
        private System.Windows.Forms.ListBox ofertado;
        private System.Windows.Forms.ListBox ofertadoCosto;
        private System.Windows.Forms.ListBox seleccionadoCosto;
        private System.Windows.Forms.ListBox seleccionado;
        private System.Windows.Forms.BindingSource bsCursoOfertado;
        private System.Windows.Forms.BindingSource bsCursoSeleccionado;
    }
}

