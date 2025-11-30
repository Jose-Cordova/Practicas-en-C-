namespace Proyecto_POS.Capa_presentacion
{
    partial class frmRegistrar_venta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboTipo_pago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnNuevo_cliente = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar_producto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar_producto = new System.Windows.Forms.Button();
            this.txtBuscar_producto = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar_detalle = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar_venta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.cboTipo_pago);
            this.panel1.Controls.Add(this.lblPago);
            this.panel1.Controls.Add(this.btnNuevo_cliente);
            this.panel1.Controls.Add(this.cboCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 173);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATOS GENERALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(440, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 485);
            this.panel3.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(118, 109);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(331, 30);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 115);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 23);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboTipo_pago
            // 
            this.cboTipo_pago.FormattingEnabled = true;
            this.cboTipo_pago.Items.AddRange(new object[] {
            "Lista de tipos de pagos"});
            this.cboTipo_pago.Location = new System.Drawing.Point(451, 57);
            this.cboTipo_pago.Name = "cboTipo_pago";
            this.cboTipo_pago.Size = new System.Drawing.Size(155, 31);
            this.cboTipo_pago.TabIndex = 4;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(350, 60);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(101, 23);
            this.lblPago.TabIndex = 3;
            this.lblPago.Text = "Tipo Pago:";
            // 
            // btnNuevo_cliente
            // 
            this.btnNuevo_cliente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevo_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevo_cliente.Location = new System.Drawing.Point(575, 104);
            this.btnNuevo_cliente.Name = "btnNuevo_cliente";
            this.btnNuevo_cliente.Size = new System.Drawing.Size(184, 45);
            this.btnNuevo_cliente.TabIndex = 2;
            this.btnNuevo_cliente.Text = "Registrar Cliente";
            this.btnNuevo_cliente.UseVisualStyleBackColor = false;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Items.AddRange(new object[] {
            "Lista de clientes activos"});
            this.cboCliente.Location = new System.Drawing.Point(118, 57);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(155, 31);
            this.cboCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(36, 60);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 23);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAgregar_producto);
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.Controls.Add(this.btnBuscar_producto);
            this.panel2.Controls.Add(this.txtBuscar_producto);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Location = new System.Drawing.Point(-5, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 424);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "BUSQUEDA DE PRODUCTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar_producto
            // 
            this.btnAgregar_producto.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAgregar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar_producto.Location = new System.Drawing.Point(17, 361);
            this.btnAgregar_producto.Name = "btnAgregar_producto";
            this.btnAgregar_producto.Size = new System.Drawing.Size(180, 39);
            this.btnAgregar_producto.TabIndex = 5;
            this.btnAgregar_producto.Text = "Enviar al detalle";
            this.btnAgregar_producto.UseVisualStyleBackColor = false;
            this.btnAgregar_producto.Click += new System.EventHandler(this.btnAgregar_producto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 192);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(409, 150);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // btnBuscar_producto
            // 
            this.btnBuscar_producto.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBuscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar_producto.Location = new System.Drawing.Point(303, 127);
            this.btnBuscar_producto.Name = "btnBuscar_producto";
            this.btnBuscar_producto.Size = new System.Drawing.Size(101, 36);
            this.btnBuscar_producto.TabIndex = 3;
            this.btnBuscar_producto.Text = "Filtrar";
            this.btnBuscar_producto.UseVisualStyleBackColor = false;
            // 
            // txtBuscar_producto
            // 
            this.txtBuscar_producto.Location = new System.Drawing.Point(179, 81);
            this.txtBuscar_producto.Name = "txtBuscar_producto";
            this.txtBuscar_producto.Size = new System.Drawing.Size(225, 30);
            this.txtBuscar_producto.TabIndex = 2;
            this.txtBuscar_producto.TextChanged += new System.EventHandler(this.txtBuscar_producto_TextChanged);
            this.txtBuscar_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_producto_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(22, 88);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(153, 23);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar Producto:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnLimpiar_detalle);
            this.panel4.Controls.Add(this.btnQuitar);
            this.panel4.Controls.Add(this.dgvDetalles);
            this.panel4.Location = new System.Drawing.Point(443, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 424);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "DETALLES DE LA VENTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar_detalle
            // 
            this.btnLimpiar_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpiar_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar_detalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar_detalle.Location = new System.Drawing.Point(250, 230);
            this.btnLimpiar_detalle.Name = "btnLimpiar_detalle";
            this.btnLimpiar_detalle.Size = new System.Drawing.Size(169, 43);
            this.btnLimpiar_detalle.TabIndex = 7;
            this.btnLimpiar_detalle.Text = "Limpiar todo";
            this.btnLimpiar_detalle.UseVisualStyleBackColor = false;
            this.btnLimpiar_detalle.Click += new System.EventHandler(this.btnLimpiar_detalle_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitar.Location = new System.Drawing.Point(15, 230);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(169, 43);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Eliminar una fila";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(15, 51);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(404, 150);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            this.dgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellEndEdit);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnRegistrar_venta);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Location = new System.Drawing.Point(-5, 591);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(878, 207);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(872, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOTAL Y ACCION FINAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Location = new System.Drawing.Point(228, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 39);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar/Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar_venta
            // 
            this.btnRegistrar_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar_venta.Location = new System.Drawing.Point(17, 125);
            this.btnRegistrar_venta.Name = "btnRegistrar_venta";
            this.btnRegistrar_venta.Size = new System.Drawing.Size(114, 39);
            this.btnRegistrar_venta.TabIndex = 1;
            this.btnRegistrar_venta.Text = "Registrar";
            this.btnRegistrar_venta.UseVisualStyleBackColor = false;
            this.btnRegistrar_venta.Click += new System.EventHandler(this.btnRegistrar_venta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(178, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a pagar: $0.00\r\n";
            // 
            // frmRegistrar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 788);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrar_venta";
            this.Text = "frmRegistrar_venta";
            this.Load += new System.EventHandler(this.frmRegistrar_venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboTipo_pago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnNuevo_cliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscar_producto;
        private System.Windows.Forms.TextBox txtBuscar_producto;
        private System.Windows.Forms.Button btnAgregar_producto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnLimpiar_detalle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRegistrar_venta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}