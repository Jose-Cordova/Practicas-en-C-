namespace Proyecto_POS
{
    partial class MenuScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScript));
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.gestíonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produxtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCorteCaja = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btmVentaRapida = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.logoPOST = new System.Windows.Forms.PictureBox();
            this.menuSuperior.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPOST)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.Color.LightGray;
            this.menuSuperior.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestíonToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(782, 31);
            this.menuSuperior.TabIndex = 0;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // gestíonToolStripMenuItem
            // 
            this.gestíonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestíonToolStripMenuItem.Name = "gestíonToolStripMenuItem";
            this.gestíonToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.gestíonToolStripMenuItem.Text = "Gestíon";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.verProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriasToolStripMenuItem,
            this.verCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // agregarCategoriasToolStripMenuItem
            // 
            this.agregarCategoriasToolStripMenuItem.Name = "agregarCategoriasToolStripMenuItem";
            this.agregarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(241, 28);
            this.agregarCategoriasToolStripMenuItem.Text = "Agregar Categorias";
            // 
            // verCategoriaToolStripMenuItem
            // 
            this.verCategoriaToolStripMenuItem.Name = "verCategoriaToolStripMenuItem";
            this.verCategoriaToolStripMenuItem.Size = new System.Drawing.Size(241, 28);
            this.verCategoriaToolStripMenuItem.Text = "Ver Categoria";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.verClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // verClienteToolStripMenuItem
            // 
            this.verClienteToolStripMenuItem.Name = "verClienteToolStripMenuItem";
            this.verClienteToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.verClienteToolStripMenuItem.Text = "Ver Cliente";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.historialDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(75, 27);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // historialDeVentaToolStripMenuItem
            // 
            this.historialDeVentaToolStripMenuItem.Name = "historialDeVentaToolStripMenuItem";
            this.historialDeVentaToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.historialDeVentaToolStripMenuItem.Text = "Historial de Venta";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiarioToolStripMenuItem,
            this.produxtoToolStripMenuItem,
            this.cierreDeCajaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            this.reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            this.reporteDiarioToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // produxtoToolStripMenuItem
            // 
            this.produxtoToolStripMenuItem.Name = "produxtoToolStripMenuItem";
            this.produxtoToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.produxtoToolStripMenuItem.Text = "Producto mas vendido";
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de Caja";
            this.cierreDeCajaToolStripMenuItem.Click += new System.EventHandler(this.cierreDeCajaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.SaddleBrown;
            this.PanelIzquierdo.Controls.Add(this.btnSalir);
            this.PanelIzquierdo.Controls.Add(this.btnCorteCaja);
            this.PanelIzquierdo.Controls.Add(this.btnInventario);
            this.PanelIzquierdo.Controls.Add(this.btnClientes);
            this.PanelIzquierdo.Controls.Add(this.btnProducto);
            this.PanelIzquierdo.Controls.Add(this.btmVentaRapida);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 31);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(200, 522);
            this.PanelIzquierdo.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Bisque;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 448);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 55);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.BackColor = System.Drawing.Color.Bisque;
            this.btnCorteCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorteCaja.FlatAppearance.BorderSize = 2;
            this.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteCaja.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCorteCaja.Image")));
            this.btnCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorteCaja.Location = new System.Drawing.Point(12, 358);
            this.btnCorteCaja.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.Size = new System.Drawing.Size(180, 55);
            this.btnCorteCaja.TabIndex = 4;
            this.btnCorteCaja.Text = "Corte de Caja";
            this.btnCorteCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCorteCaja.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Bisque;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 2;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(12, 274);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(180, 55);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Bisque;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 2;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 190);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 55);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.Bisque;
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.FlatAppearance.BorderSize = 2;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(12, 100);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(180, 55);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btmVentaRapida
            // 
            this.btmVentaRapida.BackColor = System.Drawing.Color.Bisque;
            this.btmVentaRapida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmVentaRapida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmVentaRapida.FlatAppearance.BorderSize = 2;
            this.btmVentaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVentaRapida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVentaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btmVentaRapida.Image")));
            this.btmVentaRapida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmVentaRapida.Location = new System.Drawing.Point(12, 13);
            this.btmVentaRapida.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btmVentaRapida.Name = "btmVentaRapida";
            this.btmVentaRapida.Size = new System.Drawing.Size(180, 55);
            this.btmVentaRapida.TabIndex = 0;
            this.btmVentaRapida.Text = "Venta Rapída";
            this.btmVentaRapida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmVentaRapida.UseVisualStyleBackColor = false;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentral.Controls.Add(this.logoPOST);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(200, 31);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(582, 522);
            this.panelCentral.TabIndex = 2;
            // 
            // logoPOST
            // 
            this.logoPOST.Image = ((System.Drawing.Image)(resources.GetObject("logoPOST.Image")));
            this.logoPOST.Location = new System.Drawing.Point(55, 35);
            this.logoPOST.Name = "logoPOST";
            this.logoPOST.Size = new System.Drawing.Size(479, 443);
            this.logoPOST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPOST.TabIndex = 0;
            this.logoPOST.TabStop = false;
            // 
            // MenuScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.menuSuperior);
            this.MainMenuStrip = this.menuSuperior;
            this.MaximizeBox = false;
            this.Name = "MenuScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS Cafeteria Dulce Aroma";
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.PanelIzquierdo.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPOST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem gestíonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produxtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Button btmVentaRapida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCorteCaja;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox logoPOST;
    }
}

