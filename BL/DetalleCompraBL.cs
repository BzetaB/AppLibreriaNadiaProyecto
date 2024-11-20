using BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DetalleCompraBL
    {
        public DetalleCompraBL() { }

        public DataTable VistaDetalleCompra()
        {
            DataTable daatable = new DataTable();
            string sql = "select * from VistaDetalleCompra";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conexion.SQLServer());
            adapter.Fill(daatable);
            return daatable;
        }
    }
}
