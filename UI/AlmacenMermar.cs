using BE;
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
    public partial class AlmacenMermar : Form
    {
        private UsuariosBE usuariosBE = new UsuariosBE();
        private ProductosBE productsBE = new ProductosBE();
        private MermaBE mermaBE = new MermaBE();
        private MermaBL mermaBL = new MermaBL();
        public AlmacenMermar(int productoCod,string userUsuario, int codigoUser,string nombreProducto)
        {
            productsBE.Cod_Producto = productoCod;
            usuariosBE.User_Usuario = userUsuario;
            usuariosBE.Cod_Usuario = codigoUser;
            productsBE.Nombre_Producto = nombreProducto;

            InitializeComponent();
        }

        private void AlmacenMermar_Load(object sender, EventArgs e)
        {
            Reiniciar();
            dgvMerma.DataSource = mermaBL.MostrarMerma();

        }
        private void Reiniciar()
        {
            txtCodUsuario.Text = usuariosBE.Cod_Usuario.ToString();
            txtCodUsuario.Enabled = false;
            txtCodProducto.Text = productsBE.Cod_Producto.ToString();
            txtCodProducto.Enabled = false;
            txtNombreUsuario.Text = usuariosBE.User_Usuario;
            txtNombreUsuario.Enabled = false;
            txtNombreProducto.Text = productsBE.Nombre_Producto;
            txtNombreProducto.Enabled = false;
            txtCantidad.Clear();
            dateTimePicker1.Value = DateTime.Now;
            richTextBox1.Clear();
            dgvMerma.DataSource = mermaBL.MostrarMerma();
        }
        private void btnMermar_Click(object sender, EventArgs e)
        {
            int codUsuario = Convert.ToInt32(txtCodUsuario.Text);
            int codProducto = Convert.ToInt32(txtCodProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            DateTime fechaSalidad = dateTimePicker1.Value;
            string descripcionSalida = richTextBox1.Text;

            UsuariosBE usuariosBE = new UsuariosBE(codUsuario);
            ProductosBE productosBE = new ProductosBE(codProducto);
            MermaBE mermaBE = new MermaBE(fechaSalidad, descripcionSalida, cantidad);

            DialogResult result = MessageBox.Show("¿Estás seguro que quieres mermar este producto?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int rptProcedimeinto = mermaBL.Insert(usuariosBE, productosBE, mermaBE);
                
                if(rptProcedimeinto == 1)
                {
                    MessageBox.Show("¡pRODUCTO MERMADO!", "MENSAJE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reiniciar();
                }
                else if(rptProcedimeinto == 0)
                {
                    MessageBox.Show("No hay suficiente stock para registrar la merma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al mermar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reiniciar();
            }
        }
    }
}
