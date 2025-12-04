using Proyecto_POS.Capa_entidades;
using Proyecto_POS.Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS.Capa_presentacion
{
    public partial class frmReporteVenta : Form
    {
        public frmReporteVenta()
        {
            InitializeComponent();
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            // Validación de fechas
            if (fin < inicio)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial.",
                    "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================
            // 1) OBTENER LAS VENTAS DEL BLL
            // ============================
            DataTable tabla = ReporteBLL.ObtenerVentasPorPeriodo(inicio, fin);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen ventas registradas en ese período.",
                    "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ============================
            // 2) SELECCIONAR DONDE GUARDAR PDF
            // ============================
            SaveFileDialog1.Title = "Guardar Reporte en PDF";
            SaveFileDialog1.Filter = "Archivo PDF (*.pdf)|*.pdf";
            SaveFileDialog1.FileName = $"ReporteVentas_{inicio:dd-MM-yyyy}_a_{fin:dd-MM-yyyy}.pdf";

            if (SaveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string ruta = SaveFileDialog1.FileName;

            try
            {
                // ============================
                // 3) GENERAR PDF CON QuestPDF
                // ============================
                ReporteVentasPDF.GenerarPDF(tabla, inicio, fin, ruta);

                // Mensaje de éxito
                MessageBox.Show("Reporte generado correctamente.\n\n" +
                                "Ubicación:\n" + ruta,
                                "PDF Generado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el PDF:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

