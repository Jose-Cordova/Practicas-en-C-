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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Se llenan los datos de la lista
            if (!ListaProductos.Any())
            {
                ListaProductos.Add(new ClassProducto { id = 1, nombre = "Cafe Gourmet", descripcion = "Importado", precio = 10.5m , stock = 100, estado = true});
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Validar que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text)){
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra ventana emergente con mensaje de error
                txtNombre.Focus(); //Se coloca el cursor en el campo para corregir
                return; //Termina la ejecucion y devuelve un valor
            }
            //Validar que el precio sea un valor numerico
            if (!ClassValidaciones.EsDecimal(txtPrecio.Text)) { 
                MessageBox.Show("El precio de el producto debe ser un valor numerico.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            //Validar que el stock sea un valor entero
            if (!ClassValidaciones.EsEntero(txtStock.Text)) {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return;
            }
        }
    }
}
