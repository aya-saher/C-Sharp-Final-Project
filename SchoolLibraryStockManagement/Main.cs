using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Factory;

namespace SchoolLibraryStockManagement
{
    public partial class Main : Form
    {

      /*  [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );*/

        public User user;

        public Main(User user)
        {
            InitializeComponent();
          
            this.user = user;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            new Login().ShowDialog();
        }

        private void lbl_products_Click(object sender, EventArgs e)
        {
            new ProductForm(user).ShowDialog();
        }

        private void lbl_categories_Click(object sender, EventArgs e)
        {
            new CategoryForm().ShowDialog();
        }

        private void lbl_users_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void lbl_orders_Click(object sender, EventArgs e)
        {
            new OrderForm(user).ShowDialog();
        }

        private void lbl_reports_Click(object sender, EventArgs e)
        {
            new ReportForm().ShowDialog();
        }

        private void lbl_settings_Click(object sender, EventArgs e)
        {
            new StockManagementForm().ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Settings(user).ShowDialog();
            //this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                this.Hide();
                new Login().ShowDialog();
            }
            else
            {
                foreach (Permission permission in this.user.user_algorithm.getMainPermissions())
                {
                    var control = this.Controls.OfType<Label>().FirstOrDefault(c => c.Name == permission.name);
                    control.Enabled = permission.status;
                }

            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
