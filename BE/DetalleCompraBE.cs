using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleCompraBE
    {
        public DetalleCompraBE() { }

        public DetalleCompraBE(int cod_Producto, int cod_Compra, decimal precio_Det_Compra, int cantidad_Det_Compra, decimal subTotal_Det_Compra, decimal precio_Venta_Producto)
        {
            Cod_Producto = cod_Producto;
            Cod_Compra = cod_Compra;
            Precio_Det_Compra = precio_Det_Compra;
            Cantidad_Det_Compra = cantidad_Det_Compra;
            SubTotal_Det_Compra = subTotal_Det_Compra;
            Precio_Venta_Producto = precio_Venta_Producto;
        }

        public int Cod_Producto { get; set; }
        public int Cod_Compra { get; set; }
        public decimal Precio_Det_Compra { get; set; }
        public int Cantidad_Det_Compra { get; set; }
        public decimal SubTotal_Det_Compra { get; set; }
        public decimal Precio_Venta_Producto { get; set; }
    }
}
