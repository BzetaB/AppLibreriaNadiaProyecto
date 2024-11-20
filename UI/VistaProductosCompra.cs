using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace UI
{
    public partial class VistaProductosCompra : Form
    {
        ProductosBL productosBL = new ProductosBL();
        public int ProductoCod { get; private set; }
        public string NombreProduc { get; private set; }

        public VistaProductosCompra()
        {
            InitializeComponent();
        }

        private void VistaProductosCompra_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = productosBL.MostrarProductos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            ProductoCod = Convert.ToInt32(codigo);
            NombreProduc = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }
    }
}
