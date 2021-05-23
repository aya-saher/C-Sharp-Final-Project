using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Command;
using SchoolLibraryStockManagement.Factory;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement
{
    public partial class StockManagementForm : Form
    {
        List<StockManagement> stock = new List<StockManagement>();
        string selected_product_id;
        int selected_index;
        private readonly IProduct _product = new IProductReciever();
        private readonly IStock _stock = new IStockReciever();
        Invoker _invoker = new Invoker();

        public StockManagementForm()
        {
            InitializeComponent();
        }

        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));

            disableFields(false, false, false);

            dgv_stock.ColumnCount = 3;
            dgv_stock.Columns[0].Name = "#";
            dgv_stock.Columns[1].Name = "Product";
            dgv_stock.Columns[2].Name = "Quantity";
        }

        private void dgv_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_product_id = dgv_products.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txt_product.Text = dgv_products.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_quantity.Value = 1;

            disableFields(true, false, false);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            stock.Add(new StockManagement(
                selected_product_id,
                Convert.ToInt32(txt_quantity.Value), // Convert from Decimen to Int
                1
            ));

            dgv_stock.Rows.Add(dgv_stock.Rows.Count,
                txt_product.Text,
                Convert.ToInt32(txt_quantity.Value)
            );
            disableFields(false, false, false);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            disableFields(false, false, false);

            _invoker.Invoke(new InsertStock(_stock, stock));
            //DatabaseOperation.create(new StockManagement().add(stock));
            MessageBox.Show("Quantities Added Successfully!");

            stock.Clear();
            dgv_stock.Rows.Clear();
        }

        private void dgv_stock_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1){
                selected_index = e.RowIndex;
                disableFields(false, true, true);

                txt_product.Text = dgv_stock.Rows[e.RowIndex].Cells["Product"].Value.ToString();
                txt_quantity.Value = decimal.Parse(dgv_stock.Rows[e.RowIndex].Cells["Quantity"].Value.ToString()); // Convert from string to decimel
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dgv_stock.Rows[selected_index].Cells["Quantity"].Value = txt_quantity.Value.ToString();

            var obj = stock.FirstOrDefault(item => item.product_id == selected_product_id);
            if (obj != null) obj.quantity = Convert.ToInt32(txt_quantity.Value);

            disableFields(false, false, false);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            dgv_stock.Rows.RemoveAt(selected_index);

            var obj = stock.Single(item => item.product_id == selected_product_id);
            stock.Remove(obj);

            disableFields(false, false, false);
        }

        private void disableFields(bool add_button, bool edit_button, bool remove_button)
        {
            btn_add.Enabled = add_button;
            btn_edit.Enabled = edit_button;
            btn_remove.Enabled = edit_button;
        }
    }
}
