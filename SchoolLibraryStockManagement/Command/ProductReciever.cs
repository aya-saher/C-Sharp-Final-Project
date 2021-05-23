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
    public interface IProduct
    {
        DataTable SelectAll();
        DataTable SelectProductsHasQuantity();
        string SelectQuantity(string product_code);
        DataTable Search(string column, string value);
        DataTable SearchHasQuantity(string column, string value);
        void Insert(string code, string name, string description, string price, string quantity, string category_id);
        void Update(string id, string code, string name, string description, string price, string quantity, string category_id);
        void Delete(string id);
    }
    public class IProductReciever : IProduct
    {
        public DataTable SelectAll()
        {
            return DatabaseOperation.get(new DataTable(), new Product().all());
        }

        public DataTable SelectProductsHasQuantity()
        {
            return DatabaseOperation.get(new DataTable(), (new Product()).select_productsHasQuantity());
        }
        public string SelectQuantity(string product_code)
        {
            return DatabaseOperation.get(new DataTable(), new Product().select_Quantity(product_code)).Rows[0].Field<Int32>("quantity").ToString();
        }
        public DataTable Search(string column, string value)
        {
            return DatabaseOperation.get(new DataTable(), new Product().search(column, value));
        }
        public DataTable SearchHasQuantity(string column, string value)
        { 
            return DatabaseOperation.get(new DataTable(), new Product().search_HasQuantity(column, value));
        }
        public void Insert(string code, string name, string description, string price, string quantity, string category_id)
        {
            string query = (new Product()).insert(
               code,
               name,
               description,
               price,
               quantity,
               category_id
            );
            DatabaseOperation.create(query);
        }
        public void Update(string id, string code, string name, string description, string price, string quantity, string category_id)
        {
            string query = (new Product()).update(
               id,
               code,
               name,
               description,
               price,
               quantity,
               category_id
            );
            Console.WriteLine(query);
            DatabaseOperation.update(query);
        }
        public void Delete(string id)
        {
            DatabaseOperation.delete(new Product().delete(id));
        }
    }
}
