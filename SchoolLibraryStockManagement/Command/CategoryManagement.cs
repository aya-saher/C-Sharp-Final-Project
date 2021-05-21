using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
        public class GetAllCategories : ICommand2
        {
            private readonly ICategory _category;
            private DataTable _table;
            public GetAllCategories(ICategory category , DataTable table)
            {
                _category = category;
                _table = table;
            }
            public DataTable Execute()
            {
                return _category.GetAll(_table);
            }
            public bool CanExecute()
            {
                return true;
            }
        }

    public class SearchCategory : ICommand2
    {
        private readonly ICategory _category;
        private string _column, _value;
        public SearchCategory(ICategory category, string column, string value)
        {
            _category = category;
            _column = column;
            _value = value;
        }
        public DataTable Execute()
        {
            return _category.Search(_column, _value);
        }
        public bool CanExecute()
        {
            return true;
        }
    }

    public class InsertCategory : ICommand
    {
        private readonly ICategory _category;
        private string  _name, _description;

        public InsertCategory(ICategory category,  string name, string description)
        {
            _category = category;
      
            _name = name;
            _description = description;

        }
        public void Execute()
        {
            _category.Insert(_name, _description);
        }
        public bool CanExecute()
        {
            if ( _name != "" )
                return true;
            else return false;
        }
    }


    public class UpdateCategory : ICommand
    {
        private readonly ICategory _category;
        private string _id, _name, _description;
        public UpdateCategory(ICategory category, string id, string name, string description)
        {
            _category = category;
            _id = id;
            _name = name;
            _description = description;
         
        }
        public void Execute()
        {
            _category.Update(_id,  _name, _description);
        }
        public bool CanExecute()
        {
            if (_id != "" &&  _name != "" )
                return true;
            else return false;
        }
    }
    public class DeleteCategory : ICommand
    {
        private readonly ICategory _category;
        private string _id;
        public DeleteCategory(ICategory category, string id)
        {
            _category = category;
            _id = id;
        }
        public void Execute()
        {
            _category.Delete(_id);
        }
        public bool CanExecute()
        {
            if (Convert.ToInt32(_id) > 0 && _id != "")
                return true;
            else return false;
        }
    }



}
