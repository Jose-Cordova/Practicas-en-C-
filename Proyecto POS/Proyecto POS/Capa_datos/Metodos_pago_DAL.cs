using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_datos
{
    public class Metodos_pago_DAL
    {
        public static List<Metodos_pago> Listar()
        {
            List<Metodos_pago> lista = new List<Metodos_pago>();

            using (SqlConnection con = new SqlConnection(Conexion_DB.cadena))
            {
                string sql = "SELECT * FROM Metodos_pago";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Metodos_pago
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
