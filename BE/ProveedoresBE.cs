using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProveedoresBE
    {
        public ProveedoresBE() { }

        public ProveedoresBE(int cod_Proveedor)
        {
            Cod_Proveedor = cod_Proveedor;
        }

        public ProveedoresBE( string nombre_Proveedor, string direccion_Proveedor, string telf_provedor, string correo_Provedor, string rUC)
        {
            Nombre_Proveedor = nombre_Proveedor;
            Direccion_Proveedor = direccion_Proveedor;
            Telf_provedor = telf_provedor;
            Correo_Provedor = correo_Provedor;
            RUC = rUC;
        }
        public ProveedoresBE(int cod_Proveedor, string nombre_Proveedor, string direccion_Proveedor, string telf_provedor, string correo_Provedor, string rUC)
        {
            Cod_Proveedor = cod_Proveedor;
            Nombre_Proveedor = nombre_Proveedor;
            Direccion_Proveedor = direccion_Proveedor;
            Telf_provedor = telf_provedor;
            Correo_Provedor = correo_Provedor;
            RUC = rUC;
        }

        public int Cod_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Direccion_Proveedor { get; set; }
        public string Telf_provedor { get; set; }
        public string Correo_Provedor { get; set; }
        public string RUC { get; set; }

    }
}
