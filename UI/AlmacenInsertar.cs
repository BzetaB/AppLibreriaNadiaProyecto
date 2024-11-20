using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AlmacenInsertar : Form
    {
        private ProductosBL productsBL = new ProductosBL();
        private CategoriaBL categoriaBL = new CategoriaBL();
        public AlmacenInsertar()
        {
            InitializeComponent();
        }

        public void ActualizarCategoria()
        {
            List<CategoriaBE> lista = new List<CategoriaBE>(categoriaBL.MuestraCategorias());
            foreach (var categoria in lista)
            {
                comboCategoria.Items.Add(categoria.Nombre_Categoria);
            }
        }
        private void AlmacenInsertar_Load(object sender, EventArgs e)
        {
            ActualizarCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiar()
        {
            comboCategoria.Text = null;
            txtNombreProduc.Clear();
            txtColorProduc.Clear();
            txtMarcaProduc.Clear();
            txtUnidProduc.Clear();
            txtTamanioProduc.Clear();
            datetimeVencimiento.Enabled = false;
            richTextBoxDetallesProduc.Clear();
            radioButtonNO.Checked = false;
            radioButtonSI.Checked = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string categoria = comboCategoria.Text.ToUpper();
            string nombreproduc = txtNombreProduc.Text.ToUpper();
            string marcaproduc = txtMarcaProduc.Text.ToUpper();
            int unidades;    
            string color = txtColorProduc.Text.ToUpper();
            string tamanio = txtTamanioProduc.Text.ToUpper();
            bool perecible = false;
            if(radioButtonSI.Checked) {
                perecible = true;
                datetimeVencimiento.Enabled = true;
            }else if (radioButtonNO.Checked)
            {
                perecible = false;
                datetimeVencimiento.Enabled = false;
            }
            DateTime fechaVencimiento = datetimeVencimiento.Value;
            string detalles = richTextBoxDetallesProduc.Text.ToUpper();


            if (!int.TryParse(txtUnidProduc.Text, out unidades))
            {
                MessageBox.Show("Solo se permiten datos enteros en UNIDADES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            while  (int.TryParse(txtUnidProduc.Text, out unidades))
            {
                ProductosBE productosBE = new ProductosBE(nombreproduc, marcaproduc, unidades, color, perecible, fechaVencimiento, tamanio, detalles);
                CategoriaBE categoriaBE = new CategoriaBE(categoria);
                productsBL.InsertarProducto(productosBE, categoriaBE);
                MessageBox.Show("¡Nuevo producto Insertado!", "MENSAJE",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                break;
            }
        }

        private void radioButtonSI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSI.Checked)
            {
                datetimeVencimiento.Enabled = true;
            }
            else
            {
                datetimeVencimiento.Enabled = false;
            }
        }
    }
}
