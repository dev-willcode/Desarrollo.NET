namespace AppFacturaComputador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCoreDuo = new System.Windows.Forms.RadioButton();
            this.rbDualCore = new System.Windows.Forms.RadioButton();
            this.rbAMD = new System.Windows.Forms.RadioButton();
            this.rbP4 = new System.Windows.Forms.RadioButton();
            this.chAccesorios = new System.Windows.Forms.CheckedListBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.comboMonitor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb2gb = new System.Windows.Forms.RadioButton();
            this.rb512mb = new System.Windows.Forms.RadioButton();
            this.rb1gb = new System.Windows.Forms.RadioButton();
            this.rb256mb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblFactura = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCoreDuo);
            this.groupBox1.Controls.Add(this.rbDualCore);
            this.groupBox1.Controls.Add(this.rbAMD);
            this.groupBox1.Controls.Add(this.rbP4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesador";
            // 
            // rbCoreDuo
            // 
            this.rbCoreDuo.AutoSize = true;
            this.rbCoreDuo.Location = new System.Drawing.Point(110, 55);
            this.rbCoreDuo.Name = "rbCoreDuo";
            this.rbCoreDuo.Size = new System.Drawing.Size(79, 17);
            this.rbCoreDuo.TabIndex = 3;
            this.rbCoreDuo.Text = "Core 2 Duo";
            this.rbCoreDuo.UseVisualStyleBackColor = true;
            // 
            // rbDualCore
            // 
            this.rbDualCore.AutoSize = true;
            this.rbDualCore.Location = new System.Drawing.Point(110, 32);
            this.rbDualCore.Name = "rbDualCore";
            this.rbDualCore.Size = new System.Drawing.Size(72, 17);
            this.rbDualCore.TabIndex = 2;
            this.rbDualCore.Text = "Dual Core";
            this.rbDualCore.UseVisualStyleBackColor = true;
            // 
            // rbAMD
            // 
            this.rbAMD.AutoSize = true;
            this.rbAMD.Location = new System.Drawing.Point(6, 55);
            this.rbAMD.Name = "rbAMD";
            this.rbAMD.Size = new System.Drawing.Size(49, 17);
            this.rbAMD.TabIndex = 1;
            this.rbAMD.Text = "AMD";
            this.rbAMD.UseVisualStyleBackColor = true;
            // 
            // rbP4
            // 
            this.rbP4.AutoSize = true;
            this.rbP4.Checked = true;
            this.rbP4.Location = new System.Drawing.Point(6, 32);
            this.rbP4.Name = "rbP4";
            this.rbP4.Size = new System.Drawing.Size(38, 17);
            this.rbP4.TabIndex = 0;
            this.rbP4.TabStop = true;
            this.rbP4.Text = "P4";
            this.rbP4.UseVisualStyleBackColor = true;
            // 
            // chAccesorios
            // 
            this.chAccesorios.FormattingEnabled = true;
            this.chAccesorios.Location = new System.Drawing.Point(227, 147);
            this.chAccesorios.Name = "chAccesorios";
            this.chAccesorios.Size = new System.Drawing.Size(209, 64);
            this.chAccesorios.TabIndex = 12;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(47, 336);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(136, 34);
            this.btnGenerarFactura.TabIndex = 14;
            this.btnGenerarFactura.Text = "Generar factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // comboMonitor
            // 
            this.comboMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonitor.FormattingEnabled = true;
            this.comboMonitor.Location = new System.Drawing.Point(12, 147);
            this.comboMonitor.Name = "comboMonitor";
            this.comboMonitor.Size = new System.Drawing.Size(203, 21);
            this.comboMonitor.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb2gb);
            this.groupBox2.Controls.Add(this.rb512mb);
            this.groupBox2.Controls.Add(this.rb1gb);
            this.groupBox2.Controls.Add(this.rb256mb);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 105);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memoria";
            // 
            // rb2gb
            // 
            this.rb2gb.AutoSize = true;
            this.rb2gb.Location = new System.Drawing.Point(105, 55);
            this.rb2gb.Name = "rb2gb";
            this.rb2gb.Size = new System.Drawing.Size(49, 17);
            this.rb2gb.TabIndex = 5;
            this.rb2gb.Text = "2 GB";
            this.rb2gb.UseVisualStyleBackColor = true;
            // 
            // rb512mb
            // 
            this.rb512mb.AutoSize = true;
            this.rb512mb.Location = new System.Drawing.Point(6, 55);
            this.rb512mb.Name = "rb512mb";
            this.rb512mb.Size = new System.Drawing.Size(62, 17);
            this.rb512mb.TabIndex = 1;
            this.rb512mb.Text = "512 MB";
            this.rb512mb.UseVisualStyleBackColor = true;
            // 
            // rb1gb
            // 
            this.rb1gb.AutoSize = true;
            this.rb1gb.Location = new System.Drawing.Point(105, 32);
            this.rb1gb.Name = "rb1gb";
            this.rb1gb.Size = new System.Drawing.Size(49, 17);
            this.rb1gb.TabIndex = 4;
            this.rb1gb.Text = "1 GB";
            this.rb1gb.UseVisualStyleBackColor = true;
            // 
            // rb256mb
            // 
            this.rb256mb.AutoSize = true;
            this.rb256mb.Checked = true;
            this.rb256mb.Location = new System.Drawing.Point(6, 32);
            this.rb256mb.Name = "rb256mb";
            this.rb256mb.Size = new System.Drawing.Size(62, 17);
            this.rb256mb.TabIndex = 0;
            this.rb256mb.TabStop = true;
            this.rb256mb.Text = "256 MB";
            this.rb256mb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Accesorios";
            // 
            // tblFactura
            // 
            this.tblFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Valor,
            this.IVA});
            this.tblFactura.Location = new System.Drawing.Point(12, 220);
            this.tblFactura.Name = "tblFactura";
            this.tblFactura.Size = new System.Drawing.Size(443, 110);
            this.tblFactura.TabIndex = 22;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(47, 376);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 34);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subtotal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "IVA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(273, 346);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 27;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(272, 373);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 28;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(272, 399);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 426);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tblFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboMonitor);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.chAccesorios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAMD;
        private System.Windows.Forms.RadioButton rbP4;
        private System.Windows.Forms.CheckedListBox chAccesorios;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.RadioButton rbCoreDuo;
        private System.Windows.Forms.RadioButton rbDualCore;
        private System.Windows.Forms.ComboBox comboMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb2gb;
        private System.Windows.Forms.RadioButton rb512mb;
        private System.Windows.Forms.RadioButton rb1gb;
        private System.Windows.Forms.RadioButton rb256mb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblFactura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
    }
}