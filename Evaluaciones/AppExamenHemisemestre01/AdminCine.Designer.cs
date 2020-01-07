namespace AppExamenHemisemestre01
{
    partial class AdminCine
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
            this.btnAgregarFuncion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaFunciones = new System.Windows.Forms.DataGridView();
            this.diaFuncionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFuncionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaFuncionesCine = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnVentaBoleto = new System.Windows.Forms.Button();
            this.btnAgregarEspectadores = new System.Windows.Forms.Button();
            this.btnTotalRecaudado = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnMasEspectadores = new System.Windows.Forms.Button();
            this.listaEspectadores = new System.Windows.Forms.BindingSource(this.components);
            this.listaPeliculas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionesCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspectadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarFuncion
            // 
            this.btnAgregarFuncion.Location = new System.Drawing.Point(15, 179);
            this.btnAgregarFuncion.Name = "btnAgregarFuncion";
            this.btnAgregarFuncion.Size = new System.Drawing.Size(177, 46);
            this.btnAgregarFuncion.TabIndex = 0;
            this.btnAgregarFuncion.Text = "Agregar funciones";
            this.btnAgregarFuncion.UseVisualStyleBackColor = true;
            this.btnAgregarFuncion.Click += new System.EventHandler(this.btnAgregarFuncion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de CINE";
            // 
            // tablaFunciones
            // 
            this.tablaFunciones.AllowUserToAddRows = false;
            this.tablaFunciones.AutoGenerateColumns = false;
            this.tablaFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaFuncionDataGridViewTextBoxColumn,
            this.horaFuncionDataGridViewTextBoxColumn,
            this.precioEntradaDataGridViewTextBoxColumn,
            this.estadoPeliculaDataGridViewTextBoxColumn,
            this.nombrePeliculaDataGridViewTextBoxColumn});
            this.tablaFunciones.DataSource = this.listaFuncionesCine;
            this.tablaFunciones.Location = new System.Drawing.Point(15, 59);
            this.tablaFunciones.Name = "tablaFunciones";
            this.tablaFunciones.Size = new System.Drawing.Size(558, 114);
            this.tablaFunciones.TabIndex = 2;
            // 
            // diaFuncionDataGridViewTextBoxColumn
            // 
            this.diaFuncionDataGridViewTextBoxColumn.DataPropertyName = "DiaFuncion";
            this.diaFuncionDataGridViewTextBoxColumn.HeaderText = "DiaFuncion";
            this.diaFuncionDataGridViewTextBoxColumn.Name = "diaFuncionDataGridViewTextBoxColumn";
            // 
            // horaFuncionDataGridViewTextBoxColumn
            // 
            this.horaFuncionDataGridViewTextBoxColumn.DataPropertyName = "HoraFuncion";
            this.horaFuncionDataGridViewTextBoxColumn.HeaderText = "HoraFuncion";
            this.horaFuncionDataGridViewTextBoxColumn.Name = "horaFuncionDataGridViewTextBoxColumn";
            // 
            // precioEntradaDataGridViewTextBoxColumn
            // 
            this.precioEntradaDataGridViewTextBoxColumn.DataPropertyName = "PrecioEntrada";
            this.precioEntradaDataGridViewTextBoxColumn.HeaderText = "PrecioEntrada";
            this.precioEntradaDataGridViewTextBoxColumn.Name = "precioEntradaDataGridViewTextBoxColumn";
            // 
            // estadoPeliculaDataGridViewTextBoxColumn
            // 
            this.estadoPeliculaDataGridViewTextBoxColumn.DataPropertyName = "EstadoPelicula";
            this.estadoPeliculaDataGridViewTextBoxColumn.HeaderText = "EstadoPelicula";
            this.estadoPeliculaDataGridViewTextBoxColumn.Name = "estadoPeliculaDataGridViewTextBoxColumn";
            // 
            // nombrePeliculaDataGridViewTextBoxColumn
            // 
            this.nombrePeliculaDataGridViewTextBoxColumn.DataPropertyName = "NombrePelicula";
            this.nombrePeliculaDataGridViewTextBoxColumn.HeaderText = "NombrePelicula";
            this.nombrePeliculaDataGridViewTextBoxColumn.Name = "nombrePeliculaDataGridViewTextBoxColumn";
            // 
            // listaFuncionesCine
            // 
            this.listaFuncionesCine.DataSource = typeof(AppExamenHemisemestre01.Clases.FuncionCine);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado de funciones :";
            // 
            // btnVentaBoleto
            // 
            this.btnVentaBoleto.Location = new System.Drawing.Point(402, 179);
            this.btnVentaBoleto.Name = "btnVentaBoleto";
            this.btnVentaBoleto.Size = new System.Drawing.Size(171, 46);
            this.btnVentaBoleto.TabIndex = 4;
            this.btnVentaBoleto.Text = "Venta de boletos";
            this.btnVentaBoleto.UseVisualStyleBackColor = true;
            this.btnVentaBoleto.Click += new System.EventHandler(this.btnVentaBoleto_Click);
            // 
            // btnAgregarEspectadores
            // 
            this.btnAgregarEspectadores.Location = new System.Drawing.Point(198, 179);
            this.btnAgregarEspectadores.Name = "btnAgregarEspectadores";
            this.btnAgregarEspectadores.Size = new System.Drawing.Size(198, 46);
            this.btnAgregarEspectadores.TabIndex = 5;
            this.btnAgregarEspectadores.Text = "Agregar espectadores";
            this.btnAgregarEspectadores.UseVisualStyleBackColor = true;
            this.btnAgregarEspectadores.Click += new System.EventHandler(this.btnAgregarEspectadores_Click);
            // 
            // btnTotalRecaudado
            // 
            this.btnTotalRecaudado.Location = new System.Drawing.Point(15, 231);
            this.btnTotalRecaudado.Name = "btnTotalRecaudado";
            this.btnTotalRecaudado.Size = new System.Drawing.Size(177, 46);
            this.btnTotalRecaudado.TabIndex = 6;
            this.btnTotalRecaudado.Text = "Total recaudado de la pelicula";
            this.btnTotalRecaudado.UseVisualStyleBackColor = true;
            this.btnTotalRecaudado.Click += new System.EventHandler(this.btnTotalRecaudado_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(198, 231);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(198, 46);
            this.btnPorcentaje.TabIndex = 7;
            this.btnPorcentaje.Text = "Porcentaje de peliculas vistas";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnMasEspectadores
            // 
            this.btnMasEspectadores.Location = new System.Drawing.Point(402, 231);
            this.btnMasEspectadores.Name = "btnMasEspectadores";
            this.btnMasEspectadores.Size = new System.Drawing.Size(171, 46);
            this.btnMasEspectadores.TabIndex = 8;
            this.btnMasEspectadores.Text = "Pelicula con más espectadores";
            this.btnMasEspectadores.UseVisualStyleBackColor = true;
            this.btnMasEspectadores.Click += new System.EventHandler(this.btnMasEspectadores_Click);
            // 
            // listaEspectadores
            // 
            this.listaEspectadores.DataSource = typeof(AppExamenHemisemestre01.Clases.Espectador);
            // 
            // listaPeliculas
            // 
            this.listaPeliculas.DataSource = typeof(AppExamenHemisemestre01.Clases.Pelicula);
            // 
            // AdminCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 296);
            this.Controls.Add(this.btnMasEspectadores);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnTotalRecaudado);
            this.Controls.Add(this.btnAgregarEspectadores);
            this.Controls.Add(this.btnVentaBoleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaFunciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarFuncion);
            this.Name = "AdminCine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionesCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspectadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaFunciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVentaBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFuncionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFuncionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaFuncionesCine;
        private System.Windows.Forms.Button btnAgregarEspectadores;
        private System.Windows.Forms.BindingSource listaEspectadores;
        private System.Windows.Forms.BindingSource listaPeliculas;
        private System.Windows.Forms.Button btnTotalRecaudado;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnMasEspectadores;
    }
}

