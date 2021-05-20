using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    public class Permission
    {
        public string name;
        public bool status;

        public Permission(string name, bool status)
        {
            this.name = name;
            this.status = status;
        }
    }
}
