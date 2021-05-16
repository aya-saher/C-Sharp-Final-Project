using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class OrderItem
    {
        public string orderItems(string order_id) {
            return "SELECT order_items.id as ID , code as 'Product Code', order_items.quantity , order_items.price FROM order_items , products WHERE order_id="+order_id+" AND order_items.product_id = products.id";
        }
        public string insert(string order_id, string product_id , string quantity , string price)
        {
            string query = "INSERT INTO order_items (order_id , product_id , quantity , price)";
            query += String.Format(" VALUES ({0},{1},{2},{3})", order_id, product_id, quantity, price);
            return query;
        }

        public string update(string id , string quantity)
        {
            string query = "UPDATE order_items SET ";
            query += String.Format("quantity = '{0}'", quantity);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string update(string order_id) {
            string query = "UPDATE order_items SET ";
            query += String.Format("order_id = '{0}'", order_id);
            query += String.Format(" WHERE order_id = {0}", 0);
            return query;
        }

        public string delete(string id) {
            return "DELETE FROM order_items WHERE id="+id;
        }

        public string delete_order_id(string order_id)
        {
            return "DELETE FROM order_items WHERE order_id=" + order_id;
        }

        public string total_price(string order_id)
        {
            return "SELECT SUM(quantity *price) AS total FROM order_items WHERE order_id = " + order_id;
        }

    }
}
