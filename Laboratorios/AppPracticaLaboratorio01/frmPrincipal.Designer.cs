namespace AppWinPrácticaLab01Banco
{
    partial class frmPrincipal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPagoInteres = new MetroFramework.Controls.MetroButton();
            this.btnMejorCliente = new MetroFramework.Controls.MetroButton();
            this.btnDeposito = new MetroFramework.Controls.MetroButton();
            this.btnApertura = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 203);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(683, 87);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPagoInteres, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMejorCliente, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeposito, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnApertura, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPagoInteres
            // 
            this.btnPagoInteres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagoInteres.Location = new System.Drawing.Point(507, 3);
            this.btnPagoInteres.Name = "btnPagoInteres";
            this.btnPagoInteres.Size = new System.Drawing.Size(163, 71);
            this.btnPagoInteres.TabIndex = 3;
            this.btnPagoInteres.Text = "Pago interés";
            this.btnPagoInteres.UseSelectable = true;
            this.btnPagoInteres.Click += new System.EventHandler(this.btnPagoInteres_Click);
            // 
            // btnMejorCliente
            // 
            this.btnMejorCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMejorCliente.Location = new System.Drawing.Point(339, 3);
            this.btnMejorCliente.Name = "btnMejorCliente";
            this.btnMejorCliente.Size = new System.Drawing.Size(162, 71);
            this.btnMejorCliente.TabIndex = 2;
            this.btnMejorCliente.Text = "Mejor cliente";
            this.btnMejorCliente.UseSelectable = true;
            this.btnMejorCliente.Click += new System.EventHandler(this.btnMejorCliente_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeposito.Location = new System.Drawing.Point(171, 3);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(162, 71);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Deposito/Retiro";
            this.btnDeposito.UseSelectable = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnApertura
            // 
            this.btnApertura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApertura.Location = new System.Drawing.Point(3, 3);
            this.btnApertura.Name = "btnApertura";
            this.btnApertura.Size = new System.Drawing.Size(162, 71);
            this.btnApertura.TabIndex = 0;
            this.btnApertura.Text = "Apertura de cuenta";
            this.btnApertura.UseSelectable = true;
            this.btnApertura.Click += new System.EventHandler(this.btnApertura_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 290);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 203);
            this.panel3.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Simulación de un Banco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnPagoInteres;
        private MetroFramework.Controls.MetroButton btnMejorCliente;
        private MetroFramework.Controls.MetroButton btnDeposito;
        private MetroFramework.Controls.MetroButton btnApertura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

