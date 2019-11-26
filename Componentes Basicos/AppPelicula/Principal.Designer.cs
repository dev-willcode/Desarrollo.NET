namespace AppPelicula
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.rbDrama = new System.Windows.Forms.RadioButton();
            this.rbAccion = new System.Windows.Forms.RadioButton();
            this.rbDibujos = new System.Windows.Forms.RadioButton();
            this.rbComedia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tblPelicula = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPelicula = new System.Windows.Forms.BindingSource(this.components);
            this.grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(369, 146);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 35);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total de películas:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(384, 366);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(251, 146);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(133, 146);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(76, 106);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(110, 20);
            this.txtDuracion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Película:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(390, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.rbDrama);
            this.grupo.Controls.Add(this.rbAccion);
            this.grupo.Controls.Add(this.rbDibujos);
            this.grupo.Controls.Add(this.rbComedia);
            this.grupo.Location = new System.Drawing.Point(23, 38);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(440, 59);
            this.grupo.TabIndex = 27;
            this.grupo.TabStop = false;
            this.grupo.Text = "Categoría:";
            // 
            // rbDrama
            // 
            this.rbDrama.AutoSize = true;
            this.rbDrama.Location = new System.Drawing.Point(346, 19);
            this.rbDrama.Name = "rbDrama";
            this.rbDrama.Size = new System.Drawing.Size(56, 17);
            this.rbDrama.TabIndex = 3;
            this.rbDrama.Text = "Drama";
            this.rbDrama.UseVisualStyleBackColor = true;
            // 
            // rbAccion
            // 
            this.rbAccion.AutoSize = true;
            this.rbAccion.Location = new System.Drawing.Point(137, 19);
            this.rbAccion.Name = "rbAccion";
            this.rbAccion.Size = new System.Drawing.Size(58, 17);
            this.rbAccion.TabIndex = 2;
            this.rbAccion.Text = "Acción";
            this.rbAccion.UseVisualStyleBackColor = true;
            // 
            // rbDibujos
            // 
            this.rbDibujos.AutoSize = true;
            this.rbDibujos.Location = new System.Drawing.Point(223, 19);
            this.rbDibujos.Name = "rbDibujos";
            this.rbDibujos.Size = new System.Drawing.Size(108, 17);
            this.rbDibujos.TabIndex = 1;
            this.rbDibujos.Text = "Dibujos animados";
            this.rbDibujos.UseVisualStyleBackColor = true;
            // 
            // rbComedia
            // 
            this.rbComedia.AutoSize = true;
            this.rbComedia.Checked = true;
            this.rbComedia.Location = new System.Drawing.Point(38, 19);
            this.rbComedia.Name = "rbComedia";
            this.rbComedia.Size = new System.Drawing.Size(66, 17);
            this.rbComedia.TabIndex = 0;
            this.rbComedia.TabStop = true;
            this.rbComedia.Text = "Comedia";
            this.rbComedia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Actor Principal:";
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(319, 106);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(144, 20);
            this.txtActor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "min.";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 146);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 35);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tblPelicula
            // 
            this.tblPelicula.AllowUserToAddRows = false;
            this.tblPelicula.AutoGenerateColumns = false;
            this.tblPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn});
            this.tblPelicula.DataSource = this.bsPelicula;
            this.tblPelicula.Location = new System.Drawing.Point(23, 197);
            this.tblPelicula.Name = "tblPelicula";
            this.tblPelicula.Size = new System.Drawing.Size(443, 150);
            this.tblPelicula.TabIndex = 32;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            this.actorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPelicula
            // 
            this.bsPelicula.DataSource = typeof(AppPelicula.Clases.Pelicula);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 395);
            this.Controls.Add(this.tblPelicula);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "Principal";
            this.Text = "Form1";
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.RadioButton rbDrama;
        private System.Windows.Forms.RadioButton rbAccion;
        private System.Windows.Forms.RadioButton rbDibujos;
        private System.Windows.Forms.RadioButton rbComedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView tblPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsPelicula;
    }
}

