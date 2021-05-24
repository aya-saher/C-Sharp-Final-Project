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

namespace SchoolLibraryStockManagement
{
    public partial class Settings : Form
    {
        public User user;
        private readonly ISettingReciever _setting = new ISettingReciever();
        Invoker _invoker = new Invoker();
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

                _invoker.Invoke(new UpdateSetting(_setting,this.user.id, txt_name.Text, txt_username.Text, txt_password.Text));
                MessageBox.Show("Updated Successfully!!");

                this.Close();
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //new Main(user).Show();
        }
    }
}
