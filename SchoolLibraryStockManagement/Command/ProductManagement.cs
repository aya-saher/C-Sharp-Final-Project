using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Command
{
    public class InsertProduct : ICommand
    {
        private readonly IProduct _product;
        private string _code, _name, _description, _price, _quantity, _category_id;
        public InsertProduct(IProduct product, string code, string name, string description, string price, string quantity, string category_id)
        {
            _product = product;
            _code = code;
            _name = name;
            _description = description;
            _price = price;
            _quantity = quantity;
            _category_id = category_id;
        }
        public void Execute()
        {
            _product.Insert(_code, _name, _description, _price, _quantity, _category_id);
        }
        public bool CanExecute()
        {
            if (_code != "" && _name != "" && _description != "" && _price != "" && _quantity != "" && _category_id != "")
                return true;
            else return false;
        }
    }
    public class UpdateProduct : ICommand
    {
        private readonly IProduct _product;
        private string _id, _code, _name, _description, _price, _quantity, _category_id;
        public UpdateProduct(IProduct product, string id, string code, string name, string description, string price, string quantity, string category_id)
        {
            _product = product;
            _id = id;
            _code = code;
            _name = name;
            _description = description;
            _price = price;
            _quantity = quantity;
            _category_id = category_id;
        }
        public void Execute()
        {
            _product.Update(_id, _code, _name, _description, _price, _quantity, _category_id);
        }
        public bool CanExecute()
        {
            if (_id != "" && _code != "" && _name != "" && _description != "" && _price != "" && _quantity != "" && _category_id != "")
                return true;
            else return false;
        }
    }
    public class DeleteProduct : ICommand
    {
        private readonly IProduct _product;
        private string _id;
        public DeleteProduct(IProduct product, string id)
        {
            _product = product;
            _id = id;
        }
        public void Execute()
        {
            _product.Delete(_id);
        }
        public bool CanExecute()
        {
            if (Convert.ToInt32(_id) > 0 && _id != "")
                return true;
            else return false;
        }
    }
}
