using System;
using System.Data;
using System.Windows.Forms;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Command;

namespace SchoolLibraryStockManagement
{
    public partial class OrdersForm : Form
    {
        private readonly IOrder _order = new IOrderReciever();
        private readonly IOrderItem _orderItem = new IOrderItemReciever();
        private readonly IProduct _product = new IProductReciever();
        Invoker _invoker = new Invoker(); 
        string selected_order ,  selected_order_item;
        string selected_product;
        public OrdersForm()
        {
            InitializeComponent();
        }
        private void clearOrderitemsFields()
        {
            dGVOrderItems.ClearSelection();
            tB_productCode.Clear();
            tB_Quantity.Clear();
            btnDeleteOrederItem.Enabled = false;
            btnEditOrderItem.Enabled = false;
            selected_order_item = "";
        } 
        private void clear() {
            dGVOrders.ClearSelection();
            tB_referenceNum.Clear();
            btnDeleteOrder.Enabled = false;
            btn_editOrder.Enabled = false;
            dGVOrderItems.DataSource = new DataTable();
            selected_order = "";
            cB_search.SelectedIndex = -1;
            tBSearch.Clear();
        }
        public void fillColumns()
        {
            foreach (string field in new Order().fields)
            {
                cB_search.Items.Add(field);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
            fillColumns();
        }

        private void dGVOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_order = dGVOrders.Rows[e.RowIndex].Cells["id"].Value.ToString();
                tB_referenceNum.Text = dGVOrders.Rows[e.RowIndex].Cells["reference number"].Value.ToString();
                dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, selected_order));
                if (dGVOrders.Rows[e.RowIndex].Cells["reference number"].Value.ToString() != "")
                {
                    btnDeleteOrder.Enabled = true;
                    btn_editOrder.Enabled = true;
                }
                else {
                    clearOrderitemsFields();
                    clear();
                }
                
            }
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text.Length > 0 && cB_search.SelectedIndex > -1)
            {
                dGVOrders.DataSource = _invoker.Invoke(new SearchOrder(_order,(cB_search.SelectedItem).ToString(), tBSearch.Text));
            }
            else {
                dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new DeleteOrder(_order, _orderItem,selected_order));
            dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
            clear();
        }

        private void dGVOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_order_item = dGVOrderItems.Rows[e.RowIndex].Cells["id"].Value.ToString();
                selected_product = dGVOrderItems.Rows[e.RowIndex].Cells["product code"].Value.ToString();
                tB_productCode.Text = selected_product;
                tB_Quantity.Text = dGVOrderItems.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                if (selected_product != "")
                {
                    btnDeleteOrederItem.Enabled = true;
                    btnEditOrderItem.Enabled = true;
                }
                else
                    clearOrderitemsFields();           
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            clear();
            clearOrderitemsFields();
            dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
        }

        private void btnEditOrderItem_Click(object sender, EventArgs e)
        {
            string quantity = _product.SelectQuantity(selected_product);
            int product_quantity = Convert.ToInt32(tB_Quantity.Text) + Convert.ToInt32(quantity)+1;

            if (tB_Quantity.Text != "" && tB_Quantity.Text != "0" && Convert.ToInt32(tB_Quantity.Text) < product_quantity && product_quantity > 0)
            {
                _invoker.Invoke(new UpdateOrderItems(_orderItem, _order, selected_order, selected_order_item, tB_Quantity.Text));
                dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, selected_order));
                dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
            }
            else if (product_quantity < 0)
            {
                MessageBox.Show("There is no more quantity in this product");
            }
            else
            {
                MessageBox.Show("Quantity must be more than 0 and less than " + product_quantity.ToString());
            }
        }

        private void btnDeleteOrederItem_Click(object sender, EventArgs e)
        {
            int count = dGVOrderItems.Rows.Count;
            _invoker.Invoke(new DeleteOrderItemsFROMOrder(_orderItem , _order,selected_order_item , selected_order  , count));
            dGVOrderItems.DataSource = _invoker.Invoke(new GetOrderItems(_orderItem, selected_order));
            dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
            clearOrderitemsFields();
        }

        private void btn_clear_items_Click(object sender, EventArgs e)
        {
            clearOrderitemsFields();
        }

        private void tB_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_editOrder_Click(object sender, EventArgs e)
        {
            if (!tB_referenceNum.Text.Contains(".")) { 
            if (tB_referenceNum.Text.Length > 0 && tB_referenceNum.Text.Length == 6) {
                _invoker.Invoke(new UpdateOrder(_order, selected_order, tB_referenceNum.Text));
                dGVOrders.DataSource = _invoker.Invoke(new GetAllOrders(_order));
                }
            else
               MessageBox.Show("Reference number must contain 6 char");
            }
            else
                MessageBox.Show("Invalid reference number");
        }
    }
}