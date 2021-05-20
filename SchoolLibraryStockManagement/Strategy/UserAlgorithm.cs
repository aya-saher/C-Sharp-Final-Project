﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Strategy
{
    public abstract class UserAlgorithm
    {
        public abstract List<Permission> getMainPermissions();

        public abstract List<Permission> getProductManagementPermissionsOnLoad();

        public abstract List<Permission> getProductManagementPermissionsEditing();

        //public abstract List<Permission> getCategoryManagementPermissions();

        //public abstract List<Permission> getOrderManagementPermissions();

        //public abstract List<Permission> getStockManagementPermissions();

        //public abstract List<Permission> getReportPermissions();

        //public abstract List<Permission> getUserManagementPermissions();
    }
}
