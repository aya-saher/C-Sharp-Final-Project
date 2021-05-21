using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Libraries;

namespace SchoolLibraryStockManagement.Command
{
    public interface ICategory
    {
        DataTable GetAll(DataTable table);
        void Delete(string id);
        void Update(string id, string name, string description);
        DataTable Search(string column, string value);
        void Insert( string name, string description);

    }
    public class ICategoryReciever : ICategory
    {
        public void Delete(string id)
        {
            DatabaseOperation.delete(new Category().delete(id));
        }

        public DataTable GetAll(DataTable table)
        {
            return DatabaseOperation.get(table, (new Category()).all());
        }

        public void Insert(string name, string description)
        {
            DatabaseOperation.create(new Category().insert(name, description));
        }

        public DataTable Search(string column, string value)
        {
            return DatabaseOperation.select(new DataTable(),new Category().search(column, value));
                }

        public void Update(string id, string name, string description)
        {
            DatabaseOperation.update(new Category().update(id, name, description));
        }
    }
}
