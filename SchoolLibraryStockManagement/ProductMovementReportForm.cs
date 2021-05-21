using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Command;

namespace SchoolLibraryStockManagement
{
    public partial class ProductMovementReportForm : Form
    {
        private readonly IReport _report = new IReportReciever();
        Invoker _invoker = new Invoker();

        public ProductMovementReportForm()
        {
            InitializeComponent();
        }

        private void ProductMovementReportForm_Load(object sender, EventArgs e)
        {
            fillColumns();
        }

        public void fillColumns()
        {
            foreach (string field in new Product().fields)
            {
                cmb_columns.Items.Add(field);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dgv_products.DataSource = _invoker.Invoke(new GetProductMovement(_report,(cmb_columns.SelectedItem).ToString(), txt_search.Text.ToString()));
            }
            else
            {
                dgv_products.DataSource = null;
            }
        }
    }
}
