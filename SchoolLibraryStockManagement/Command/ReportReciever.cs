using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Command
{
    public interface IReport
    {
        DataTable GetOutofStock();
        DataTable SearchOutofStock(string column, string value);
        DataTable GetTopSelling();
        DataTable SearchTopSelling(string column, string value);
        DataTable GetProductMovement(string column, string value);
    }
    public class IReportReciever : IReport
    {
        public DataTable GetOutofStock()
        {
            return DatabaseOperation.get(new DataTable(), new Report().getOutofStock());
        }
        public DataTable SearchOutofStock(string column, string value)
        { 
            return DatabaseOperation.get(new DataTable(), new Report().searchOutofStock(column, value));
        }
        public DataTable GetTopSelling()
        { 
            return DatabaseOperation.get(new DataTable(), new Report().getTopSelling());
        }
        public DataTable SearchTopSelling(string column, string value)
        {
            return DatabaseOperation.get(new DataTable(), new Report().searchTopSelling(column, value));
        }
        public DataTable GetProductMovement(string column, string value)
        {
            Console.WriteLine(new Report().getProductMovement(column, value));
            return DatabaseOperation.get(new DataTable(), new Report().getProductMovement(column, value));
        }
    }
}
