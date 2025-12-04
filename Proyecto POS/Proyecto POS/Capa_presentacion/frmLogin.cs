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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = UsuarioBLL.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim());

                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guardar sesión
                SesionActual.IdUsuario = u.IdUsuario;
                SesionActual.NombreUsuario = u.NombreUsuario;
                SesionActual.Rol = u.Rol;

                // Abrir principal
                MenuScript main = new MenuScript();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
