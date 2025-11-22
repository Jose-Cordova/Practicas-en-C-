using Proyecto_POS.Capa_entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS.Capa_presentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        //Creacion de una lista que simule una base de datos
        public static List<Clientes> ListaClientes = new List<Clientes>();
        private void DesabilitarBotones()
        {
            btnLimpiar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCliente.Enabled = true;
        }
        private void HabilitarBotones()
        {
            btnLimpiar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCliente.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            DesabilitarBotones();
            //Se llenan los datos de la lista
            if (!ListaClientes.Any())
            {
                ListaClientes.Add(new Clientes 
                { id = 1, 
                  nombre = "Jose Santos",
                  apellido = "Cordova Cordova",
                  dui = "07273225-9",
                  telefono = "60472114",
                  correo = "jose681720@gmaol.com",
                  estado = true
                
                });
               
            }
            RefrescarGrid(); //Se mada a llamar el metodo para refrescar si hay datos


        }
        //Asignar la lista
        private void RefrescarGrid() //Metodo para refrescar el DataGridView
        {
            dgvClientes.DataSource = null; //Limpiar el DataSource antes de asignarlo
            dgvClientes.DataSource = ListaClientes; //Asignar la lista como DataSource
        }
        //Boton registra cliente
        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Validaciones basicas
            //Validar que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra ventana emergente con mensaje de error
                txtNombre.Focus(); //Se coloca el cursor en el campo para corregir
                return; //Termina la ejecucion y devuelve un valor
            }
            //Validar que el apellido no este vacio
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus(); 
                return;
            }
            //Validar direccion de correo electronico
            if (!ClassValidaciones.EsCorreoValido(txtEmail.Text))
            {
                MessageBox.Show("El correo electronico no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            //Validar que el telefono no este vacio
            if (!mkdTelefono.MaskCompleted)
            {
                MessageBox.Show("El teléfono del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdTelefono.Focus();
                return;
            }
            //Crear un objeto cliente y aignar id atomaticamente
            int nuevoid = ListaClientes.Any() ? ListaClientes.Max(x => x.id) + 1 : 1;
            var cliente = new Clientes
            {
                id = nuevoid,
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                dui = mkdDui.Text.Trim(),
                telefono = mkdTelefono.Text.Trim(),
                correo = txtEmail.Text.Trim(),
                estado = chkEstado.Checked
            };
            //Agregar el cliente a la lista
            ListaClientes.Add(cliente);
            //Refrescar el DataGridView
            RefrescarGrid();
        }
        //Metdod para limpiar los campos
        private void LimpiarCampos()
        {
            txtid.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            mkdDui.Clear();
            mkdTelefono.Clear();
            txtEmail.Clear();
            chkEstado.Checked = true;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        //Evento al hacer click en una celda del DataGridView
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotones();
            if (dgvClientes.CurrentRow == null) return;
            //Obtener el cliente seleccionado
            txtid.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells["apellido"].Value.ToString();
            mkdDui.Text = dgvClientes.CurrentRow.Cells["dui"].Value.ToString();
            mkdTelefono.Text = dgvClientes.CurrentRow.Cells["telefono"].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells["correo"].Value.ToString();
            chkEstado.Checked = (bool)dgvClientes.CurrentRow.Cells["estado"].Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Evento para eliminar un cliente
            if (!int.TryParse(txtid.Text, out int id))
            {
                MessageBox.Show("Seleccione un cliente existente para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cliente = ListaClientes.FirstOrDefault(x => x.id == id);
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaClientes.Remove(cliente);//con remove elimino el producto de la lista
                RefrescarGrid();//refrescar el datagridview
                LimpiarCampos();//limpiar los controles
                DesabilitarBotones();

            }
        }
        //Evento para actualizar los datos de un cliente
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtid.Text, out int id))
            {
                MessageBox.Show("Seleccione un cliente existente para modificar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //busco el producto en la lista
            var cliente = ListaClientes.FirstOrDefault(x => x.id == id);
            //si lo encuentro, actualizo sus propiedades
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas a las del boton registrar
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra ventana emergente con mensaje de error
                txtNombre.Focus(); //Se coloca el cursor en el campo para corregir
                return; //Termina la ejecucion y devuelve un valor
            }
            //Validar que el apellido no este vacio
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            //Validar direccion de correo electronico
            if (!ClassValidaciones.EsCorreoValido(txtEmail.Text))
            {
                MessageBox.Show("El correo electronico no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            //Validar que el telefono no este vacio
            if (!mkdTelefono.MaskCompleted)
            {
                MessageBox.Show("El teléfono del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdTelefono.Focus();
                return;
            }
            //Actualizo las propiedades del cliente
            cliente.nombre = txtNombre.Text.Trim();
            cliente.apellido = txtApellido.Text.Trim();
            cliente.dui = mkdDui.Text.Trim();
            cliente.telefono = mkdTelefono.Text.Trim();
            cliente.correo = txtEmail.Text.Trim();
            cliente.estado = chkEstado.Checked;
            //Mostra un mensaje de exito
            MessageBox.Show("Cliente modifcado exitosa mente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid(); //Refrescar el DataGridView
            LimpiarCampos(); //Limpiar los campos
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
