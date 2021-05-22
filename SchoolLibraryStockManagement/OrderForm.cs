using System;
using System.Data;
using System.Windows.Forms;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Command;

namespace SchoolLibraryStockManagement
{
    public partial class OrderForm : Form
    {
        User _user;
        private readonly IOrderItem _orderItem = new IOrderItemReciever();
        private readonly IOrder _order = new IOrderReciever();
        private readonly IProduct _product = new IProductReciever();
        Invoker _invoker = new Invoker();
        string selected_product , selected_order;
        string product_price , product_quantity;

        public OrderForm(User user)
        {
            InitializeComponent();
            this._user = user;
        }
        
        private void clearFields() {
            cBSearch.SelectedIndex = -1;
            tBSearch.Clear();
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
            dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            _invoker.Invoke(new DeleteOrderItemsByOrderId(_order, _orderItem, "0"));
            dGVOrderItems.DataSource = new DataTable();
            if (dGVProducts.Rows.Count < 1)
            {
                dGVOrderItems.DataSource = new DataTable();
                MessageBox.Show("Sorry! There is no product that you can order");
            }
            clearOrderFields(false, false);
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
                        _invoker.Invoke(new InsertOrderItem(_orderItem , "0" , selected_product, tBQuantity.Text, product_price , product_q));
                        dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, "0"));
                        dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
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
                if (dGVProducts.Rows[e.RowIndex].Cells["code"].Value.ToString() != "")
                {
                    btnAddOrderItem.Enabled = true;
                    btnDeleteOrderItem.Enabled = false;
                    btnEditOrderItem.Enabled = false;
                }
                else clearFields();
            }
        }

        private void bClearProducts_Click(object sender, EventArgs e)
        {
            clearFields();
            dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, "0"));
            if (dGVOrderItems.Rows.Count > 1)
            {
                clearOrderFields(true, true);
            }
            else
            {
                dGVOrderItems.DataSource = new DataTable();
            }
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text.Length > 0 && cBSearch.SelectedIndex>-1)
            {
                dGVProducts.DataSource = _invoker.Invoke(new SearchProductsHasQuantity(_product,(cBSearch.SelectedItem).ToString(), tBSearch.Text.ToString()));
            }
            else
            {
                dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new InsertOrder(_orderItem, _order , "0" , _user.id.ToString()));
            dGVOrderItems.DataSource = new DataTable();
            dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            MessageBox.Show("Order has Added Successfully");
            clearFields();
            clearOrderFields(false , false);
        }

        private void btnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new DeleteOrderItems(_orderItem,selected_order));
            dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, "0"));
            dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
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
                _invoker.Invoke(new UpdateOrderItem(_orderItem,selected_order, tBQuantity.Text));
                dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, "0"));
                dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            }
        }

        private void tBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            _invoker.Invoke(new DeleteOrder(_order,_orderItem, "0"));
            dGVOrderItems.DataSource = new DataTable();
            dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, "0"));
            dGVProducts.DataSource = _invoker.Invoke(new GetProductsHasQuantity(_product));
            clearOrderFields(false, false);
            clearFields();
        }
    }
}
