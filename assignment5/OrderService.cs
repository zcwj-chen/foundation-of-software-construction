using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        public List<Order> Orders { get { return orders; } }

        public void addOrder(Order o)
        {
            if(orders != null)
                orders.Add(o);
        }

        //根据订单号删除订单
        public void removeOrder(string id)
        {
            /*Order order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
                throw new Exception("Order not found!");
            orders.Remove(order);*/

            try
            {
                orders.Remove(orders.FirstOrDefault(o => o.OrderId == id));
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        //根据订单号修改订单：删除旧的，添加新的
        public void modifyOrder(Order newOrder)
        {
            removeOrder(newOrder.OrderId);
            orders.Add(newOrder);
        }

        public List<Order> searchOrders(Func<Order,bool> condition) {
            return orders.Where(condition).OrderBy(o => o.TotalPrice).ToList();
/*            var o = from order in orders
                    where condition(order)
                    orderby order.TotalPrice
                    select order;
            return o.ToList();*/
        }       

        //默认按订单号排序
        public void sort()
        {
            orders.Sort((o1, o2) => string.Compare(o1.OrderId, o2.OrderId));
        }
    }
}
