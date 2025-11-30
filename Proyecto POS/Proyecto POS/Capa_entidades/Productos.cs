using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    public class Productos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
        public int id_categoria { get; set; }
    }
}
