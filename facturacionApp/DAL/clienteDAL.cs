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
    class clienteDAL
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
                               cliente.codigo_cliente as 'Cliente ID',
                               cliente.nombre as 'Nombre', 
                               cliente.apellido 'Apellido',
                               cliente.cedula as 'Cedula',
                               cliente.telefono as 'Telefono'
                               FROM CLIENTE 
                               ORDER BY codigo_cliente ASC";

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
        public bool Insert(clienteBLL cliente)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {
                // SQL Query to get data from database
                string sql = "INSERT INTO CLIENTE (nombre, apellido, cedula, telefono) VALUES (@nombre, @apellido, @cedula, @telefono)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", cliente.nombre);
                command.Parameters.AddWithValue("@apellido", cliente.apellido);
                command.Parameters.AddWithValue("@cedula", cliente.cedula);
                command.Parameters.AddWithValue("@telefono", cliente.telefono);

                connection.Open();

                int rows = command.ExecuteNonQuery();

                // if query is executerd, the value of rows > 0 
                if(rows > 0)
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
            catch(Exception ex)
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
        public bool Update(Dictionary<string, object> cliente)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE CLIENTE SET nombre=@nombre, apellido=@apellido, cedula=@cedula, telefono=@telefono WHERE codigo_cliente=@codigo_cliente";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", cliente["nombre"]); 
                command.Parameters.AddWithValue("@apellido", cliente["apellido"]);
                command.Parameters.AddWithValue("@cedula", cliente["cedula"]);
                command.Parameters.AddWithValue("@telefono", cliente["telefono"]);
                command.Parameters.AddWithValue("@codigo_cliente", cliente["codigo_cliente"]);
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
        public bool Delete(clienteBLL cliente)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM CLIENTE WHERE codigo_cliente = @codigo_cliente";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigo_cliente", cliente.codigo_cliente);
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

        #region Search clients in database 
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
                                cliente.codigo_cliente as 'Cliente ID',
                                cliente.nombre as 'Nombre', 
                                cliente.apellido 'Apellido',
                                cliente.cedula as 'Cedula',
                                cliente.telefono as 'Telefono'
                              FROM CLIENTE WHERE cliente.nombre LIKE @q OR cliente.apellido LIKE @q OR cliente.cedula LIKE @q";
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

        #region Search client in database by their cedula number
        public DataTable SearchByCedula(String q)
        {
            //static method to connect data
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            //To hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to get data from database
                string sql = @"SELECT
                                cliente.codigo_cliente as 'Cliente ID',
                                cliente.nombre as 'Nombre', 
                                cliente.apellido 'Apellido',
                                cliente.cedula as 'Cedula',
                                cliente.telefono as 'Telefono'
                              FROM CLIENTE WHERE cliente.cedula = @q";
                // For executing cmmand
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@q", q);
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
