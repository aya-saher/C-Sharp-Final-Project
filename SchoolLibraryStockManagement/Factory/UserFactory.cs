using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Strategy;

namespace SchoolLibraryStockManagement.Factory
{
    public class UserFactory
    {
        private string user_role;

        public UserFactory() { }

        public UserFactory(string user_role)
        {
            this.user_role = user_role;
        }

        public UserAlgorithm getUserAlgorithm()
        {
            //UserAlgorithm user;
            switch (this.user_role)
            {
                case "super_admin":
                    return new SuperAdmin();
                    //return user;

                case "sales_employee":
                    return new SalesEmployee();
                    //return user;

                case "warehouse_employee":
                    return new WarehouseEmployee();
                    //return user;

                default:
                    return new SalesEmployee();
                    //return user;
            }
        }
    }
}
