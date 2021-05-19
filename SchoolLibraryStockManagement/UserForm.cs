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
    public partial class UserForm : Form
    {
        public string selected_user;

        public UserForm()
        {
            InitializeComponent();
        }
        private void combobox_roles()
        {
            List<ComboRoles> ComboRoles = new List<ComboRoles>();
            ComboRoles.Add(new ComboRoles("sales_employee", "sales Employee"));
            ComboRoles.Add(new ComboRoles("warehouse_employee", "warehouse Employee"));
            ComboRoles.Add(new ComboRoles("super_admin", "super Admin"));

            comboBox1.DataSource = ComboRoles;
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseOperation.delete(new User().delete(selected_user));
            dgv_users.DataSource = DatabaseOperation.get(new DataTable(), (new User()).all());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" | txt_name.Text == "")
            {
                MessageBox.Show("fields cannot be null");
            }
            else
            {
                DataTable dt = null;
                string validateUsernameQuery = (new User().validateUsername(txt_username.Text));
                dt = DatabaseOperation.get(new DataTable(), validateUsernameQuery);
                if (dt != null)
                {
                    MessageBox.Show("Duplicated username ! ");
                    txt_username.Text = null;

                }
                else if (txt_password.TextLength < 8 | txt_password.Text == null)
                {
                    MessageBox.Show("please enter a valid password");
                    txt_password.Text = null;
                }

                else
                {
                    string type;
                    if (superRadio.Checked)
                    {
                        type = "super_admin";
                    }
                    else if (salesRadio.Checked)
                    {
                        type = "sales_employee";
                    }
                    else
                    {
                        type = "warehouse_employee";
                    }


                    string query = (new User().insert(
                    txt_username.Text,
                    txt_name.Text,
                    txt_password.Text,
                    type.ToString())
//comboBox1.SelectedValue.ToString())
);
                    DatabaseOperation.create(query);

                    dgv_users.DataSource = DatabaseOperation.get(new DataTable(), (new User()).all());


                }
            }


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            combobox_roles();
            dgv_users.DataSource = DatabaseOperation.get(new DataTable(), (new User()).all());
            fillColumns();

        }


        public void fillColumns()
        {
            foreach (string field in new User().fields)
            {
                cmb_columns.Items.Add(field);
            }
        }

        private void dgv_users_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected_user = dgv_users.Rows[e.RowIndex].Cells["id"].Value.ToString();
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            //  btn_clear.Enabled = true;
            btn_add.Enabled = false;
            // txt_price.ReadOnly = false;
            //txt_quantity.ReadOnly = false;

            txt_username.Text = dgv_users.Rows[e.RowIndex].Cells["username"].Value.ToString();
            txt_name.Text = dgv_users.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_password.Text = dgv_users.Rows[e.RowIndex].Cells["password"].Value.ToString();

            comboBox1.SelectedValue = dgv_users.Rows[e.RowIndex].Cells["role"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string query = (new User()).update(
              selected_user,
              txt_username.Text,
              txt_name.Text,
              txt_password.Text,
              comboBox1.SelectedValue.ToString());

            DatabaseOperation.update(query);

            dgv_users.DataSource = DatabaseOperation.get(new DataTable(), (new User()).all());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                Console.WriteLine(new User().search(cmb_columns.SelectedItem.ToString(), txt_search.Text));
                dgv_users.DataSource = DatabaseOperation.get(new DataTable(), new User().search((cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_users.DataSource = DatabaseOperation.get(new DataTable(), new User().all());
            }
        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {
            combobox_roles();
            dgv_users.DataSource = DatabaseOperation.get(new DataTable(), (new User()).all());
            fillColumns();
        }
    }
}


public class ComboRoles
{
    public string value { get; set; }
    public string key { get; set; }
    //  private int key;
    //private string value;
    public ComboRoles(string strkey, string strvalue)
    {
        this.key = strkey;
        this.value = strvalue;
    }

}