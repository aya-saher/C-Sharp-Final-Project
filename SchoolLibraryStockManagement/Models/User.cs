using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    public class User
    {
        public string username { set; get; }
        public string password { set; get; }
        public string role { set; get; }

        public User(string username, string role)
        {
            this.username = username;
            this.role = role;
        }
        public User() { }
        public string[] fields = { "username", "name", "role" };

        public string login(string userName, string password)
        {
            return "SELECT username, role FROM users WHERE username = '" + userName + "' and password ='" + password + "'";
        }

        public string validateUsername(string value)
        {
            return "SELECT * FROM users WHERE username ='" + value + "'and deleted_at IS NULL";
        }
        public string search(string column, string value)
        {
            return "SELECT * FROM users WHERE " + column + " LIKE '%" + value + "%' AND deleted_at IS NULL";
        }
        public string insert(string username, string name, string password, string role)
        {

            string query = "INSERT INTO users(usrename, name, password, role)";

            query += String.Format(" VALUES ('{0}','{1}','{2}','{3}')", username, name, password, role);
            return query;
        }
        public string all()
        {
            return "SELECT * FROM users WHERE deleted_at IS NULL";
        }

        public string delete(string id)
        {
            string query = "UPDATE users SET ";
            query += String.Format("deleted_at = '{0}'", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }

        public string update(string id, string username, string name, string password, string role)
        {
            string query = "UPDATE users SET ";
            query += String.Format("username = '{0}', name = '{1}', password = '{2}', role = '{3}'", username, name, password, role);
            query += String.Format(" WHERE id = {0}", id);
            return query;
        }
    }
}
