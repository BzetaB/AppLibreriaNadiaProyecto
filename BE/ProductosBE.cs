using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductosBE
    {
        public ProductosBE() { }

        public ProductosBE(int cod_Producto)
        {
            Cod_Producto = cod_Producto;
        }
        public ProductosBE(string nombre_Producto)
        {
            Nombre_Producto = nombre_Producto;
        }
        public ProductosBE(string nombre_Producto, string marca_produc, int unid_Produc, string color_Produc, bool perecible_produc, DateTime fecha_Venci_Produc, string tamanio_produc, string detalles_produc)
        {
            Nombre_Producto = nombre_Producto;
            Marca_produc = marca_produc;
            Unid_Produc = unid_Produc;
            Color_Produc = color_Produc;
            Perecible_produc = perecible_produc;
            Fecha_Venci_Produc = fecha_Venci_Produc;
            Tamanio_produc = tamanio_produc;
            Detalles_produc = detalles_produc;
        }
        public ProductosBE(string nombre_Producto, decimal precio_Unit_Produc, int stock_Producto, string marca_produc, int unid_Produc, string color_Produc, bool perecible_produc, DateTime fecha_Venci_Produc, string tamanio_produc, int cantidad_produc, string detalles_produc)
        {
            Nombre_Producto = nombre_Producto;
            Precio_Unit_Produc = precio_Unit_Produc;
            Stock_Producto = stock_Producto;
            Marca_produc = marca_produc;
            Unid_Produc = unid_Produc;
            Color_Produc = color_Produc;
            Perecible_produc = perecible_produc;
            Fecha_Venci_Produc = fecha_Venci_Produc;
            Tamanio_produc = tamanio_produc;
            Cantidad_produc = cantidad_produc;
            Detalles_produc = detalles_produc;
        }
        public ProductosBE(int cod_Producto, int cod_Categorias, string nombre_Producto, decimal precio_Unit_Produc, string marca_produc, int unid_Produc, string color_Produc, bool perecible_produc, DateTime fecha_Venci_Produc, string tamanio_produc, string detalles_produc)
        {
            Cod_Producto = cod_Producto;
            Cod_Categorias = cod_Categorias;
            Nombre_Producto = nombre_Producto;
            Precio_Unit_Produc = precio_Unit_Produc;
            Marca_produc = marca_produc;
            Unid_Produc = unid_Produc;
            Color_Produc = color_Produc;
            Perecible_produc = perecible_produc;
            Fecha_Venci_Produc = fecha_Venci_Produc;
            Tamanio_produc = tamanio_produc;
            Detalles_produc = detalles_produc;
        }
        public ProductosBE(int cod_Producto, int cod_Categorias, string nombre_Producto, decimal precio_Unit_Produc, int stock_Producto, string marca_produc, int unid_Produc, string color_Produc, bool perecible_produc, DateTime fecha_Venci_Produc, string tamanio_produc, int cantidad_produc, string detalles_produc)
        {
            Cod_Producto = cod_Producto;
            Cod_Categorias = cod_Categorias;
            Nombre_Producto = nombre_Producto;
            Precio_Unit_Produc = precio_Unit_Produc;
            Stock_Producto = stock_Producto;
            Marca_produc = marca_produc;
            Unid_Produc = unid_Produc;
            Color_Produc = color_Produc;
            Perecible_produc = perecible_produc;
            Fecha_Venci_Produc = fecha_Venci_Produc;
            Tamanio_produc = tamanio_produc;
            Cantidad_produc = cantidad_produc;
            Detalles_produc = detalles_produc;
        }

        public int Cod_Producto { get; set; }
        public int Cod_Categorias { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Unit_Produc { get; set; }
        public int Stock_Producto { get; set; }
        public string Marca_produc { get; set; }
        public int Unid_Produc { get; set; }
        public string Color_Produc { get; set; }
        public bool Perecible_produc { get; set; }
        public DateTime Fecha_Venci_Produc { get; set; }
        public string Tamanio_produc { get; set; }
        public int Cantidad_produc { get; set; }
        public string Detalles_produc { get; set; }
    }
}
