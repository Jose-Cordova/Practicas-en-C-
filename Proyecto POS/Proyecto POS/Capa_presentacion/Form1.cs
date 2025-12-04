using Proyecto_POS.Capa_entidades;
using Proyecto_POS.Capa_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS
{
    public partial class MenuScript : Form
    {
        public MenuScript()
        {
            InitializeComponent();
        }

        private void cierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            //Crear una instancia de el formulario productos
            frmProductos frm = new frmProductos();
            //Muestra el formulario
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Crear una instancia de el formulario productos
            frmClientes frm = new frmClientes();
            //Muestra el formulario
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Advertencia antes de cerrar el formulario
            if (MessageBox.Show("¿Está seguro de cerrar el programa?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Cerrar el formulario
            }
        }

        private void MenuScript_Load(object sender, EventArgs e)
        {
             CambiarClave.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
            //Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

            }

        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarClave frm = new frmCambiarClave();
            frm.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.ShowDialog();

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Confirmar si desea cerrar sesión
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Limpiar la sesión actual
                SesionActual.Cerrar();

                // Crear una nueva instancia del formulario de Login
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                // Cerrar el formulario principal
                this.Close();
            }
        }
    }
}
