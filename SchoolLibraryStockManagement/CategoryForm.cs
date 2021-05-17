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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        public string selected_category;
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Category().all());
            fillColumns();
            btn_delete.Enabled = false;
            btn_edir.Enabled = false;
        }
        public void fillColumns()
        {
            foreach (string field in new Category().fields)
            {
                cmb_columns.Items.Add(field);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Category().search((cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_products.DataSource = DatabaseOperation.get(new DataTable(), new Category().all());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = (new Category()).insert(
             txt_name.Text,
             txt_description.Text

          );
            Console.WriteLine(query);
            DatabaseOperation.create(query);

            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Category()).all());
        }

        private void dgv_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_category = dgv_products.Rows[e.RowIndex].Cells["id"].Value.ToString();
            btn_delete.Enabled = true;
            btn_edir.Enabled = true;
            txt_name.Text = dgv_products.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_description.Text = dgv_products.Rows[e.RowIndex].Cells["description"].Value.ToString();
        }

        private void btn_edir_Click(object sender, EventArgs e)
        {
            string query = (new Category()).update(
               selected_category,
               txt_name.Text,
               txt_description.Text

                );
            Console.WriteLine(query);
            DatabaseOperation.update(query);

            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Category()).all());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseOperation.delete(new Category().delete(selected_category));
            dgv_products.DataSource = DatabaseOperation.get(new DataTable(), (new Category()).all());
        }
    }
}
