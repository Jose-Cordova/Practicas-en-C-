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
    public partial class frmCambiarClave : Form
    {
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SesionActual.IdUsuario;
                if (id == 0) throw new Exception("No hay sesión activa.");

                // Verificar clave actual
                var user = UsuarioDAL.Login(SesionActual.NombreUsuario, PruebaHash(txtClaveActual.Text));
                if (user == null)
                {
                    MessageBox.Show("La contraseña actual es incorrecta.");
                    return;
                }

                if (txtNuevaClave.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("La nueva contraseña y su confirmación no coinciden.");
                    return;
                }

                bool ok = UsuarioBLL.CambiarClave(id, txtNuevaClave.Text);
                MessageBox.Show(ok ? "Contraseña actualizada." : "No se pudo actualizar.");
                if (ok) this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Método privado para generar hash temporal y verificar (evita duplicar Seguridad en UI)
        private string PruebaHash(string pass)
        {
            return Seguridad.Hash_SHA256(pass);
        }

    }
}

