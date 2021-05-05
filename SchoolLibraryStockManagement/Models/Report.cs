using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class Report
    {
        public string getOutofStock()
        {
            return "SELECT * FROM products WHERE quantity = 0 AND deleted_at IS NULL";
        }

        public string searchOutofStock(string column, string value)
        {
            return "SELECT * FROM products WHERE " + column + " LIKE '%" + value + "%' AND quantity = 0 AND deleted_at IS NULL";
        }

        public string getTopSelling()
        {
            return "SELECT * FROM products WHERE id IN (SELECT product_id FROM order_items GROUP BY product_id ORDER BY COUNT(product_id) DESC) AND deleted_at IS NULL LIMIT 10";
        }

        public string searchTopSelling(string column, string value)
        {
            return "SELECT * FROM products WHERE id IN (SELECT product_id FROM order_items GROUP BY product_id ORDER BY COUNT(product_id) DESC) AND " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL LIMIT 10";
        }

        public string getProductMovement(string column, string value)
        {
            return "SELECT * FROM stock_history WHERE product_id IN (SELECT id FROM products WHERE " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL)";
        }
    }
}
