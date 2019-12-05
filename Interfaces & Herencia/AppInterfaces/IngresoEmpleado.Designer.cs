namespace AppInterfaces
{
    partial class IngresoEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoEmpleado));
            this.panelDer = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboTipoEmpleado = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInterno = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.fechaNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboEstadoCivil = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEdad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelIzq.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelDer.Controls.Add(this.btnClose);
            this.panelDer.Controls.Add(this.comboTipoEmpleado);
            this.panelDer.Controls.Add(this.bunifuCustomLabel1);
            this.panelDer.Controls.Add(this.panelInterno);
            this.panelDer.Controls.Add(this.bunifuSeparator2);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Location = new System.Drawing.Point(457, 0);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(445, 450);
            this.panelDer.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(390, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 37;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboTipoEmpleado
            // 
            this.comboTipoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.comboTipoEmpleado.BorderRadius = 3;
            this.comboTipoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.comboTipoEmpleado.Items = new string[] {
        "<Seleccione>",
        "Asalariado",
        "Asalariado Comisión",
        "Comisión",
        "Por hora"};
            this.comboTipoEmpleado.Location = new System.Drawing.Point(30, 77);
            this.comboTipoEmpleado.Name = "comboTipoEmpleado";
            this.comboTipoEmpleado.NomalColor = System.Drawing.Color.White;
            this.comboTipoEmpleado.onHoverColor = System.Drawing.Color.White;
            this.comboTipoEmpleado.selectedIndex = -1;
            this.comboTipoEmpleado.Size = new System.Drawing.Size(223, 35);
            this.comboTipoEmpleado.TabIndex = 35;
            this.comboTipoEmpleado.onItemSelected += new System.EventHandler(this.eventoCambioTipo);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(190, 30);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Tipo de Empleado";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInterno
            // 
            this.panelInterno.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelInterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelInterno.Location = new System.Drawing.Point(29, 121);
            this.panelInterno.Name = "panelInterno";
            this.panelInterno.Size = new System.Drawing.Size(385, 317);
            this.panelInterno.TabIndex = 29;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(30, 52);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(223, 19);
            this.bunifuSeparator2.TabIndex = 28;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.White;
            this.panelIzq.Controls.Add(this.fechaNacimiento);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel2);
            this.panelIzq.Controls.Add(this.comboEstadoCivil);
            this.panelIzq.Controls.Add(this.bunifuSeparator3);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel9);
            this.panelIzq.Controls.Add(this.txtCedula);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel10);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel7);
            this.panelIzq.Controls.Add(this.txtNombre);
            this.panelIzq.Controls.Add(this.groupBox2);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel11);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel6);
            this.panelIzq.Controls.Add(this.txtApellido);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel12);
            this.panelIzq.Controls.Add(this.txtCiudad);
            this.panelIzq.Controls.Add(this.bunifuCustomLabel5);
            this.panelIzq.Controls.Add(this.txtEdad);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 0);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(457, 450);
            this.panelIzq.TabIndex = 0;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.BackColor = System.Drawing.Color.SeaGreen;
            this.fechaNacimiento.BorderRadius = 0;
            this.fechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaNacimiento.FormatCustom = null;
            this.fechaNacimiento.Location = new System.Drawing.Point(152, 193);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(249, 36);
            this.fechaNacimiento.TabIndex = 37;
            this.fechaNacimiento.Value = new System.DateTime(2019, 12, 5, 0, 43, 53, 286);
            this.fechaNacimiento.onValueChanged += new System.EventHandler(this.cambioFecha);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 195);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(126, 30);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Fecha Nac. :";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.comboEstadoCivil.BorderRadius = 3;
            this.comboEstadoCivil.ForeColor = System.Drawing.Color.White;
            this.comboEstadoCivil.Items = new string[] {
        "<Seleccione>",
        "Soltero",
        "Casado",
        "Divorciado",
        "Viudo",
        "Union Libre"};
            this.comboEstadoCivil.Location = new System.Drawing.Point(152, 315);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.NomalColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboEstadoCivil.onHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboEstadoCivil.selectedIndex = -1;
            this.comboEstadoCivil.Size = new System.Drawing.Size(249, 35);
            this.comboEstadoCivil.TabIndex = 34;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(25, 52);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(129, 19);
            this.bunifuSeparator3.TabIndex = 33;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(22, 67);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(82, 30);
            this.bunifuCustomLabel9.TabIndex = 19;
            this.bunifuCustomLabel9.Text = "Cedula:";
            this.bunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCedula.HintForeColor = System.Drawing.Color.Empty;
            this.txtCedula.HintText = "";
            this.txtCedula.isPassword = false;
            this.txtCedula.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtCedula.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtCedula.LineThickness = 4;
            this.txtCedula.Location = new System.Drawing.Point(152, 69);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(249, 31);
            this.txtCedula.TabIndex = 20;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(22, 109);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(103, 30);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "Nombres:";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 20);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(110, 30);
            this.bunifuCustomLabel7.TabIndex = 32;
            this.bunifuCustomLabel7.Text = "Empleado";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(152, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 31);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 79);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(151, 27);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(122, 34);
            this.rbFemenino.TabIndex = 13;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(19, 27);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(126, 34);
            this.rbMasculino.TabIndex = 12;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(22, 154);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(103, 30);
            this.bunifuCustomLabel11.TabIndex = 23;
            this.bunifuCustomLabel11.Text = "Apellidos:";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(22, 315);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(124, 30);
            this.bunifuCustomLabel6.TabIndex = 30;
            this.bunifuCustomLabel6.Text = "Estado Civil:";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellido.HintText = "";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtApellido.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtApellido.LineThickness = 4;
            this.txtApellido.Location = new System.Drawing.Point(152, 156);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 31);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(22, 233);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(64, 30);
            this.bunifuCustomLabel12.TabIndex = 25;
            this.bunifuCustomLabel12.Text = "Edad:";
            this.bunifuCustomLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCiudad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCiudad.HintText = "";
            this.txtCiudad.isPassword = false;
            this.txtCiudad.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtCiudad.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiudad.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtCiudad.LineThickness = 4;
            this.txtCiudad.Location = new System.Drawing.Point(152, 272);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(249, 31);
            this.txtCiudad.TabIndex = 28;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 273);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(83, 30);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "Ciudad:";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEdad
            // 
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEdad.HintForeColor = System.Drawing.Color.Empty;
            this.txtEdad.HintText = "";
            this.txtEdad.isPassword = false;
            this.txtEdad.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtEdad.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtEdad.LineThickness = 4;
            this.txtEdad.Location = new System.Drawing.Point(152, 235);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(249, 31);
            this.txtEdad.TabIndex = 26;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelDer;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelIzq;
            this.bunifuDragControl2.Vertical = true;
            // 
            // IngresoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoEmpleado";
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Panel panelIzq;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCedula;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEdad;
        private System.Windows.Forms.Panel panelInterno;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown comboEstadoCivil;
        private Bunifu.Framework.UI.BunifuDropdown comboTipoEmpleado;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker fechaNacimiento;
    }
}