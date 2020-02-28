namespace AppPruebaHemisemestre02
{
    partial class Inicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuias = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCamiones = new System.Windows.Forms.Button();
            this.btnEncomienda = new System.Windows.Forms.Button();
            this.btnGuiasEnvio = new System.Windows.Forms.Button();
            this.btnEncomiendas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 89);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuiasEnvio, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEncomiendas, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGuias, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCamiones, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEncomienda, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGuias
            // 
            this.btnGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuias.Location = new System.Drawing.Point(492, 3);
            this.btnGuias.Name = "btnGuias";
            this.btnGuias.Size = new System.Drawing.Size(157, 83);
            this.btnGuias.TabIndex = 4;
            this.btnGuias.Text = "Administrar Guias";
            this.btnGuias.UseVisualStyleBackColor = true;
            this.btnGuias.Click += new System.EventHandler(this.btnGuias_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(3, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(157, 83);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Administrar Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCamiones
            // 
            this.btnCamiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCamiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamiones.Location = new System.Drawing.Point(329, 3);
            this.btnCamiones.Name = "btnCamiones";
            this.btnCamiones.Size = new System.Drawing.Size(157, 83);
            this.btnCamiones.TabIndex = 3;
            this.btnCamiones.Text = "Administrar Camiones";
            this.btnCamiones.UseVisualStyleBackColor = true;
            this.btnCamiones.Click += new System.EventHandler(this.btnCamiones_Click);
            // 
            // btnEncomienda
            // 
            this.btnEncomienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncomienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncomienda.Location = new System.Drawing.Point(166, 3);
            this.btnEncomienda.Name = "btnEncomienda";
            this.btnEncomienda.Size = new System.Drawing.Size(157, 83);
            this.btnEncomienda.TabIndex = 2;
            this.btnEncomienda.Text = "Administrar Encomiendas";
            this.btnEncomienda.UseVisualStyleBackColor = true;
            this.btnEncomienda.Click += new System.EventHandler(this.btnEncomienda_Click);
            // 
            // btnGuiasEnvio
            // 
            this.btnGuiasEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuiasEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiasEnvio.Location = new System.Drawing.Point(818, 3);
            this.btnGuiasEnvio.Name = "btnGuiasEnvio";
            this.btnGuiasEnvio.Size = new System.Drawing.Size(158, 83);
            this.btnGuiasEnvio.TabIndex = 2;
            this.btnGuiasEnvio.Text = "Reporte: Guias de envío";
            this.btnGuiasEnvio.UseVisualStyleBackColor = true;
            // 
            // btnEncomiendas
            // 
            this.btnEncomiendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncomiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncomiendas.Location = new System.Drawing.Point(655, 3);
            this.btnEncomiendas.Name = "btnEncomiendas";
            this.btnEncomiendas.Size = new System.Drawing.Size(157, 83);
            this.btnEncomiendas.TabIndex = 3;
            this.btnEncomiendas.Text = "Reporte: Encomiendas por entregar";
            this.btnEncomiendas.UseVisualStyleBackColor = true;
            this.btnEncomiendas.Click += new System.EventHandler(this.btnEncomiendas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 607);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGuias;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnCamiones;
        private System.Windows.Forms.Button btnEncomienda;
        private System.Windows.Forms.Button btnGuiasEnvio;
        private System.Windows.Forms.Button btnEncomiendas;
    }
}