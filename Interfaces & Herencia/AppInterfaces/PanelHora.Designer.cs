namespace AppInterfaces
{
    partial class PanelHora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelHora));
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCostoHora = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHora = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 162);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 30);
            this.bunifuCustomLabel1.TabIndex = 46;
            this.bunifuCustomLabel1.Text = "Costo Hora:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCostoHora
            // 
            this.txtCostoHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCostoHora.HintForeColor = System.Drawing.Color.Empty;
            this.txtCostoHora.HintText = "";
            this.txtCostoHora.isPassword = false;
            this.txtCostoHora.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtCostoHora.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtCostoHora.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtCostoHora.LineThickness = 4;
            this.txtCostoHora.Location = new System.Drawing.Point(165, 162);
            this.txtCostoHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCostoHora.Name = "txtCostoHora";
            this.txtCostoHora.Size = new System.Drawing.Size(178, 31);
            this.txtCostoHora.TabIndex = 47;
            this.txtCostoHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(36, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 30);
            this.label.TabIndex = 44;
            this.label.Text = "Horas:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHora
            // 
            this.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHora.HintForeColor = System.Drawing.Color.Empty;
            this.txtHora.HintText = "";
            this.txtHora.isPassword = false;
            this.txtHora.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtHora.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtHora.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtHora.LineThickness = 4;
            this.txtHora.Location = new System.Drawing.Point(168, 114);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(178, 31);
            this.txtHora.TabIndex = 45;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PanelHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtCostoHora);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnGuardar);
            this.Name = "PanelHora";
            this.Size = new System.Drawing.Size(385, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCostoHora;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHora;
    }
}
