using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Helper
{
    class Roles
    {
        public string key { get; set; }
        public string value { get; set; }

        public Roles(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
