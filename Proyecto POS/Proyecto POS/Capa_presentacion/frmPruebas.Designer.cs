namespace Proyecto_POS.Capa_presentacion
{
    partial class frmPruebas
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
            this.btnProbar_stock = new System.Windows.Forms.Button();
            this.btnProbar_clientes = new System.Windows.Forms.Button();
            this.btnProbar_pagos = new System.Windows.Forms.Button();
            this.btnProbar_cerrar = new System.Windows.Forms.Button();
            this.btnValidar_venta = new System.Windows.Forms.Button();
            this.btnProbar_venta_transaccional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProbar_stock
            // 
            this.btnProbar_stock.BackColor = System.Drawing.Color.Blue;
            this.btnProbar_stock.ForeColor = System.Drawing.Color.Silver;
            this.btnProbar_stock.Location = new System.Drawing.Point(48, 56);
            this.btnProbar_stock.Name = "btnProbar_stock";
            this.btnProbar_stock.Size = new System.Drawing.Size(123, 48);
            this.btnProbar_stock.TabIndex = 0;
            this.btnProbar_stock.Text = "Stock";
            this.btnProbar_stock.UseVisualStyleBackColor = false;
            this.btnProbar_stock.Click += new System.EventHandler(this.btnProbar_stock_Click);
            // 
            // btnProbar_clientes
            // 
            this.btnProbar_clientes.BackColor = System.Drawing.Color.Blue;
            this.btnProbar_clientes.ForeColor = System.Drawing.Color.Silver;
            this.btnProbar_clientes.Location = new System.Drawing.Point(251, 56);
            this.btnProbar_clientes.Name = "btnProbar_clientes";
            this.btnProbar_clientes.Size = new System.Drawing.Size(161, 48);
            this.btnProbar_clientes.TabIndex = 1;
            this.btnProbar_clientes.Text = "Clientes activos";
            this.btnProbar_clientes.UseVisualStyleBackColor = false;
            this.btnProbar_clientes.Click += new System.EventHandler(this.btnProbar_clientes_Click);
            // 
            // btnProbar_pagos
            // 
            this.btnProbar_pagos.BackColor = System.Drawing.Color.Blue;
            this.btnProbar_pagos.ForeColor = System.Drawing.Color.Silver;
            this.btnProbar_pagos.Location = new System.Drawing.Point(507, 56);
            this.btnProbar_pagos.Name = "btnProbar_pagos";
            this.btnProbar_pagos.Size = new System.Drawing.Size(147, 48);
            this.btnProbar_pagos.TabIndex = 2;
            this.btnProbar_pagos.Text = "Probar Pagos";
            this.btnProbar_pagos.UseVisualStyleBackColor = false;
            this.btnProbar_pagos.Click += new System.EventHandler(this.btnProbar_pagos_Click);
            // 
            // btnProbar_cerrar
            // 
            this.btnProbar_cerrar.BackColor = System.Drawing.Color.Blue;
            this.btnProbar_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btnProbar_cerrar.Location = new System.Drawing.Point(743, 56);
            this.btnProbar_cerrar.Name = "btnProbar_cerrar";
            this.btnProbar_cerrar.Size = new System.Drawing.Size(123, 48);
            this.btnProbar_cerrar.TabIndex = 3;
            this.btnProbar_cerrar.Text = "Cerrar";
            this.btnProbar_cerrar.UseVisualStyleBackColor = false;
            this.btnProbar_cerrar.Click += new System.EventHandler(this.btnProbar_cerrar_Click);
            // 
            // btnValidar_venta
            // 
            this.btnValidar_venta.BackColor = System.Drawing.Color.Blue;
            this.btnValidar_venta.ForeColor = System.Drawing.Color.Silver;
            this.btnValidar_venta.Location = new System.Drawing.Point(155, 166);
            this.btnValidar_venta.Name = "btnValidar_venta";
            this.btnValidar_venta.Size = new System.Drawing.Size(133, 48);
            this.btnValidar_venta.TabIndex = 4;
            this.btnValidar_venta.Text = "Validar venta";
            this.btnValidar_venta.UseVisualStyleBackColor = false;
            this.btnValidar_venta.Click += new System.EventHandler(this.btnValidar_venta_Click);
            // 
            // btnProbar_venta_transaccional
            // 
            this.btnProbar_venta_transaccional.BackColor = System.Drawing.Color.Blue;
            this.btnProbar_venta_transaccional.ForeColor = System.Drawing.Color.Silver;
            this.btnProbar_venta_transaccional.Location = new System.Drawing.Point(558, 166);
            this.btnProbar_venta_transaccional.Name = "btnProbar_venta_transaccional";
            this.btnProbar_venta_transaccional.Size = new System.Drawing.Size(240, 48);
            this.btnProbar_venta_transaccional.TabIndex = 5;
            this.btnProbar_venta_transaccional.Text = "Prueba de venta rapida";
            this.btnProbar_venta_transaccional.UseVisualStyleBackColor = false;
            this.btnProbar_venta_transaccional.Click += new System.EventHandler(this.btnProbar_venta_transaccional_Click);
            // 
            // frmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(922, 291);
            this.Controls.Add(this.btnProbar_venta_transaccional);
            this.Controls.Add(this.btnValidar_venta);
            this.Controls.Add(this.btnProbar_cerrar);
            this.Controls.Add(this.btnProbar_pagos);
            this.Controls.Add(this.btnProbar_clientes);
            this.Controls.Add(this.btnProbar_stock);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPruebas";
            this.Text = "frmPruebas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProbar_stock;
        private System.Windows.Forms.Button btnProbar_clientes;
        private System.Windows.Forms.Button btnProbar_pagos;
        private System.Windows.Forms.Button btnProbar_cerrar;
        private System.Windows.Forms.Button btnValidar_venta;
        private System.Windows.Forms.Button btnProbar_venta_transaccional;
    }
}