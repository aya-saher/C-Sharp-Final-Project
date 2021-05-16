using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Libraries;

namespace SchoolLibraryStockManagement
{
    public partial class OrderForm : Form
    {
        string selected_product , selected_order;
        string product_price , product_quantity;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void clearFields() {
            tBProductCode.Clear();
            tBQuantity.Clear();
            dGVProducts.ClearSelection();
            dGVOrderItems.ClearSelection();
            btnAddOrderItem.Enabled = false;
            btnDeleteOrderItem.Enabled = false;
            btnEditOrderItem.Enabled = false;
        }

        private void clearOrderFields(bool add , bool delete) {
            btnAddOrder.Enabled = add;
            btnDeleteOrder.Enabled = delete;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            fillColumns();
            dGVProducts.DataSource = DatabaseOperation.get(new DataTable(), (new Product()).select_productsHasQuantity());
            dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems("0"));

            if (dGVOrderItems.Rows.Count > 1)
            {
                clearOrderFields(true, true);
            }
            else {
                dGVOrderItems.DataSource = new DataTable();

            }
        }
        public void fillColumns()
        {
            foreach (string field in new Product().fields)
            {
                cBSearch.Items.Add(field);
            }
        }
        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            if (tBQuantity.Text != "")
            {
                if (!tBQuantity.Text.Contains("."))
                {
                    var product_q = Convert.ToInt32(product_quantity) + 1;
                    if (tBQuantity.Text != "0" && Convert.ToDouble(tBQuantity.Text) > 0 && Convert.ToInt32(tBQuantity.Text) < product_q)
                    {
                        DatabaseOperation.create((new OrderItem()).insert("0", selected_product, tBQuantity.Text, product_price));
                        dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems("0"));
                        clearOrderFields(true, true);
                        clearFields();
                    }
                    else
                    {
                        
                        MessageBox.Show("Quantity must be more than 0 and less than " + product_q);
                    }
                }
                else
                {
                    MessageBox.Show("Quantity must be Integer number");
                }
            }
            else {
                MessageBox.Show("Quantity Field required");
            }
           
        }

        private void dGVProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_product = dGVProducts.Rows[e.RowIndex].Cells["id"].Value.ToString();
                product_price = dGVProducts.Rows[e.RowIndex].Cells["price"].Value.ToString();
                tBProductCode.Text = dGVProducts.Rows[e.RowIndex].Cells["code"].Value.ToString();
                product_quantity = dGVProducts.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                tBQuantity.Text = product_quantity;
                btnAddOrderItem.Enabled = true;
                btnDeleteOrderItem.Enabled = false;
                btnEditOrderItem.Enabled = false;
            }
        }

        private void bClearProducts_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text.Length > 0 && cBSearch.SelectedIndex>-1)
            {
                Console.WriteLine(new Product().search(cBSearch.SelectedItem.ToString(), tBSearch.Text));
                dGVProducts.DataSource = DatabaseOperation.get(new DataTable(), new Product().search((cBSearch.SelectedItem).ToString(), tBSearch.Text.ToString()));
            }
            else
            {
                dGVProducts.DataSource = DatabaseOperation.get(new DataTable(), new Product().select_productsHasQuantity());
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string total = DatabaseOperation.get(new DataTable(), new OrderItem().total_price("0")).Rows[0].Field<double>("total").ToString();
            DatabaseOperation.create((new Order()).insert("0" , total));
            string last_order_id = DatabaseOperation.get(new DataTable(), new Order().lastOrder()).Rows[0].Field<Int32>("id").ToString();
            DatabaseOperation.create((new OrderItem()).update(last_order_id));
            dGVOrderItems.DataSource = new DataTable();
            MessageBox.Show("Order has Added Successfully");
            clearFields();
            clearOrderFields(false , false);
        }

        private void btnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            DatabaseOperation.create((new OrderItem()).delete(selected_order));
            dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems("0"));
            if (dGVOrderItems.Rows.Count < 2)
            {
                dGVOrderItems.DataSource = new DataTable();
                clearOrderFields(false, false);
            }
            clearFields();
        }

        private void btnEditOrderItem_Click(object sender, EventArgs e)
        {
            if (tBQuantity.Text != "" && tBQuantity.Text != "0" && Convert.ToInt32(tBQuantity.Text) < Convert.ToInt32(product_quantity) +1)
            {
                DatabaseOperation.create((new OrderItem()).update(selected_order, tBQuantity.Text));
                dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems("0"));
            }
        }

        private void tBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dGVOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_order = dGVOrderItems.Rows[e.RowIndex].Cells["id"].Value.ToString();
                tBProductCode.Text = dGVOrderItems.Rows[e.RowIndex].Cells["Product Code"].Value.ToString();
                tBQuantity.Text = dGVOrderItems.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                btnDeleteOrderItem.Enabled = true;
                btnEditOrderItem.Enabled = true;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DatabaseOperation.create((new OrderItem()).delete_order_id("0"));
            dGVOrderItems.DataSource = new DataTable();
            clearOrderFields(false, false);
            clearFields();
        }
    }
}
