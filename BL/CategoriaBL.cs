using BD;
using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoriaBL
    {
        public CategoriaBL() { }

        public List<CategoriaBE> MuestraCategorias()
        {
            List<CategoriaBE> list = new List<CategoriaBE>();

            //conexión DB
            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                string SQL = "select Nombre_Categoria from TB_Categoria";

                SqlCommand SqlCmd = new SqlCommand(SQL, SqlConn);
                SqlDataReader SqlDR = SqlCmd.ExecuteReader();
                while (SqlDR.Read())
                {
                    CategoriaBE categoriaBE = new CategoriaBE();
                    categoriaBE.Nombre_Categoria = SqlDR.GetString(0);
                    list.Add(categoriaBE);
                }
                SqlConn.Close();
            }
            return list;
        }

        public int CodigoCat(string codigo)
        {

            int codigoCat = 0;

            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                string sql = "select Cod_Categorias from TB_Categoria where Nombre_Categoria = @categoria";

                SqlCommand SqlCmd = new SqlCommand(sql, SqlConn);
                SqlCmd.Parameters.AddWithValue("categoria", codigo);

                object result = SqlCmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    codigoCat = Convert.ToInt32(result);
                }
            }

            return codigoCat;


        }
    }
}
