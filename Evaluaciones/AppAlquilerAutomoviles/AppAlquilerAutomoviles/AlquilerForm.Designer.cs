namespace AppAlquilerAutomoviles
{
    partial class AlquilerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.fechaRecogida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de entrega:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbD);
            this.groupBox1.Controls.Add(this.rbG);
            this.groupBox1.Location = new System.Drawing.Point(62, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelo de vehiculo";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(27, 44);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(82, 17);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "MODELO D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.Checked = true;
            this.rbG.Location = new System.Drawing.Point(27, 20);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(82, 17);
            this.rbG.TabIndex = 0;
            this.rbG.TabStop = true;
            this.rbG.Text = "MODELO G";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de recogida:";
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.Location = new System.Drawing.Point(114, 157);
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.fechaEntrega.TabIndex = 9;
            // 
            // fechaRecogida
            // 
            this.fechaRecogida.Location = new System.Drawing.Point(114, 183);
            this.fechaRecogida.Name = "fechaRecogida";
            this.fechaRecogida.Size = new System.Drawing.Size(200, 20);
            this.fechaRecogida.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alquiler de vehiculo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(37, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 44);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.txtCliente.DisplayMember = "Nombre";
            this.txtCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(62, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(166, 21);
            this.txtCliente.TabIndex = 14;
            this.txtCliente.ValueMember = "Nombre";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(AppAlquilerAutomoviles.Modelos.Cliente);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "+ Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlquilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaRecogida);
            this.Controls.Add(this.fechaEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AlquilerForm";
            this.Text = "Alquiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaEntrega;
        private System.Windows.Forms.DateTimePicker fechaRecogida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button button1;
    }
}