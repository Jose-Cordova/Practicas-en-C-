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
    public partial class frmRegistrar_venta : Form
    {
        public frmRegistrar_venta()
        {
            InitializeComponent();
        }

        private void frmRegistrar_venta_Load(object sender, EventArgs e)
        {
            
            // --- CLIENTES ---
            cboCliente.DataSource = Cliente_DAL.Listar_activos();
            cboCliente.DisplayMember = "nombre";
            cboCliente.ValueMember = "id";

            // --- TIPO PAGO ---
            cboTipo_pago.DataSource = Metodos_pago_DAL.Listar(); //asiganmos datos al desplegable
            cboTipo_pago.DisplayMember = "nombre"; //lo que muestra
            cboTipo_pago.ValueMember = "id"; //el valor que nos importa ID

            // --- FECHA ---
            dtpFecha.Value = DateTime.Now;//obtiene la fecha de ahora
            CargarProductos(string.Empty);

            // --- CONFIGURAR COLUMNAS DEL DETALLE ---
            ConfigurarTablaDetalles();
        }

        //Definimos un método para crear las columnas para el DataGrid de detalles
        private void ConfigurarTablaDetalles()
        {
            dgvDetalles.Columns.Clear();

            // ID PRODUCTO
            DataGridViewTextBoxColumn colIdProd = new DataGridViewTextBoxColumn();
            colIdProd.Name = "id_producto";
            colIdProd.HeaderText = "ID";
            colIdProd.Visible = false;
            dgvDetalles.Columns.Add(colIdProd);

            // NOMBRE PRODUCTO
            dgvDetalles.Columns.Add("NombreProducto", "Productos");

            // CANTIDAD
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "cantidad";
            colCant.HeaderText = "Cant.";
            dgvDetalles.Columns.Add(colCant);

            // PRECIO UNITARIO
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "precio_unitario";
            colPrecio.HeaderText = "Precio Unitario";
            dgvDetalles.Columns.Add(colPrecio);

            // SUBTOTAL
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "sub_total";
            colSub.HeaderText = "Subtotal";
            colSub.ReadOnly = true;
            dgvDetalles.Columns.Add(colSub);
            // Asegurar permisos de edición
            dgvDetalles.ReadOnly = false;

            // Columnas NO editables
            dgvDetalles.Columns["sub_total"].ReadOnly = true;
            dgvDetalles.Columns["precio_unitario"].ReadOnly = true;
            dgvDetalles.Columns["NombreProducto"].ReadOnly = true;
            dgvDetalles.Columns["id_producto"].ReadOnly = true;

            // ÚNICA columna editable:
            dgvDetalles.Columns["cantidad"].ReadOnly = false;

        }
        private void CargarProductos(string filtro)
        {
            // Obtenemos la lista desde DAL
            var tabla = Productos_DAL.Listar(); // ya lo creamos en Paso 2

            // Filtrar si hay texto
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = tabla.DefaultView;
                dv.RowFilter = $"nombre LIKE '%{filtro}%'";
                dgvProductos.DataSource = dv;
            }
            else
            {
                dgvProductos.DataSource = tabla;
            }

            dgvProductos.Columns["id"].Visible = false;
        }

        private void txtBuscar_producto_TextChanged(object sender, EventArgs e)
        {
            {
                string texto = txtBuscar_producto.Text.Trim();
                CargarProductos(texto);
            }
        }
        //Este es un nuevo evento, no lo hemos utilizado antes, se llama “keydown”, se habilitará en el txtBUscarProdcuto, si presionamos ENTER
        private void txtBuscar_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarProductos(txtBuscar_producto.Text.Trim());
            }
        }

        private void btnAgregar_producto_Click(object sender, EventArgs e)
        {

            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            DataGridViewRow row = dgvProductos.SelectedRows[0];

            int idProducto = Convert.ToInt32(row.Cells["id"].Value);
            string nombre = row.Cells["nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);

            // Cantidad inicial = 1
            int cantidad = 1;

            decimal subTotal = precio * cantidad;

            // Agregar al detalle
            dgvDetalles.Rows.Add(
                idProducto,
                nombre,
                cantidad,
                precio,
                subTotal
            );
            RecalcularTotal();//dará error, mas adelante se creará el método, comenta esta linea cuando ejecutes
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar_producto_Click(sender, e);

        }
        //método que suma los totales, este se debera llamar cada vez que: agregue producto, se cambie la cantidad y se elimine un producto
        private void RecalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                total += Convert.ToDecimal(row.Cells["sub_total"].Value);
            }

            lblTotal.Text = "Total a pagar: $" + total.ToString("0.00");
        }

        private void dgvDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Si editaron la columna Cantidad
            if (dgvDetalles.Columns[e.ColumnIndex].Name == "cantidad")
            {
                DataGridViewRow row = dgvDetalles.Rows[e.RowIndex];

                int cantidad;
                bool ok = int.TryParse(row.Cells["cantidad"].Value?.ToString(), out cantidad);

                if (!ok || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida.");
                    row.Cells["cantidad"].Value = 1;
                    cantidad = 1;
                }

                decimal precio = Convert.ToDecimal(row.Cells["precio_unitario"].Value);
                decimal subTotal = cantidad * precio;

                row.Cells["sub_total"].Value = subTotal;

                // Recalcular total general
                RecalcularTotal();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para quitar.");
                return;
            }

            dgvDetalles.Rows.RemoveAt(dgvDetalles.SelectedRows[0].Index);

            RecalcularTotal();
        }

        private void btnLimpiar_detalle_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            RecalcularTotal();
        }

        private void btnRegistrar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalles.Rows.Count == 0)
                {
                    MessageBox.Show("La venta no tiene productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ---------------------------------------------------
                // 1) CREAR OBJETO VENTA
                // ---------------------------------------------------
                Ventas venta = new Ventas()
                {
                    fecha = dtpFecha.Value,
                    monto_total = ObtenerTotalVenta(), // lo creamos abajo
                    id_cliente = Convert.ToInt32(cboCliente.SelectedValue),
                    id_metodo_pago = Convert.ToInt32(cboTipo_pago.SelectedValue)
                };

                // ---------------------------------------------------
                // 2) CREAR LISTA DE DETALLES
                // ---------------------------------------------------
                List<Detalles_venta> detalles = new List<Detalles_venta>();

                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    detalles.Add(new Detalles_venta()
                    {
                        id_producto = Convert.ToInt32(row.Cells["id_producto"].Value),
                        cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                        precio_unitario = Convert.ToDecimal(row.Cells["precio_unitario"].Value),
                        sub_total = Convert.ToDecimal(row.Cells["sub_total"].Value)
                    });
                }

                // ---------------------------------------------------
                // 3) VALIDAR EN BLL
                // ---------------------------------------------------
                var validacion = VentaBLL.ValidarVenta(venta, detalles);

                if (!validacion.exito)
                {
                    MessageBox.Show(validacion.mensaje, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ---------------------------------------------------
                // 4) GUARDAR EN BASE DE DATOS (TRANSACCIÓN)
                // ---------------------------------------------------
                var resultado = VentaDAL.RegistrarVentaTransaccional(venta, detalles);

                if (resultado.exito)
                {
                    MessageBox.Show(resultado.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        private decimal ObtenerTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
                total += Convert.ToDecimal(row.Cells["sub_total"].Value);
            return total;
        }
        private void LimpiarFormulario()
        {
            dgvDetalles.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
            txtBuscar_producto.Clear();
            CargarProductos(string.Empty); // recarga lista completa
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}