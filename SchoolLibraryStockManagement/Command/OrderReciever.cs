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
        public interface IOrder
        {
            DataTable GetAllOrders();
            string LastOrderID();
            void Insert(string user_id, string total);
            void Delete(string id);
            void UpdateTotal(string id, string total);
            void Update(string id, string reference_num);
            DataTable Search(string column, string txt);
        }
        public class IOrderReciever : IOrder
        {
            public DataTable GetAllOrders()
            {
                return DatabaseOperation.get(new DataTable(), (new Order()).all());
            }

            public string LastOrderID()
            {
                return DatabaseOperation.get(new DataTable(), new Order().lastOrder()).Rows[0].Field<Int32>("id").ToString();
            }

            public void Insert(string user_id, string total)
            {
                DatabaseOperation.create((new Order()).insert(user_id, total));
            }

            public void Delete(string id)
            {
                DatabaseOperation.create((new Order()).delete(id));
            }
            public void UpdateTotal(string id, string total)
            {
                DatabaseOperation.create((new Order()).update_total(id, total));
            }
            public void Update(string id, string reference_num)
            {
                DatabaseOperation.create((new Order()).update(id, reference_num));
            }
            public DataTable Search(string column, string txt)
            {
                return DatabaseOperation.get(new DataTable(), (new Order()).search((column).ToString(), txt));
            }
        }
}
