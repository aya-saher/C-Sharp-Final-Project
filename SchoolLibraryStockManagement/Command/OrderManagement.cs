using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public class GetAllOrders : ICommand2
    {
        private readonly IOrder _order;
        public GetAllOrders(IOrder order)
        {
            _order = order;
        }
        public DataTable Execute()
        {
            return _order.GetAllOrders();
        }
        public bool CanExecute()
        {
            return true;
        }
    }
        public class GetOrderItems : ICommand2
    {
        private readonly IOrderItem _orderItem;
        private string _order_id;
        public GetOrderItems(IOrderItem orderItem ,string order_id)
        {
            _orderItem = orderItem;
            _order_id = order_id;
        }
        public DataTable Execute()
        {
            return _orderItem.GetOrderItems(_order_id);
        }
        public bool CanExecute()
        {
            if (_order_id != "")
                return true;
            else return false;
        }
    }
    public class SearchOrder : ICommand2
    {
        private readonly IOrder _order;
        private string _column, _txt;
        public SearchOrder(IOrder order , string column, string txt)
        {
            _order = order;
            _column = column;
            _txt = txt;
        }
        public DataTable Execute()
        {
            return _order.Search(_column, _txt);
        }
        public bool CanExecute()
        {
            if (_column != "" && _txt != "")
                return true;
            else return false;
        }
    }
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
        private int _product_q;
        public InsertOrderItem(IOrderItem orderItem, string order_id, string product_id, string quantity, string price, int product_q)
        {
            _orderItem = orderItem;
            _order_id = order_id;
            _product_id = product_id;
            _quantity = quantity;
            _price = price;
            _product_q = product_q;
        }
        public void Execute()
        {
            _orderItem.Insert(_order_id, _product_id, _quantity, _price);
        }
        public bool CanExecute()
        {
            if (_order_id != "" && _product_id != "" && _quantity != "" && _price != "" && !_quantity.Contains(".") && _quantity != "0" &&
                Convert.ToDouble(_quantity) > 0 && Convert.ToDouble(_quantity) < _product_q)
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
    public class DeleteOrderItemsByOrderId : ICommand
    {
        private readonly IOrder _order;
        private readonly IOrderItem _orderItem;
        private string _id;
        public DeleteOrderItemsByOrderId(IOrder order, IOrderItem orderItem, string id)
        {
            _order = order;
            _orderItem = orderItem;
            _id = id;
        }
        public void Execute()
        {
            _orderItem.DeleteOrderById(_id);
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
