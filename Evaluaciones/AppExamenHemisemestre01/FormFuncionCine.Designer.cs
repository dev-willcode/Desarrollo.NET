namespace AppExamenHemisemestre01
{
    partial class FormFuncionCine
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiaFuncion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboPeliculas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboHorario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar función de cine";
            // 
            // txtdiaFuncion
            // 
            this.txtdiaFuncion.Location = new System.Drawing.Point(114, 58);
            this.txtdiaFuncion.Name = "txtdiaFuncion";
            this.txtdiaFuncion.Size = new System.Drawing.Size(200, 20);
            this.txtdiaFuncion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Día de la función:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de la función:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pelicula a emitir:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 43);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboPeliculas
            // 
            this.comboPeliculas.DisplayMember = "Titulo";
            this.comboPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeliculas.FormattingEnabled = true;
            this.comboPeliculas.Location = new System.Drawing.Point(114, 117);
            this.comboPeliculas.Name = "comboPeliculas";
            this.comboPeliculas.Size = new System.Drawing.Size(150, 21);
            this.comboPeliculas.TabIndex = 12;
            this.comboPeliculas.ValueMember = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio boleto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(114, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 21);
            this.button1.TabIndex = 15;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboHorario
            // 
            this.comboHorario.FormattingEnabled = true;
            this.comboHorario.Items.AddRange(new object[] {
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"});
            this.comboHorario.Location = new System.Drawing.Point(114, 87);
            this.comboHorario.Name = "comboHorario";
            this.comboHorario.Size = new System.Drawing.Size(200, 21);
            this.comboHorario.TabIndex = 17;
            // 
            // FormFuncionCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 236);
            this.Controls.Add(this.comboHorario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPeliculas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdiaFuncion);
            this.Controls.Add(this.label1);
            this.Name = "FormFuncionCine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFuncionCine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdiaFuncion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboPeliculas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboHorario;
    }
}