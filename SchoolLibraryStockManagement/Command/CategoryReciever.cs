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
    }
    public class ICategoryReciever : ICategory
    {
        public DataTable GetAll(DataTable table)
        {
            return DatabaseOperation.get(table, (new Category()).all());
        }
    }
}
