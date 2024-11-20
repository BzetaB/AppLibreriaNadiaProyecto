using BD;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BL
{
    public class ProductosBL
    {
        public ProductosBL() { }
        
        public string NombreProducto(int codigo)
        {
            using(SqlConnection conec = new SqlConnection(Conexion.SQLServer()))
            {
                conec.Open();
                string sql = "select Nombre_Producto from TB_Producto where Cod_Producto = @codigo";
                SqlCommand sqlcmd = new SqlCommand(sql, conec);
                sqlcmd.Parameters.AddWithValue("@codigo",codigo);
                SqlDataReader sqlDataReader = sqlcmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    return sqlDataReader.GetString(0);
                }
                sqlcmd.ExecuteNonQuery();
                conec.Close();
                return "no encontrado";
            }
        }
        public DataTable MostrarProductos()
        {
            DataTable dataTable = new DataTable();
            string SQL = "select * from VistaProductosConCategorias";
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Conexion.SQLServer());
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable MostrarVencimiento()
        {
            DataTable dataTable = new DataTable();
            string SQL = "select * from ProductosProximosAVencer";
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Conexion.SQLServer());
            adapter.Fill(dataTable);
            return dataTable;
        }

        public List<ProductosBE> Marcas(string nombreProduc)
        {
            List<ProductosBE> list = new List<ProductosBE>();

            using (SqlConnection sqlConnection = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConnection.Open();
                string sql = "Select MARCA from VistaProductosConCategorias where [NOMBRE DE PRODUCTO] like @nombreProduc + '%'";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.Parameters.AddWithValue("@nombreProduc", nombreProduc);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0)) // Verifica si el valor en la columna no es nulo
                    {
                        ProductosBE productosBE = new ProductosBE();
                        productosBE.Marca_produc = sqlDataReader.GetString(0);
                        list.Add(productosBE);
                    }
                }
                sqlConnection.Close();
            }
            return list;
        }
        public DataTable BuscarProducMarca(string producto, string marca)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConnection.Open();

                string SQL = "select * from VistaProductosConCategorias where [NOMBRE DE PRODUCTO] like @nombreProduc + '%' and MARCA = @marcaProduc";
                SqlCommand command = new SqlCommand(SQL, sqlConnection);
                command.Parameters.AddWithValue("@nombreProduc", producto);
                command.Parameters.AddWithValue("@marcaProduc", marca);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable ConsultaProducs(string nombreProduc)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();

                string SQL = "select * from VistaProductosConCategorias where [NOMBRE DE PRODUCTO] like @nombreProduc + '%' ";
                SqlCommand command = new SqlCommand(SQL, SqlConn);
                command.Parameters.AddWithValue("@nombreProduc", nombreProduc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                SqlConn.Close();
            }
            return dataTable;
        }

        public DataTable ConsultarProductoCategoria(string categoria)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(Conexion.SQLServer()))
            {
                connection.Open();

                string SQL = "select * from VistaProductosConCategorias where CATEGORIA = @categoria";
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.AddWithValue("@categoria", categoria);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();
            }
            return dataTable;
        }

        public DataTable ConsulProducCodigo(string cod)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Conexion.SQLServer()))
            {
                connection.Open();

                string SQL = "select * from VistaProductosConCategorias where CODIGO = @cod_producto";
                SqlCommand sqlcomand = new SqlCommand(SQL, connection);
                sqlcomand.Parameters.AddWithValue("@cod_producto", cod);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcomand);
                adapter.Fill(dataTable);

                connection.Close();
            }
            return dataTable;
        }

        public DataTable ConsularPorCategoriayNombre(string nombre,string categoria)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Conexion.SQLServer()))
            {
                connection.Open();

                string SQL = "select * from VistaProductosConCategorias where CATEGORIA = @categoria and [NOMBRE DE PRODUCTO] like @nombreProduc+ '%' ";
                SqlCommand sqlcomand = new SqlCommand(SQL, connection);
                sqlcomand.Parameters.AddWithValue("@Nombre_Categoria", categoria);
                sqlcomand.Parameters.AddWithValue("@Nombre_Producto", nombre);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcomand);
                adapter.Fill(dataTable);

                connection.Close();
            }
            return dataTable;
        }

        public ProductosBE BuscarProducto(int cod)
        {
            ProductosBE productosBE = null;
            using(SqlConnection connection = new SqlConnection(Conexion.SQLServer()))
            {
                connection.Open();

                string sql = "select * from  TB_Producto where Cod_Producto = @codigo";
                SqlCommand sqlcmd = new SqlCommand(sql,connection);

                sqlcmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader sqlDataReader = sqlcmd.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    productosBE = new ProductosBE();

                    productosBE.Cod_Producto = sqlDataReader.IsDBNull(0) ? 0 : sqlDataReader.GetInt32(0);
                    productosBE.Nombre_Producto = sqlDataReader.IsDBNull(2) ? string.Empty : sqlDataReader.GetString(2);
                    productosBE.Precio_Unit_Produc = sqlDataReader.IsDBNull(3) ? 0 : sqlDataReader.GetDecimal(3);
                    productosBE.Stock_Producto = sqlDataReader.IsDBNull(4) ? 0 : sqlDataReader.GetInt32(4);
                    productosBE.Marca_produc = sqlDataReader.IsDBNull(5) ? string.Empty : sqlDataReader.GetString(5);
                    productosBE.Unid_Produc = sqlDataReader.IsDBNull(6) ? 0 : sqlDataReader.GetInt32(6);
                    productosBE.Color_Produc = sqlDataReader.IsDBNull(7) ? string.Empty : sqlDataReader.GetString(7);
                    productosBE.Perecible_produc = sqlDataReader.IsDBNull(8) ? false : sqlDataReader.GetBoolean(8);
                    productosBE.Fecha_Venci_Produc = sqlDataReader.IsDBNull(9) ? DateTime.MinValue : sqlDataReader.GetDateTime(9);
                    productosBE.Tamanio_produc = sqlDataReader.IsDBNull(10) ? string.Empty : sqlDataReader.GetString(10);
                    productosBE.Detalles_produc = sqlDataReader.IsDBNull(11) ? string.Empty : sqlDataReader.GetString(11);
                }
                connection.Close();

            }
            return productosBE;
        }

        public void InsertarProducto(ProductosBE productosBE, CategoriaBE categoriaBE)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.SQLServer()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("InsertarProducto", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@NombreCategoria", categoriaBE.Nombre_Categoria);
                    sqlCommand.Parameters.AddWithValue("@NombreProducto", productosBE.Nombre_Producto);
                    sqlCommand.Parameters.AddWithValue("@PrecioUnitario", productosBE.Precio_Unit_Produc);
                    sqlCommand.Parameters.AddWithValue("@Marca", productosBE.Marca_produc);
                    sqlCommand.Parameters.AddWithValue("@Unidad", productosBE.Unid_Produc);
                    sqlCommand.Parameters.AddWithValue("@Color", productosBE.Color_Produc);
                    sqlCommand.Parameters.AddWithValue("@Perecible", productosBE.Perecible_produc);
                    sqlCommand.Parameters.AddWithValue("@FechaVencimiento", productosBE.Fecha_Venci_Produc);
                    sqlCommand.Parameters.AddWithValue("@Tamanio", productosBE.Tamanio_produc);
                    sqlCommand.Parameters.AddWithValue("@Detalles", productosBE.Detalles_produc);

                    transaction.Commit();

                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    transaction.Rollback();
                }
                connection.Close();
            }
        }

        public void Update(ProductosBE productosBE)
        {
            using (SqlConnection SqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                SqlConn.Open();
                //SQL INSERT
                string SQL = "update TB_Producto set " +
                             "Cod_Categorias = @Categorias, " +
                             "Nombre_Producto = @Nombre, " +
                             "Precio_Unit_Produc = @precio, " +
                             "Marca_produc = @marca, " +
                             "Unid_Produc = @unid," +
                             "Color_Produc = @Color_Produc, "+
                             "Perecible_produc = @Perecible, "+
                             "Fecha_Venci_Produc = @Vencimiento, "+ 
                             "Tamanio_produc = @tamanio, " +
                             "Detalles_produc = @detalles " +
                             "where Cod_Producto = @codigo";


                SqlCommand SqlCmd = new SqlCommand(SQL, SqlConn);

                //LOAD PARAMETERS
                SqlCmd.Parameters.AddWithValue("@Categorias", productosBE.Cod_Categorias);
                SqlCmd.Parameters.AddWithValue("@Nombre", productosBE.Nombre_Producto);
                SqlCmd.Parameters.AddWithValue("@precio", productosBE.Precio_Unit_Produc);
                SqlCmd.Parameters.AddWithValue("@marca", productosBE.Marca_produc);
                SqlCmd.Parameters.AddWithValue("@unid", productosBE.Unid_Produc);
                SqlCmd.Parameters.AddWithValue("@Color_Produc", productosBE.Color_Produc);
                SqlCmd.Parameters.AddWithValue("@perecible", productosBE.Perecible_produc);
                SqlCmd.Parameters.AddWithValue("@Vencimiento", productosBE.Fecha_Venci_Produc);
                SqlCmd.Parameters.AddWithValue("@tamanio", productosBE.Tamanio_produc);
                SqlCmd.Parameters.AddWithValue("@detalles", productosBE.Detalles_produc);
                SqlCmd.Parameters.AddWithValue("@codigo", productosBE.Cod_Producto);

                //EXECUTE
                SqlCmd.ExecuteNonQuery();
                SqlConn.Close();
            }
        }

    }
}

