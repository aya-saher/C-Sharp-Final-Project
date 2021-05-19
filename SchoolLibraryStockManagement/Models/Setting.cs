using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    class Setting
    {
        public string all()
        {
            return "SELECT * FROM users ";
        }
        public string authenticate(string username, string password)
        {
            string query = "SELECT* FROM users WHERE username LIKE '%" + username + "%' AND password LIKE '%" + password + "%' ";

            return query;

        }
        public string updateAll(string oldusername, string username, string name, string password)
        {
            string query = "UPDATE users SET ";
            query += String.Format("username = '{0}',name = '{1}',password = '{2}' ", username, name, password);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_nameandusername(string oldusername, string username, string name)
        {
            string query = "UPDATE users SET ";
            query += String.Format("username = '{0}',name = '{1}' ", username, name);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_NameAndPassword(string oldusername, string name, string password)
        {
            string query = "UPDATE users SET ";
            query += String.Format("name = '{0}',password = '{1}' ", name, password);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_UsernameAndPassword(string oldusername, string username, string password)
        {
            string query = "UPDATE users SET ";
            query += String.Format("username = '{0}',password = '{1}' ", username, password);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_Name(string oldusername, string name)
        {
            string query = "UPDATE users SET ";
            query += String.Format("name = '{0}' ", name);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_Username(string oldusername, string username)
        {
            string query = "UPDATE users SET ";
            query += String.Format("username = '{0}' ", username);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
        public string update_Password(string oldusername, string password)
        {
            string query = "UPDATE users SET ";
            query += String.Format("password = '{0}' ", password);
            query += String.Format(" WHERE username ='{0}' ", oldusername);
            return query;
        }
    }
}

