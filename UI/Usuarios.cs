using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Usuarios : Form
    {
        UsuariosBL usuariosBL = new UsuariosBL();
        int CodUsuario = 0;
        public Usuarios()
        {
            InitializeComponent();
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cargo = comboCargo.Text.ToUpper();
            string nombre = txtNombre.Text.ToUpper();
            string apellido = txtApellido.Text.ToUpper();
            string usuario = txtUsuario.Text.ToUpper();
            string contrasenia = txtContrasenia.Text;
            string contraseniaconfir = txtContraseniaValidada.Text;
            string CONTRASENIAFINAL = null;
            string dni = txtDNI.Text.ToUpper();
            string numero = txtTelefono.Text.ToUpper();
            string correo = txtCorreo.Text.Trim();
            string patroncorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (cargo == "" || nombre == "" || apellido == "" || usuario == "" || contrasenia == "" || contraseniaconfir == "" || dni == "" || numero == "" || correo == "")
            {
                MessageBox.Show("ERROR. COMPLETA TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (contrasenia == contraseniaconfir)
                {
                    CONTRASENIAFINAL = contraseniaconfir;
                    if (!Regex.IsMatch(correo, patroncorreo))
                    {
                        MessageBox.Show("Ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        UsuariosBE usuariosBE = new UsuariosBE(usuario, CONTRASENIAFINAL, cargo, dni, nombre, apellido, numero, correo);
                        usuariosBL.Insert(usuariosBE);
                        MessageBox.Show("¡Usuario Registrado!", "MENSAJE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reiniciar();
                    }

                }
                else
                {
                    MessageBox.Show("ERROR. VERIFICAR CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void reiniciar()
        {
            txtUsuario.Text = null;
            txtContrasenia.Text = null;
            txtContraseniaValidada.Text = null;
            comboCargo.Text = null;
            txtDNI.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtTelefono.Text = null;
            txtCorreo.Text = null;
            txtUsuario.Focus();
            btnModificar.Enabled = false;
            txtBuscar.Text = null;
            radiobutonNombre.Checked = false;
            radioButtonCodigo.Checked = false;
            combocargo2.Text = null;
            btnRegistrar.Enabled = true;
            datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cargo = comboCargo.Text.ToUpper();
            string nombre = txtNombre.Text.ToUpper();
            string apellido = txtApellido.Text.ToUpper();
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            string contraseniaconfir = txtContraseniaValidada.Text;
            string CONTRASENIAFINAL = null;
            string dni = txtDNI.Text.ToUpper();
            string numero = txtTelefono.Text.ToUpper();
            string correo = txtCorreo.Text.Trim();
            string patroncorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (cargo == "" || nombre == "" || apellido == "" || usuario == "" || contrasenia == "" || contraseniaconfir == "" || dni == "" || numero == "" || correo == "")
            {
                MessageBox.Show("ERROR. COMPLETA TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (contrasenia == contraseniaconfir)
                {
                    CONTRASENIAFINAL = contraseniaconfir;
                    if (!Regex.IsMatch(correo, patroncorreo))
                    {
                        MessageBox.Show("Ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        UsuariosBE usuariosBE = new UsuariosBE(CodUsuario, usuario, CONTRASENIAFINAL, cargo, dni, nombre, apellido, numero, correo);
                        usuariosBL.Actualizar(usuariosBE);
                        MessageBox.Show("¡Usuario Actualizado!", "MENSAJE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reiniciar();
                    }

                }
                else
                {
                    MessageBox.Show("ERROR. VERIFICAR CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void datagridviewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo= datagridviewUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            int usuariocod = Convert.ToInt32(codigo);

            UsuariosBE usuariosBE = usuariosBL.BuscarUsuario(usuariocod);
          

            comboCargo.Text = usuariosBE.Usuario_Cargo;
            txtNombre.Text = usuariosBE.Nombre_Usuario;
            txtApellido.Text = usuariosBE.Ape_Usuario;
            txtUsuario.Text = usuariosBE.User_Usuario;
            txtContrasenia.Text = usuariosBE.Usuario_Pass;
            txtContraseniaValidada.Text = usuariosBE.Usuario_Pass;
            txtDNI.Text = usuariosBE.DNI_Usuario;
            txtTelefono.Text = usuariosBE.Tel_Usuario;
            txtCorreo.Text = usuariosBE.Correo_Usuario;

            CodUsuario = usuariosBE.Cod_Usuario;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = true;
            datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscador = txtBuscar.Text;
            string codbuscador = buscador.Trim();
            if (radioButtonCodigo.Checked)
            {
                if (!int.TryParse(codbuscador, out int codigo))
                {
                    MessageBox.Show("Error de ingreso: Por favor, ingrese un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                datagridviewUsuarios.DataSource = usuariosBL.BuscarPorCodigoNombreOCargo(codigo,null,null);
                if (datagridviewUsuarios.Rows.Count == 1)
                {
                    MessageBox.Show("Código no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
                }
            }
            else if(radiobutonNombre.Checked)
            {
                datagridviewUsuarios.DataSource = usuariosBL.BuscarPorCodigoNombreOCargo(0,buscador,null);
                if (datagridviewUsuarios.Rows.Count == 1)
                {
                    MessageBox.Show("Nombre no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
                }
            }
            else if (datagridviewUsuarios.DataSource == usuariosBL.MostrarUsuariosCargo(combocargo2.Text))
            {
                    datagridviewUsuarios.DataSource = usuariosBL.BuscarPorCodigoNombreOCargo(0,buscador, combocargo2.Text);
                    if(datagridviewUsuarios.Rows.Count == 1)
                    {
                        MessageBox.Show("Nombre no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuarios();
                    }
                }
        }

        private void combocargo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combocargo2.Text != null)
            {
                datagridviewUsuarios.DataSource = usuariosBL.MostrarUsuariosCargo(combocargo2.Text);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}
