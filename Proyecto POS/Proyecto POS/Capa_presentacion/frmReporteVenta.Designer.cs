namespace Proyecto_POS.Capa_presentacion
{
    partial class frmReporteVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE VENTAS";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(31, 103);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(107, 20);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "FECHA INICIO";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(405, 103);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(85, 20);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "FECHA FIN";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(145, 103);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(232, 22);
            this.dtpInicio.TabIndex = 3;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(496, 103);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(232, 22);
            this.dtpFin.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Lime;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(99, 173);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(199, 39);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "GENERAR REPORTE";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(449, 173);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 39);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(763, 243);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Name = "frmReporteVenta";
            this.Text = "frmReporteVenta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}