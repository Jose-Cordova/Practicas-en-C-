using Proyecto_POS.Capa_entidades;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        //Creacion de una lista estatica que simulara la BD
        public static List<ClassProducto> ListaProductos = new List<ClassProducto>();
        private void DesabilitarBotones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnNuevo.Enabled = true;

        }
        private void HabilitarBotones()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            DesabilitarBotones();
            //Se llenan los datos de la lista
            if (!ListaProductos.Any())
            {
                ListaProductos.Add(new ClassProducto { id = 1, nombre = "Cafe Gourmet", descripcion = "Importado", precio = 10.5m, stock = 100, estado = true });
                ListaProductos.Add(new ClassProducto { id = 2, nombre = "Cafe Borbon ", descripcion = "De Altura", precio = 20.0m, stock = 50, estado = true });
                ListaProductos.Add(new ClassProducto { id = 3, nombre = "Chescake", descripcion = "Dulce Saver", precio = 15.75m, stock = 75, estado = true });
            }
            RefrescarGrid(); //Se mada a llamar el metodo para refrescar si hay datos
        }
        //Asignar la lista
        private void RefrescarGrid() //Metodo para refrescar el DataGridView
        {
            dgv.DataSource = null; //Limpiar el DataSource antes de asignarlo
            dgv.DataSource = ListaProductos; //Asignar la lista como DataSource
        }
        //Boton guardar
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones basicas
            //Validar que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra ventana emergente con mensaje de error
                txtNombre.Focus(); //Se coloca el cursor en el campo para corregir
                return; //Termina la ejecucion y devuelve un valor
            }
            //Validar que el precio sea un valor numerico
            if (!ClassValidaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("El precio de el producto debe ser un valor numerico.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            //Validar que el stock sea un valor entero
            if (!ClassValidaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return;
            }
            //Crear objeto peoducto y asignar id automatico
            int nuevoid = ListaProductos.Any() ? ListaProductos.Max(x => x.id) + 1 : 1;
            var p = new ClassProducto
            {
                id = nuevoid,
                nombre = txtNombre.Text,
                descripcion = txtDescripcion.Text,
                precio = decimal.Parse(txtPrecio.Text),
                stock = int.Parse(txtStock.Text),
                estado = chkEstado.Checked
            };
            //Agregar el nuevo producto a la lista
            ListaProductos.Add(p);
            RefrescarGrid(); //Refrescar el DataGridView
            //Limpiar los campos del formulario
            LimpiarCampos();
        }
        //Metodo para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            chkEstado.Checked = true;
            txtNombre.Focus(); //Colocar el cursor en el campo nombre
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Evento al hacer click en una celda del DataGridView
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            //Obtener el producto seleccionado
            txtId.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
            txtNombre.Text = dgv.CurrentRow.Cells["nombre"].Value.ToString();
            txtDescripcion.Text = dgv.CurrentRow.Cells["descripcion"].Value.ToString();
            txtPrecio.Text = dgv.CurrentRow.Cells["precio"].Value.ToString();
            txtStock.Text = dgv.CurrentRow.Cells["stock"].Value.ToString();
            chkEstado.Checked = (bool)dgv.CurrentRow.Cells["Estado"].Value;
            //Habilitar los botones
            HabilitarBotones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Evento para eliminar un producto
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaProductos.FirstOrDefault(x => x.id == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaProductos.Remove(prod);//con remove elimino el producto de la lista
                RefrescarGrid();//refrescar el datagridview
                LimpiarCampos();//limpiar los controles
                DesabilitarBotones();
            }

        }
        //Evento para editar un producto
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido para modificar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //busco el producto en la lista
            var prod = ListaProductos.FirstOrDefault(x => x.id == id);
            //si lo encuentro, actualizo sus propiedades
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas a las del boton guardar
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }//valida que el precio ingresado sea un decimal
            if (!ClassValidaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("El precio del producto debe ser un valor numérico.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }//valida que el stock ingresado sea un entero
            if (!ClassValidaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("el stock del producto debe ser un valor entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return;
            }
            //Actualizar los campos en memoria
            prod.nombre = txtNombre.Text.Trim();
            prod.descripcion = txtDescripcion.Text.Trim();
            prod.precio = decimal.Parse(txtPrecio.Text);
            prod.stock = int.Parse(txtStock.Text);
            prod.estado = chkEstado.Checked;
            MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid();//refrescar el datagridview
            LimpiarCampos();//limpiar los controles
            DesabilitarBotones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Advertencia antes de cerrar el formulario
            if (MessageBox.Show("¿Está seguro de volver al menú principal?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Cerrar el formulario actual
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
