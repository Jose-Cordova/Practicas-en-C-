using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_entidades
{
    //Clase cliente, tabla que esta en la base de datos
    public class Cliente_2
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }

    } 
}
