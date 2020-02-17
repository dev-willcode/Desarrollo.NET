namespace Presentación
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTransportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarGuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeEmpleadosToolStripMenuItem,
            this.facturacionStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(932, 54);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCategoriaToolStripMenuItem,
            this.administrarProveedorToolStripMenuItem,
            this.administrarProductoToolStripMenuItem1});
            this.gestionDeEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionDeEmpleadosToolStripMenuItem.Image")));
            this.gestionDeEmpleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(120, 50);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Inventario";
            // 
            // administrarCategoriaToolStripMenuItem
            // 
            this.administrarCategoriaToolStripMenuItem.Name = "administrarCategoriaToolStripMenuItem";
            this.administrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.administrarCategoriaToolStripMenuItem.Text = "Administrar Categoria";
            this.administrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.administrarCategoriaToolStripMenuItem_Click);
            // 
            // administrarProveedorToolStripMenuItem
            // 
            this.administrarProveedorToolStripMenuItem.Name = "administrarProveedorToolStripMenuItem";
            this.administrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.administrarProveedorToolStripMenuItem.Text = "Administrar Proveedor";
            this.administrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.administrarProveedorToolStripMenuItem_Click);
            // 
            // administrarProductoToolStripMenuItem1
            // 
            this.administrarProductoToolStripMenuItem1.Name = "administrarProductoToolStripMenuItem1";
            this.administrarProductoToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.administrarProductoToolStripMenuItem1.Text = "Administrar Producto";
            this.administrarProductoToolStripMenuItem1.Click += new System.EventHandler(this.administrarProductoToolStripMenuItem1_Click);
            // 
            // facturacionStripMenuItem
            // 
            this.facturacionStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarLocalToolStripMenuItem,
            this.administrarTransportistaToolStripMenuItem,
            this.administrarGuToolStripMenuItem,
            this.administrarOrdenToolStripMenuItem});
            this.facturacionStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturacionStripMenuItem.Image")));
            this.facturacionStripMenuItem.Name = "facturacionStripMenuItem";
            this.facturacionStripMenuItem.Size = new System.Drawing.Size(105, 50);
            this.facturacionStripMenuItem.Text = "Facturación";
            // 
            // administrarLocalToolStripMenuItem
            // 
            this.administrarLocalToolStripMenuItem.Name = "administrarLocalToolStripMenuItem";
            this.administrarLocalToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarLocalToolStripMenuItem.Text = "Administrar Local";
            this.administrarLocalToolStripMenuItem.Click += new System.EventHandler(this.administrarLocalToolStripMenuItem_Click);
            // 
            // administrarTransportistaToolStripMenuItem
            // 
            this.administrarTransportistaToolStripMenuItem.Name = "administrarTransportistaToolStripMenuItem";
            this.administrarTransportistaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarTransportistaToolStripMenuItem.Text = "Administrar Transportista";
            this.administrarTransportistaToolStripMenuItem.Click += new System.EventHandler(this.abrirTransportista);
            // 
            // administrarGuToolStripMenuItem
            // 
            this.administrarGuToolStripMenuItem.Name = "administrarGuToolStripMenuItem";
            this.administrarGuToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarGuToolStripMenuItem.Text = "Administrar Guía";
            this.administrarGuToolStripMenuItem.Click += new System.EventHandler(this.abrirGuia);
            // 
            // administrarOrdenToolStripMenuItem
            // 
            this.administrarOrdenToolStripMenuItem.Name = "administrarOrdenToolStripMenuItem";
            this.administrarOrdenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarOrdenToolStripMenuItem.Text = "Administrar Orden";
            this.administrarOrdenToolStripMenuItem.Click += new System.EventHandler(this.abrirOrden);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 50);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 50);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCategoriasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 50);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // reporteCategoriasToolStripMenuItem
            // 
            this.reporteCategoriasToolStripMenuItem.Name = "reporteCategoriasToolStripMenuItem";
            this.reporteCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteCategoriasToolStripMenuItem.Text = "Reporte categorias";
            this.reporteCategoriasToolStripMenuItem.Click += new System.EventHandler(this.reporteCategoriasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 507);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturacionStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarTransportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarGuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteCategoriasToolStripMenuItem;
    }
}