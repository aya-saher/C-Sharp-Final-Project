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
    }
}
