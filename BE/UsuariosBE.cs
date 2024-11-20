using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuariosBE
    {
        public  UsuariosBE() { }
        public UsuariosBE(int cod_Usuario)
        {
            Cod_Usuario = cod_Usuario;
        }
        public UsuariosBE(string user_Usuario)
        {
            User_Usuario = user_Usuario;       
        }
        public UsuariosBE(string user_Usuario, string usuario_Pass, string usuario_Cargo)
        {         
            User_Usuario = user_Usuario;
            Usuario_Pass = usuario_Pass;
            Usuario_Cargo = usuario_Cargo;
        }
        public UsuariosBE(string user_Usuario, string usuario_Pass, string usuario_Cargo, string dNI_Usuario, string nombre_Usuario, string ape_Usuario, string tel_Usuario, string correo_Usuario)
        {
            User_Usuario = user_Usuario;
            Usuario_Pass = usuario_Pass;
            Usuario_Cargo = usuario_Cargo;
            DNI_Usuario = dNI_Usuario;
            Nombre_Usuario = nombre_Usuario;
            Ape_Usuario = ape_Usuario;
            Tel_Usuario = tel_Usuario;
            Correo_Usuario = correo_Usuario;
        }
        public UsuariosBE(int cod_Usuario, string user_Usuario, string usuario_Pass, string usuario_Cargo, string dNI_Usuario, string nombre_Usuario, string ape_Usuario, string tel_Usuario, string correo_Usuario)
        {
            Cod_Usuario = cod_Usuario;
            User_Usuario = user_Usuario;
            Usuario_Pass = usuario_Pass;
            Usuario_Cargo = usuario_Cargo;
            DNI_Usuario = dNI_Usuario;
            Nombre_Usuario = nombre_Usuario;
            Ape_Usuario = ape_Usuario;
            Tel_Usuario = tel_Usuario;
            Correo_Usuario = correo_Usuario;
        }

        public int Cod_Usuario { get; set; }
        public string User_Usuario { get; set; }
        public string Usuario_Pass { get; set; }
        public string Usuario_Cargo { get; set; }
        public string DNI_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Ape_Usuario { get; set; }
        public string Tel_Usuario { get; set; }
        public string Correo_Usuario { get; set; }
        
    }
}
