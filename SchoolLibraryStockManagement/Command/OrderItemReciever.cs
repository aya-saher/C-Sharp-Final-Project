using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SchoolLibraryStockManagement.Models;
using SchoolLibraryStockManagement.Libraries;

namespace SchoolLibraryStockManagement.Command
{
    public interface IOrderItem
    {
        DataTable GetOrderItems(string order_id);
        void Insert(string order_id, string product_id, string quantity, string price);
        void Update(string id, string quantity);
        void Update(string order_id);
        void Delete(string id);
        void DeleteOrderById(string order_id);
        string GetTotalPrice(string order_id);
    }
    public class IOrderItemReciever : IOrderItem
    {
        public DataTable GetOrderItems(string order_id)
        {
            return DatabaseOperation.get(new DataTable(), (new OrderItem()).orderItems(order_id));
        }
        public void Insert(string order_id, string product_id, string quantity, string price)
        {
            DatabaseOperation.create((new OrderItem()).insert(order_id, product_id, quantity, price));
        }
        public void Update(string id, string quantity)
        {
            DatabaseOperation.create((new OrderItem()).update(id, quantity));
        }
        public void Update(string order_id)
        {
            DatabaseOperation.create((new OrderItem()).update(order_id));
        }
        public void Delete(string id)
        {
            DatabaseOperation.create((new OrderItem()).delete(id));
        }
        public void DeleteOrderById(string order_id)
        {
            DatabaseOperation.create((new OrderItem()).delete_order_id(order_id));
        }
        public string GetTotalPrice(string order_id)
        {
            return DatabaseOperation.get(new DataTable(), new OrderItem().total_price(order_id)).Rows[0].Field<double>("total").ToString();
        }
    }
}
