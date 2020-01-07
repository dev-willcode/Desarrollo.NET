namespace AppExamenHemisemestre01
{
    partial class FormEspectador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tablaEspectadores = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEspectadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Añadir Espectador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Location = new System.Drawing.Point(576, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 39);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(83, 10);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 17);
            this.rbF.TabIndex = 1;
            this.rbF.TabStop = true;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(4, 10);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(73, 17);
            this.rbM.TabIndex = 0;
            this.rbM.TabStop = true;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(576, 68);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(158, 20);
            this.txtCedula.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(576, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(576, 119);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(158, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(513, 190);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(221, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tablaEspectadores
            // 
            this.tablaEspectadores.AllowUserToAddRows = false;
            this.tablaEspectadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEspectadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEspectadores.Location = new System.Drawing.Point(16, 68);
            this.tablaEspectadores.Name = "tablaEspectadores";
            this.tablaEspectadores.ReadOnly = true;
            this.tablaEspectadores.Size = new System.Drawing.Size(468, 157);
            this.tablaEspectadores.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Espectadores registrados:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(714, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormEspectador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 291);
            this.Controls.Add(this.tablaEspectadores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEspectador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEspectador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEspectadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView tablaEspectadores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}