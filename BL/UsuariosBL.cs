using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using BE;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace BL
{
    public class UsuariosBL
    {
        public UsuariosBL() { }

        SqlConnection conec = new SqlConnection(Conexion.SQLServer());

        public int CargarCodigo(UsuariosBE usuarios)
        {
            using(SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    conexion.Open();
                    string sql = "select Cod_Usuario from TB_Usuario where User_Usuario = @usuarioUser";
                    SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                    sqlcmd.Parameters.AddWithValue("@usuarioUser", usuarios.User_Usuario);
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
                return -1;
            }
        }
        public int Logeo(UsuariosBE usuariosBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("ProceLogeo", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@usuario", usuariosBE.User_Usuario);
                    sqlCommand.Parameters.AddWithValue("@contraseña", usuariosBE.Usuario_Pass);
                    sqlCommand.Parameters.AddWithValue("@cargo", usuariosBE.Usuario_Cargo);

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        return dataReader.GetInt32(0);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }
                return -1;
            }
        }
        public DataTable MostrarUsuariosCargo(string cargo)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from Usuarios where CARGO=@cargo";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@cargo", cargo);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }

        public DataTable MostrarUsuarios()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from Usuarios";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, Conexion.SQLServer());
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable BuscarNombreyCargo(string nombre, string cargo)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from Usuarios where USUARIO=@NombreUsuario and CARGO=@cargo";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@NombreUsuario", nombre);
                sqlcmd.Parameters.AddWithValue("@cargo", cargo);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }
        public DataTable BuscarPorNombre(string nombre)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from Usuarios where NOMBRES=@NombreUsuario";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@NombreUsuario",nombre);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }

        public DataTable BuscarPorCodigo(int codigo)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection conexion = new SqlConnection(Conexion.SQLServer()))
            {
                conexion.Open();
                string sql = "select * from Usuarios where CÓDIGO=@Codigo";
                SqlCommand sqlcmd = new SqlCommand(sql, conexion);
                sqlcmd.Parameters.AddWithValue("@Codigo", codigo);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dataTable);
                conexion.Close();
            }
            return dataTable;
        }

        public DataTable BuscarPorCodigoNombreOCargo(int codigo, string nombre, string cargo)
        {
            DataTable datatable = new DataTable();
            using(SqlConnection connection = conec)
            {
                connection.Open();
                string sql = "";
                if(codigo != 0 && nombre == null && cargo == null)
                {
                    sql = "select * from Usuarios where CÓDIGO=@Codigo";
                }else if(codigo == 0 && (nombre !=null && cargo !=null))
                {
                    sql = "select * from Usuarios where USUARIO=@NombreUsuario and CARGO=@cargo";
                }else if(codigo == 0 && nombre != null && cargo == null)
                {
                    sql = "select * from Usuarios where USUARIO=@NombreUsuario";
                }

                SqlCommand sqlcmd = new SqlCommand(sql, connection);
                sqlcmd.Parameters.AddWithValue("@Codigo", codigo);
                sqlcmd.Parameters.AddWithValue("@NombreUsuario", nombre);
                sqlcmd.Parameters.AddWithValue("@cargo", cargo);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(datatable);
                connection.Close();
            }
            return datatable;
        }        




        public void Insert(UsuariosBE usuariosBE)
        {
            //conexión DB
            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                SqlTransaction transaction = SqlConn.BeginTransaction();
                try
                {

                    //SQL INSERT
                    string SQL = "insert into TB_Usuario " +
                                 "values(@Usuario,@Contrasena,@Cargo,@Dni,@Nombre, @Apellido, @Telefono, @Correo)";


                    SqlCommand SqlCmd = new SqlCommand(SQL, SqlConn,transaction);

                    //LOAD PARAMETERS
                    SqlCmd.Parameters.AddWithValue("@Usuario", usuariosBE.User_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Contrasena", usuariosBE.Usuario_Pass);
                    SqlCmd.Parameters.AddWithValue("@Cargo", usuariosBE.Usuario_Cargo);
                    SqlCmd.Parameters.AddWithValue("@Dni", usuariosBE.DNI_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Nombre", usuariosBE.Nombre_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Apellido", usuariosBE.Ape_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Telefono", usuariosBE.Tel_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Correo", usuariosBE.Correo_Usuario);

                    //EXECUTE
                    SqlCmd.ExecuteNonQuery();
                    transaction.Commit();
                } catch {
                    transaction.Rollback();
                }

                SqlConn.Close();
            }
        }

        public void Actualizar(UsuariosBE usuariosBE)
        {
            using (SqlConnection sqlconec = new SqlConnection(Conexion.SQLServer()))
            {
                sqlconec.Open();

                    string SQL = "update TB_Usuario set " +
                              "User_Usuario=@Usuario, " +
                              "Usuario_Pass=@Contrasenia, " +
                              "Usuario_Cargo=@Cargo, " +
                              "DNI_Usuario=@DNI, " +
                              "Nombre_Usuario=@Nombre," +
                              "Ape_Usuario=@Apellido," +
                              "Tel_Usuario=@Telefono," +
                              "Correo_Usuario=@Correo " +
                              "where Cod_Usuario=@Codigo";

                    SqlCommand SqlCmd = new SqlCommand(SQL, sqlconec);

                    SqlCmd.Parameters.AddWithValue("@Usuario", usuariosBE.User_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Contrasenia", usuariosBE.Usuario_Pass);
                    SqlCmd.Parameters.AddWithValue("@Cargo", usuariosBE.Usuario_Cargo);
                    SqlCmd.Parameters.AddWithValue("@DNI", usuariosBE.DNI_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Nombre", usuariosBE.Nombre_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Apellido", usuariosBE.Ape_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Telefono", usuariosBE.Tel_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Correo", usuariosBE.Correo_Usuario);
                    SqlCmd.Parameters.AddWithValue("@Codigo", usuariosBE.Cod_Usuario);

                    //EXECUTE
                    SqlCmd.ExecuteNonQuery();

                sqlconec.Close();
            }
        } 

        public UsuariosBE BuscarUsuario(int codigoUsuario)
        {
            UsuariosBE usuariosBE = null;
            using(SqlConnection cone = new SqlConnection(Conexion.SQLServer()))
            {
                cone.Open();

                    string SQL = "select * from TB_Usuario where Cod_Usuario = @codigo";
                    SqlCommand sqlCommand = new SqlCommand(SQL, cone);

                    sqlCommand.Parameters.AddWithValue("@codigo", codigoUsuario);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        usuariosBE = new UsuariosBE();

                        usuariosBE.Cod_Usuario = sqlDataReader.GetInt32(0);
                        usuariosBE.User_Usuario = sqlDataReader.GetString(1);
                        usuariosBE.Usuario_Pass = sqlDataReader.IsDBNull(2) ? string.Empty : sqlDataReader.GetString(2);
                        usuariosBE.Usuario_Cargo = sqlDataReader.IsDBNull(3) ? string.Empty : sqlDataReader.GetString(3);
                        usuariosBE.DNI_Usuario = sqlDataReader.IsDBNull(4) ? string.Empty : sqlDataReader.GetString(4);
                        usuariosBE.Nombre_Usuario = sqlDataReader.IsDBNull(5) ? string.Empty : sqlDataReader.GetString(5);
                        usuariosBE.Ape_Usuario = sqlDataReader.IsDBNull(6) ? string.Empty : sqlDataReader.GetString(6);
                        usuariosBE.Tel_Usuario = sqlDataReader.IsDBNull(7) ? string.Empty : sqlDataReader.GetString(7);
                        usuariosBE.Correo_Usuario = sqlDataReader.IsDBNull(8) ? string.Empty : sqlDataReader.GetString(8);

                    }
                
                cone.Close();
            }
            return usuariosBE;
        }

    }
}
