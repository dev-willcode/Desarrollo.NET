namespace AppOperadorLambda
{
    partial class formContacto
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.tablaFemeninos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaMasculinos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaMenoresEdad = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaContactos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFemeninos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMasculinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMenoresEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AutoGenerateColumns = false;
            this.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.data1.DataSource = this.listaContactos;
            this.data1.Location = new System.Drawing.Point(17, 41);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(626, 96);
            this.data1.TabIndex = 0;
            // 
            // tablaFemeninos
            // 
            this.tablaFemeninos.AllowUserToAddRows = false;
            this.tablaFemeninos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaFemeninos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFemeninos.Location = new System.Drawing.Point(30, 227);
            this.tablaFemeninos.Name = "tablaFemeninos";
            this.tablaFemeninos.Size = new System.Drawing.Size(299, 120);
            this.tablaFemeninos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos de contactos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.accion_Filtrar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contactos femeninos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contactos masculinos";
            // 
            // tablaMasculinos
            // 
            this.tablaMasculinos.AllowUserToAddRows = false;
            this.tablaMasculinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMasculinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMasculinos.Location = new System.Drawing.Point(344, 227);
            this.tablaMasculinos.Name = "tablaMasculinos";
            this.tablaMasculinos.Size = new System.Drawing.Size(299, 120);
            this.tablaMasculinos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contactos mayores a 30 años";
            // 
            // tablaMenoresEdad
            // 
            this.tablaMenoresEdad.AllowUserToAddRows = false;
            this.tablaMenoresEdad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMenoresEdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMenoresEdad.Location = new System.Drawing.Point(30, 392);
            this.tablaMenoresEdad.Name = "tablaMenoresEdad";
            this.tablaMenoresEdad.Size = new System.Drawing.Size(613, 84);
            this.tablaMenoresEdad.TabIndex = 8;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // listaContactos
            // 
            this.listaContactos.DataSource = typeof(AppOperadorLambda.Clases.Contacto);
            // 
            // formContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 484);
            this.Controls.Add(this.tablaMenoresEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaMasculinos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaFemeninos);
            this.Controls.Add(this.data1);
            this.Name = "formContacto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFemeninos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMasculinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMenoresEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.DataGridView tablaFemeninos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaMasculinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaContactos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaMenoresEdad;
    }
}

