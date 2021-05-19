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

namespace SchoolLibraryStockManagement
{
    public partial class ProductForm : Form
    {
        public string selected_product;
        public User user;

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
            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Product().all());

            fillColumns();

            fillCategories();

            if (user.role == "sales_employee")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
                btn_clear.Enabled = false;
                txt_price.ReadOnly = true;
                txt_quantity.ReadOnly = true;
                btn_add_category.Enabled = false;
            }
            else
            {
                btn_add.Enabled = true;
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_clear.Enabled = true;
                txt_price.ReadOnly = false;
                txt_quantity.ReadOnly = false;
            }
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
            cmb_categories.DataSource = DatabaseOperation.get(table, (new Category()).all());
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
                dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Product().search((cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Product().all());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = (new Product()).insert(
               txt_code.Text,
               txt_name.Text,
               txt_description.Text,
               txt_price.Text,
               txt_quantity.Text,
               cmb_categories.SelectedValue.ToString()
            );
            Console.WriteLine(query);
            DatabaseOperation.create(query);

            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Product()).all());
        }

        private void dgv_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_product = dgv_products.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (user.role == "sales_employee" || user.role == "warehouse_employee")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
                btn_clear.Enabled = false;
                txt_price.ReadOnly = true;
                txt_quantity.ReadOnly = true;
            }
            else
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_clear.Enabled = true;
                txt_price.ReadOnly = false;
                txt_quantity.ReadOnly = false;
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
            DatabaseOperation.delete(new Product().delete(selected_product));
            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Product()).all());
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string query = (new Product()).update(
               selected_product,
               txt_code.Text,
               txt_name.Text,
               txt_description.Text,
               txt_price.Text,
               txt_quantity.Text,
               cmb_categories.SelectedValue.ToString()
            );
            Console.WriteLine(query);
            DatabaseOperation.update(query);

            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Product()).all());
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

            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_clear.Enabled = false;
            btn_edit.Enabled = false;
            txt_price.ReadOnly = true;
            txt_quantity.ReadOnly = true;
        }
    }
}
