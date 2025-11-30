using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_datos
{
    public class Productos_DAL
    {
        public static int Obtener_stock(int id_producto)
        {
            int stock = 0;

            using (SqlConnection con = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = "SELECT stock FROM Productos WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id_producto);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        stock = Convert.ToInt32(result);
                }
            }
            return stock;
        }

        // OPCIONAL pero muy útil para el formulario de venta
        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = @"SELECT p.id, p.nombre, p.precio, p.stock, c.nombre AS Categorias
                               FROM Productos p
                               INNER JOIN Categorias c ON p.id_categoria = c.id
                               WHERE p.estado = 1;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
            }
            return tabla;
        }

    }
}
