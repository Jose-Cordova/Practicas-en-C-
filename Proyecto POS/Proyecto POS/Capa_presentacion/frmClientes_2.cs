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
    public partial class frmClientes_2 : Form
    {
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
            CargarDatos();
            //Limpiar:()
        }
        public void CargarDatos()
        {
            dgvClientes_2.DataSource = bll.Listar();
        }

        private void dgvClientes_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
