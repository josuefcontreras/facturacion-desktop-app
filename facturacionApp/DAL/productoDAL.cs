using facturacionApp.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace facturacionApp.DAL
{
    class productoDAL
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
                                PRODUCTO.codigo_producto as 'codigo',
                                PRODUCTO.nombre as 'Producto',
                                PRODUCTO.descripcion,
                                TIPO_PRODUCTO.descripcion as Categoria,
                                PRODUCTO.existencia,
                                PRODUCTO.precio,
                                PRODUCTO.costo
                                FROM PRODUCTO LEFT JOIN TIPO_PRODUCTO
                                    ON PRODUCTO.tipo_producto = TIPO_PRODUCTO.codigo_tipo_producto
                                ORDER BY PRODUCTO.codigo_producto ASC";
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
        public bool Insert(productoBLL producto)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {
                // SQL Query to get data from database
                string sql = "INSERT INTO PRODUCTO (nombre, descripcion, precio, costo, existencia, tipo_producto) VALUES (@nombre, @descripcion, @precio, @costo, @existencia, @tipo_producto)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", producto.nombre);
                command.Parameters.AddWithValue("@descripcion", producto.descripcion);
                command.Parameters.AddWithValue("@precio", producto.precio);
                command.Parameters.AddWithValue("@costo", producto.costo);
                command.Parameters.AddWithValue("@existencia", producto.existencia);
                command.Parameters.AddWithValue("@tipo_producto", producto.tipo_producto);

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
        public bool Update(Dictionary<string, object> producto)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE PRODUCTO SET nombre=@nombre, descripcion=@descripcion, precio=@precio, costo=@costo, existencia=@existencia, tipo_producto=@tipo_producto WHERE codigo_producto=@codigo_producto";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", producto["nombre"]);
                command.Parameters.AddWithValue("@descripcion", producto["descripcion"]);
                command.Parameters.AddWithValue("@precio", producto["precio"]);
                command.Parameters.AddWithValue("@costo", producto["costo"]);
                command.Parameters.AddWithValue("@existencia", producto["existencia"]);
                command.Parameters.AddWithValue("@tipo_producto", producto["tipo_producto"]);
                command.Parameters.AddWithValue("@codigo_producto", producto["codigo_producto"]);
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

        #region Update product existencia
        public bool UpdateExistencia(int codigo_producto, int nuevaExistencia)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE PRODUCTO SET existencia=@nuevaExistencia WHERE codigo_producto=@codigo_producto";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nuevaExistencia", nuevaExistencia);
                command.Parameters.AddWithValue("@codigo_producto", codigo_producto);
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
        public bool Delete(productoBLL producto)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM PRODUCTO WHERE codigo_producto = @codigo_producto ";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigo_producto", producto.codigo_producto);
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

        #region Search productos in database 
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
                                PRODUCTO.codigo_producto as 'codigo',
                                PRODUCTO.nombre as 'Producto',
                                PRODUCTO.descripcion,
                                TIPO_PRODUCTO.descripcion as Categoria,
                                PRODUCTO.existencia,
                                PRODUCTO.precio,
                                PRODUCTO.costo
                                FROM PRODUCTO LEFT JOIN TIPO_PRODUCTO
                                    ON PRODUCTO.tipo_producto = TIPO_PRODUCTO.codigo_tipo_producto
                                WHERE PRODUCTO.nombre LIKE @q OR PRODUCTO.descripcion LIKE @q
                                ORDER BY PRODUCTO.codigo_producto ASC";
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

        #region Search producto in database by product id 
        public DataTable SearchByCodigo(String q)
        {
            //static method to connect data
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to get data from database
                string sql = "SELECT * FROM PRODUCTO WHERE codigo_producto = '" + q + "' ";
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

    }
}

