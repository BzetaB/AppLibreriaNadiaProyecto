using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class ConnectionTest
    {
        public static void Main(string[] david)
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConn.Open();
                    Console.WriteLine("¡Conexión base de datos Biblioteca... OK!");
                    sqlConn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("¡Error, como todo lo que haces!");
                    Console.WriteLine(ex.ToString());
                }

                Console.ReadLine();
            }
        }
    }
}
