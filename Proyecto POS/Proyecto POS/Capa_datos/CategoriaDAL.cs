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
    public class CategoriaDAL
    {
        // ==========================================
        // MÉTODO LISTAR (READ)
        // ==========================================
        // Devuelve una tabla (DataTable) con todas las categorías de la base de datos.
        public DataTable Listar()
        {
            DataTable dt = new DataTable();// Crea una tabla vacía en memoria para llenarla luego.
            // 'using' asegura que la conexión se cierre y se elimine de memoria al terminar este bloque.
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                // Consulta SQL para traer los datos.
                string sql = "SELECT id, nombre FROM Categorias";
                // SqlCommand es el objeto que lleva la consulta a la base de datos.
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();// Abre la puerta a la base de datos.
                    // SqlDataAdapter es un "ayudante" que ejecuta el SELECT
                    // y vuelca los datos automáticamente dentro del DataTable 'dt'.
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;// Devuelve la tabla llena con los datos.

        }
        // ==========================================
        // MÉTODO INSERTAR (CREATE)
        // ==========================================
        // Inserta una nueva categoría y devuelve el ID generado (int).
        public int Insertar(Categorias c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                // La consulta hace dos cosas:
                // 1. INSERT: Guarda el dato.
                // 2. SELECT SCOPE_IDENTITY(): Recupera el ID autonumérico que SQL acaba de crear.
                string sql = @"INSERT INTO Categorias (nombre)
                    VALUES (@nombre);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Uso de parámetros (@nombre) para evitar inyección SQL (hackeos).
                    cmd.Parameters.AddWithValue("@nombre", c.nombre);
                    cn.Open();
                    // ExecuteScalar devuelve un solo valor (el ID)
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }

        }
        public bool Actualizar(Categorias c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = @"UPDATE Categorias SET
                   nombre=@nombre
                   WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@nombre", c.nombre);
                    cn.Open();
                    // ExecuteNonQuery devuelve número de filas afectadas
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = "DELETE FROM Categorias WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = @"SELECT id, nombre
                               FROM Categorias
                               WHERE nombre LIKE @filtro 
                                  OR nombre LIKE @filtro";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // %filtro% coincide con cualquier parte del texto
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    cn.Open();

                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
        public bool ExisteNombre(string nombre)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = "SELECT COUNT(*) FROM Categorias WHERE nombre = @nombre";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public bool ExisteNombreEnOtraCategoria(string nombre, int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = @"SELECT COUNT(*) 
                               FROM Categorias
                               WHERE nombre = @nombre AND id != @id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;


                }
            }
        }
        public bool TieneProductosAsociados(int id_Categoria)
        {
            using (SqlConnection cn = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = @"SELECT COUNT(*) 
                               FROM Productos 
                               WHERE id_categoria = @id_categoria";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id_categoria", id_Categoria);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }
}

