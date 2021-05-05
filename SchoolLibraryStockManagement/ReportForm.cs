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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void lbl_product_movement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductMovementReportForm().ShowDialog();
            this.Close();
        }

        private void lbl_out_of_stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OutofStockReportForm().ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TopSellingReportForm().ShowDialog();
            this.Close();
        }

        private void lbl_top_selling_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TopSellingReportForm().ShowDialog();
            this.Close();
        }
    }
}
