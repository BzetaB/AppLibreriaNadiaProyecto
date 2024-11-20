using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BD
{
    public class Conexion
    {
        public static string SQLServer()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ZEVALLOS";
            builder.InitialCatalog = "BDLIBRERIA";
            builder.IntegratedSecurity = true;
            return builder.ToString();
        }
    }
}
