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
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Command;
using SchoolLibraryStockManagement.Factory;

namespace SchoolLibraryStockManagement
{
    public partial class ProductForm : Form
    {
        private User user;
        public string selected_product;
        private readonly IProduct _product = new IProductReciever();
        private readonly ICategory _category = new ICategoryReciever();
        Invoker _invoker = new Invoker();

        public ProductForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_stock_management_Click(object sender, EventArgs e)
        {
            new StockManagementForm().ShowDialog();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));

            fillColumns();

            fillCategories();

            foreach (Permission permission in this.user.user_algorithm.getProductManagementPermissionsOnLoad())
            {
                var control = this.Controls.OfType<Button>().FirstOrDefault(c => c.Name == permission.name);
                control.Enabled = permission.status;
            }

            txt_quantity.ReadOnly = true;
        }

        public void fillColumns()
        {
            foreach (string field in new Product().fields)
            {
                cmb_columns.Items.Add(field);
            }
        }

        public void fillCategories()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("name", typeof(string));
            cmb_categories.ValueMember = "id";
            cmb_categories.DisplayMember = "name";
            cmb_categories.DataSource = _invoker.Invoke(new GetAllCategories(_category,table));
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            new CategoryForm().ShowDialog();
            fillCategories();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dgv_products.DataSource = _invoker.Invoke(new SearchProduct(_product,(cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new InsertProduct(_product,txt_code.Text,
               txt_name.Text,
               txt_description.Text,
               txt_price.Text,
               txt_quantity.Text,
               cmb_categories.SelectedValue.ToString()));

            dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));
        }

        private void dgv_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_product = dgv_products.Rows[e.RowIndex].Cells["id"].Value.ToString();

            foreach (Permission permission in this.user.user_algorithm.getProductManagementPermissionsEditing())
            {
                var control = this.Controls.OfType<Button>().FirstOrDefault(c => c.Name == permission.name);
                control.Enabled = permission.status;
            }

            txt_code.Text = dgv_products.Rows[e.RowIndex].Cells["code"].Value.ToString();
            txt_name.Text = dgv_products.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_description.Text = dgv_products.Rows[e.RowIndex].Cells["description"].Value.ToString();
            txt_price.Text = dgv_products.Rows[e.RowIndex].Cells["price"].Value.ToString();
            txt_quantity.Text = dgv_products.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            cmb_categories.SelectedValue = dgv_products.Rows[e.RowIndex].Cells["category_id"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new DeleteProduct(_product,selected_product));
            dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new UpdateProduct(_product, selected_product,
               txt_code.Text,
               txt_name.Text,
               txt_description.Text,
               txt_price.Text,
               txt_quantity.Text,
               cmb_categories.SelectedValue.ToString()
            ));

            dgv_products.DataSource = _invoker.Invoke(new GetAllProducts(_product));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).Clear();
                else if (ctrl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctrl).SelectedIndex = -1;
            }

            foreach (Permission permission in this.user.user_algorithm.getProductManagementPermissionsOnLoad())
            {
                var control = this.Controls.OfType<Button>().FirstOrDefault(c => c.Name == permission.name);
                control.Enabled = permission.status;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
