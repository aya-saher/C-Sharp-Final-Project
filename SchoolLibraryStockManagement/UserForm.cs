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
using SchoolLibraryStockManagement.Helper;

namespace SchoolLibraryStockManagement
{
    public partial class UserForm : Form
    {
        public string selected_user;
        private readonly IUser _user = new IUserReciever();
        Invoker _invoker = new Invoker();

        public UserForm()
        {
            InitializeComponent();
        }
      
        private void btn_delete_Click(object sender, EventArgs e)
        {
            dgv_users.DataSource =  _invoker.Invoke(new DeleteUserThenGetUsers(_user,selected_user));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_name.Text == "" || txt_password.Text == null)
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
                else if (txt_password.TextLength < 8)
                {
                    MessageBox.Show("please enter a valid password");
                    txt_password.Text = null;
                }

                else
                {
                    dgv_users.DataSource = _invoker.Invoke(new InsertUserThenGetUsers(_user, txt_username.Text,
                    txt_name.Text,
                    txt_password.Text,
                    ((Roles)cmb_roles.SelectedItem).key));
                }
            }

        }

        public void fillColumns()
        {
            foreach (string field in new User().fields)
            {
                cmb_columns.Items.Add(field);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dgv_users.DataSource = _invoker.Invoke(new IUpdateUserThenGetUsers(_user , selected_user,
              txt_username.Text,
              txt_name.Text,
              txt_password.Text,
              ((Roles)cmb_roles.SelectedItem).key));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dgv_users.DataSource = _invoker.Invoke(new SearchUser(_user, (cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_users.DataSource = _invoker.Invoke(new GetAllUsers(_user));
            }
        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {
            dgv_users.DataSource = _invoker.Invoke(new GetAllUsers(_user));
            fillColumns();

            fillRoles();
        }

        private void fillRoles()
        {
            List<Roles> roles = new List<Roles>();

            roles.Add(new Roles("super_admin", "Super Admin"));
            roles.Add(new Roles("sales_employee", "Sales Employee"));
            roles.Add(new Roles("warehouse_employee", "Warehouse Employee"));

            cmb_roles.DataSource = roles;
            cmb_roles.DisplayMember = "value";
            cmb_roles.ValueMember = "key";
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_user = dgv_users.Rows[e.RowIndex].Cells["id"].Value.ToString();
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            //  btn_clear.Enabled = true;
            btn_add.Enabled = false;

            txt_username.Text = dgv_users.Rows[e.RowIndex].Cells["username"].Value.ToString();
            txt_name.Text = dgv_users.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_password.Text = dgv_users.Rows[e.RowIndex].Cells["password"].Value.ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
