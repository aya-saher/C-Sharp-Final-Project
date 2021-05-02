using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryStockManagement
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btn_stock_management_Click(object sender, EventArgs e)
        {
            new StockManagement().ShowDialog();
        }
    }
}
