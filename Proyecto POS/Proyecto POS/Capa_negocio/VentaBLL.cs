using Proyecto_POS.Capa_datos;
using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.Capa_negocio
{
    public class VentaBLL
    {
        public static Respuestas_operacion ValidarVenta(Ventas venta, List<Detalles_venta> detalles)
        {
            // 1) Validar existencia del objeto Venta
            if (venta == null)
                return new Respuestas_operacion { exito = false, mensaje = "Venta no válida." };

            // 2) Validar cliente
            if (venta.id_cliente <= 0)
                return new Respuestas_operacion { exito = false, mensaje = "Debe seleccionar un cliente." };

            // 3) Validar tipo de pago
            if (venta.id_metodo_pago <= 0)
                return new Respuestas_operacion { exito = false, mensaje = "Debe seleccionar un tipo de pago." };

            // 4) Validar detalles
            if (detalles == null || detalles.Count == 0)
            {
                return new Respuestas_operacion
                {
                    exito = false,
                    mensaje = "La venta debe contener al menos un producto."
                };
            }

            // 5) Validar montos
            if (venta.monto_total <= 0)
                return new Respuestas_operacion { exito = false, mensaje = "El total de la venta debe ser mayor a cero." };

            // 6) Validar cada detalle
            foreach (var d in detalles)
            {
                // Validar cantidad
                if (d.cantidad <= 0)
                    return new Respuestas_operacion
                    {
                        exito = false,
                        mensaje = $"La cantidad del producto ID {d.id_producto} es inválida."
                    };

                // Validar precio
                if (d.precio_unitario <= 0)
                    return new Respuestas_operacion
                    {
                        exito = false,
                        mensaje = $"Precio unitario inválido para el producto ID {d.id_producto}"
                    };

                // Validar subtotal
                if (d.sub_total != d.cantidad * d.precio_unitario)
                    return new Respuestas_operacion
                    {
                        exito = false,
                        mensaje = $"Subtotal incorrecto para el producto ID {d.id_producto}."
                    };

                // Validar stock disponible (consulta al DAL)
                int stockActual = Productos_DAL.Obtener_stock(d.id_producto);

                if (stockActual < d.cantidad)
                {
                    return new Respuestas_operacion
                    {
                        exito = false,
                        mensaje = $"Stock insuficiente del producto ID {d.id_producto} (Stock actual: {stockActual})."
                    };
                }
            }

            // Si todo está OK, la BLL autoriza enviar a DAL transaccional
            return new Respuestas_operacion
            {
                exito = true,
                mensaje = "Validación correcta."
            };
        }
    }

}

