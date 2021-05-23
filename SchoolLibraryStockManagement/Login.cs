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
using SchoolLibraryStockManagement.Factory;

namespace SchoolLibraryStockManagement
{
    public partial class Login : Form
    {
        public User user;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.ToString() == "" || txt_password.Text.ToString() == "")
            {
                MessageBox.Show("username and password cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable dt = new DataTable();
                int count = 0;
                string query = new User().login(txt_username.Text, txt_password.Text);

                dt = DatabaseOperation.select(dt, query);
                Console.WriteLine(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count != 0)
                {
                    user = new User(id: dt.Rows[0].Field<int>("id"),
                                    name: dt.Rows[0].Field<string>("name"),
                                    username: dt.Rows[0].Field<string>("username"),
                                    password: dt.Rows[0].Field<string>("password"),
                                    role: dt.Rows[0].Field<string>("role"),
                                    user_algorithm: new UserFactory(dt.Rows[0].Field<string>("role")).getUserAlgorithm());
                    MessageBox.Show("Welcome to the LIBRARY MANAGEMENT SYSTEM! " + user.role + " - " + user.username);

                    this.Hide();
                    new Main(user).Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
