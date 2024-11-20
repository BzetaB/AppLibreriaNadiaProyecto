using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class MermaBE
    {
        public MermaBE() { }

        public MermaBE(DateTime fecha_Salida,string descripcion_Salida,int cantidad)
        {
            Fecha_Salida = fecha_Salida;
            Descripcion_Salida = descripcion_Salida;
            Cantidad = cantidad;
        }

        public MermaBE(int cod_Salida_producto, int cod_Usuario, int cod_Producto, DateTime fecha_Salida, string descripcion_Salida, int cantidad)
        {
            Cod_Salida_producto = cod_Salida_producto;
            Cod_Usuario = cod_Usuario;
            Cod_Producto = cod_Producto;
            Fecha_Salida = fecha_Salida;
            Descripcion_Salida = descripcion_Salida;
            Cantidad = cantidad;
        }

        public int Cod_Salida_producto { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Producto { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public string Descripcion_Salida { get; set; }
        public int Cantidad { get; set; }
    }
}
