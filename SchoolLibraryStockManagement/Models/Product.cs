using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class Product
    {
        public string[] fields = {"code", "name"};

        public string all()
        {
            return "SELECT * FROM products WHERE deleted_at IS NULL";
        }

        public string select_productsHasQuantity()
        {
            return "SELECT * FROM products WHERE deleted_at IS NULL AND quantity > 0";
        }

        public string select_Quantity(string product_code)
        {
            return "SELECT quantity FROM products WHERE code = " + product_code;
        }

        public string search(string column, string value)
        {
            return "SELECT * FROM products WHERE " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL";
        }
        public string search_HasQuantity(string column, string value)
        {
            return "SELECT * FROM products WHERE " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL AND quantity > 0";
        }
        public string insert(string code, string name, string description, string price, string quantity, string category_id)
        {
            string query = "INSERT INTO products(code, name, description, price, quantity, category_id)";
            query += String.Format(" VALUES ('{0}','{1}','{2}',{3},{4},{5})", code, name, description, price.Length>0?price:"0", quantity.Length>0?quantity:"0", category_id);
            return query;
        }

        public string update(string id, string code, string name, string description, string price, string quantity, string category_id)
        {
            string query = "UPDATE products SET ";
            query += String.Format("code = '{0}', name = '{1}', description = '{2}', price = {3}, quantity = {4}, category_id = {5}", code, name, description, price, quantity, category_id);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string delete(string id)
        {
            string query = "UPDATE products SET ";
            query += String.Format("deleted_at = '{0}'", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }
    }
}
