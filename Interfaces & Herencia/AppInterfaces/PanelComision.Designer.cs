namespace AppInterfaces
{
    partial class PanelComision
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelComision));
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtVentas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPorcentaje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 23;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.btnGuardar.IdleForecolor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(105, 250);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(184, 54);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(36, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(144, 30);
            this.label.TabIndex = 40;
            this.label.Text = "Ventas brutas:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVentas
            // 
            this.txtVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVentas.HintForeColor = System.Drawing.Color.Empty;
            this.txtVentas.HintText = "";
            this.txtVentas.isPassword = false;
            this.txtVentas.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtVentas.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtVentas.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtVentas.LineThickness = 4;
            this.txtVentas.Location = new System.Drawing.Point(187, 115);
            this.txtVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(156, 31);
            this.txtVentas.TabIndex = 41;
            this.txtVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 152);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 30);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Porcentaje:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorcentaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPorcentaje.HintForeColor = System.Drawing.Color.Empty;
            this.txtPorcentaje.HintText = "";
            this.txtPorcentaje.isPassword = false;
            this.txtPorcentaje.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtPorcentaje.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtPorcentaje.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPorcentaje.LineThickness = 4;
            this.txtPorcentaje.Location = new System.Drawing.Point(162, 152);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(184, 31);
            this.txtPorcentaje.TabIndex = 43;
            this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PanelComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.btnGuardar);
            this.Name = "PanelComision";
            this.Size = new System.Drawing.Size(385, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVentas;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPorcentaje;
    }
}
