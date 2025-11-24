using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_datos
{
    public class Cliente_DAL
    {
        public DataTable Listar()
        {
            //Crea una tabla vacía para guardar los datos que traigamos.
            DataTable dt = new DataTable();
            //Establece la conexión usando la cadena que se definio en la clase Conexion_DB.
            //El bloque 'using' asegura que la conexión se cierre sola al terminar.
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                //Se define la consulta SQL para pedir las columnas específicas.
                string sql = "SELECT id, nombre, apellido, dui, telefono, correo, estado FROM Clientes";
                //Prepara la consulta SQL para ser enviada al servidor
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open(); //Abre la conexion
                    // El SqlDataAdapter funciona como un "camión de carga":
                    // va a la base de datos, ejecuta el comando y regresa llenando (.Fill) la tabla 'dt'.
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt; //retornar la tabla con los datos
        }
        public int Insertar(Cliente_2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                //SQL con Parámetros (@nombre, etc.) para evitar hackeos (Inyección SQL).
                //'SELECT SCOPE_IDENTITY()' sirve para recuperar el ID del cliente recién creado.
                string sql = @"INSERT INTO Clientes(nombre, apellido, dui, telefono, correo, estado) VALUES (@nombre, @apellido, @dui, @telefono, @correo, @estado); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    //Asigna los valores reales del objeto 'c' a los parámetros de la consulta.
                    cmd.Parameters.AddWithValue("@nombre", c.nombre);
                    cmd.Parameters.AddWithValue("@apellido", c.apellido);
                    cmd.Parameters.AddWithValue("dui", c.dui);
                    cmd.Parameters.AddWithValue("@telefono", c.telefono);
                    cmd.Parameters.AddWithValue("@correo", c.correo);
                    cmd.Parameters.AddWithValue("@estado", c.estado);
                    cn.Open();
                    //ExecuteScalar ejecuta el INSERT y recupera el primer dato devuelto (el nuevo ID).
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
        }
        public bool Actualizar(Cliente_2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                //Instrucción UPDATE. Importante: El WHERE asegura que solo modifiques al cliente correcto.
                string sql = @"UPDATE cliente SET nombre=@nombre, apellido=@apellido, dui=@dui, telefono=@telefono, correo=@correo, estado=@estado WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    //Se envían todos los parámetros, incluido el ID para saber a quién editar.
                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@nombre", c.nombre);
                    cmd.Parameters.AddWithValue("@apellido", c.apellido);
                    cmd.Parameters.AddWithValue("dui", c.dui);
                    cmd.Parameters.AddWithValue("@telefono", c.telefono);
                    cmd.Parameters.AddWithValue("@correo", c.correo);
                    cmd.Parameters.AddWithValue("@estado", c.estado);
                    cn.Open();
                    //ExecuteNonQuery devuelve el número de filas afectadas. 
                    //Si es > 0, significa que sí encontró y actualizó al cliente.
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                //Instrucción DELETE simple con filtro por ID.
                string sql = "DELETE FROM Clientes WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    //Devuelve verdadero si logró borrar al menos una fila.
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            
        }
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                //Busca coincidencias parciales.
                string sql = @"SELECT id, nombre, apellido, dui, telefono, correo, estado FROM Clientes WHERE nombre LIKE @filtro OR telefono LIKE @filtro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    //Los signos '%' permiten buscar texto intermedio (ej: buscar "Juan" encuentra "San Juan").
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    //Llena la tabla 'dt' con los resultados de la búsqueda.
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
    }
}
