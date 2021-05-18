﻿using System;
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
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count != 0)
                {


                    user = new User(username: dt.Rows[0].Field<string>("username"), role: dt.Rows[0].Field<string>("role"));
                    MessageBox.Show("Welcome to the LIBRARY MANAGEMENT SYSTEM!" + user.role + user.username);

                    this.Hide();
                    Main min = new Main(user);

                    min.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
        }
    }
}
