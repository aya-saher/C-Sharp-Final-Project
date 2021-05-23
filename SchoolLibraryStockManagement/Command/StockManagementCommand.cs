using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryStockManagement.Models;

namespace SchoolLibraryStockManagement.Command
{
    public class InsertStock : ICommand
    {
        private readonly IStock _stock;
        private List<StockManagement> stock;

        public InsertStock(IStock _stock, List<StockManagement> stock)
        {
            this._stock = _stock;
            this.stock = stock;
        }
        public void Execute()
        {
            _stock.Insert(this.stock);
        }
        public bool CanExecute()
        {
            return true;
        }
    }
}
