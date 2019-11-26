namespace Proyecto01
{
    partial class Principal
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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnIngrediente = new System.Windows.Forms.Button();
            this.btnNuevoPlato = new System.Windows.Forms.Button();
            this.listboxOrigen = new System.Windows.Forms.ListBox();
            this.listboxDestino = new System.Windows.Forms.ListBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLlevar = new System.Windows.Forms.RadioButton();
            this.rbComerAqui = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chIsopo = new System.Windows.Forms.CheckBox();
            this.chAluminio = new System.Windows.Forms.CheckBox();
            this.chPlastico = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chVino = new System.Windows.Forms.CheckBox();
            this.chCerveza = new System.Windows.Forms.CheckBox();
            this.chGaseosa = new System.Windows.Forms.CheckBox();
            this.chJugo = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIZZA UTSAM";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(183, 69);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(136, 34);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir >>";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(183, 109);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(136, 34);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar <<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnIngrediente
            // 
            this.btnIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngrediente.Location = new System.Drawing.Point(183, 149);
            this.btnIngrediente.Name = "btnIngrediente";
            this.btnIngrediente.Size = new System.Drawing.Size(136, 34);
            this.btnIngrediente.TabIndex = 3;
            this.btnIngrediente.Text = "Especial";
            this.btnIngrediente.UseVisualStyleBackColor = true;
            this.btnIngrediente.Click += new System.EventHandler(this.btnIngrediente_Click);
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPlato.Location = new System.Drawing.Point(183, 189);
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(136, 34);
            this.btnNuevoPlato.TabIndex = 4;
            this.btnNuevoPlato.Text = "Nuevo plato";
            this.btnNuevoPlato.UseVisualStyleBackColor = true;
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevoPlato_Click);
            // 
            // listboxOrigen
            // 
            this.listboxOrigen.FormattingEnabled = true;
            this.listboxOrigen.Location = new System.Drawing.Point(15, 78);
            this.listboxOrigen.Name = "listboxOrigen";
            this.listboxOrigen.Size = new System.Drawing.Size(154, 134);
            this.listboxOrigen.TabIndex = 5;
            // 
            // listboxDestino
            // 
            this.listboxDestino.FormattingEnabled = true;
            this.listboxDestino.Location = new System.Drawing.Point(334, 78);
            this.listboxDestino.Name = "listboxDestino";
            this.listboxDestino.Size = new System.Drawing.Size(154, 134);
            this.listboxDestino.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(97, 37);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(391, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CLIENTE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLlevar);
            this.groupBox1.Controls.Add(this.rbComerAqui);
            this.groupBox1.Location = new System.Drawing.Point(52, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCAL";
            // 
            // rbLlevar
            // 
            this.rbLlevar.AutoSize = true;
            this.rbLlevar.Location = new System.Drawing.Point(6, 55);
            this.rbLlevar.Name = "rbLlevar";
            this.rbLlevar.Size = new System.Drawing.Size(98, 17);
            this.rbLlevar.TabIndex = 1;
            this.rbLlevar.Text = "PARA LLEVAR";
            this.rbLlevar.UseVisualStyleBackColor = true;
            // 
            // rbComerAqui
            // 
            this.rbComerAqui.AutoSize = true;
            this.rbComerAqui.Checked = true;
            this.rbComerAqui.Location = new System.Drawing.Point(6, 32);
            this.rbComerAqui.Name = "rbComerAqui";
            this.rbComerAqui.Size = new System.Drawing.Size(93, 17);
            this.rbComerAqui.TabIndex = 0;
            this.rbComerAqui.TabStop = true;
            this.rbComerAqui.Text = "COMER AQUI";
            this.rbComerAqui.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chIsopo);
            this.groupBox2.Controls.Add(this.chAluminio);
            this.groupBox2.Controls.Add(this.chPlastico);
            this.groupBox2.Location = new System.Drawing.Point(195, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENVASE";
            // 
            // chIsopo
            // 
            this.chIsopo.AutoSize = true;
            this.chIsopo.Enabled = false;
            this.chIsopo.Location = new System.Drawing.Point(6, 78);
            this.chIsopo.Name = "chIsopo";
            this.chIsopo.Size = new System.Drawing.Size(59, 17);
            this.chIsopo.TabIndex = 2;
            this.chIsopo.Text = "ISOPO";
            this.chIsopo.UseVisualStyleBackColor = true;
            // 
            // chAluminio
            // 
            this.chAluminio.AutoSize = true;
            this.chAluminio.Enabled = false;
            this.chAluminio.Location = new System.Drawing.Point(6, 55);
            this.chAluminio.Name = "chAluminio";
            this.chAluminio.Size = new System.Drawing.Size(78, 17);
            this.chAluminio.TabIndex = 1;
            this.chAluminio.Text = "ALUMINIO";
            this.chAluminio.UseVisualStyleBackColor = true;
            // 
            // chPlastico
            // 
            this.chPlastico.AutoSize = true;
            this.chPlastico.Enabled = false;
            this.chPlastico.Location = new System.Drawing.Point(6, 32);
            this.chPlastico.Name = "chPlastico";
            this.chPlastico.Size = new System.Drawing.Size(78, 17);
            this.chPlastico.TabIndex = 0;
            this.chPlastico.Text = "PLASTICO";
            this.chPlastico.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chVino);
            this.groupBox3.Controls.Add(this.chCerveza);
            this.groupBox3.Controls.Add(this.chGaseosa);
            this.groupBox3.Controls.Add(this.chJugo);
            this.groupBox3.Location = new System.Drawing.Point(339, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 105);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BEBIDAS";
            // 
            // chVino
            // 
            this.chVino.AutoSize = true;
            this.chVino.Location = new System.Drawing.Point(14, 88);
            this.chVino.Name = "chVino";
            this.chVino.Size = new System.Drawing.Size(52, 17);
            this.chVino.TabIndex = 6;
            this.chVino.Text = "VINO";
            this.chVino.UseVisualStyleBackColor = true;
            // 
            // chCerveza
            // 
            this.chCerveza.AutoSize = true;
            this.chCerveza.Location = new System.Drawing.Point(14, 67);
            this.chCerveza.Name = "chCerveza";
            this.chCerveza.Size = new System.Drawing.Size(76, 17);
            this.chCerveza.TabIndex = 5;
            this.chCerveza.Text = "CERVEZA";
            this.chCerveza.UseVisualStyleBackColor = true;
            // 
            // chGaseosa
            // 
            this.chGaseosa.AutoSize = true;
            this.chGaseosa.Location = new System.Drawing.Point(14, 44);
            this.chGaseosa.Name = "chGaseosa";
            this.chGaseosa.Size = new System.Drawing.Size(77, 17);
            this.chGaseosa.TabIndex = 4;
            this.chGaseosa.Text = "GASEOSA";
            this.chGaseosa.UseVisualStyleBackColor = true;
            // 
            // chJugo
            // 
            this.chJugo.AutoSize = true;
            this.chJugo.Location = new System.Drawing.Point(14, 21);
            this.chJugo.Name = "chJugo";
            this.chJugo.Size = new System.Drawing.Size(55, 17);
            this.chJugo.TabIndex = 3;
            this.chJugo.Text = "JUGO";
            this.chJugo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalcular);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Location = new System.Drawing.Point(27, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 77);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LOCAL";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(318, 24);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 32);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TOTAL A PAGAR:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(126, 31);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(185, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.listboxDestino);
            this.Controls.Add(this.listboxOrigen);
            this.Controls.Add(this.btnNuevoPlato);
            this.Controls.Add(this.btnIngrediente);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnIngrediente;
        private System.Windows.Forms.Button btnNuevoPlato;
        private System.Windows.Forms.ListBox listboxOrigen;
        private System.Windows.Forms.ListBox listboxDestino;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLlevar;
        private System.Windows.Forms.RadioButton rbComerAqui;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chIsopo;
        private System.Windows.Forms.CheckBox chAluminio;
        private System.Windows.Forms.CheckBox chPlastico;
        private System.Windows.Forms.CheckBox chVino;
        private System.Windows.Forms.CheckBox chCerveza;
        private System.Windows.Forms.CheckBox chGaseosa;
        private System.Windows.Forms.CheckBox chJugo;
    }
}

