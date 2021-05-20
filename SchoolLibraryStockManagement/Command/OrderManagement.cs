using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public class InsertOrder : ICommand
    {
        private readonly IOrderItem _orderItem;
        private readonly IOrder _order;
        private string _order_id, _user_id;
        public InsertOrder(IOrderItem orderItem, IOrder order, string order_id, string user_id)
        {
            _orderItem = orderItem;
            _order = order;
            _order_id = order_id;
            _user_id = user_id;
        }
        public void Execute()
        {
            string total = _orderItem.GetTotalPrice(_order_id);
            _order.Insert(_user_id, total);
            string last_order_id = _order.LastOrderID();
            _orderItem.Update(last_order_id);
        }
        public bool CanExecute()
        {
            if (_order_id != "" && _user_id != "")
                return true;
            else return false;
        }
    }

    public class InsertOrderItem : ICommand
    {
        private readonly IOrderItem _orderItem;
        private string _order_id, _product_id, _quantity, _price;
        public InsertOrderItem(IOrderItem orderItem, string order_id, string product_id, string quantity, string price)
        {
            _orderItem = orderItem;
            _order_id = order_id;
            _product_id = product_id;
            _quantity = quantity;
            _price = price;
        }
        public void Execute()
        {
            _orderItem.Insert(_order_id, _product_id, _quantity, _price);
        }
        public bool CanExecute()
        {
            if (_order_id != "" && _product_id != "" && _quantity != "" && _price != "")
                return true;
            else return false;
        }
    }

    public class DeleteOrder : ICommand
    {
        private readonly IOrder _order;
        private readonly IOrderItem _orderItem;
        private string _id;
        public DeleteOrder(IOrder order, IOrderItem orderItem, string id)
        {
            _order = order;
            _orderItem = orderItem;
            _id = id;
        }
        public void Execute()
        {
            _orderItem.DeleteOrderById(_id);
            _order.Delete(_id);
        }
        public bool CanExecute()
        {
            if (_id != "")
                return true;
            else
                return false;
        }
    }

    public class DeleteOrderItems : ICommand
    {
        private readonly IOrderItem _orderItem;
        private string _id;
        public DeleteOrderItems(IOrderItem orderItem, string id)
        {
            _orderItem = orderItem;
            _id = id;
        }
        public void Execute()
        {
            _orderItem.Delete(_id);
        }
        public bool CanExecute()
        {
            if (_id != "")
                return true;
            else
                return false;
        }
    }
    public class DeleteOrderItemsFROMOrder : ICommand
    {
        private readonly IOrderItem _orderItem;
        private readonly IOrder _order;
        private string _id, _orderId;
        private int _count;
        public DeleteOrderItemsFROMOrder(IOrderItem orderItem, IOrder order,string id, string orderId ,int count)
        {
            _orderItem = orderItem;
            _order = order;
            _id = id;
            _orderId = orderId;
            _count = count;
        }
        public void Execute()
        {
            _orderItem.Delete(_id);
            string total = "0";
            if (_count > 2)
               total = _orderItem.GetTotalPrice(_orderId);
            _order.UpdateTotal(_orderId, total);
        }
        public bool CanExecute()
        {
            if (_id != "")
                return true;
            else
                return false;
        }
    }
    public class UpdateOrder : ICommand
    {
        private readonly IOrder _order;
        private string _orderId, _referenceNum;

        public UpdateOrder(IOrder order, string orderId, string referenceNum)
        {
            _order = order;
            _orderId = orderId;
            _referenceNum = referenceNum;
        }
        public void Execute()
        {
            _order.Update(_orderId, _referenceNum);

        }
        public bool CanExecute()
        {
            if (_referenceNum != "")
                return true;
            else
                return false;
        }
    }

    public class UpdateOrderItem : ICommand
    {
        private readonly IOrderItem _orderItem;
        private string _id, _quantity;
        public UpdateOrderItem(IOrderItem orderItem, string id, string quantity)
        {
            _orderItem = orderItem;
            _id = id;
            _quantity = quantity;
        }
        public void Execute()
        {
            _orderItem.Update(_id, _quantity);
        }
        public bool CanExecute()
        {
            if (_quantity != "" && _quantity != "0")
                return true;
            else
                return false;
        }
    }
    public class UpdateOrderItems : ICommand
    {
        private readonly IOrderItem _orderItem;
        private readonly IOrder _order;
        private string _orderId, _orderItemId, _quantity;
        public UpdateOrderItems(IOrderItem orderItem, IOrder order, string orderId, string orderItemId, string quantity)
        {
            _orderItem = orderItem;
            _order = order;
            _orderId = orderId;
            _orderItemId = orderItemId;
            _quantity = quantity;
        }
        public void Execute()
        {
            _orderItem.Update(_orderItemId, _quantity);
            string total = _orderItem.GetTotalPrice(_orderId);
            _order.UpdateTotal(_orderId, total);

        }
        public bool CanExecute()
        {
            if (_quantity != "" && _quantity != "0")
                return true;
            else
                return false;
        }
    }
}
