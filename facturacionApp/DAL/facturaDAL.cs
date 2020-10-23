using facturacionApp.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace facturacionApp.DAL
{
    class facturaDAL
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
                string sql = "SELECT * FROM FACTURA";
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
        public bool Insert(facturaBLL factura, List<factura_productoBLL> productos_agregados)
        {
            bool isSuccess = false;

            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                MySqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Insert new factura in database
                    command.CommandText = "INSERT INTO FACTURA (total_factura, codigo_cliente) VALUES  (@total_factura, @codigo_cliente); SELECT CAST(scope_identity() AS int)";
                    command.Parameters.AddWithValue("@total_factura", factura.total_factura);
                    command.Parameters.AddWithValue("@codigo_cliente", factura.codigo_cliente);
                    int id = (int)command.ExecuteScalar();

                    // Insert productos agregados in database
                    command.CommandText = "INSERT INTO FACTURA_PRODUCTO (codigo_factura, codigo_producto, cantidad, precio_unitario, total) VALUES (@codigo_factura, @codigo_producto, @cantidad, @precio_unitario, @total)";
                    command.Parameters.Add("@codigo_factura", MySqlDbType.Int32);
                    command.Parameters.Add("@codigo_producto", MySqlDbType.Int32);
                    command.Parameters.Add("@cantidad", MySqlDbType.Int32);
                    command.Parameters.Add("@precio_unitario", MySqlDbType.Decimal);
                    command.Parameters.Add("@total", MySqlDbType.Decimal);

                    for (int i = 0; i < productos_agregados.Count; i++)
                    {
                        command.Parameters["@codigo_factura"].Value = id;
                        command.Parameters["@codigo_producto"].Value = productos_agregados[i].codigo_producto;
                        command.Parameters["@cantidad"].Value = productos_agregados[i].cantidad;
                        command.Parameters["@precio_unitario"].Value = productos_agregados[i].precio_unitario;
                        command.Parameters["@total"].Value = productos_agregados[i].total;
                        command.ExecuteNonQuery();
                    }

                    //Update existencia de productos in database
                    command.CommandText = "UPDATE PRODUCTO SET existencia = existencia - @cantidadAgregada WHERE codigo_producto = @codigo_productoAgregado";
                    command.Parameters.Add("@cantidadAgregada", MySqlDbType.Int32);
                    command.Parameters.Add("@codigo_productoAgregado", MySqlDbType.Int32);

                    for (int i = 0; i < productos_agregados.Count; i++)
                    {
                        command.Parameters["@cantidadAgregada"].Value = productos_agregados[i].cantidad;
                        command.Parameters["@codigo_productoAgregado"].Value = productos_agregados[i].codigo_producto;
                        command.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    MessageBox.Show("Transacción existosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                return isSuccess;
            }

        }

        #endregion

        #region Delete data from database
        public bool Delete(facturaBLL factura)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM FACTURA WHERE codigo_factura = @codigo_factura";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigo_factura ", factura.codigo_factura);
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

        #region Search client in database 
        public DataTable Search(String q)
        {
            //static method to connect data
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to get data from database
                string sql = "SELECT * FROM FACTURA WHERE codigo_factura LIKE '%" + q + "%'";
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
