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
    public partial class Proveedores : Form
    {
        ProveedoresBL proveedoresBL = new ProveedoresBL();
        int codProvedor = 0;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscador = txtBuscar.Text;
            if (radiobtnNombre.Checked)
            {
                dataGridView1.DataSource = proveedoresBL.BuscarPorNombre(buscador);
                if(dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Código no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = proveedoresBL.MostrarProveedores();
                }
            }else if (radiobtnRUC.Checked)
            {
                dataGridView1.DataSource = proveedoresBL.BuscarPorRUC(buscador);
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("RUC no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = proveedoresBL.MostrarProveedores();
                }
            }

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedoresBL.MostrarProveedores();
            btnModificar.Enabled = false;
        }

        public void Reiniciar()
        {

            txtRUC.Text = null;
            txtNombre.Text = null;
            txtDireccion.Text = null;
            txtTelefono.Text = null;
            txtCorreo.Text = null;
            btnModificar.Enabled = false;
            txtBuscar.Text = null;
            radiobtnRUC.Checked = false;
            radiobtnNombre.Checked = false;
            dataGridView1.DataSource = proveedoresBL.MostrarProveedores();
            txtRUC.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string ruc = txtRUC.Text.ToUpper();
            string nombre = txtNombre.Text.ToUpper();
            string direccion = txtDireccion.Text.ToUpper();
            string numero = txtTelefono.Text.ToUpper();
            string correo = txtCorreo.Text;

            ProveedoresBE proveedoresBE = new ProveedoresBE(nombre, direccion, numero, correo, ruc);

            proveedoresBL.Insert(proveedoresBE);
            Reiniciar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoProv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int ProvCodigo = Convert.ToInt32(codigoProv);

            ProveedoresBE proveedoresBE = proveedoresBL.BuscarProveedor(ProvCodigo);

            txtRUC.Text= proveedoresBE.RUC;
            txtNombre.Text = proveedoresBE.Nombre_Proveedor;
            txtDireccion.Text = proveedoresBE.Direccion_Proveedor;
            txtTelefono.Text = proveedoresBE.Telf_provedor;
            txtCorreo.Text = proveedoresBE.Correo_Provedor;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = false;
            codProvedor = proveedoresBE.Cod_Proveedor;


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string ruc = txtRUC.Text.ToUpper();
            string nombre = txtNombre.Text.ToUpper();
            string direccion = txtDireccion.Text.ToUpper();
            string numero = txtTelefono.Text.ToUpper();
            string correo = txtCorreo.Text;

            ProveedoresBE proveedoresBE = new ProveedoresBE(codProvedor,nombre,direccion,numero,correo,ruc);

            proveedoresBL.Update(proveedoresBE);
            MessageBox.Show("¡Usuario Actualizado!", "MENSAJE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reiniciar();

        }
    }
}
