using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BD;
using System.Data.SqlClient;
using System.Data;
namespace BL
{
    public class ProveedoresBL
    {
        public ProveedoresBL() { }

        public DataTable MostrarProveedores()
        {
            DataTable daatable = new DataTable();
            string sql = "select * from ProveedoresTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conexion.SQLServer());
            adapter.Fill(daatable);
            return daatable;
        }

        public DataTable VistaProvedoresCompra()
        {
            DataTable daatable = new DataTable();
            string sql = "select * from VistaProvedoresCompra";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conexion.SQLServer());
            adapter.Fill(daatable);
            return daatable;
        }

        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from ProveedoresTabla where NOMBRE like @NombreProveedor + '%'";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@NombreProveedor", nombre);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }
        public DataTable BuscarPorRUC(string ruc)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from ProveedoresTabla where RUC=@RUC";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@RUC", ruc);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }


        public ProveedoresBE BuscarProveedor(int codigoProvedor)
        {
            ProveedoresBE proveedoresBE = null;
            using (SqlConnection cone = new SqlConnection(Conexion.SQLServer()))
            {
                cone.Open();

                string SQL = "select * from TB_PROVEEDOR where Cod_Proveedor = @codigoProvedor";
                SqlCommand sqlCommand = new SqlCommand(SQL, cone);

                sqlCommand.Parameters.AddWithValue("@codigoProvedor", codigoProvedor);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    proveedoresBE = new ProveedoresBE();

                    proveedoresBE.Cod_Proveedor = sqlDataReader.GetInt32(0);
                    proveedoresBE.Nombre_Proveedor = sqlDataReader.IsDBNull(1) ? string.Empty: sqlDataReader.GetString(1);
                    proveedoresBE.Direccion_Proveedor = sqlDataReader.IsDBNull(2) ? string.Empty : sqlDataReader.GetString(2);
                    proveedoresBE.Telf_provedor = sqlDataReader.IsDBNull(3) ? string.Empty : sqlDataReader.GetString(3);
                    proveedoresBE.Correo_Provedor = sqlDataReader.IsDBNull(4) ? string.Empty : sqlDataReader.GetString(4);
                    proveedoresBE.RUC = sqlDataReader.IsDBNull(5) ? string.Empty : sqlDataReader.GetString(5);
                   
                }

                cone.Close();
            }
            return proveedoresBE;
        }


        public void Insert(ProveedoresBE proveedoresBE)
        {
            //conexión DB
            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                //SQL INSERT
                    string SQL = "insert into TB_PROVEEDOR " +
                                 "values(@Nombre_Proveedor,@Direccion_Proveedor,@Telf_provedor,@Correo_provedor, @RUC)";


                    SqlCommand SqlCmd = new SqlCommand(SQL, SqlConn);

                    //LOAD PARAMETERS
                    SqlCmd.Parameters.AddWithValue("@Nombre_Proveedor", proveedoresBE.Nombre_Proveedor);
                    SqlCmd.Parameters.AddWithValue("@Direccion_Proveedor", proveedoresBE.Direccion_Proveedor);
                    SqlCmd.Parameters.AddWithValue("@Telf_provedor", proveedoresBE.Telf_provedor);
                    SqlCmd.Parameters.AddWithValue("@Correo_provedor", proveedoresBE.Correo_Provedor);
                    SqlCmd.Parameters.AddWithValue("@RUC", proveedoresBE.RUC);

                    //EXECUTE
                    SqlCmd.ExecuteNonQuery();
                    SqlConn.Close();
            }
        }

        public void Update(ProveedoresBE proveedoresBE)
        {
            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                //SQL INSERT
                string SQL = "update TB_PROVEEDOR set " +
                             "Nombre_Proveedor = @Nombre_Proveedor, "+
                             "Direccion_Proveedor = @Direccion_Proveedor, "+
                             "Telf_provedor = @Telf_provedor, "+
                             "Correo_provedor = @Correo_provedor, "+
                             "RUC = @RUC "+
                             "where Cod_Proveedor = @Cod_Provedor";


                SqlCommand SqlCmd = new SqlCommand(SQL, SqlConn);

                //LOAD PARAMETERS
                SqlCmd.Parameters.AddWithValue("@Nombre_Proveedor", proveedoresBE.Nombre_Proveedor);
                SqlCmd.Parameters.AddWithValue("@Direccion_Proveedor", proveedoresBE.Direccion_Proveedor);
                SqlCmd.Parameters.AddWithValue("@Telf_provedor", proveedoresBE.Telf_provedor);
                SqlCmd.Parameters.AddWithValue("@Correo_provedor", proveedoresBE.Correo_Provedor);
                SqlCmd.Parameters.AddWithValue("@RUC", proveedoresBE.RUC);
                SqlCmd.Parameters.AddWithValue("@Cod_Provedor", proveedoresBE.Cod_Proveedor);

                //EXECUTE
                SqlCmd.ExecuteNonQuery();
                SqlConn.Close();
            }
        }


    }
}
