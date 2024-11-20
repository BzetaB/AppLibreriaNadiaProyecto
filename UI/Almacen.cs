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
    public partial class Almacen : Form
    {
        private CategoriaBL categoriaBL = new CategoriaBL();
        private ProductosBL productsBL = new ProductosBL();
        private static UsuariosBE CargoActual;
        private int productoSeleccionado;
        private string nombreProductoSeleccionado;
        private string categoria;
        public Almacen(UsuariosBE cargo, int codigo)
        {
            CargoActual = cargo;
            CargoActual.Cod_Usuario = codigo;
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
        public void ActualizarMarca()
        {
            comboMarca.Items.Clear();

            List<ProductosBE> lista = new List<ProductosBE>(productsBL.Marcas(txtBuscar.Text));
            foreach (var product in lista)
            {
                comboMarca.Items.Add(product.Marca_produc);
            }
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = productsBL.MostrarProductos();
            dgvRegistros.Columns[0].Width = 32;
            dgvRegistros.Columns[4].Width = 50;
            dgvVencimineto.DataSource = productsBL.MostrarVencimiento();
            ActualizarCategoria();
            if(CargoActual.Usuario_Cargo == "EMPLEADO")
            {
                btnIngresar.Visible = false;
                btnMermar.Visible = false;
                btnModificar.Visible = false;
            }

        }
   
        private void comboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboCategoria.Text != "SELECCIONAR")
            {
                dgvRegistros.DataSource = productsBL.ConsultarProductoCategoria(comboCategoria.Text.ToString());
            }
            comboMarca.Items.Clear();
            radiobutonCodigo.Checked = false;
            radiobutonProduc.Checked = false;
            comboMarca.Text = null;
            txtBuscar.Text = null;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            comboMarca.Items.Clear();
            radiobutonCodigo.Checked = false;
            radiobutonProduc.Checked = false;
            comboCategoria.Text = null;
            comboMarca.Text = null;
            dgvRegistros.DataSource = productsBL.MostrarProductos();
            txtBuscar.Text = null;
            btnMermar.Enabled = false;
            btnModificar.Enabled = false;
            dgvVencimineto.DataSource = productsBL.MostrarVencimiento();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            string codBusqueda = busqueda.Trim(); // Eliminar espacios en blanco alrededor del código

            // Validar si el valor ingresado en txtBuscar es un código válido
            
            if (radiobutonCodigo.Checked == true)
            {
                if (!int.TryParse(codBusqueda, out _))
                {
                    MessageBox.Show("Error de ingreso: Por favor, ingrese un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistros.DataSource = productsBL.ConsulProducCodigo(busqueda);
                if (dgvRegistros.Rows.Count == 1)
                {
                     MessageBox.Show("Código no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvRegistros.DataSource = productsBL.MostrarProductos();
                }
            }else if(radiobutonProduc.Checked == true)
             {
                dgvRegistros.DataSource = productsBL.ConsultaProducs(busqueda);
                if (dgvRegistros.Rows.Count == 1)
                {
                    MessageBox.Show("Nombre de producto no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvRegistros.DataSource = productsBL.MostrarProductos();
                }
                ActualizarMarca();
             }
            else if(dgvRegistros.DataSource == productsBL.ConsultarProductoCategoria(comboCategoria.Text.ToString()))
            {
                dgvRegistros.DataSource = productsBL.ConsularPorCategoriayNombre(busqueda,comboCategoria.Text.ToString());
                if (dgvRegistros.Rows.Count == 1)
                {
                    MessageBox.Show("Nombre de producto no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvRegistros.DataSource = productsBL.MostrarProductos();
                }
                ActualizarMarca();
            }
        }

        private void comboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboMarca.Text != null)
            {
                dgvRegistros.DataSource = productsBL.BuscarProducMarca(txtBuscar.Text, comboMarca.Text.ToString());
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AlmacenInsertar almacenInsertar = new AlmacenInsertar();
            almacenInsertar.Show();
            dgvRegistros.DataSource = productsBL.MostrarProductos();

        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMermar.Enabled = true;
            btnModificar.Enabled = true;

            string codigo = dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString();
            productoSeleccionado = Convert.ToInt32(codigo);
            nombreProductoSeleccionado = productsBL.NombreProducto(Convert.ToInt32(codigo));
            categoria = dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnMermar_Click(object sender, EventArgs e)
        {
            AlmacenMermar almacenMermar = new AlmacenMermar(productoSeleccionado,CargoActual.User_Usuario,CargoActual.Cod_Usuario,nombreProductoSeleccionado);
            almacenMermar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AlmacenModificar almacenModificar = new AlmacenModificar(productoSeleccionado,categoria);
            almacenModificar.Show();
        }
    }
}
