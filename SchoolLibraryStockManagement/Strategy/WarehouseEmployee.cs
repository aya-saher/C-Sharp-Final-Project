using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Strategy
{
    public class WarehouseEmployee : UserAlgorithm
    {
        public override List<Permission> getMainPermissions()
        {
            List<Permission> permissions = new List<Permission>();
            permissions.Add(new Permission("lbl_users", false));
            permissions.Add(new Permission("lbl_reports", false));
            permissions.Add(new Permission("lbl_orders", false));
            permissions.Add(new Permission("lbl_stock_management", true));
            return permissions;
        }

        public override List<Permission> getProductManagementPermissionsOnLoad()
        {
            List<Permission> permissions = new List<Permission>();
            permissions.Add(new Permission("btn_add", true));
            permissions.Add(new Permission("btn_delete", false));
            permissions.Add(new Permission("btn_edit", false));
            permissions.Add(new Permission("btn_clear", false));
            permissions.Add(new Permission("btn_add_category", true));
            return permissions;
        }

        public override List<Permission> getProductManagementPermissionsEditing()
        {
            List<Permission> permissions = new List<Permission>();
            permissions.Add(new Permission("btn_add", false));
            permissions.Add(new Permission("btn_delete", true));
            permissions.Add(new Permission("btn_edit", true));
            permissions.Add(new Permission("btn_clear", true));
            permissions.Add(new Permission("btn_add_category", true));
            return permissions;
        }
    }
}
