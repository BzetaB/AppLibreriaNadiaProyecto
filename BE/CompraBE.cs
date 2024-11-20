using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CompraBE
    {
        public CompraBE() { }

        public CompraBE(int cod_Compra, int cod_Usuario, int cod_Proveedor, bool tipo_comprobante_compra, DateTime fecha_Compra, decimal iGV_compra, decimal monto_Total, string descripcion_compra)
        {
            Cod_Compra = cod_Compra;
            Cod_Usuario = cod_Usuario;
            Cod_Proveedor = cod_Proveedor;
            Tipo_comprobante_compra = tipo_comprobante_compra;
            Fecha_Compra = fecha_Compra;
            IGV_compra = iGV_compra;
            Monto_Total = monto_Total;
            Descripcion_Compra = descripcion_compra;
        }

        public int Cod_Compra { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Proveedor { get; set; }
        public bool Tipo_comprobante_compra { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public decimal IGV_compra { get; set; }
        public decimal Monto_Total { get; set; }
        public string Descripcion_Compra { get; set; }
    }
}
