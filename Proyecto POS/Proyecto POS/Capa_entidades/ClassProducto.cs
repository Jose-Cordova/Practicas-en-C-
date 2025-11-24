using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    // =====================================================================
    // ZONA: Clase de Producto
    // AQUI SE DEFINEN LOS ATRIBUTOS DE LA CLASE PRODUCTO
    // =====================================================================
    public class ClassProducto //Se crea la clase producto y se deja publica
    {
        //Se definen los atributos de la clase 
        public int id { get; set; } //get y set para poder acceder y modificar los atributos
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
    }
}
