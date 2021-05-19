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
    public partial class OrdersForm : Form
    {
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
            dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
            fillColumns();
        }

        private void dGVOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_order = dGVOrders.Rows[e.RowIndex].Cells["id"].Value.ToString();
                tB_referenceNum.Text = dGVOrders.Rows[e.RowIndex].Cells["reference number"].Value.ToString();
                dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems(selected_order));
                btnDeleteOrder.Enabled = true;
                btn_editOrder.Enabled = true;
            }
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text.Length > 0 && cB_search.SelectedIndex > -1)
            {
                dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).search((cB_search.SelectedItem).ToString(), tBSearch.Text));
            }
            else {
                dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DatabaseOperation.create((new Order()).delete(selected_order));
            dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
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
                btnDeleteOrederItem.Enabled = true;
                btnEditOrderItem.Enabled = true;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            clear();
            clearOrderitemsFields();
            dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
        }

        private void btnEditOrderItem_Click(object sender, EventArgs e)
        {
            string quantity = DatabaseOperation.get(new DataTable(), new Product().select_Quantity(selected_product)).Rows[0].Field<Int32>("quantity").ToString();
            int product_quantity = Convert.ToInt32(tB_Quantity.Text) + Convert.ToInt32(quantity);

            if (tB_Quantity.Text != "" && tB_Quantity.Text != "0" && Convert.ToInt32(tB_Quantity.Text) < product_quantity + 1)
            {
                DatabaseOperation.create((new OrderItem()).update(selected_order_item, tB_Quantity.Text));
                string total = DatabaseOperation.get(new DataTable(), new OrderItem().total_price(selected_order)).Rows[0].Field<double>("total").ToString();
                DatabaseOperation.create((new Order()).update_total(selected_order, total));
                dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems(selected_order));
                dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
            }
            else {
                MessageBox.Show("Quantity must be more than 0 and less than " + product_quantity.ToString());
            }
        }

        private void btnDeleteOrederItem_Click(object sender, EventArgs e)
        {
            DatabaseOperation.create((new OrderItem()).delete(selected_order_item));
            dGVOrderItems.DataSource = DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems(selected_order));
            clearOrderitemsFields();
        }

        private void btn_clear_items_Click(object sender, EventArgs e)
        {
            clearOrderitemsFields();
        }

        private void tB_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_editOrder_Click(object sender, EventArgs e)
        {
            if (tB_referenceNum.Text.Length > 0 && tB_referenceNum.Text.Length == 6) {
                DatabaseOperation.create((new Order()).update(selected_order, tB_referenceNum.Text));
                dGVOrders.DataSource = DatabaseOperation.get(new DataTable(), (new Order()).all());
            }
            else
               MessageBox.Show("Reference number must contain 6 char");
        }
    }
}