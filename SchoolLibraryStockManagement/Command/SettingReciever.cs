using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Libraries;

namespace SchoolLibraryStockManagement.Command
{
    public class ISettingReciever
    {
        public void UpdateSetting(int id, string name, string username, string password) {
            string query = new User().settings(id, name, username, password);
            DatabaseOperation.select(new DataTable(), query);
        }
    }
}
