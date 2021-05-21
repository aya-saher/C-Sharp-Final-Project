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
    public partial class CategoryForm : Form
    {
        public string selected_category;
        private readonly ICategory _category = new ICategoryReciever();
        Invoker _invoker = new Invoker();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
          //  dgv_categories.DataSource = DatabaseOperation.get(new DataTable(), new Category().all());
            dgv_categories.DataSource = _invoker.Invoke(new GetAllCategories(_category, new DataTable()));

            fillColumns();

            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_clear.Enabled = false;
        }

        public void fillColumns()
        {
            foreach (string field in new Category().fields)
            {
                cmb_columns.Items.Add(field);
            }
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
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseOperation.delete(new Category().delete(selected_category));
            dgv_categories.DataSource = DatabaseOperation.get(new DataTable(), (new Category()).all());
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new UpdateCategory(_category, selected_category,
               txt_name.Text,
               txt_description.Text
            ));

            dgv_categories.DataSource = _invoker.Invoke(new GetAllCategories(_category,new DataTable()));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _invoker.Invoke(new InsertCategory(_category,
              txt_name.Text,
               txt_description.Text));

            dgv_categories.DataSource = _invoker.Invoke(new GetAllCategories(_category, new DataTable()));

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dgv_categories.DataSource = _invoker.Invoke(new SearchCategory(_category, (cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_categories.DataSource = _invoker.Invoke(new GetAllCategories(_category, new DataTable()));
            }
        }

        private void dgv_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_category = dgv_categories.Rows[e.RowIndex].Cells["id"].Value.ToString();

            btn_add.Enabled = false;
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_clear.Enabled = true;

            txt_name.Text = dgv_categories.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_description.Text = dgv_categories.Rows[e.RowIndex].Cells["description"].Value.ToString();
        }
    }
}
