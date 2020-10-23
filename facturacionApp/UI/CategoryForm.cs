using facturacionApp.BLL;
using facturacionApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacionApp.UI
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        tipo_productoBLL tipo_producto = new tipo_productoBLL();
        tipo_productoDAL dal = new tipo_productoDAL();
        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get values from UI 
            tipo_producto.descripcion = descripcionTextBox.Text;

            if (tipo_producto.descripcion != string.Empty)
            {
                //Inserting data into database
                bool isSuccess = dal.Insert(tipo_producto);

                if (isSuccess)
                {
                    //Data inserted successfully
                    MessageBox.Show("Categoría agregado exitosamente.");
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
            else
            {
                MessageBox.Show("La descripción no puede estar vacia.");
                this.descripcionTextBox.Focus();
            }


        }
        
        private void clear_form()
        {
            codigoTextBox.Text = "";
            descripcionTextBox.Text = "";

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get values from UI
            Dictionary<string, object> tipoProductoData = getTipoProductoData();

            if (tipoProductoDataisValid(tipoProductoData))
            {
                //Update data into database
                bool isSuccess = dal.Update(tipoProductoData);

                if (isSuccess)
                {
                    //Data updated successfully
                    MessageBox.Show("Categoría actualizada exitosamente.");
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
        }

        private bool tipoProductoDataisValid(Dictionary<string, object> tipoProductoData)
        {
            bool result = true;

            if (tipoProductoData["codigo_tipo_producto"] as string == string.Empty)
            {
                MessageBox.Show("Seleccione una categoría.");
                result = false;
            }
            else if (tipoProductoData["descripcion"] as string == string.Empty)
            {
                MessageBox.Show("La descripción no puede estar vacia.");
                this.descripcionTextBox.Focus();
                result = false;
            }

            return result;
        }

        private Dictionary<string, object> getTipoProductoData()
        {
            Dictionary<string, object> tipoProductoData = new Dictionary<string, object>();
            tipoProductoData.Add("codigo_tipo_producto", this.codigoTextBox.Text);
            tipoProductoData.Add("descripcion", this.descripcionTextBox.Text);
            return tipoProductoData;
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(codigoTextBox.Text, out int codigo_tipo_producto))
            {
                tipo_producto.codigo_tipo_producto = codigo_tipo_producto;

                //Delete data from database
                bool isSuccess = dal.Delete(tipo_producto);

                if (isSuccess)
                {
                    //Data updated successfully
                    MessageBox.Show("Categoría eliminada exitosamente.");
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
            else
            {
                MessageBox.Show("Seleccione una categoría.");
            }

        }

        private void LimpiarFormularioLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
                categoriasDataGridView.DataSource = dt;
            }
            else
            {
                //Show all users from the databade
                DataTable dt = dal.Select();
                categoriasDataGridView.DataSource = dt;
            }
        }

        private void CategoriasDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get index of clicked row
            int rowIndex = e.RowIndex;
            this.codigoTextBox.Text = categoriasDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            this.descripcionTextBox.Text = categoriasDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void fillDataGridView()
        {
            DataTable dt = dal.Select();
            categoriasDataGridView.DataSource = dt;
        }
    }
}
