using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Command
{
    public interface IUser
    {
        DataTable GetAll();
        DataTable Search(string column, string value);
        void Insert(string username, string name, string password, string role);
        void Delete(string id);
        void Update(string id, string username, string name, string password, string role);

    }
    public class IUserReciever : IUser
    {
        public DataTable GetAll()
        {
            return DatabaseOperation.get(new DataTable(), (new User()).all());
        }
        public DataTable Search(string column, string value)
        {
            return DatabaseOperation.get(new DataTable(), new User().search(column, value));
        }
        public void Insert(string username, string name, string password, string role)
        {
            string query = (new User()).insert(
                    username,
                    name,
                    password,
                    role);
            DatabaseOperation.create(query);
        }
        public void Delete(string id)
        {
            DatabaseOperation.delete(new User().delete(id));
        }
        public void Update(string id, string username, string name, string password, string role)
        {
            string query = (new User()).update(
             id,
             username,
             name,
             password,
             role);
            DatabaseOperation.update(query);
        }
    }
}
