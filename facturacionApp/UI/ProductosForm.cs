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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }
        productoBLL producto = new productoBLL();
        productoDAL dal = new productoDAL();
        tipo_productoDAL tipo_productoDAL = new tipo_productoDAL();

        private void clear_form()
        {
            codigoTextBox.Text = "";
            nombreTextBox.Text = "";
            descripcionTextBox.Text = "";
            precioTextBox.Text = "";
            costoTextBox.Text = "";
            existenciaTextBox.Text = "";
            tipoProductoComboBox.Text = "";
        }
        
        private void ProductosForm_Load(object sender, EventArgs e)
        {
            this.fillDataGridView();
           this. fillTipoProductoComboBox();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get values from UI 
            Dictionary<string, object> productData = getProductData();

            if (productDataValid(productData))
            {
                productoBLL producto = new productoBLL(productData);

                //Inserting data into database
                bool isSuccess = dal.Insert(producto);

                if (isSuccess)
                {
                    //Data inserted successfully
                    MessageBox.Show("Producto agregado exitosamente.");
                }
                else
                {
                    //Data insertion failed
                    MessageBox.Show("Hubo un fallo.");

                }
                //Refresh DataGridView
                this.fillDataGridView();

                clear_form();

            }           
        }

         private bool productDataValid(Dictionary<string, object> productData)
        {

            bool result = true;

            if (productData["nombre"] as string == string.Empty)
            {
                MessageBox.Show("El nombre no puede estar vacio.");
                this.nombreTextBox.Focus();
                result = false;
            }
            else if (productData["descripcion"] as string == string.Empty)
            {
                MessageBox.Show("La descripción no puede estar vacia.");
                this.descripcionTextBox.Focus();
                result = false;
            }
            else if (productData["precio"] as string == string.Empty)
            {
                MessageBox.Show("El precio no puede estar vacio.");
                this.precioTextBox.Focus();
                result = false;
            }
            else if (!double.TryParse(productData["precio"] as string,out double precio))
            {
                MessageBox.Show("El precio debe ser un número.");
                this.precioTextBox.Focus();
                result = false;
            }
            else if (productData["costo"] as string == string.Empty)
            {
                MessageBox.Show("El costo no puede estar vacio.");
                this.costoTextBox.Focus();
                result = false;
            }
            else if (!double.TryParse(productData["costo"] as string, out double costo))
            {
                MessageBox.Show("El costo debe ser un número.");
                this.precioTextBox.Focus();
                result = false;
            }
            else if (productData["existencia"] as string == string.Empty)
            {
                MessageBox.Show("La existencia no puede estar vacia.");
                this.existenciaTextBox.Focus();
                result = false;
            }
            else if (!int.TryParse(productData["existencia"] as string, out int existencia))
            {
                MessageBox.Show("La existencia debe ser un número.");
                this.precioTextBox.Focus();
                result = false;
            }
            else if (productData["tipo_producto"] as string == string.Empty)
            {
                MessageBox.Show("La categoría no puede estar vacia.");
                this.existenciaTextBox.Focus();
                result = false;
            }

            return result;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Get values from UI 
            Dictionary<string, object> productData = getProductData();

            if (productDataValid(productData))
            {
                //Update data into database
                bool isSuccess = dal.Update(productData);

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
                //Refresh DataGridView
                this.fillDataGridView();

                clear_form();
            }

            
        }

        private Dictionary<string, object> getProductData()
        {
            Dictionary<string, object> productData = new Dictionary<string, object>();
            productData.Add("codigo_producto", this.codigoTextBox.Text);
            productData.Add("nombre", this.nombreTextBox.Text);
            productData.Add("descripcion", this.descripcionTextBox.Text);
            productData.Add("precio", this.precioTextBox.Text);
            productData.Add("costo",this.costoTextBox.Text);
            productData.Add("existencia", this.existenciaTextBox.Text);
            productData.Add("tipo_producto", (tipoProductoComboBox.SelectedItem as tipo_productoBLL).codigo_tipo_producto);
            return productData;
        }  

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get values from UI
            
            if(int.TryParse(codigoTextBox.Text, out int codigo_producto))
            {
                producto.codigo_producto = codigo_producto;

                //Delete data from database
                bool isSuccess = dal.Delete(producto);

                if (isSuccess)
                {
                    //Data updated successfully
                    MessageBox.Show("Producto eliminado exitosamente.");
                }
                else
                {
                    //Data update failed
                    MessageBox.Show("Hubo un fallo.");

                }
                //Refresh DataGridView
                this.fillDataGridView();

                clear_form();
            }
            else
            {
                MessageBox.Show("Seleccione un producto.");
            }
            
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
                productosDataGridView.DataSource = dt;
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

        private void ProductosDataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        { 
            //Get index of clicked row
            int rowIndex = e.RowIndex;
            codigoTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            nombreTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            descripcionTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            tipoProductoComboBox.Text = productosDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            existenciaTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            precioTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            costoTextBox.Text = productosDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
        }
        
        private void fillDataGridView()
        {
            DataTable dt = dal.Select();
            productosDataGridView.DataSource = dt;
        }
       
        private void fillTipoProductoComboBox()
        {
            DataTable dt = tipo_productoDAL.Select();

            foreach(DataRow row in dt.Rows)
            {
                tipo_productoBLL tipo_producto = new tipo_productoBLL();
                tipo_producto.codigo_tipo_producto = row.Field<int>("codigo_tipo_producto");
                tipo_producto.descripcion = row.Field<string>("descripcion");
                this.tipoProductoComboBox.Items.Add(tipo_producto);
            }
            this.tipoProductoComboBox.ValueMember = "codigo_tipo_producto";
            this.tipoProductoComboBox.DisplayMember = "descripcion";
            this.tipoProductoComboBox.SelectedIndex = 0;
        }
    }
}
