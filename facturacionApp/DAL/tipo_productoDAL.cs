using facturacionApp.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace facturacionApp.DAL
{
    class tipo_productoDAL
    {
        static string myConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        #region Select data from database
        public DataTable Select()
        {
            //static method to connect data
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to get data from database
                string sql = @"SELECT
                                TIPO_PRODUCTO.codigo_tipo_producto,
                                TIPO_PRODUCTO.descripcion
                               FROM TIPO_PRODUCTO ORDER BY codigo_tipo_producto ASC";
                // For executing cmmand
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Getting data from database
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                // Database connection open
                connection.Open();
                // Fill data in our table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Closing database connection
                connection.Close();
            }
            // Return the value in DataTable
            return dt;
        }
        #endregion

        #region Insert data in database
        public bool Insert(tipo_productoBLL tipo_producto)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {
                // SQL Query to get data from database
                string sql = "INSERT INTO TIPO_PRODUCTO (descripcion) VALUES (@descripcion)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@descripcion", tipo_producto.descripcion);
                connection.Open();

                int rows = command.ExecuteNonQuery();

                // if query is executerd, the value of rows > 0 
                if (rows > 0)
                {
                    //Query successful
                    isSuccess = true;
                }
                else
                {
                    //Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }

        #endregion

        #region Update data in database
        public bool Update(Dictionary<string, object> tipoProductoData)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE TIPO_PRODUCTO SET descripcion=@descripcion WHERE codigo_tipo_producto=@codigo_tipo_producto";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@descripcion", tipoProductoData["descripcion"]);
                command.Parameters.AddWithValue("@codigo_tipo_producto", tipoProductoData["codigo_tipo_producto"]);
                connection.Open();

                int rows = command.ExecuteNonQuery();


                // if query is executerd, the value of rows > 0 
                if (rows > 0)
                {
                    //Query successful
                    isSuccess = true;
                }
                else
                {
                    //Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Delete data from database
        public bool Delete(tipo_productoBLL tipo_producto)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM TIPO_PRODUCTO WHERE codigo_tipo_producto = @codigo_tipo_producto";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigo_tipo_producto", tipo_producto.codigo_tipo_producto);
                connection.Open();
                int rows = command.ExecuteNonQuery();
                
                // if query is executerd, the value of rows > 0 
                if (rows > 0)
                {
                    //Query successful
                    isSuccess = true;
                }
                else
                {
                    //Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Search tipo_producto in database 
        public DataTable Search(String q)
        {
            //static method to connect data
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to get data from database
                string sql = @"SELECT
                                TIPO_PRODUCTO.codigo_tipo_producto,
                                TIPO_PRODUCTO.descripcion
                              FROM TIPO_PRODUCTO WHERE TIPO_PRODUCTO.descripcion LIKE @q";
                // For executing cmmand
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@q", $"%{q}%");
                // Getting data from database
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                // Database connection open
                connection.Open();
                // Fill data in our table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Closing database connection
                connection.Close();
            }
            // Return the value in DataTable
            return dt;
        }
        #endregion

    }
}
