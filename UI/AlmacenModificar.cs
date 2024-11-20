using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AlmacenModificar : Form
    {   
        ProductosBL productosBL = new ProductosBL();
        ProductosBE productosBE = null;
        CategoriaBE categoriaBE = new CategoriaBE();
        private CategoriaBL categoriaBL = new CategoriaBL();
        public AlmacenModificar(int productoCod, string categoria)
        {
            productosBE = productosBL.BuscarProducto(productoCod);
            categoriaBE.Nombre_Categoria = categoria;
            InitializeComponent();

        }

        private void AlmacenModificar_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = productosBE.Cod_Producto.ToString();
            txtCodigo.Enabled = false;
            txtNombre.Text = productosBE.Nombre_Producto;
            comboCategoria.Text = categoriaBE.Nombre_Categoria;
            txtPrecioUnitario.Text = productosBE.Precio_Unit_Produc.ToString();
            txtMarca.Text = productosBE.Marca_produc;
            txtUnidades.Text = productosBE.Unid_Produc.ToString();
            txtColor.Text = productosBE.Color_Produc;
            txtTamaño.Text = productosBE.Tamanio_produc;
            richtxtDetalles.Text = productosBE.Detalles_produc;
            if (productosBE.Perecible_produc == false)
            {
                radiobtnNO.Checked = true;
                dateVencimiento.Enabled = false;
            }
            else
            {
                radiobtnSI.Checked = true;
                dateVencimiento.Value = productosBE.Fecha_Venci_Produc;

            }

            ActualizarCategoria();
            
        }

        public void ActualizarCategoria()
        {
            List<CategoriaBE> lista = new List<CategoriaBE>(categoriaBL.MuestraCategorias());
            foreach (var categoria in lista)
            {
                comboCategoria.Items.Add(categoria.Nombre_Categoria);
            }
        }

        private void radiobtnSI_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnSI.Checked)
            {
                dateVencimiento.Enabled = true;
            }
            else
            {
                dateVencimiento.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int codigoCat = categoriaBL.CodigoCat(comboCategoria.Text);
            decimal precio = Convert.ToDecimal(txtPrecioUnitario.Text);
            string marca = txtMarca.Text;
            int unidades = Convert.ToInt32(txtUnidades.Text);
            string color = txtColor.Text;
            bool perecible = false;
            if (radiobtnSI.Checked)
            {
                perecible = true;
            }
            DateTime vencimiento = dateVencimiento.Value;
            string tamaño = txtTamaño.Text;
            string detalles = richtxtDetalles.Text;

            ProductosBE productosbe = new ProductosBE(codigo,codigoCat,nombre,precio,marca,unidades,color,perecible,vencimiento,tamaño,detalles);
            productosBL.Update(productosbe);

            MessageBox.Show("PRODUCTO MODIFICADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }
    }
}
