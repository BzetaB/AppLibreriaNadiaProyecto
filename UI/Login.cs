using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;

namespace UI
{
    public partial class Login : Form
    {
        private UsuariosBL usuariosBL = new UsuariosBL();
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cargo = comboCargo.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            UsuariosBE usuariosBE = new UsuariosBE(usuario,contraseña,cargo);
            
            int resultado = usuariosBL.Logeo(usuariosBE);
            int codigo = usuariosBL.CargarCodigo(usuariosBE);

            if (resultado == 1)
            {
                if(usuariosBE.Usuario_Cargo == "ADMINISTRADOR")
                {                   
                    Menu menu = new Menu(usuariosBE,codigo);
                    //MenuAdmin menuAdmin = new MenuAdmin();
                    //menuAdmin.Show();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    Menu menu = new Menu(usuariosBE,codigo);
                    menu.Show();
                    this.Hide();
                    //MenuEmpleado menuEmpleado = new MenuEmpleado();
                    //menuEmpleado.Show();
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente con otro usuario.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
