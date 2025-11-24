using Proyecto_POS.Capa_datos;
using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_negocio
{
    public class Cliente_BLL
    {
        //Instancia de la Capa de Acceso a Datos (DAL).
        //La BLL usará este objeto 'dal' para pedirle que ejecute los comandos SQL reales.
        Cliente_DAL dal = new Cliente_DAL();
        //Se piden los datos a la DAL y se retornan a la Capa de Presentación.
        public DataTable Listar()
        {
            return dal.Listar();
        }
        //Antes de intentar guardar, verifica que los datos cumplan los requisitos.
        //Si el nombre está vacío o es nulo, detiene todo y lanza un error (Excepción).
        public int Guardar(Cliente_2 c)
        {
            if (string.IsNullOrEmpty(c.nombre))
            {
                throw new Exception("El nombre  del cliente es obligatorio.");
            }
            //Si el ID es 0, significa que el cliente aún no existe en la base de datos.
            if (c.id == 0)
            {
                //Llama al método Insertar del DAL (crea nuevo).
                return dal.Insertar(c);
            }
            else
            {
                //Si el ID es mayor a 0, el cliente ya existe, así que lo actualiza.
                dal.Actualizar(c);
                return c.id; //Retorna el mismo ID que ya tenía.
            }
        }
        //Simplemente le ordena a la capa de datos que elimine el registro con ese ID.
        public void Eliminar(int id)
        {
            dal.Eliminar(id);
        }
        // Le pide a la capa de datos que busque coincidencias y devuelve el resultado.
        public DataTable Buscar(string nombre)
        {
            return dal.Buscar(nombre);
        }
    }
}
