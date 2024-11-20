using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class VistaProvedoresCompra : Form
    {
        ProveedoresBL proveedoresBL = new ProveedoresBL();
        public int ProveedorSelectCod { get; private set; }
        public string Ruc { get; private set; }
        public string NombreProveedor { get; private set; }
        public VistaProvedoresCompra()
        {
            InitializeComponent();
        }

        private void VistaProvedoresCompra_Load(object sender, EventArgs e)
        {
            dgvProvedoresCompra.DataSource = proveedoresBL.VistaProvedoresCompra();
        }

        private void dgvProvedoresCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dgvProvedoresCompra.Rows[e.RowIndex].Cells[0].Value.ToString();
            ProveedorSelectCod = Convert.ToInt32(codigo);
            Ruc = dgvProvedoresCompra.Rows[e.RowIndex].Cells[1].Value.ToString();
            NombreProveedor = dgvProvedoresCompra.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.DialogResult = DialogResult.OK;

        }
    }
}
