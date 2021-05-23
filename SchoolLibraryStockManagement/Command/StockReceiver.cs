using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Command
{
    public interface IStock
    {
        void Insert(List<StockManagement> stock);
    }
    public class IStockReciever : IStock
    {
        public void Insert(List<StockManagement> stock)
        {
            string query = (new StockManagement()).insert(stock);
            DatabaseOperation.create(query);
        }
    }
}