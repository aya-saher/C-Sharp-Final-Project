using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Models
{
    public class StockManagement
    {
        public string product_id;
        public int quantity;
        public int user_id;
        public StockManagement() { }

        public StockManagement(string product_id, int quantity, int user_id)
        {
            this.product_id = product_id;
            this.quantity = quantity;
            this.user_id = user_id;
        }

        public string insert(List<StockManagement> stock)
        {
            string query = "INSERT INTO stock_history(product_id, quantity, user_id) VALUES";
            foreach(StockManagement item in stock){
                query += String.Format(" ({0},{1},{2}),", item.product_id, item.quantity, item.user_id);
            }
            return query.Remove(query.Length - 1);
        }
    }
}
