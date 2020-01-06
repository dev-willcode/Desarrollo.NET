namespace AppPOOPractica2
{
    partial class FrmProcesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcesos));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.selectUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLamdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereMultipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresOrdenacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderbyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderbyLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAgregadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresUnionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuantificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Linq to Object";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(773, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(806, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSimpleToolStripMenuItem,
            this.selecUpperToolStripMenuItem,
            this.operadoresOrdenacionToolStripMenuItem,
            this.operacionesAgregadoToolStripMenuItem,
            this.operaToolStripMenuItem,
            this.operadoresUnionToolStripMenuItem,
            this.cuantificadoresToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 36);
            this.toolStripMenuItem1.Text = "Sentencias Linq to Object";
            // 
            // selectSimpleToolStripMenuItem
            // 
            this.selectSimpleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSimple,
            this.selectUpper,
            this.selectTodoToolStripMenuItem,
            this.selectLamdaToolStripMenuItem});
            this.selectSimpleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectSimpleToolStripMenuItem.Image")));
            this.selectSimpleToolStripMenuItem.Name = "selectSimpleToolStripMenuItem";
            this.selectSimpleToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.selectSimpleToolStripMenuItem.Text = "Operadores proyeccion";
            // 
            // selectSimple
            // 
            this.selectSimple.Name = "selectSimple";
            this.selectSimple.Size = new System.Drawing.Size(180, 22);
            this.selectSimple.Text = "Select simple";
            this.selectSimple.Click += new System.EventHandler(this.selectSimpleToolStripMenuItem1_Click);
            // 
            // selectUpper
            // 
            this.selectUpper.Name = "selectUpper";
            this.selectUpper.Size = new System.Drawing.Size(180, 22);
            this.selectUpper.Text = "Select upper/lower";
            this.selectUpper.Click += new System.EventHandler(this.selectUpperlowerToolStripMenuItem_Click);
            // 
            // selectTodoToolStripMenuItem
            // 
            this.selectTodoToolStripMenuItem.Name = "selectTodoToolStripMenuItem";
            this.selectTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectTodoToolStripMenuItem.Text = "Select todo";
            this.selectTodoToolStripMenuItem.Click += new System.EventHandler(this.selectTodoToolStripMenuItem_Click);
            // 
            // selectLamdaToolStripMenuItem
            // 
            this.selectLamdaToolStripMenuItem.Name = "selectLamdaToolStripMenuItem";
            this.selectLamdaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectLamdaToolStripMenuItem.Text = "Select lamda";
            this.selectLamdaToolStripMenuItem.Click += new System.EventHandler(this.selectLamdaToolStripMenuItem_Click);
            // 
            // selecUpperToolStripMenuItem
            // 
            this.selecUpperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whereToolStripMenuItem,
            this.whereMultipleToolStripMenuItem});
            this.selecUpperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selecUpperToolStripMenuItem.Image")));
            this.selecUpperToolStripMenuItem.Name = "selecUpperToolStripMenuItem";
            this.selecUpperToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.selecUpperToolStripMenuItem.Text = "Operadores desicion";
            // 
            // whereToolStripMenuItem
            // 
            this.whereToolStripMenuItem.Name = "whereToolStripMenuItem";
            this.whereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whereToolStripMenuItem.Text = "where simple";
            this.whereToolStripMenuItem.Click += new System.EventHandler(this.whereToolStripMenuItem_Click);
            // 
            // whereMultipleToolStripMenuItem
            // 
            this.whereMultipleToolStripMenuItem.Name = "whereMultipleToolStripMenuItem";
            this.whereMultipleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whereMultipleToolStripMenuItem.Text = "where multiple";
            this.whereMultipleToolStripMenuItem.Click += new System.EventHandler(this.whereMultipleToolStripMenuItem_Click);
            // 
            // operadoresOrdenacionToolStripMenuItem
            // 
            this.operadoresOrdenacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderbyToolStripMenuItem1,
            this.orderbyLengthToolStripMenuItem});
            this.operadoresOrdenacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operadoresOrdenacionToolStripMenuItem.Image")));
            this.operadoresOrdenacionToolStripMenuItem.Name = "operadoresOrdenacionToolStripMenuItem";
            this.operadoresOrdenacionToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.operadoresOrdenacionToolStripMenuItem.Text = "Operadores ordenacion";
            // 
            // orderbyToolStripMenuItem1
            // 
            this.orderbyToolStripMenuItem1.Name = "orderbyToolStripMenuItem1";
            this.orderbyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.orderbyToolStripMenuItem1.Text = "orderby";
            this.orderbyToolStripMenuItem1.Click += new System.EventHandler(this.orderbyToolStripMenuItem1_Click);
            // 
            // orderbyLengthToolStripMenuItem
            // 
            this.orderbyLengthToolStripMenuItem.Name = "orderbyLengthToolStripMenuItem";
            this.orderbyLengthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderbyLengthToolStripMenuItem.Text = "orderby length";
            // 
            // operacionesAgregadoToolStripMenuItem
            // 
            this.operacionesAgregadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripMenuItem,
            this.countSimpleToolStripMenuItem,
            this.sumToolStripMenuItem,
            this.minToolStripMenuItem,
            this.averageToolStripMenuItem});
            this.operacionesAgregadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operacionesAgregadoToolStripMenuItem.Image")));
            this.operacionesAgregadoToolStripMenuItem.Name = "operacionesAgregadoToolStripMenuItem";
            this.operacionesAgregadoToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.operacionesAgregadoToolStripMenuItem.Text = "Operadores agregado";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.countToolStripMenuItem.Text = "count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // countSimpleToolStripMenuItem
            // 
            this.countSimpleToolStripMenuItem.Name = "countSimpleToolStripMenuItem";
            this.countSimpleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.countSimpleToolStripMenuItem.Text = "count simple";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumToolStripMenuItem.Text = "sum";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minToolStripMenuItem.Text = "min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageToolStripMenuItem.Text = "average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // operaToolStripMenuItem
            // 
            this.operaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operaToolStripMenuItem.Image")));
            this.operaToolStripMenuItem.Name = "operaToolStripMenuItem";
            this.operaToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.operaToolStripMenuItem.Text = "Operadores conjunto";
            // 
            // operadoresUnionToolStripMenuItem
            // 
            this.operadoresUnionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operadoresUnionToolStripMenuItem.Image")));
            this.operadoresUnionToolStripMenuItem.Name = "operadoresUnionToolStripMenuItem";
            this.operadoresUnionToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.operadoresUnionToolStripMenuItem.Text = "Operadores union";
            // 
            // cuantificadoresToolStripMenuItem
            // 
            this.cuantificadoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuantificadoresToolStripMenuItem.Image")));
            this.cuantificadoresToolStripMenuItem.Name = "cuantificadoresToolStripMenuItem";
            this.cuantificadoresToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.cuantificadoresToolStripMenuItem.Text = "Cuantificadores";
            // 
            // FrmProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Procesos Linq";
            this.Load += new System.EventHandler(this.FrmProcesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecUpperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSimple;
        private System.Windows.Forms.ToolStripMenuItem selectUpper;
        private System.Windows.Forms.ToolStripMenuItem whereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresOrdenacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderbyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operacionesAgregadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresUnionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuantificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderbyLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereMultipleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectLamdaToolStripMenuItem;
    }
}