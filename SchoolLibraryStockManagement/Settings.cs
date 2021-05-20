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
    public partial class Settings : Form
    {
        public User user;

        public Settings(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txt_name.Text = this.user.name;
            txt_username.Text = this.user.username;
        }

        private void btn_settings_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.ToString() == "" || txt_username.Text.ToString() == "")
            {
                MessageBox.Show("Name and Username Can not be Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.user.name = txt_name.Text;
                this.user.username = txt_username.Text;

                string query = new User().settings(this.user.id, txt_name.Text, txt_username.Text, txt_password.Text);
                DatabaseOperation.select(new DataTable(), query);

                MessageBox.Show("Updated Successfully!!");

                this.Hide();
                new Main(user).Show();
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Main(user).Show();
        }
    }
}
