using DGVPrinterHelper;
using facturacionApp.BLL;
using facturacionApp.DAL;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace facturacionApp.UI
{
    public partial class FacturasForm : Form
    {
        public FacturasForm()
        {
            InitializeComponent();
        }

        productoDAL producto_dal = new productoDAL();
        clienteDAL cliente_dal = new clienteDAL();
        facturaDAL factura_dal = new facturaDAL();
        DataTable productos_agregados = new DataTable
        {
            Columns = { "ID Producto", "Producto", "Precio x unidad", "Cantidad", "Total" }
        };

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BuscarClienteMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cliente_cedula = buscarClienteMaskedTextBox.Text;

            if (e.KeyChar == (char)Keys.Return)
            {
                //this line will stop the ding sound
                e.Handled = true;

                //clear textboxes before searching
                limpiarDetallesCliente();

                //search client by cedula
                DataTable cliente = cliente_dal.SearchByCedula(cliente_cedula);

                //if client is found, fill the textboxes in DETALLES DEL CLIENTE seccion 
                if (cliente.Rows.Count > 0)
                {
                    nombreClienteTextBox.Text = cliente.Rows[0].Field<string>(1);
                    apellidoClienteTextBox.Text = cliente.Rows[0].Field<string>(2);
                    cedulaClienteTextBox.Text = cliente.Rows[0].Field<string>(3);
                    telefonoClienteTextBox.Text = cliente.Rows[0].Field<string>(4);
                }
                else
                {
                    //Client not found
                    MessageBox.Show("No se ha encontrado ningún cliente con el cedula: " + cliente_cedula);
                }
            }
        }
        private void CantidadProductosNumericUpDown_Click(object sender, EventArgs e)
        {
            incrementarCantidad();

        }
        private void CantidadProductosNumericUpDown_DoubleClick(object sender, EventArgs e)
        {
            //Agregar producto a la lista de productos agregados
            incrementarCantidad();

        }
        private void CantidadProductosNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //this line will stop the ding sound
                e.Handled = true;

                // If product already exists and quantity to Total added quantity is greater than inventory, display message
                if (productAdded(Convert.ToInt32(buscarProductoNumericUpDown.Value), out DataGridViewRow productRow) && (Convert.ToInt32(productRow.Cells[3].Value) + Convert.ToInt32(cantidadProductosNumericUpDown.Value)) > Convert.ToInt32(existenciaProductoTextBox.Text))
                {

                    cantidadProductosNumericUpDown.Text = Convert.ToString(Convert.ToInt32(existenciaProductoTextBox.Text) - Convert.ToInt32(productRow.Cells[3].Value));
                    MessageBox.Show("Ya has agregado " + Convert.ToString(productRow.Cells[3].Value) + " " + nombreProductoTextBox.Text + ". Solo puedes agregar " + cantidadProductosNumericUpDown.Text + " más.");
                    return;
                }
                else
                {
                    //Agregar producto a la lista de productos agregados
                    incrementarCantidad();
                }

            }
        }
        private void BuscarProductoNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            string codigo_producto = buscarProductoNumericUpDown.Text;

            if (e.KeyChar == (char)Keys.Return)
            {
                //this line will stop the ding sound
                e.Handled = true;

                //clear textboxes before searching
                limpiarDetallesProducto();

                //search client by NIT
                DataTable producto = producto_dal.SearchByCodigo(codigo_producto);

                //if client is found, fill the textboxes in DETALLES DEL CLIENTE seccion 
                if (producto.Rows.Count > 0)
                {
                    // Lock BuscarProductoNumericUpDown
                    deshabilitarCampoNumerico(buscarProductoNumericUpDown);
                    buscarProductoNumericUpDown.Value = producto.Rows[0].Field<int>(0);
                    nombreProductoTextBox.Text = producto.Rows[0].Field<string>(1);
                    precio_unitarioProductoTextBox.Text = Convert.ToString(producto.Rows[0].Field<decimal>(3));
                    existenciaProductoTextBox.Text = Convert.ToString(producto.Rows[0].Field<int>(5));
                    cantidadProductosNumericUpDown.Text = "1";
                    double precio_unitatio = Convert.ToDouble(precio_unitarioProductoTextBox.Text);
                    double cantidad = Convert.ToDouble(cantidadProductosNumericUpDown.Text);
                    totalProductosTextBox.Text = Convert.ToString(cantidad * precio_unitatio);
                }
                else
                {
                    //Client not found
                    MessageBox.Show("No se ha encontrado ningún producto con el código: " + codigo_producto);
                }
            }
        }
        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {

            if (cedulaClienteTextBox.Text == "")
            {
                MessageBox.Show("Error: Debe agregar un cliente a la factura.");
                return;
            }
            if (nombreProductoTextBox.Text == "")
            {
                MessageBox.Show("Error: Seleccione un producto.");
                return;

            }
            if (Convert.ToString(cantidadProductosNumericUpDown.Value) == "0")
            {
                MessageBox.Show("Error: Debe agregar al menos un " + nombreProductoTextBox.Text + ".");
                return;
            }
            if (Convert.ToInt32(existenciaProductoTextBox.Text) == Convert.ToInt32("0"))
            {
                MessageBox.Show("Lo sentimos. La cantidad disponible de " + nombreProductoTextBox.Text + " en estos momentos es " + existenciaProductoTextBox.Text + ".");
                return;
            }

            int codigo_producto = Convert.ToInt32(buscarProductoNumericUpDown.Value);
            string nombre_producto = nombreProductoTextBox.Text;
            double precio_unitario = Convert.ToDouble(precio_unitarioProductoTextBox.Text);
            int cantidad = Convert.ToInt32(cantidadProductosNumericUpDown.Value);
            double total_producto = Convert.ToDouble(totalProductosTextBox.Text);

            if (productAdded(Convert.ToInt32(buscarProductoNumericUpDown.Value), out DataGridViewRow productRow) && (Convert.ToInt32(productRow.Cells[3].Value) + Convert.ToInt32(cantidadProductosNumericUpDown.Value)) > Convert.ToInt32(existenciaProductoTextBox.Text))
            {

                cantidadProductosNumericUpDown.Text = Convert.ToString(Convert.ToInt32(existenciaProductoTextBox.Text) - Convert.ToInt32(productRow.Cells[3].Value));
                MessageBox.Show("Ya has agregado " + Convert.ToString(productRow.Cells[3].Value) + " " + nombreProductoTextBox.Text + ". Solo puedes agregar " + cantidadProductosNumericUpDown.Text + " más.");
                return;
            }
            // if product already exists, update quantity and product total 
            if (productAdded(codigo_producto, out DataGridViewRow productRow2))
            {
                productosAgregadosDataGridView.Rows[productRow2.Index].Cells[3].Value = Convert.ToInt32(productosAgregadosDataGridView.Rows[productRow2.Index].Cells[3].Value) + cantidad;
                productosAgregadosDataGridView.Rows[productRow2.Index].Cells[4].Value = Convert.ToDouble(productosAgregadosDataGridView.Rows[productRow2.Index].Cells[4].Value) + total_producto;
            }

            else
            {
                //Agrega producto a la table
                productos_agregados.Rows.Add(codigo_producto, nombre_producto, precio_unitario, cantidad, total_producto);
            }

            //Agrega producto a productosAgregadosDataGridView
            productosAgregadosDataGridView.DataSource = productos_agregados;
            productosAgregadosDataGridView.Columns[0].Visible = false;
            //******REFACTOR ******  Update GRAND TOTAL
            UpdateTotal();

            //Clear product detail fields
            limpiarDetallesProducto();

            // Unlock BuscarProductoNumericUpDown
            habilitarCampoNumerico(buscarProductoNumericUpDown);
        }
        private void ProductosAgregadosDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateTotal();
        }
        private void LimpiarDetallesClientePictureBox_Click(object sender, EventArgs e)
        {
            //clear textboxes before searching
            limpiarDetallesCliente();
        }
        private void LimpiarDetallesProductoPictureBox_Click(object sender, EventArgs e)
        {
            //Clear product detail fields
            limpiarDetallesProducto();
            // Unlock BuscarProductoNumericUpDown
            habilitarCampoNumerico(buscarProductoNumericUpDown);
        }
        private void EliminarProductoAgregadoPictureBox_Click(object sender, EventArgs e)
        {
            if (productosAgregadosDataGridView.CurrentRow.Index != -1)
            {
                productosAgregadosDataGridView.Rows.Remove(productosAgregadosDataGridView.CurrentRow);
                UpdateTotal();
                EliminarProductoAgregadoPictureBox.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccion la fila que desea eliminar.");
            }
        }
        private void ProductosAgregadosDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EliminarProductoAgregadoPictureBox.Visible = true;
        }
        void limpiarDetallesCliente()
        {
            nombreClienteTextBox.Text = "";
            apellidoClienteTextBox.Text = "";
            cedulaClienteTextBox.Text = "";
            telefonoClienteTextBox.Text = "";
        }
        void limpiarDetallesProducto()
        {
            buscarProductoNumericUpDown.Value = 0;
            nombreProductoTextBox.Text = "";
            precio_unitarioProductoTextBox.Text = "";
            existenciaProductoTextBox.Text = "";
            totalProductosTextBox.Text = "";
            cantidadProductosNumericUpDown.Value = 0;
        }
        void habilitarCampoNumerico(NumericUpDown campo)
        {
            campo.Enabled = true;
            campo.Cursor = Cursors.Default;
        }
        void deshabilitarCampoNumerico(NumericUpDown campo)
        {
            campo.Enabled = false;
            campo.Cursor = Cursors.No;
        }
        void incrementarCantidad()
        {
            if (precio_unitarioProductoTextBox.Text != "" && cantidadProductosNumericUpDown.Text != "")
            {
                if (productAdded(Convert.ToInt32(buscarProductoNumericUpDown.Value), out DataGridViewRow productRow) && (Convert.ToInt32(productRow.Cells[3].Value) + Convert.ToInt32(cantidadProductosNumericUpDown.Value)) > Convert.ToInt32(existenciaProductoTextBox.Text))
                {

                    cantidadProductosNumericUpDown.Text = Convert.ToString(Convert.ToInt32(existenciaProductoTextBox.Text) - Convert.ToInt32(productRow.Cells[3].Value));
                    MessageBox.Show("Ya has agregado " + Convert.ToString(productRow.Cells[3].Value) + " " + nombreProductoTextBox.Text + ". Solo puedes agregar " + cantidadProductosNumericUpDown.Text + " más.");
                    return;
                }
                if (Convert.ToDouble(existenciaProductoTextBox.Text) < Convert.ToInt32(cantidadProductosNumericUpDown.Text))
                {
                    cantidadProductosNumericUpDown.Text = existenciaProductoTextBox.Text;
                    MessageBox.Show("Lo sentimos. La cantidad disponible de " + nombreProductoTextBox.Text + " en estos momentos es " + existenciaProductoTextBox.Text + ".");
                }
                else
                {
                    double precio_unitatio = Convert.ToDouble(precio_unitarioProductoTextBox.Text);
                    double cantidad = Convert.ToDouble(cantidadProductosNumericUpDown.Text);
                    totalProductosTextBox.Text = Convert.ToString(cantidad * precio_unitatio);
                }
            }
        }
        private bool productAdded(int codigo_producto, out DataGridViewRow productRow)
        {
            bool found = false;
            productRow = new DataGridViewRow();

            foreach (DataGridViewRow row in productosAgregadosDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == codigo_producto)
                {
                    productRow = row;
                    found = true;
                    break;
                }
            }
            return found;
        }
        private void UpdateTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in productosAgregadosDataGridView.Rows)
            {
                total = total + Convert.ToDouble(row.Cells[4].Value);
            }
            TotalTextBox.Text = Convert.ToString(total);
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            calcularCambio();
        }

        private void calcularCambio()
        {
            double total = Convert.ToDouble(TotalTextBox.Text);
            double pago = Convert.ToDouble(pagoNumericUpDown.Value);
            double cambio;

            if (pago < total)
            {
                MessageBox.Show("Por favor, introduzca un pago mayor o igual al total de la factura.");
                return;
            }
            else
            {
                cambio = pago - total;
            }
            cambioTextBox.Text = Convert.ToString(Math.Floor(cambio));
        }

        private void PagoNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If return key pressed, calculate change
            if (e.KeyChar == (char)Keys.Return)
            {
                //this line will stop the ding sound
                e.Handled = true;

                calcularCambio();
            }
        }
        private void FacturarButton_Click(object sender, EventArgs e)
        {

            if (nombreClienteTextBox.Text == "")
            {

            }
            if (productosAgregadosDataGridView.Rows.Count == 0)
            {

            } 
            try
            {
                facturaBLL factura = new facturaBLL();

                factura.codigo_cliente = cliente_dal.SearchByCedula(cedulaClienteTextBox.Text).Rows[0].Field<int>(0);
                factura.total_factura = Convert.ToDecimal(TotalTextBox.Text);

                List<factura_productoBLL> factura_productoList = new List<factura_productoBLL>();

                for (int i = 0; i < productosAgregadosDataGridView.Rows.Count; i++)
                {
                    factura_productoBLL factura_producto = new factura_productoBLL();

                    factura_producto.codigo_producto = Convert.ToInt32(productosAgregadosDataGridView.Rows[i].Cells[0].Value);
                    factura_producto.cantidad = Convert.ToInt32(productosAgregadosDataGridView.Rows[i].Cells[3].Value);
                    factura_producto.precio_unitario = Convert.ToDecimal(productosAgregadosDataGridView.Rows[i].Cells[2].Value);
                    factura_producto.total = Convert.ToDecimal(productosAgregadosDataGridView.Rows[i].Cells[4].Value);

                    factura_productoList.Add(factura_producto);
                }

                factura_dal.Insert(factura, factura_productoList);

                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                this.SetTopLevel(false);

                //Code to print bill
                printBill(productosAgregadosDataGridView);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printBill(DataGridView productosAgregadosDataGridView)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "\r\n\r\n TIENDA INFOTEP";
            printer.SubTitle = "Calle 5 Esq. Manantial, Urbanización Kenndy, Santo Domingo, República Dominicana \r\n Teléfono: (809) 220-1111";
            printer.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.TableAlignment = DGVPrinter.Alignment.Center;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;
            printer.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
            printer.Footer = "Total de factura: RD$ " + TotalTextBox.Text + "\r\n" + "Gracias por su compra!";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(productosAgregadosDataGridView);
        }
    }
}
