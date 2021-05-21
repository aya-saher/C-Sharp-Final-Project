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
}
