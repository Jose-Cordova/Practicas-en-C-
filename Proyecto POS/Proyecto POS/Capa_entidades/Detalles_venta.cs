using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    public class Detalles_venta
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal sub_total { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
    }
}
