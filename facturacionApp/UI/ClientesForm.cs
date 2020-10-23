using facturacionApp.BLL;
using facturacionApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace facturacionApp.UI
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        clienteBLL cliente = new clienteBLL();
        clienteDAL dal = new clienteDAL();

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get values from UI 
            Dictionary<string, object> personalData = getPersonalData();

            if (personalDataIsValid(personalData))
            {
                clienteBLL cliente = new clienteBLL(personalData);
                //Inserting data into database
                bool isSuccess = dal.Insert(cliente);

                if (isSuccess)
                {
                    //Data inserted successfully
                    MessageBox.Show("Cliente agregado exitosamente.");
                }
                else
                {
                    //Data insertion failed
                    MessageBox.Show("Hubo un fallo.");

                }
                //Refresh clientesDataGridView
                fillDataGridView();

                clear_form();
            }

        }

        private bool personalDataIsValid(Dictionary<string, object> personalData)
        {

            bool result = true;

            if (personalData["nombre"] as string == string.Empty)
            {
                MessageBox.Show("El nombre no puede estar vacio.");
                this.nombreTextBox.Focus();
                result = false;
            }
            else if (personalData["apellido"] as string == string.Empty)
            {
                MessageBox.Show("El apellido no puede estar vacio.");
                this.apellidoTextBox.Focus();
                result = false;
            }
            else if (!new Regex("^(SDO)[0-9]{5}$").IsMatch(personalData["cedula"] as string))
            {
                MessageBox.Show("La cédula debe contener SDO seguida de 5 números.");
                this.cedulaTextBox.Focus();
                result = false;
            }
            else if (!new Regex("^[0-9]{10}$").IsMatch(personalData["telefono"] as string))
            {
                MessageBox.Show("El teléfono debe contener 10 dígitos.");
                this.telefonoTextBox.Focus();
                result = false;
            }

            return result;
        }

        private Dictionary<string, object> getPersonalData()
        {
            Dictionary<string, object> personalData = new Dictionary<string, object>();
            personalData.Add("codigo_cliente", this.codigoTextBox.Text);
            personalData.Add("nombre", this.nombreTextBox.Text);
            personalData.Add("apellido", this.apellidoTextBox.Text);
            personalData.Add("cedula", this.cedulaTextBox.Text);
            personalData.Add("telefono", this.telefonoTextBox.Text);
            return personalData;
        }

        private void clear_form()
        {
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            cedulaTextBox.Text = "";
            telefonoTextBox.Text = "";
            codigoTextBox.Text = "";
        }

        private void ClientesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get index of clicked row
            int rowIndex = e.RowIndex;
            codigoTextBox.Text = clientesDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            nombreTextBox.Text = clientesDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            apellidoTextBox.Text = clientesDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            cedulaTextBox.Text = clientesDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            telefonoTextBox.Text = clientesDataGridView.Rows[rowIndex].Cells[4].Value.ToString();

        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Get values from UI 
            Dictionary<string, object> personalData = getPersonalData();

            if (personalDataIsValid(personalData))
            {
                //Update data into database
                bool isSuccess = dal.Update(personalData);

                if (isSuccess)
                {
                    //Data updated successfully
                    MessageBox.Show("Cliente actualizado exitosamente.");
                }
                else
                {
                    //Data update failed
                    MessageBox.Show("Hubo un fallo.");

                }

                fillDataGridView();

                clear_form();
            }   
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get values from UI
            cliente.codigo_cliente = Convert.ToInt32(codigoTextBox.Text);

            //Delete data from database
            bool isSuccess = dal.Delete(cliente);

            if (isSuccess)
            {
                //Data updated successfully
                MessageBox.Show("Cliente eliminado exitosamente.");
            }
            else
            {
                //Data update failed
                MessageBox.Show("Hubo un fallo.");

            }
            //Refresh clientesDataGridView
            fillDataGridView();

            clear_form();
        }
       
        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get keyword from textbox
            string q = buscarTextBox.Text;

            // Check null
            if (q != null)
            {
                //Show clientes based on keyword
                DataTable dt = dal.Search(q);
                clientesDataGridView.DataSource = dt;
            }
            else
            {
                //Show all users from the databade
                DataTable dt = dal.Select();
                clientesDataGridView.DataSource = dt;
            }

        }
        
        private void LimpiarFormularioLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear_form();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void fillDataGridView()
        {
            clientesDataGridView.DataSource = dal.Select();
        }
    }
}
