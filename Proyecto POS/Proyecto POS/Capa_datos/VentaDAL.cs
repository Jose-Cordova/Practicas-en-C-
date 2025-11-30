using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_datos
{
    public class VentaDAL
    {
        public static (bool exito, string mensaje) RegistrarVentaTransaccional(Ventas venta, List<Detalles_venta> detalles)
        {
            using (SqlConnection con = new SqlConnection(Conexion_DB.cadena))
            {
                con.Open();

                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    // 1) INSERTAMOS VENTA Y RECUPERAMOS ID DE LA VENTA INGRESADA

                    string sqlVenta = @"
                        INSERT INTO Ventas (fecha, monto_total, id_metodo_pago, id_cliente)
                        VALUES (@fecha, @monto_total, @id_metodo_pago, @id_cliente);
                        SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlVenta, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@fecha", venta.fecha);
                        cmd.Parameters.AddWithValue("@monto_total", venta.monto_total);
                        cmd.Parameters.AddWithValue("@id_metodo_pago", venta.id_metodo_pago);
                        cmd.Parameters.AddWithValue("@id_cliente", venta.id_cliente);

                        // Recuperamos ID generado
                        venta.id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2) INSERTAMOS LOS DETALLES

                    string sqlDetalle = @"
                        INSERT INTO Detalles_venta (cantidad, precio_unitario, sub_total, id_venta, id_producto)
                        VALUES (@cantidad , @precio_unitario, @sub_total, @id_venta, @id_producto);";

                    // Acumular cantidades por producto (para descontar stock una sola vez)
                    var acumulador = new Dictionary<int, int>();

                    foreach (var d in detalles)
                    {
                        // A) Insertar detalle de venta
                        using (SqlCommand cmdDet = new SqlCommand(sqlDetalle, con, tx))
                        {
                            cmdDet.Parameters.AddWithValue("@cantidad", d.cantidad);
                            cmdDet.Parameters.AddWithValue("@precio_unitario", d.precio_unitario);
                            cmdDet.Parameters.AddWithValue("@sub_total", d.sub_total);
                            cmdDet.Parameters.AddWithValue("@id_venta", venta.id);
                            cmdDet.Parameters.AddWithValue("@id_producto", d.id_producto);

                            cmdDet.ExecuteNonQuery();
                        }

                        // B) Actualizar acumulador
                        if (!acumulador.ContainsKey(d.id_producto))
                            acumulador[d.id_producto] = 0;

                        acumulador[d.id_producto] += d.cantidad;
                    }

                    // 3) DESCONTAREMOS EL STOCK (validación interna)

                    string sqlStock = @"
                        UPDATE Productos
                        SET stock = stock - @cantidad
                        WHERE id = @id_producto AND stock >= @cantidad;";

                    foreach (var item in acumulador)
                    {
                        using (SqlCommand cmdStock = new SqlCommand(sqlStock, con, tx))
                        {
                            cmdStock.Parameters.AddWithValue("@cantidad", item.Value);
                            cmdStock.Parameters.AddWithValue("@id_producto", item.Key);

                            int filas = cmdStock.ExecuteNonQuery();

                            // Si no se afectó ninguna fila → NO había stock suficiente
                            if (filas == 0)
                                throw new Exception("Stock insuficiente para el producto ID: " + item.Key);
                        }
                    }

                    // 4) CONFIRMAMOS LA TRANSACCIÓN
                    tx.Commit();

                    return (true, "Venta registrada con éxito. ID generado: " + venta.id);
                }
                catch (Exception ex)
                {
                    // Si algo falla → revertir todo
                    tx.Rollback();
                    return (false, "Error al registrar venta: " + ex.Message);
                }
            }
        }

    }
}
