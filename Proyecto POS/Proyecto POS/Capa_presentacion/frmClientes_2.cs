using Proyecto_POS.Capa_entidades;
using Proyecto_POS.Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_POS.Capa_presentacion
{
    public partial class frmClientes_2 : Form
    {
        //Variable global para guardar el ID del cliente seleccionado; si es 0, es un cliente nuevo.
        int clienteid = 0;
        // Instancia de la Capa de Lógica de Negocio (BLL) para comunicarse con la base de datos.
        Cliente_BLL bll = new Cliente_BLL();
        public frmClientes_2()
        {
            InitializeComponent();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_2_Load(object sender, EventArgs e)
        {
            CargarDatos(); //Al abrir el formulario, llena la tabla con los clientes existentes.
            Limpiar(); //Se asegura de que las cajas de texto estén vacías al iniciar.
        }
        public void CargarDatos()
        {
            //Conecta el origen de datos del DataGridView (la tabla visual) con la base de datos que trae la BLL.
            dgvClientes_2.DataSource = bll.Listar();
        }
        //Metodo para borra el texto de todas las cajas de texto (Nombre, Apellido, DUI, etc.).
        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDui.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
            chkActivo.Checked = true;
            txtNombre.Focus();

            clienteid = 0; // Reinicia el ID a 0 para indicar que el próximo guardado será un registro NUEVO.
        }

        private void dgvClientes_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(); //Llama al método Limpiar cuando se presiona el botón "Limpiar".
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crea un objeto Cliente_2 y llena sus propiedades con lo que se escribe en las cajas de texto.
                Cliente_2 c = new Cliente_2 //Si es sero es un nuevo registro si ya hay uno se modifica
                {
                    id = clienteid,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    telefono = txtTelefono.Text,
                    dui = txtDui.Text,
                    correo = txtCorreo.Text,
                    estado = chkActivo.Checked
                };
                //Envía el objeto a la BLL para guardarlo en la base de datos.
                int id = bll.Guardar(c);
                //Muestra una ventana emergente confirmando el éxito.
                MessageBox.Show("Cliente guardado con exito", "Modifcacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); //Si hay error, lo escribe en la consola de depuración.
            }

        }

        private void dgvClientes_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se verifica que no haya hecho clic en el encabezado(índice negativo).
            if (e.RowIndex >= 0)
            {
                //Pasa los datos de la fila seleccionada a las cajas de texto para poder editarlos.
                clienteid = Convert.ToInt32(dgvClientes_2.Rows[e.RowIndex].Cells["id"].Value);
                txtNombre.Text = dgvClientes_2.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvClientes_2.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                txtTelefono.Text = dgvClientes_2.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtDui.Text = dgvClientes_2.Rows[e.RowIndex].Cells["dui"].Value.ToString();
                txtCorreo.Text = dgvClientes_2.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(dgvClientes_2.Rows[e.RowIndex].Cells["estado"].Value);
            }
        }
        //Si el ID es 0, significa que no has seleccionado nada de la tabla.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(clienteid == 0)
            {
                MessageBox.Show("Seleciones un cliente al eliminar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Pregunta al usuario "Sí o No" antes de borrar.
            if (MessageBox.Show("Esta seguro de eliminar", "Confirmacion", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(clienteid); //Llama a la BLL para borrar el registro con ese ID.
                CargarDatos(); // Actualiza la tabla visualmente.
                Limpiar(); // Limpia las cajas de texto.
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close(); //Cierra el formulario
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Cada vez que se escribe algo en la caja de búsqueda, actualiza la tabla con los resultados.
            dgvClientes_2.DataSource = bll.Buscar(txtBuscar.Text);
        }
    }
}
