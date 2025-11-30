using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    public class Ventas
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto_total { get; set; }
        public int id_cliente { get; set; }
        public int id_metodo_pago { get; set; }
    }
}
