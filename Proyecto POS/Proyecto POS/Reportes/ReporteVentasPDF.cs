using Proyecto_POS.Reportes;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;


namespace Proyecto_POS.Capa_entidades
{
    public class ReporteVentasPDF
    {
        // Método estático: se puede llamar sin crear instancias
        public static void GenerarPDF(DataTable tabla, DateTime inicio, DateTime fin, string rutaArchivo)
        {
            // QuestPDF requiere declarar la licencia (Community es gratuita)
            QuestPDF.Settings.License = LicenseType.Community;

            // 1) Creamos el modelo de datos (DataTable y rango de fechas)
            var modelo = new ReporteVentasModel(tabla, inicio, fin);

            // 2) Creamos el documento PDF usando ese modelo
            var documento = new ReporteVentasDocumento(modelo);

            // 3) Generamos el archivo PDF en disco
            documento.GeneratePdf(rutaArchivo);
        }
    
        // Tabla con la información de ventas (producto, cantidad, etc.)
        public DataTable Tabla { get; }

        // Fechas de inicio y fin del período consultado
        public DateTime Inicio { get; }

        public DateTime Fin { get; }

        // Constructor que recibe los valores y los asigna
       
    }
}


