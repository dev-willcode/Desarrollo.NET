namespace AppAlquilerAutomoviles
{
    partial class AdministrarVehiculos
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClienteMasDias = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnMasAlquilado = new System.Windows.Forms.Button();
            this.btnRecaudado = new System.Windows.Forms.Button();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaAlquileresSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlquileresSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AutoGenerateColumns = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteDataGridViewTextBoxColumn,
            this.modeloVehiculoDataGridViewTextBoxColumn,
            this.fechaEntregaDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.importeTotalDataGridViewTextBoxColumn});
            this.tabla.DataSource = this.listaAlquileresSource;
            this.tabla.Location = new System.Drawing.Point(12, 68);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(820, 150);
            this.tabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de vehiculos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alquilar Vehiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClienteMasDias
            // 
            this.btnClienteMasDias.Location = new System.Drawing.Point(646, 237);
            this.btnClienteMasDias.Name = "btnClienteMasDias";
            this.btnClienteMasDias.Size = new System.Drawing.Size(180, 34);
            this.btnClienteMasDias.TabIndex = 3;
            this.btnClienteMasDias.Text = "Cliente que alquiló por más días";
            this.btnClienteMasDias.UseVisualStyleBackColor = true;
            this.btnClienteMasDias.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(314, 237);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(172, 34);
            this.btnPorcentaje.TabIndex = 4;
            this.btnPorcentaje.Text = "Porcentaje de vehículos";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMasAlquilado
            // 
            this.btnMasAlquilado.Location = new System.Drawing.Point(492, 237);
            this.btnMasAlquilado.Name = "btnMasAlquilado";
            this.btnMasAlquilado.Size = new System.Drawing.Size(148, 34);
            this.btnMasAlquilado.TabIndex = 5;
            this.btnMasAlquilado.Text = "Modelo más alquilado";
            this.btnMasAlquilado.UseVisualStyleBackColor = true;
            this.btnMasAlquilado.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRecaudado
            // 
            this.btnRecaudado.Location = new System.Drawing.Point(160, 237);
            this.btnRecaudado.Name = "btnRecaudado";
            this.btnRecaudado.Size = new System.Drawing.Size(148, 34);
            this.btnRecaudado.TabIndex = 6;
            this.btnRecaudado.Text = "Recaudado por modelo";
            this.btnRecaudado.UseVisualStyleBackColor = true;
            this.btnRecaudado.Click += new System.EventHandler(this.button5_Click);
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloVehiculoDataGridViewTextBoxColumn
            // 
            this.modeloVehiculoDataGridViewTextBoxColumn.DataPropertyName = "ModeloVehiculo";
            this.modeloVehiculoDataGridViewTextBoxColumn.HeaderText = "ModeloVehiculo";
            this.modeloVehiculoDataGridViewTextBoxColumn.Name = "modeloVehiculoDataGridViewTextBoxColumn";
            this.modeloVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrega";
            this.fechaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEntrega";
            this.fechaEntregaDataGridViewTextBoxColumn.Name = "fechaEntregaDataGridViewTextBoxColumn";
            this.fechaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeTotalDataGridViewTextBoxColumn
            // 
            this.importeTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.Name = "importeTotalDataGridViewTextBoxColumn";
            this.importeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alquilerBindingSource
            // 
            this.listaAlquileresSource.DataSource = typeof(AppAlquilerAutomoviles.Modelos.Alquiler);
            // 
            // AdministrarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 289);
            this.Controls.Add(this.btnRecaudado);
            this.Controls.Add(this.btnMasAlquilado);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnClienteMasDias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Name = "AdministrarVehiculos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlquileresSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaAlquileresSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClienteMasDias;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnMasAlquilado;
        private System.Windows.Forms.Button btnRecaudado;
    }
}

