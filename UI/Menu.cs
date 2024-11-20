using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace UI
{
    public partial class Menu : Form
    {

        private static UsuariosBE RolActual;
        private static IconMenuItem itemSeleccionado = null;
        private static Form FormularioActual = null;
        public Menu(UsuariosBE rol,int codigoUser)
        {
            RolActual = rol;
            RolActual.Cod_Usuario = codigoUser;
            InitializeComponent();
        }
       

        private void Menu_Load(object sender, EventArgs e)
        {
                labelCargo.Text = RolActual.Usuario_Cargo;
            if(RolActual.Usuario_Cargo == "EMPLEADO")
            {
                itemUsuario.Visible = false;
                itemCompras.Visible = false;
                itemProveedores.Visible = false;
            }
        }

        private void CargarFormulario(IconMenuItem itemsMenu, Form formulario)
        {
            if(itemSeleccionado != null)
            {
                itemSeleccionado.BackColor = Color.White;
                //al cambiar de item, el item anterior seleccionado vuelve a su color, o sea, blanco.
            }

            itemsMenu.BackColor = Color.Silver; //el item selccionado toma un color plata
            itemSeleccionado = itemsMenu;//el item actual se vuelve el item seleccionado

            if(FormularioActual != null)
            {
                FormularioActual.Close();
                // si hay un formulario activo, se cierra al cambiar de item
            }

            FormularioActual = formulario; //el fomrulario actual se convierte al formulario que es seleccionado con el item
            formulario.TopLevel = false; //que no se muestre como ventana superior
            formulario.FormBorderStyle = FormBorderStyle.None;//que no tenga bordes
            formulario.Dock = DockStyle.Fill;//que rellene todo el espacio del panel
            formulario.BackColor = Color.SteelBlue;
            PanelMuestraForm.Controls.Add(formulario);//agrega el formulario al panel
            formulario.Show();

        }

        private void itemAlmacen_Click(object sender, EventArgs e)
        {
            CargarFormulario((IconMenuItem)sender, new Almacen(RolActual,RolActual.Cod_Usuario));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?",
            "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                login.Show();
            }
        }

        private void itemUsuario_Click(object sender, EventArgs e)
        {
            CargarFormulario((IconMenuItem)sender,new Usuarios());
        }

        private void itemCompras_Click(object sender, EventArgs e)
        {
            CargarFormulario((IconMenuItem)sender, new Compras());
        }

        private void itemProveedores_Click(object sender, EventArgs e)
        {
            CargarFormulario((IconMenuItem)sender, new Proveedores());
        }
    }
}
