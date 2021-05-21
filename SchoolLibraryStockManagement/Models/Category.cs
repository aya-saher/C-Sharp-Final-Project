using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class Category
    {
        public string[] fields = { "name" };

        public string all()
        {
            return "SELECT * FROM categories WHERE deleted_at IS NULL";
        }

        public string search(string column, string value)
        {
            return "SELECT * FROM categories WHERE " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL";
        }

        public string insert(string name, string description)
        {
            string query = "INSERT INTO categories(name, description)";
            query += String.Format(" VALUES ('{0}','{1}')", name, description);
            return query;
        }

        public string update(string id, string name, string description)
        {
            string query = "UPDATE categories SET ";
            query += String.Format("name = '{0}', description = '{1}'", name, description);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string delete(string id)
        {
            string query = "UPDATE categories SET ";
            query += String.Format("deleted_at = '{0}'", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }
    }
}
