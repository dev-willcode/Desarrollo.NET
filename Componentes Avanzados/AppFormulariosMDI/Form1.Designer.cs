namespace AppFormulariosMDI
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenciasLINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPersonasToolStripMenuItem,
            this.sentenciasLINQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarPersonasToolStripMenuItem
            // 
            this.gestionarPersonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPersonasToolStripMenuItem});
            this.gestionarPersonasToolStripMenuItem.Name = "gestionarPersonasToolStripMenuItem";
            this.gestionarPersonasToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionarPersonasToolStripMenuItem.Text = "Gestionar personas";
            // 
            // sentenciasLINQToolStripMenuItem
            // 
            this.sentenciasLINQToolStripMenuItem.Name = "sentenciasLINQToolStripMenuItem";
            this.sentenciasLINQToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.sentenciasLINQToolStripMenuItem.Text = "Sentencias LINQ";
            // 
            // administrarPersonasToolStripMenuItem
            // 
            this.administrarPersonasToolStripMenuItem.Name = "administrarPersonasToolStripMenuItem";
            this.administrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.administrarPersonasToolStripMenuItem.Text = "Administrar Personas...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenciasLINQToolStripMenuItem;
    }
}

