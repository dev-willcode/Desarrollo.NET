namespace AppPartesDelComputador
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb16tb = new System.Windows.Forms.RadioButton();
            this.rb1tb = new System.Windows.Forms.RadioButton();
            this.rb4tb = new System.Windows.Forms.RadioButton();
            this.rb512gb = new System.Windows.Forms.RadioButton();
            this.chAccesorios = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMDA = new System.Windows.Forms.RadioButton();
            this.rbEption = new System.Windows.Forms.RadioButton();
            this.rbSXM = new System.Windows.Forms.RadioButton();
            this.rbElestra = new System.Windows.Forms.RadioButton();
            this.comboDisco = new System.Windows.Forms.ComboBox();
            this.chRaid = new System.Windows.Forms.CheckBox();
            this.chVideo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuardadas = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(145, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 34);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Accesorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Configuración de disco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb16tb);
            this.groupBox2.Controls.Add(this.rb1tb);
            this.groupBox2.Controls.Add(this.rb4tb);
            this.groupBox2.Controls.Add(this.rb512gb);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 105);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memoria";
            // 
            // rb16tb
            // 
            this.rb16tb.AutoSize = true;
            this.rb16tb.Location = new System.Drawing.Point(105, 55);
            this.rb16tb.Name = "rb16tb";
            this.rb16tb.Size = new System.Drawing.Size(54, 17);
            this.rb16tb.TabIndex = 5;
            this.rb16tb.Text = "16 TB";
            this.rb16tb.UseVisualStyleBackColor = true;
            // 
            // rb1tb
            // 
            this.rb1tb.AutoSize = true;
            this.rb1tb.Location = new System.Drawing.Point(6, 55);
            this.rb1tb.Name = "rb1tb";
            this.rb1tb.Size = new System.Drawing.Size(48, 17);
            this.rb1tb.TabIndex = 1;
            this.rb1tb.Text = "1 TB";
            this.rb1tb.UseVisualStyleBackColor = true;
            // 
            // rb4tb
            // 
            this.rb4tb.AutoSize = true;
            this.rb4tb.Location = new System.Drawing.Point(105, 32);
            this.rb4tb.Name = "rb4tb";
            this.rb4tb.Size = new System.Drawing.Size(48, 17);
            this.rb4tb.TabIndex = 4;
            this.rb4tb.Text = "4 TB";
            this.rb4tb.UseVisualStyleBackColor = true;
            // 
            // rb512gb
            // 
            this.rb512gb.AutoSize = true;
            this.rb512gb.Checked = true;
            this.rb512gb.Location = new System.Drawing.Point(6, 32);
            this.rb512gb.Name = "rb512gb";
            this.rb512gb.Size = new System.Drawing.Size(64, 17);
            this.rb512gb.TabIndex = 0;
            this.rb512gb.TabStop = true;
            this.rb512gb.Text = "512 GB ";
            this.rb512gb.UseVisualStyleBackColor = true;
            // 
            // chAccesorios
            // 
            this.chAccesorios.FormattingEnabled = true;
            this.chAccesorios.Location = new System.Drawing.Point(227, 147);
            this.chAccesorios.Name = "chAccesorios";
            this.chAccesorios.Size = new System.Drawing.Size(209, 79);
            this.chAccesorios.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMDA);
            this.groupBox1.Controls.Add(this.rbEption);
            this.groupBox1.Controls.Add(this.rbSXM);
            this.groupBox1.Controls.Add(this.rbElestra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesador";
            // 
            // rbMDA
            // 
            this.rbMDA.AutoSize = true;
            this.rbMDA.Location = new System.Drawing.Point(110, 55);
            this.rbMDA.Name = "rbMDA";
            this.rbMDA.Size = new System.Drawing.Size(49, 17);
            this.rbMDA.TabIndex = 3;
            this.rbMDA.Text = "MDA";
            this.rbMDA.UseVisualStyleBackColor = true;
            // 
            // rbEption
            // 
            this.rbEption.AutoSize = true;
            this.rbEption.Location = new System.Drawing.Point(110, 32);
            this.rbEption.Name = "rbEption";
            this.rbEption.Size = new System.Drawing.Size(55, 17);
            this.rbEption.TabIndex = 2;
            this.rbEption.Text = "Eption";
            this.rbEption.UseVisualStyleBackColor = true;
            // 
            // rbSXM
            // 
            this.rbSXM.AutoSize = true;
            this.rbSXM.Location = new System.Drawing.Point(6, 55);
            this.rbSXM.Name = "rbSXM";
            this.rbSXM.Size = new System.Drawing.Size(48, 17);
            this.rbSXM.TabIndex = 1;
            this.rbSXM.Text = "SXM";
            this.rbSXM.UseVisualStyleBackColor = true;
            // 
            // rbElestra
            // 
            this.rbElestra.AutoSize = true;
            this.rbElestra.Checked = true;
            this.rbElestra.Location = new System.Drawing.Point(6, 32);
            this.rbElestra.Name = "rbElestra";
            this.rbElestra.Size = new System.Drawing.Size(57, 17);
            this.rbElestra.TabIndex = 0;
            this.rbElestra.TabStop = true;
            this.rbElestra.Text = "Elestra";
            this.rbElestra.UseVisualStyleBackColor = true;
            // 
            // comboDisco
            // 
            this.comboDisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDisco.FormattingEnabled = true;
            this.comboDisco.Location = new System.Drawing.Point(9, 206);
            this.comboDisco.Name = "comboDisco";
            this.comboDisco.Size = new System.Drawing.Size(203, 21);
            this.comboDisco.TabIndex = 30;
            // 
            // chRaid
            // 
            this.chRaid.AutoSize = true;
            this.chRaid.Location = new System.Drawing.Point(12, 131);
            this.chRaid.Name = "chRaid";
            this.chRaid.Size = new System.Drawing.Size(109, 17);
            this.chRaid.TabIndex = 31;
            this.chRaid.Text = "Controlador RAID";
            this.chRaid.UseVisualStyleBackColor = true;
            // 
            // chVideo
            // 
            this.chVideo.AutoSize = true;
            this.chVideo.Location = new System.Drawing.Point(12, 154);
            this.chVideo.Name = "chVideo";
            this.chVideo.Size = new System.Drawing.Size(119, 17);
            this.chVideo.TabIndex = 32;
            this.chVideo.Text = "Grabación de video";
            this.chVideo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Configuraciones guardadas";
            // 
            // txtGuardadas
            // 
            this.txtGuardadas.Location = new System.Drawing.Point(9, 301);
            this.txtGuardadas.Multiline = true;
            this.txtGuardadas.Name = "txtGuardadas";
            this.txtGuardadas.Size = new System.Drawing.Size(427, 95);
            this.txtGuardadas.TabIndex = 34;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 411);
            this.Controls.Add(this.txtGuardadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chVideo);
            this.Controls.Add(this.chRaid);
            this.Controls.Add(this.comboDisco);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chAccesorios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb16tb;
        private System.Windows.Forms.RadioButton rb1tb;
        private System.Windows.Forms.RadioButton rb4tb;
        private System.Windows.Forms.RadioButton rb512gb;
        private System.Windows.Forms.CheckedListBox chAccesorios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMDA;
        private System.Windows.Forms.RadioButton rbEption;
        private System.Windows.Forms.RadioButton rbSXM;
        private System.Windows.Forms.RadioButton rbElestra;
        private System.Windows.Forms.ComboBox comboDisco;
        private System.Windows.Forms.CheckBox chRaid;
        private System.Windows.Forms.CheckBox chVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuardadas;
    }
}

