namespace Presentación.Faturacion
{
    partial class frmAdminOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTransportista));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlsBarraAdmin = new System.Windows.Forms.ToolStrip();
            this.insertarStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.actualizarStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.eliminarStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlsBarraAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 295);
            this.dataGridView1.TabIndex = 30;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(56, 341);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 39);
            this.panel1.TabIndex = 28;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(136, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(140, 22);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar";
            // 
            // tlsBarraAdmin
            // 
            this.tlsBarraAdmin.AutoSize = false;
            this.tlsBarraAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlsBarraAdmin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsBarraAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarStripButton1,
            this.actualizarStripButton2,
            this.eliminarStripButton3});
            this.tlsBarraAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tlsBarraAdmin.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraAdmin.Name = "tlsBarraAdmin";
            this.tlsBarraAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tlsBarraAdmin.Size = new System.Drawing.Size(56, 366);
            this.tlsBarraAdmin.TabIndex = 27;
            this.tlsBarraAdmin.Text = "toolStrip2";
            // 
            // insertarStripButton1
            // 
            this.insertarStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("insertarStripButton1.Image")));
            this.insertarStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertarStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertarStripButton1.Name = "insertarStripButton1";
            this.insertarStripButton1.Size = new System.Drawing.Size(53, 51);
            this.insertarStripButton1.Text = "Insertar";
            this.insertarStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.insertarStripButton1.Click += new System.EventHandler(this.insertarStripButton1_Click);
            // 
            // actualizarStripButton2
            // 
            this.actualizarStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("actualizarStripButton2.Image")));
            this.actualizarStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizarStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizarStripButton2.Name = "actualizarStripButton2";
            this.actualizarStripButton2.Size = new System.Drawing.Size(53, 51);
            this.actualizarStripButton2.Text = "Actualizar";
            this.actualizarStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.actualizarStripButton2.Click += new System.EventHandler(this.actualizarStripButton2_Click);
            // 
            // eliminarStripButton3
            // 
            this.eliminarStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("eliminarStripButton3.Image")));
            this.eliminarStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarStripButton3.Name = "eliminarStripButton3";
            this.eliminarStripButton3.Size = new System.Drawing.Size(53, 51);
            this.eliminarStripButton3.Text = "Eliminar";
            this.eliminarStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eliminarStripButton3.Click += new System.EventHandler(this.eliminarStripButton3_Click);
            // 
            // frmAdminTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlsBarraAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminTransportista";
            this.Text = "frmAdminLocal";
            this.Load += new System.EventHandler(this.frmAdminOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlsBarraAdmin.ResumeLayout(false);
            this.tlsBarraAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tlsBarraAdmin;
        private System.Windows.Forms.ToolStripButton insertarStripButton1;
        private System.Windows.Forms.ToolStripButton actualizarStripButton2;
        private System.Windows.Forms.ToolStripButton eliminarStripButton3;
    }
}