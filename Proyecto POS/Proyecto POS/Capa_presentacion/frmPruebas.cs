using Proyecto_POS.Capa_datos;
using Proyecto_POS.Capa_entidades;
using Proyecto_POS.Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS.Capa_presentacion
{
    public partial class frmPruebas : Form
    {
        public frmPruebas()
        {
            InitializeComponent();
        }

        private void btnProbar_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProbar_stock_Click(object sender, EventArgs e)
        {
            int stock = Productos_DAL.Obtener_stock(1);
            MessageBox.Show("Stock del producto 1." + stock);
        }

        private void btnProbar_clientes_Click(object sender, EventArgs e)
        {
            var clientes = Cliente_DAL.Listar_activos();
            MessageBox.Show("Clientes activos: " + clientes.Count);
        }

        private void btnProbar_pagos_Click(object sender, EventArgs e)
        {
            var pagos = Metodos_pago_DAL.Listar();
            MessageBox.Show("Tipos de pago: " + pagos.Count);
        }

        private void btnValidar_venta_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas()
            {
                fecha = DateTime.Now,
                monto_total = 5.00m,
                id_cliente = 1,
                id_metodo_pago = 1
            };
            var detalles = new List<Detalles_venta>()
            {
                new Detalles_venta()
                {
                    id_producto = 1,
                    cantidad = 1,
                    precio_unitario = 5.00m,
                    sub_total = 5.00m
                }
            };

            var r = VentaBLL.ValidarVenta(venta, detalles);

            MessageBox.Show(r.mensaje);
        }

        private void btnProbar_venta_transaccional_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas()
            {
                fecha = DateTime.Now,
                monto_total = 10.00m,
                id_cliente = 1, // usa tu Cliente por defecto
                id_metodo_pago = 1 // efectivo (o el que tengas)
            };

            var detalles = new List<Detalles_venta>()
            {
                new Detalles_venta()
                {
                    id_producto = 1,  // debe existir
                    cantidad = 1,
                    precio_unitario = 10.00m,
                    sub_total = 10.00m
                }
            };

            var r = VentaDAL.RegistrarVentaTransaccional(venta, detalles);

            MessageBox.Show(r.mensaje);
        }

    }
}



