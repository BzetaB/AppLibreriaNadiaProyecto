using BD;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BL
{
    public class MermaBL
    {
        public MermaBL() { }

        public DataTable MostrarMerma()
        {
            DataTable daatable = new DataTable();
            string sql = "select * from VistaMerma";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,Conexion.SQLServer());
            adapter.Fill(daatable);
            return daatable;
        }

        public int Insert(UsuariosBE usuariosBE, ProductosBE productosBE,MermaBE mermaBE)
        {
            int resultado = -1;
            SqlConnection conec = new SqlConnection(Conexion.SQLServer());
            try
            {
                conec.Open();
                SqlTransaction transaction = conec.BeginTransaction();
                try
                {
                    SqlCommand sqlcmd = new SqlCommand("RegistrarMerma", conec,transaction);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Cod_Usuario", usuariosBE.Cod_Usuario);
                    sqlcmd.Parameters.AddWithValue("@Cod_Producto", productosBE.Cod_Producto);
                    sqlcmd.Parameters.AddWithValue("@Fecha_Salida", mermaBE.Fecha_Salida);
                    sqlcmd.Parameters.AddWithValue("@Descripcion", mermaBE.Descripcion_Salida);
                    sqlcmd.Parameters.AddWithValue("@CantidadMerma", mermaBE.Cantidad);

                    SqlParameter returnParameter = sqlcmd.Parameters.Add("RetVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    sqlcmd.ExecuteNonQuery();
                    transaction.Commit();

                    resultado = (int)returnParameter.Value;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conec.State == ConnectionState.Open)
                    conec.Close();
            }
            return resultado;
        }
    }
}
