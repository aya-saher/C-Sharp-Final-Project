using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class Order
    {
        public string[] fields = { "Reference Number" , "order Date" };

        public string all()
        {
            return "SELECT orders.id as ID ,reference_number as 'Reference Number', users.username as 'UserName' , total as Total, created_at as 'Order Date' FROM orders , users WHERE orders.user_id = users.id AND orders.id != 0";
        }

        public string lastOrder() {
            return "SELECT id FROM orders ORDER BY id DESC LIMIT 1";
        }

        public string insert(string user_id , string total)
        {
            string query = "INSERT INTO orders (reference_number ,total ,user_id)";
            query += String.Format("  VALUES ({0},{1},{2})", "RAND() * 999999.99", float.Parse(total), user_id);
            return query;
        }

        public string delete(string id) {
            return "DELETE FROM orders WHERE id=" + id;
        }

        public string update_total(string id , string total) {
            string query = "UPDATE orders SET ";
            query += String.Format("total = '{0}'", total);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string update(string id, string reference_num)
        {
            string query = "UPDATE orders SET ";
            query += String.Format("reference_number = '{0}'", reference_num);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string search(string column , string txt) {
            if (column == "Reference Number")
            {
                column = "reference_number";
                return "SELECT orders.id as ID ,reference_number as 'Reference Number', users.username as 'UserName' , total as Total, created_at as 'Order Date' FROM orders , users WHERE orders.user_id = users.id AND orders.id != 0 AND CAST( " + column +" as CHAR) LIKE '%" + txt + "%'";

            }
            else
            {
                column = "created_at";
                return "SELECT orders.id as ID ,reference_number as 'Reference Number', users.username as 'UserName' , total as Total, created_at as 'Order Date' FROM orders , users WHERE orders.user_id = users.id AND orders.id != 0 AND " + column + " LIKE '%" + txt + "%'";

            }
        }
    }
}
