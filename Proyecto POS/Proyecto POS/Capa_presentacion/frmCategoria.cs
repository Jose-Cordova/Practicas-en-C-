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
    public partial class frmCategoria : Form
    {

        CategoriaBLL bll = new CategoriaBLL();

        int categoria_id = 0;  // Guarda el ID seleccionado
        string modo = "Nuevo"; // Nuevo o Editar

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();
        }
        void HabilitarBotones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
            dgvCategoria.ClearSelection();
            dgvCategoria.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dgvCategoria.SelectedRows.Count > 0;
                btnEditar.Enabled = filaSeleccionada;
                btnEliminar.Enabled = filaSeleccionada;
                btnNuevo.Enabled = !filaSeleccionada;
            };

        }
        void CargarDatos()
        {
            dgvCategoria.DataSource = bll.Listar();
            dgvCategoria.ClearSelection();
            categoria_id = 0;   // Reiniciar ID seleccionado
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = bll.Buscar(txtBuscar.Text);
        }
        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clickeamos una fila válida
            if (e.RowIndex >= 0)
            {
                categoria_id = Convert.ToInt32(dgvCategoria.Rows[e.RowIndex].Cells["id"].Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoria_gestion2 frm = new frmCategoria_gestion2();

            frm.modo = "Nuevo";
            frm.id = 0;

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (categoria_id == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            frmCategoria_gestion2 frm = new frmCategoria_gestion2();
            // MODO EDITAR
            frm.modo = "Editar";
            frm.id = categoria_id;

            // Pasar información desde el DGV
            frm.nombre = dgvCategoria.CurrentRow.Cells["nombre"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (categoria_id == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;

            }
            // Abrir formulario de eliminación
            frmCategoria_eliminar frm = new frmCategoria_eliminar();

            frm.id = categoria_id;
            frm.nombre = dgvCategoria.CurrentRow.Cells["nombre"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

