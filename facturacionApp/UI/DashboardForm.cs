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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void FacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form facturasForm = Application.OpenForms["facturasForm"];
            
            if (facturasForm != null)
            {
                facturasForm.Show();
                facturasForm.Focus();
            }
            else
            {
                FacturasForm factura = new FacturasForm();
                factura.Show();
            }
        }
        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideSecondaries();
            Form clientesForm = Application.OpenForms["clientesForm"];

            if (clientesForm != null)
            {
                clientesForm.Show();
                clientesForm.Focus();
            }
            else
            {
                ClientesForm cliente = new ClientesForm();
                cliente.Show();
            }
        }
        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideSecondaries();

            Form productosForm = Application.OpenForms["productosForm"];

            if (productosForm != null)
            {
                productosForm.Show();
                productosForm.Focus();
            }
            else
            {
                ProductosForm productos = new ProductosForm();
                productos.Show();
            }
            
        }
        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideSecondaries();

            Form tipo_productoForm = Application.OpenForms["tipo_productoForm"];

            if (tipo_productoForm != null)
            {
                tipo_productoForm.Show();
                tipo_productoForm.Focus();
            }
            else
            {
                CategoryForm tipo_producto = new CategoryForm();
                tipo_producto.Show();
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void hideSecondaries()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "DashboardForm") form.Hide();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
