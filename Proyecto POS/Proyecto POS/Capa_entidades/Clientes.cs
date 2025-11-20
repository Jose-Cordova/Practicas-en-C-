using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    public class Clientes
    {
        //Se definen los atributos de la clase
        public int id { get; set; } //get y set para poder acceder y modificar los atributos
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }

    }

}
