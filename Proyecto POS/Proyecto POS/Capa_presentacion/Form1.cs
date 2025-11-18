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
    }
}
