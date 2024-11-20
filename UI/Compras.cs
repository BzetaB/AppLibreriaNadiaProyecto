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
    public partial class Compras : Form
    {
        DetalleCompraBL detalleCompraBL = new DetalleCompraBL();
        private VistaProvedoresCompra vistaProvedoresCompra;
        private VistaProductosCompra vistaProductosCompra;
        public Compras()
        {
            InitializeComponent();
        }

        private void btnBuscarProvedor_Click(object sender, EventArgs e)
        {
            vistaProvedoresCompra = new VistaProvedoresCompra();
            vistaProvedoresCompra.FormClosing += VistaProvedoresCompra_FormClosing; 
            vistaProvedoresCompra.Show();
        }

        private void VistaProvedoresCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vistaProvedoresCompra.DialogResult == DialogResult.OK)
            {
                int codigoProveedor = vistaProvedoresCompra.ProveedorSelectCod;
                string rucProveedor = vistaProvedoresCompra.Ruc;
                string nombreProveedor = vistaProvedoresCompra.NombreProveedor;

                // Ahora puedes usar los datos seleccionados como desees en este formulario
                // Por ejemplo, mostrarlos en controles TextBox, etc.
                txtRUC.Text = rucProveedor;
                txtNombreProve.Text = nombreProveedor;
            }
        }

        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            vistaProductosCompra = new VistaProductosCompra();
            vistaProductosCompra.FormClosing += VistaProductosCompra_FormClosing;
            vistaProductosCompra.Show();

        }


        private void VistaProductosCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vistaProductosCompra.DialogResult == DialogResult.OK)
            {
                int codigoProduc = vistaProductosCompra.ProductoCod;
                string nombreProduc = vistaProductosCompra.NombreProduc;

                // Ahora puedes usar los datos seleccionados como desees en este formulario
                // Por ejemplo, mostrarlos en controles TextBox, etc.
                txtCodProduc.Text = codigoProduc.ToString();
                txtNombreProduc.Text = nombreProduc;
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            //dgvDetalleCompra.DataSource = detalleCompraBL.VistaDetalleCompra();
        }

        private void Limpiar()
        {
            txtCodProduc.Clear();
            txtNombreProduc.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCantidad.Value = 0;
            
        }

        public void CalcularTotal()
        {
            decimal total = 0;
            
            if(dgvDetalleCompra.Rows.Count>0)
            {
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtSubTotalCompra.Text = total.ToString("0.00");

            decimal igv = total * 18/100;
            txtIGV.Text = igv.ToString("0.00");

            decimal totalcompra = igv + total;
            txtTotalCompra.Text = totalcompra.ToString("0.00");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool productoExiste = false;
            decimal precioComra = Convert.ToDecimal(txtPrecioCompra.Text);
            decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (fila.Cells["CodProduc"].Value.ToString() == txtCodProduc.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            if (!productoExiste)
            {
                dgvDetalleCompra.Rows.Add(new object[]
                {
                txtCodProduc.Text,
                txtNombreProduc.Text,
                precioComra.ToString("0.00"),
                txtCantidad.Value.ToString(),
                precioVenta.ToString("0.00"),
                (txtCantidad.Value*precioComra).ToString("0.00")
                });
                CalcularTotal();
                Limpiar();
                txtCodProduc.Select();
            }

        }

    }
}
