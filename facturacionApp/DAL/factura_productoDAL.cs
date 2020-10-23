using facturacionApp.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace facturacionApp.DAL
{
    class factura_productoDAL
    {
       static string myConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        #region Insert data in database
        public bool Insert(factura_productoBLL factura_producto)
        {
            bool isSuccess = false;

            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {
                // SQL Query to get data from database
                string sql = "INSERT INTO FACTURA_PRODUCTO (codigo_factura, codigo_producto, cantidad, precio_unitario, total) VALUES (@codigo_factura, @codigo_client, @cantidad, @precio_unitario, @total)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigo_factura", factura_producto.codigo_factura);
                command.Parameters.AddWithValue("@codigo_producto", factura_producto.codigo_producto);
                command.Parameters.AddWithValue("@cantidad", factura_producto.cantidad);
                command.Parameters.AddWithValue("@precio_unitario", factura_producto.precio_unitario);
                command.Parameters.AddWithValue("@total", factura_producto.total);

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

        #region Open transaction
        public bool OpenTransaction()
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "BEGIN TRANSACTION ";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Commit transaction
        public bool CommitTransaction()
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "COMMIT TRANSACTION";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Rollback transaction
        public bool RollbackTransaction()
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "ROLLBACK TRANSACTION";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
